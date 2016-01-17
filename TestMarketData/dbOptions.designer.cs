﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestMarketData
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="E:\\FINANCE\\DATABASE\\OPTIONS.MDF")]
	public partial class dbOptionsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStock(Stock instance);
    partial void UpdateStock(Stock instance);
    partial void DeleteStock(Stock instance);
    #endregion
		
		public dbOptionsDataContext() : 
				base(global::TestMarketData.Properties.Settings.Default.E__FINANCE_DATABASE_OPTIONS_MDFConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbOptionsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbOptionsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbOptionsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbOptionsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Stock> Stocks
		{
			get
			{
				return this.GetTable<Stock>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Stock")]
	public partial class Stock : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Ticker;
		
		private string _Company;
		
		private string _Sector;
		
		private string _Industry;
		
		private string _Market;
		
		private System.Nullable<int> _DividendStart;
		
		private string _DividendCommentary;
		
		private System.Nullable<decimal> _LastTrade;
		
		private System.Nullable<decimal> _AverageVolume;
		
		private System.Nullable<decimal> _MarketCap;
		
		private System.Nullable<decimal> _PriceEarningRatio;
		
		private System.Nullable<decimal> _EarningsPerShare;
		
		private System.Nullable<decimal> _DividendYield;
		
		private System.Nullable<decimal> _PriceBookRatio;
		
		private System.Nullable<decimal> _SharesOutstanding;
		
		private System.Nullable<decimal> _PayoutRatio;
		
		private System.Nullable<decimal> _TotalCurrentAssets;
		
		private System.Nullable<decimal> _TotalAssets;
		
		private System.Nullable<decimal> _TotalCurrentLiabilities;
		
		private System.Nullable<decimal> _TotalLiabilities;
		
		private System.Nullable<decimal> _LongTermDebt;
		
		private System.Nullable<decimal> _StockholderEquity;
		
		private System.Nullable<decimal> _ATMStrike;
		
		private System.Nullable<decimal> _ATMCallOpenInterest;
		
		private System.Nullable<decimal> _ATMPutOpenInterest;
		
		private System.Nullable<decimal> _DailyVolume;
		
		private System.Nullable<int> _OverrideCode;
		
		private string _OverrideReason;
		
		private System.Nullable<bool> _LastUpdateSuccessful;
		
		private System.Nullable<System.DateTime> _Ex_DividendDate;
		
		private System.Nullable<System.DateTime> _NextEarningsDate;
		
		private string _NextEarningsTime;
		
		private System.Nullable<double> _AnalystsOpinion;
		
		private System.Nullable<bool> _NakedOptions;
		
		private System.Nullable<double> _IVPercentile;
		
		private System.Nullable<double> _IVRank;
		
		private System.Nullable<double> _PercentBB;
		
		private System.Nullable<double> _PriceChange5Day;
		
		private System.Nullable<double> _PriceChange10Day;
		
		private System.Nullable<double> _PriceChange15Day;
		
		private System.Nullable<double> _Beta;
		
		private string _Exchange;
		
		private string _PrimExchange;
		
		private string _SecType;
		
		private System.Nullable<System.DateTime> _FutureExpiry;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTickerChanging(string value);
    partial void OnTickerChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnSectorChanging(string value);
    partial void OnSectorChanged();
    partial void OnIndustryChanging(string value);
    partial void OnIndustryChanged();
    partial void OnMarketChanging(string value);
    partial void OnMarketChanged();
    partial void OnDividendStartChanging(System.Nullable<int> value);
    partial void OnDividendStartChanged();
    partial void OnDividendCommentaryChanging(string value);
    partial void OnDividendCommentaryChanged();
    partial void OnLastTradeChanging(System.Nullable<decimal> value);
    partial void OnLastTradeChanged();
    partial void OnAverageVolumeChanging(System.Nullable<decimal> value);
    partial void OnAverageVolumeChanged();
    partial void OnMarketCapChanging(System.Nullable<decimal> value);
    partial void OnMarketCapChanged();
    partial void OnPriceEarningRatioChanging(System.Nullable<decimal> value);
    partial void OnPriceEarningRatioChanged();
    partial void OnEarningsPerShareChanging(System.Nullable<decimal> value);
    partial void OnEarningsPerShareChanged();
    partial void OnDividendYieldChanging(System.Nullable<decimal> value);
    partial void OnDividendYieldChanged();
    partial void OnPriceBookRatioChanging(System.Nullable<decimal> value);
    partial void OnPriceBookRatioChanged();
    partial void OnSharesOutstandingChanging(System.Nullable<decimal> value);
    partial void OnSharesOutstandingChanged();
    partial void OnPayoutRatioChanging(System.Nullable<decimal> value);
    partial void OnPayoutRatioChanged();
    partial void OnTotalCurrentAssetsChanging(System.Nullable<decimal> value);
    partial void OnTotalCurrentAssetsChanged();
    partial void OnTotalAssetsChanging(System.Nullable<decimal> value);
    partial void OnTotalAssetsChanged();
    partial void OnTotalCurrentLiabilitiesChanging(System.Nullable<decimal> value);
    partial void OnTotalCurrentLiabilitiesChanged();
    partial void OnTotalLiabilitiesChanging(System.Nullable<decimal> value);
    partial void OnTotalLiabilitiesChanged();
    partial void OnLongTermDebtChanging(System.Nullable<decimal> value);
    partial void OnLongTermDebtChanged();
    partial void OnStockholderEquityChanging(System.Nullable<decimal> value);
    partial void OnStockholderEquityChanged();
    partial void OnATMStrikeChanging(System.Nullable<decimal> value);
    partial void OnATMStrikeChanged();
    partial void OnATMCallOpenInterestChanging(System.Nullable<decimal> value);
    partial void OnATMCallOpenInterestChanged();
    partial void OnATMPutOpenInterestChanging(System.Nullable<decimal> value);
    partial void OnATMPutOpenInterestChanged();
    partial void OnDailyVolumeChanging(System.Nullable<decimal> value);
    partial void OnDailyVolumeChanged();
    partial void OnOverrideCodeChanging(System.Nullable<int> value);
    partial void OnOverrideCodeChanged();
    partial void OnOverrideReasonChanging(string value);
    partial void OnOverrideReasonChanged();
    partial void OnLastUpdateSuccessfulChanging(System.Nullable<bool> value);
    partial void OnLastUpdateSuccessfulChanged();
    partial void OnEx_DividendDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEx_DividendDateChanged();
    partial void OnNextEarningsDateChanging(System.Nullable<System.DateTime> value);
    partial void OnNextEarningsDateChanged();
    partial void OnNextEarningsTimeChanging(string value);
    partial void OnNextEarningsTimeChanged();
    partial void OnAnalystsOpinionChanging(System.Nullable<double> value);
    partial void OnAnalystsOpinionChanged();
    partial void OnNakedOptionsChanging(System.Nullable<bool> value);
    partial void OnNakedOptionsChanged();
    partial void OnIVPercentileChanging(System.Nullable<double> value);
    partial void OnIVPercentileChanged();
    partial void OnIVRankChanging(System.Nullable<double> value);
    partial void OnIVRankChanged();
    partial void OnPercentBBChanging(System.Nullable<double> value);
    partial void OnPercentBBChanged();
    partial void OnPriceChange5DayChanging(System.Nullable<double> value);
    partial void OnPriceChange5DayChanged();
    partial void OnPriceChange10DayChanging(System.Nullable<double> value);
    partial void OnPriceChange10DayChanged();
    partial void OnPriceChange15DayChanging(System.Nullable<double> value);
    partial void OnPriceChange15DayChanged();
    partial void OnBetaChanging(System.Nullable<double> value);
    partial void OnBetaChanged();
    partial void OnExchangeChanging(string value);
    partial void OnExchangeChanged();
    partial void OnPrimExchangeChanging(string value);
    partial void OnPrimExchangeChanged();
    partial void OnSecTypeChanging(string value);
    partial void OnSecTypeChanged();
    partial void OnFutureExpiryChanging(System.Nullable<System.DateTime> value);
    partial void OnFutureExpiryChanged();
    #endregion
		
		public Stock()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ticker", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Ticker
		{
			get
			{
				return this._Ticker;
			}
			set
			{
				if ((this._Ticker != value))
				{
					this.OnTickerChanging(value);
					this.SendPropertyChanging();
					this._Ticker = value;
					this.SendPropertyChanged("Ticker");
					this.OnTickerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="VarChar(100)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sector", DbType="VarChar(40)")]
		public string Sector
		{
			get
			{
				return this._Sector;
			}
			set
			{
				if ((this._Sector != value))
				{
					this.OnSectorChanging(value);
					this.SendPropertyChanging();
					this._Sector = value;
					this.SendPropertyChanged("Sector");
					this.OnSectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Industry", DbType="VarChar(40)")]
		public string Industry
		{
			get
			{
				return this._Industry;
			}
			set
			{
				if ((this._Industry != value))
				{
					this.OnIndustryChanging(value);
					this.SendPropertyChanging();
					this._Industry = value;
					this.SendPropertyChanged("Industry");
					this.OnIndustryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Market", DbType="VarChar(2)")]
		public string Market
		{
			get
			{
				return this._Market;
			}
			set
			{
				if ((this._Market != value))
				{
					this.OnMarketChanging(value);
					this.SendPropertyChanging();
					this._Market = value;
					this.SendPropertyChanged("Market");
					this.OnMarketChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DividendStart", DbType="Int")]
		public System.Nullable<int> DividendStart
		{
			get
			{
				return this._DividendStart;
			}
			set
			{
				if ((this._DividendStart != value))
				{
					this.OnDividendStartChanging(value);
					this.SendPropertyChanging();
					this._DividendStart = value;
					this.SendPropertyChanged("DividendStart");
					this.OnDividendStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DividendCommentary", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string DividendCommentary
		{
			get
			{
				return this._DividendCommentary;
			}
			set
			{
				if ((this._DividendCommentary != value))
				{
					this.OnDividendCommentaryChanging(value);
					this.SendPropertyChanging();
					this._DividendCommentary = value;
					this.SendPropertyChanged("DividendCommentary");
					this.OnDividendCommentaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastTrade", DbType="Decimal(18,4)")]
		public System.Nullable<decimal> LastTrade
		{
			get
			{
				return this._LastTrade;
			}
			set
			{
				if ((this._LastTrade != value))
				{
					this.OnLastTradeChanging(value);
					this.SendPropertyChanging();
					this._LastTrade = value;
					this.SendPropertyChanged("LastTrade");
					this.OnLastTradeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AverageVolume", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> AverageVolume
		{
			get
			{
				return this._AverageVolume;
			}
			set
			{
				if ((this._AverageVolume != value))
				{
					this.OnAverageVolumeChanging(value);
					this.SendPropertyChanging();
					this._AverageVolume = value;
					this.SendPropertyChanged("AverageVolume");
					this.OnAverageVolumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarketCap", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> MarketCap
		{
			get
			{
				return this._MarketCap;
			}
			set
			{
				if ((this._MarketCap != value))
				{
					this.OnMarketCapChanging(value);
					this.SendPropertyChanging();
					this._MarketCap = value;
					this.SendPropertyChanged("MarketCap");
					this.OnMarketCapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceEarningRatio", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> PriceEarningRatio
		{
			get
			{
				return this._PriceEarningRatio;
			}
			set
			{
				if ((this._PriceEarningRatio != value))
				{
					this.OnPriceEarningRatioChanging(value);
					this.SendPropertyChanging();
					this._PriceEarningRatio = value;
					this.SendPropertyChanged("PriceEarningRatio");
					this.OnPriceEarningRatioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EarningsPerShare", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> EarningsPerShare
		{
			get
			{
				return this._EarningsPerShare;
			}
			set
			{
				if ((this._EarningsPerShare != value))
				{
					this.OnEarningsPerShareChanging(value);
					this.SendPropertyChanging();
					this._EarningsPerShare = value;
					this.SendPropertyChanged("EarningsPerShare");
					this.OnEarningsPerShareChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DividendYield", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> DividendYield
		{
			get
			{
				return this._DividendYield;
			}
			set
			{
				if ((this._DividendYield != value))
				{
					this.OnDividendYieldChanging(value);
					this.SendPropertyChanging();
					this._DividendYield = value;
					this.SendPropertyChanged("DividendYield");
					this.OnDividendYieldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceBookRatio", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> PriceBookRatio
		{
			get
			{
				return this._PriceBookRatio;
			}
			set
			{
				if ((this._PriceBookRatio != value))
				{
					this.OnPriceBookRatioChanging(value);
					this.SendPropertyChanging();
					this._PriceBookRatio = value;
					this.SendPropertyChanged("PriceBookRatio");
					this.OnPriceBookRatioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SharesOutstanding", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> SharesOutstanding
		{
			get
			{
				return this._SharesOutstanding;
			}
			set
			{
				if ((this._SharesOutstanding != value))
				{
					this.OnSharesOutstandingChanging(value);
					this.SendPropertyChanging();
					this._SharesOutstanding = value;
					this.SendPropertyChanged("SharesOutstanding");
					this.OnSharesOutstandingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PayoutRatio", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> PayoutRatio
		{
			get
			{
				return this._PayoutRatio;
			}
			set
			{
				if ((this._PayoutRatio != value))
				{
					this.OnPayoutRatioChanging(value);
					this.SendPropertyChanging();
					this._PayoutRatio = value;
					this.SendPropertyChanged("PayoutRatio");
					this.OnPayoutRatioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalCurrentAssets", DbType="Decimal(24,2)")]
		public System.Nullable<decimal> TotalCurrentAssets
		{
			get
			{
				return this._TotalCurrentAssets;
			}
			set
			{
				if ((this._TotalCurrentAssets != value))
				{
					this.OnTotalCurrentAssetsChanging(value);
					this.SendPropertyChanging();
					this._TotalCurrentAssets = value;
					this.SendPropertyChanged("TotalCurrentAssets");
					this.OnTotalCurrentAssetsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalAssets", DbType="Decimal(24,2)")]
		public System.Nullable<decimal> TotalAssets
		{
			get
			{
				return this._TotalAssets;
			}
			set
			{
				if ((this._TotalAssets != value))
				{
					this.OnTotalAssetsChanging(value);
					this.SendPropertyChanging();
					this._TotalAssets = value;
					this.SendPropertyChanged("TotalAssets");
					this.OnTotalAssetsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalCurrentLiabilities", DbType="Decimal(24,2)")]
		public System.Nullable<decimal> TotalCurrentLiabilities
		{
			get
			{
				return this._TotalCurrentLiabilities;
			}
			set
			{
				if ((this._TotalCurrentLiabilities != value))
				{
					this.OnTotalCurrentLiabilitiesChanging(value);
					this.SendPropertyChanging();
					this._TotalCurrentLiabilities = value;
					this.SendPropertyChanged("TotalCurrentLiabilities");
					this.OnTotalCurrentLiabilitiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalLiabilities", DbType="Decimal(24,2)")]
		public System.Nullable<decimal> TotalLiabilities
		{
			get
			{
				return this._TotalLiabilities;
			}
			set
			{
				if ((this._TotalLiabilities != value))
				{
					this.OnTotalLiabilitiesChanging(value);
					this.SendPropertyChanging();
					this._TotalLiabilities = value;
					this.SendPropertyChanged("TotalLiabilities");
					this.OnTotalLiabilitiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LongTermDebt", DbType="Decimal(24,2)")]
		public System.Nullable<decimal> LongTermDebt
		{
			get
			{
				return this._LongTermDebt;
			}
			set
			{
				if ((this._LongTermDebt != value))
				{
					this.OnLongTermDebtChanging(value);
					this.SendPropertyChanging();
					this._LongTermDebt = value;
					this.SendPropertyChanged("LongTermDebt");
					this.OnLongTermDebtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockholderEquity", DbType="Decimal(24,2)")]
		public System.Nullable<decimal> StockholderEquity
		{
			get
			{
				return this._StockholderEquity;
			}
			set
			{
				if ((this._StockholderEquity != value))
				{
					this.OnStockholderEquityChanging(value);
					this.SendPropertyChanging();
					this._StockholderEquity = value;
					this.SendPropertyChanged("StockholderEquity");
					this.OnStockholderEquityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ATMStrike", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> ATMStrike
		{
			get
			{
				return this._ATMStrike;
			}
			set
			{
				if ((this._ATMStrike != value))
				{
					this.OnATMStrikeChanging(value);
					this.SendPropertyChanging();
					this._ATMStrike = value;
					this.SendPropertyChanged("ATMStrike");
					this.OnATMStrikeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ATMCallOpenInterest", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> ATMCallOpenInterest
		{
			get
			{
				return this._ATMCallOpenInterest;
			}
			set
			{
				if ((this._ATMCallOpenInterest != value))
				{
					this.OnATMCallOpenInterestChanging(value);
					this.SendPropertyChanging();
					this._ATMCallOpenInterest = value;
					this.SendPropertyChanged("ATMCallOpenInterest");
					this.OnATMCallOpenInterestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ATMPutOpenInterest", DbType="Decimal(24,4)")]
		public System.Nullable<decimal> ATMPutOpenInterest
		{
			get
			{
				return this._ATMPutOpenInterest;
			}
			set
			{
				if ((this._ATMPutOpenInterest != value))
				{
					this.OnATMPutOpenInterestChanging(value);
					this.SendPropertyChanging();
					this._ATMPutOpenInterest = value;
					this.SendPropertyChanged("ATMPutOpenInterest");
					this.OnATMPutOpenInterestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DailyVolume", DbType="Decimal(24,2)")]
		public System.Nullable<decimal> DailyVolume
		{
			get
			{
				return this._DailyVolume;
			}
			set
			{
				if ((this._DailyVolume != value))
				{
					this.OnDailyVolumeChanging(value);
					this.SendPropertyChanging();
					this._DailyVolume = value;
					this.SendPropertyChanged("DailyVolume");
					this.OnDailyVolumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OverrideCode", DbType="Int")]
		public System.Nullable<int> OverrideCode
		{
			get
			{
				return this._OverrideCode;
			}
			set
			{
				if ((this._OverrideCode != value))
				{
					this.OnOverrideCodeChanging(value);
					this.SendPropertyChanging();
					this._OverrideCode = value;
					this.SendPropertyChanged("OverrideCode");
					this.OnOverrideCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OverrideReason", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string OverrideReason
		{
			get
			{
				return this._OverrideReason;
			}
			set
			{
				if ((this._OverrideReason != value))
				{
					this.OnOverrideReasonChanging(value);
					this.SendPropertyChanging();
					this._OverrideReason = value;
					this.SendPropertyChanged("OverrideReason");
					this.OnOverrideReasonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastUpdateSuccessful", DbType="Bit")]
		public System.Nullable<bool> LastUpdateSuccessful
		{
			get
			{
				return this._LastUpdateSuccessful;
			}
			set
			{
				if ((this._LastUpdateSuccessful != value))
				{
					this.OnLastUpdateSuccessfulChanging(value);
					this.SendPropertyChanging();
					this._LastUpdateSuccessful = value;
					this.SendPropertyChanged("LastUpdateSuccessful");
					this.OnLastUpdateSuccessfulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Ex-DividendDate]", Storage="_Ex_DividendDate", DbType="Date")]
		public System.Nullable<System.DateTime> Ex_DividendDate
		{
			get
			{
				return this._Ex_DividendDate;
			}
			set
			{
				if ((this._Ex_DividendDate != value))
				{
					this.OnEx_DividendDateChanging(value);
					this.SendPropertyChanging();
					this._Ex_DividendDate = value;
					this.SendPropertyChanged("Ex_DividendDate");
					this.OnEx_DividendDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NextEarningsDate", DbType="Date")]
		public System.Nullable<System.DateTime> NextEarningsDate
		{
			get
			{
				return this._NextEarningsDate;
			}
			set
			{
				if ((this._NextEarningsDate != value))
				{
					this.OnNextEarningsDateChanging(value);
					this.SendPropertyChanging();
					this._NextEarningsDate = value;
					this.SendPropertyChanged("NextEarningsDate");
					this.OnNextEarningsDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NextEarningsTime", DbType="VarChar(40)")]
		public string NextEarningsTime
		{
			get
			{
				return this._NextEarningsTime;
			}
			set
			{
				if ((this._NextEarningsTime != value))
				{
					this.OnNextEarningsTimeChanging(value);
					this.SendPropertyChanging();
					this._NextEarningsTime = value;
					this.SendPropertyChanged("NextEarningsTime");
					this.OnNextEarningsTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnalystsOpinion", DbType="Float")]
		public System.Nullable<double> AnalystsOpinion
		{
			get
			{
				return this._AnalystsOpinion;
			}
			set
			{
				if ((this._AnalystsOpinion != value))
				{
					this.OnAnalystsOpinionChanging(value);
					this.SendPropertyChanging();
					this._AnalystsOpinion = value;
					this.SendPropertyChanged("AnalystsOpinion");
					this.OnAnalystsOpinionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NakedOptions", DbType="Bit")]
		public System.Nullable<bool> NakedOptions
		{
			get
			{
				return this._NakedOptions;
			}
			set
			{
				if ((this._NakedOptions != value))
				{
					this.OnNakedOptionsChanging(value);
					this.SendPropertyChanging();
					this._NakedOptions = value;
					this.SendPropertyChanged("NakedOptions");
					this.OnNakedOptionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IVPercentile", DbType="Float")]
		public System.Nullable<double> IVPercentile
		{
			get
			{
				return this._IVPercentile;
			}
			set
			{
				if ((this._IVPercentile != value))
				{
					this.OnIVPercentileChanging(value);
					this.SendPropertyChanging();
					this._IVPercentile = value;
					this.SendPropertyChanged("IVPercentile");
					this.OnIVPercentileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IVRank", DbType="Float")]
		public System.Nullable<double> IVRank
		{
			get
			{
				return this._IVRank;
			}
			set
			{
				if ((this._IVRank != value))
				{
					this.OnIVRankChanging(value);
					this.SendPropertyChanging();
					this._IVRank = value;
					this.SendPropertyChanged("IVRank");
					this.OnIVRankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PercentBB", DbType="Float")]
		public System.Nullable<double> PercentBB
		{
			get
			{
				return this._PercentBB;
			}
			set
			{
				if ((this._PercentBB != value))
				{
					this.OnPercentBBChanging(value);
					this.SendPropertyChanging();
					this._PercentBB = value;
					this.SendPropertyChanged("PercentBB");
					this.OnPercentBBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceChange5Day", DbType="Float")]
		public System.Nullable<double> PriceChange5Day
		{
			get
			{
				return this._PriceChange5Day;
			}
			set
			{
				if ((this._PriceChange5Day != value))
				{
					this.OnPriceChange5DayChanging(value);
					this.SendPropertyChanging();
					this._PriceChange5Day = value;
					this.SendPropertyChanged("PriceChange5Day");
					this.OnPriceChange5DayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceChange10Day", DbType="Float")]
		public System.Nullable<double> PriceChange10Day
		{
			get
			{
				return this._PriceChange10Day;
			}
			set
			{
				if ((this._PriceChange10Day != value))
				{
					this.OnPriceChange10DayChanging(value);
					this.SendPropertyChanging();
					this._PriceChange10Day = value;
					this.SendPropertyChanged("PriceChange10Day");
					this.OnPriceChange10DayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PriceChange15Day", DbType="Float")]
		public System.Nullable<double> PriceChange15Day
		{
			get
			{
				return this._PriceChange15Day;
			}
			set
			{
				if ((this._PriceChange15Day != value))
				{
					this.OnPriceChange15DayChanging(value);
					this.SendPropertyChanging();
					this._PriceChange15Day = value;
					this.SendPropertyChanged("PriceChange15Day");
					this.OnPriceChange15DayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Beta", DbType="Float")]
		public System.Nullable<double> Beta
		{
			get
			{
				return this._Beta;
			}
			set
			{
				if ((this._Beta != value))
				{
					this.OnBetaChanging(value);
					this.SendPropertyChanging();
					this._Beta = value;
					this.SendPropertyChanged("Beta");
					this.OnBetaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Exchange", DbType="VarChar(8) NOT NULL", CanBeNull=false)]
		public string Exchange
		{
			get
			{
				return this._Exchange;
			}
			set
			{
				if ((this._Exchange != value))
				{
					this.OnExchangeChanging(value);
					this.SendPropertyChanging();
					this._Exchange = value;
					this.SendPropertyChanged("Exchange");
					this.OnExchangeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrimExchange", DbType="VarChar(8)")]
		public string PrimExchange
		{
			get
			{
				return this._PrimExchange;
			}
			set
			{
				if ((this._PrimExchange != value))
				{
					this.OnPrimExchangeChanging(value);
					this.SendPropertyChanging();
					this._PrimExchange = value;
					this.SendPropertyChanged("PrimExchange");
					this.OnPrimExchangeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecType", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
		public string SecType
		{
			get
			{
				return this._SecType;
			}
			set
			{
				if ((this._SecType != value))
				{
					this.OnSecTypeChanging(value);
					this.SendPropertyChanging();
					this._SecType = value;
					this.SendPropertyChanged("SecType");
					this.OnSecTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FutureExpiry", DbType="Date")]
		public System.Nullable<System.DateTime> FutureExpiry
		{
			get
			{
				return this._FutureExpiry;
			}
			set
			{
				if ((this._FutureExpiry != value))
				{
					this.OnFutureExpiryChanging(value);
					this.SendPropertyChanging();
					this._FutureExpiry = value;
					this.SendPropertyChanged("FutureExpiry");
					this.OnFutureExpiryChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
