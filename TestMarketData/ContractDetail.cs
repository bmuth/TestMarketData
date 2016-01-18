using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarketData
{
    class ContractDetail
    {
        public string Ticker { get; set; }
        public string LocalSymbol { get; set; }
        public string LongName { get; set; }
        public DateTime? Expiry { get; set; }
        public int ConId { get; set; }
        public double Strike { get; set; }
        public string Exchange { get; set; }
        public bool? bIfCall { get; set; }


        public ContractDetail (string ticker, string local_symbol, string longname, DateTime? expiry, int conid, double strike, string exchange, string right)
        {
            Ticker = ticker;
            LocalSymbol = local_symbol;
            LongName = longname;
            ConId = conid;
            Expiry = expiry;
            Strike = strike;
            Exchange = exchange;
            bIfCall = null;
            if (right == "C")
            {
                bIfCall = true;
            }
            else if (right == "P")
            {
                bIfCall = false;
            }
        }
        public override string ToString ()
        {
            return string.Format ("[{0}] {1} s:{2:F0} {3}", LocalSymbol, LongName, Strike, Expiry == null ? "null" : ((DateTime) Expiry).ToString ("yyyy-MM"));
        }
    }
}
