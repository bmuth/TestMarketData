using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWI.Controls;
using System.Globalization;
using TWSLib;

namespace TestMarketData
{
    public partial class Form1 : Form
    {
        LogCtl m_Log;
        private bool m_bIfConnected = false;
        Random m_random = new Random ();

        public Form1 ()
        {
            m_Log = new LogCtl ("OptionExperiment");
            m_Log.LogFilename = Properties.Settings.Default.LogDir + "TestMarketData.log";
            InitializeComponent ();

            List<Tuple<string, string>> sectypes = new List<Tuple<string, string>> ();
            sectypes.Add (new Tuple<string, string> ("Stock", "STK"));
            sectypes.Add (new Tuple<string, string> ("Options", "OPT"));
            sectypes.Add (new Tuple<string, string> ("Futures", "FUT"));
            sectypes.Add (new Tuple<string, string> ("Future Options", "FOP"));

            lbSecType.DataSource = sectypes;
            lbSecType.DisplayMember = "Item1";
            lbSecType.ValueMember = "Item2";
            lbSecType.SelectedIndex = 0;
        }

        private void btnConnect_Click (object sender, EventArgs e)
        {
            int clientId = 0;
            string host = "127.0.0.1";

            int port = 7496;
            if (!rbTWS.Checked)
            {
                port = 4001;
            }

            try
            {
                clientId = int.Parse (tbClientId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show ("Invalid client id specified");
                btnConnect.DialogResult = DialogResult.Cancel;
            }

            try
            {
                axTws.connect (host, port, clientId);
                m_bIfConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show (string.Format ("Please check your connection attributes. {0}", ex.Message));
            }
        }

        private async void btnFetch_Click (object sender, EventArgs e)
        {
            List<ContractDetail> cd = null;

            if (!m_bIfConnected)
            {
                MessageBox.Show ("Not connected.");
                return;
            }
            try
            {
                cd = await FetchContracts ();
                lbItems.DataSource = cd;
                //if (cd.Count != 1)
                //{
                //    MessageBox.Show ("Didn't get a single contract.");
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show (string.Format ("FetchContracts error: {0}", ex.Message));
                return;
            }

            //lbPrice.Text = string.Format ("{0} {1}", cd[0].LongName, cd[0].Expiry.ToShortDateString ());
            //double price = await FetchUnderlyingPrice (lbPrice.Text, cd[0].ConId);
            //lbPrice.Text = price.ToString ("N3");
        }

        private Task<List<ContractDetail>> FetchContracts ()
        {
            var tcs = new TaskCompletionSource<List<ContractDetail>> ();
            List<ContractDetail> cd= new List<ContractDetail> ();
             
            var errhandler = default (AxTWSLib._DTwsEvents_errMsgEventHandler);
            var contracthandler = default (AxTWSLib._DTwsEvents_contractDetailsExEventHandler);
            var endhandler = default (AxTWSLib._DTwsEvents_contractDetailsEndEventHandler);

            errhandler = new AxTWSLib._DTwsEvents_errMsgEventHandler ((s, e) =>
            {
                if (e.id != -1)
                {
                    m_Log.Log (ErrorLevel.logERR, string.Format ("GetOptionStrikes: {0}", e.errorMsg));

                    axTws.errMsg -= errhandler;
                    axTws.contractDetailsEx -= contracthandler;
                    axTws.contractDetailsEnd -= endhandler;

                    tcs.TrySetException (new Exception (e.errorMsg));
                }
                else
                {
                    m_Log.Log (ErrorLevel.logERR, string.Format ("GetOptionStrikes: error {0:x} {1}", e.id, e.errorMsg));
                }
            });

            contracthandler = new AxTWSLib._DTwsEvents_contractDetailsExEventHandler ((s, e) =>
            {
                TWSLib.IContractDetails c = e.contractDetails;
                TWSLib.IContract d = (TWSLib.IContract) c.summary;

                m_Log.Log (ErrorLevel.logINF, string.Format ("FetchContracts: {0} localsym {1} mult: {2}, strike {3:N2} right {4}", d.symbol, d.localSymbol, d.multiplier, d.strike, d.right));
                //if (d.strike >= strike_start && d.strike <= strike_stop)
                {
                    string format = "yyyyMMdd";
                    DateTime? Expiry = null;
                    if (!string.IsNullOrWhiteSpace (d.expiry))
                    {
                        Expiry = DateTime.ParseExact (d.expiry, format, CultureInfo.InvariantCulture);
                    }

                    cd.Add (new ContractDetail (d.localSymbol, c.longName, Expiry, d.conId, d.strike, d.exchange));
                }
            });

            endhandler = new AxTWSLib._DTwsEvents_contractDetailsEndEventHandler ((s, e) =>
            {
                try
                {
                    tcs.TrySetResult (cd);
                }
                finally
                {
                    axTws.contractDetailsEx -= contracthandler;
                    axTws.errMsg -= errhandler;
                    axTws.contractDetailsEnd -= endhandler;
                }
            });

            /* Get the exchange
             * ---------------- */

            string exchange = "";

            using (dbOptionsDataContext dc = new dbOptionsDataContext ())
            {
                exchange = (from s in dc.Stocks
                            where s.Ticker == tbTicker.Text
                            select s.Exchange).FirstOrDefault ();
                if (string.IsNullOrEmpty (exchange))
                {
                    exchange = "";
//                    MessageBox.Show (string.Format ("failed to extract exchange for {0}", tbTicker.Text));

//                    return tcs.Task;
                }
            }

            axTws.errMsg += errhandler;
            axTws.contractDetailsEx += contracthandler;
            axTws.contractDetailsEnd += endhandler;

            IContract contract = axTws.createContract ();

            string sectype = (string) lbSecType.SelectedValue; 

            double strike = 0;
            if (!string.IsNullOrWhiteSpace (tbStrike.Text))
            {
                strike = double.Parse (tbStrike.Text); 
            }

            if (sectype == "FOP")
            {
                contract.symbol = tbTicker.Text;
                contract.secType = "FOP";
                contract.exchange = exchange;
                contract.primaryExchange = "";
                contract.currency = "USD";
                contract.strike = strike;
                contract.expiry = tbExpiry.Text;

                m_Log.Log (ErrorLevel.logINF, string.Format ("contract: symbol:{0} secType:{1} exchange: {2} currency:{3} strike:{4} expiry: {5} right:{6}", 
                          contract.symbol, contract.secType, contract.exchange, contract.currency, contract.strike, contract.expiry, contract.right));


            }
            else if (sectype == "FUT")
            {
                contract.symbol = tbTicker.Text;
                //contract.localSymbol = tbTicker.Text;
                contract.secType = "FUT";
                contract.exchange = exchange;
                contract.primaryExchange = "";
                contract.currency = "USD";
                //contract.right = bIfCall ? "C" : "P";
                contract.expiry = tbExpiry.Text;
                contract.strike = 0.0;
                //contract.multiplier = "50"; 50 for ES, 100 for TF
                contract.includeExpired = 1;
            }
            else if (sectype == "STK")
            {
                contract.symbol = tbTicker.Text;
                contract.secType = "STK";
                contract.exchange = exchange;
                contract.primaryExchange = "";
                contract.currency = "USD";
            }

            axTws.reqContractDetailsEx (1, contract);

            return tcs.Task;
        }

        private Task<double> FetchUnderlyingPrice (string desc, int conid)
        {
            double price = 0.0;
            double close = 0.0;
            var tcs = new TaskCompletionSource<double> ();

            /* If the market is closed, get the price from somewhere else
             * ---------------------------------------------------------- */

            //if (!Utils.IfTradingNow ())
            //{
            //    using (dbOptionsDataContext dc = new dbOptionsDataContext ())
            //    {
            //        var stockprice = (from s in dc.Stocks
            //                          where s.Ticker == ticker
            //                          select s.LastTrade
            //                    ).SingleOrDefault ();

            //        if (stockprice == null)
            //        {
            //            tcs.SetException (new Exception (string.Format ("Failed to fetch underlying price for {0}", ticker)));
            //            return tcs.Task;
            //        }
            //        tcs.SetResult ((double) stockprice);
            //        return tcs.Task;
            //    }
            //}

            int reqid = m_random.Next (0xFFFF);

            var errhandler = default (AxTWSLib._DTwsEvents_errMsgEventHandler);
            var endhandler = default (AxTWSLib._DTwsEvents_tickSnapshotEndEventHandler);
            var pricehandler = default (AxTWSLib._DTwsEvents_tickPriceEventHandler);

            errhandler = new AxTWSLib._DTwsEvents_errMsgEventHandler ((s, e) =>
            {
                if (e.id == -1)
                {
                    m_Log.Log (ErrorLevel.logERR, string.Format ("FetchPriceUnderlying: error {0}", e.errorMsg));
                    return;
                }

                if ((e.id & 0xFFFF0000) != Utils.ibPRICE)
                {
                    return;
                }
                e.id &= 0xFFFF;

                m_Log.Log (ErrorLevel.logERR, string.Format ("FetchPriceUnderlying: error {0} ", e.errorMsg));

                axTws.errMsg -= errhandler;
                axTws.tickPrice -= pricehandler;
                axTws.tickSnapshotEnd -= endhandler;

                axTws.cancelMktData (reqid);

                tcs.SetException (new Exception (e.errorMsg));
            });

            pricehandler = new AxTWSLib._DTwsEvents_tickPriceEventHandler ((s, e) =>
            {
                if ((e.id & 0xFFFF0000) != Utils.ibPRICE)
                {
                    return;
                }
                e.id &= 0xFFFF;
                if (reqid != e.id)
                {
                    return;
                }

                m_Log.Log (ErrorLevel.logERR, string.Format ("FetchPriceUnderlying: axTws_tickPrice for {0} tickType:{1} {2} value: {3}", desc, e.tickType, TickType.Display (e.tickType), e.price));


                switch (e.tickType)
                {
                    case TickType.LAST:
                        price = e.price;
                        break;

                    case TickType.CLOSE:
                        close = e.price;
                        break;

                    case TickType.BID:
                        //opt.Bid = e.price;
                        break;

                    case TickType.ASK:
                        //opt.Ask = e.price;
                        break;

                    default:
                        break;
                }
            });

            endhandler = new AxTWSLib._DTwsEvents_tickSnapshotEndEventHandler ((s, e) =>
            {
                if ((e.reqId & 0xFFFF0000) != Utils.ibPRICE)
                {
                    return;
                }
                e.reqId &= 0xFFFF;
                if (reqid != e.reqId)
                {
                    return;
                }

                m_Log.Log (ErrorLevel.logINF, string.Format ("FetchOneOptionChain: axTws_tickSnapshotEnd for {0}. price={1:N3} close={2:N3}", desc, price, close));

                axTws.errMsg -= errhandler;
                axTws.tickPrice -= pricehandler;
                axTws.tickSnapshotEnd -= endhandler;

                if (price != 0.0)
                {
                    tcs.SetResult (price);
                }
                else
                {
                    tcs.SetResult (close);
                }
            });


            axTws.errMsg += errhandler;
            axTws.tickPrice += pricehandler;
            axTws.tickSnapshotEnd += endhandler;

            IContract contract = axTws.createContract ();

            contract.currency = "USD";
            contract.conId = conid;
            contract.exchange = "GLOBEX";
            contract.includeExpired = 0;

            axTws.reqMktDataEx (Utils.ibPRICE | reqid, contract, "", 1, null);
            return tcs.Task;
        }

        private void Form1_FormClosing (object sender, FormClosingEventArgs e)
        {
            m_Log.Dispose ();
            if (m_bIfConnected)
            {
                axTws.disconnect ();
            }
        }

        private void btnSave_Click (object sender, EventArgs e)
        {
            ContractDetail cd = (ContractDetail) lbItems.SelectedItem;

            using (dbOptionsDataContext dc = new dbOptionsDataContext ())
            {
                var query = (from s1 in dc.Stocks
                             where s1.Ticker == cd.LocalSymbol
                             select s1).SingleOrDefault ();

                if (query != null)
                {
                    query.Company = cd.LongName;
                    query.Exchange = cd.Exchange;
                    try
                    {
                        dc.SubmitChanges ();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show (string.Format ("Failed to update existing record {0}. {1}", cd.ToString (), ex.Message));
                    }
                    return;
                }
                Stock s = new Stock ();
                s.Ticker = cd.LocalSymbol;
                s.Company = cd.LongName;
                s.Exchange = cd.Exchange;
                s.SecType = (string) lbSecType.SelectedValue;
                s.FutureExpiry = cd.Expiry;
                dc.Stocks.InsertOnSubmit (s);
                try
                {
                    dc.SubmitChanges ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (string.Format ("Failed to insert new record {0}. {1}", cd.ToString (), ex.Message));
                }
                return;

            }
        }
    }
}
