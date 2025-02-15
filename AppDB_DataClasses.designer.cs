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

namespace project7_4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AppDB")]
	public partial class AppDB_DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCheckoutTable(CheckoutTable instance);
    partial void UpdateCheckoutTable(CheckoutTable instance);
    partial void DeleteCheckoutTable(CheckoutTable instance);
        #endregion

        //created
        public AppDB_DataClassesDataContext() : base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AppDBConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }


        public AppDB_DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AppDB_DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AppDB_DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AppDB_DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CheckoutTable> CheckoutTables
		{
			get
			{
				return this.GetTable<CheckoutTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CheckoutTable")]
	public partial class CheckoutTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _DateTime;
		
		private string _NameOnCard;
		
		private string _CreditCardNo;
		
		private string _ExpMonth;
		
		private string _CVV;
		
		private string _ExpYear;
		
		private string _FullName;
		
		private string _Email;
		
		private string _Address;
		
		private string _City;
		
		private string _ZipCode;
		
		private string _State;
		
		private string _LaptopQuantity;
		
		private string _TotalFee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDateTimeChanging(string value);
    partial void OnDateTimeChanged();
    partial void OnNameOnCardChanging(string value);
    partial void OnNameOnCardChanged();
    partial void OnCreditCardNoChanging(string value);
    partial void OnCreditCardNoChanged();
    partial void OnExpMonthChanging(string value);
    partial void OnExpMonthChanged();
    partial void OnCVVChanging(string value);
    partial void OnCVVChanged();
    partial void OnExpYearChanging(string value);
    partial void OnExpYearChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnLaptopQuantityChanging(string value);
    partial void OnLaptopQuantityChanged();
    partial void OnTotalFeeChanging(string value);
    partial void OnTotalFeeChanged();
    #endregion
		
		public CheckoutTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="VarChar(50)")]
		public string DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this.OnDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DateTime = value;
					this.SendPropertyChanged("DateTime");
					this.OnDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameOnCard", DbType="VarChar(50)")]
		public string NameOnCard
		{
			get
			{
				return this._NameOnCard;
			}
			set
			{
				if ((this._NameOnCard != value))
				{
					this.OnNameOnCardChanging(value);
					this.SendPropertyChanging();
					this._NameOnCard = value;
					this.SendPropertyChanged("NameOnCard");
					this.OnNameOnCardChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreditCardNo", DbType="VarChar(50)")]
		public string CreditCardNo
		{
			get
			{
				return this._CreditCardNo;
			}
			set
			{
				if ((this._CreditCardNo != value))
				{
					this.OnCreditCardNoChanging(value);
					this.SendPropertyChanging();
					this._CreditCardNo = value;
					this.SendPropertyChanged("CreditCardNo");
					this.OnCreditCardNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpMonth", DbType="VarChar(50)")]
		public string ExpMonth
		{
			get
			{
				return this._ExpMonth;
			}
			set
			{
				if ((this._ExpMonth != value))
				{
					this.OnExpMonthChanging(value);
					this.SendPropertyChanging();
					this._ExpMonth = value;
					this.SendPropertyChanged("ExpMonth");
					this.OnExpMonthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CVV", DbType="VarChar(50)")]
		public string CVV
		{
			get
			{
				return this._CVV;
			}
			set
			{
				if ((this._CVV != value))
				{
					this.OnCVVChanging(value);
					this.SendPropertyChanging();
					this._CVV = value;
					this.SendPropertyChanged("CVV");
					this.OnCVVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpYear", DbType="VarChar(50)")]
		public string ExpYear
		{
			get
			{
				return this._ExpYear;
			}
			set
			{
				if ((this._ExpYear != value))
				{
					this.OnExpYearChanging(value);
					this.SendPropertyChanging();
					this._ExpYear = value;
					this.SendPropertyChanged("ExpYear");
					this.OnExpYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(50)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="VarChar(50)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(50)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaptopQuantity", DbType="VarChar(50)")]
		public string LaptopQuantity
		{
			get
			{
				return this._LaptopQuantity;
			}
			set
			{
				if ((this._LaptopQuantity != value))
				{
					this.OnLaptopQuantityChanging(value);
					this.SendPropertyChanging();
					this._LaptopQuantity = value;
					this.SendPropertyChanged("LaptopQuantity");
					this.OnLaptopQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalFee", DbType="VarChar(50)")]
		public string TotalFee
		{
			get
			{
				return this._TotalFee;
			}
			set
			{
				if ((this._TotalFee != value))
				{
					this.OnTotalFeeChanging(value);
					this.SendPropertyChanging();
					this._TotalFee = value;
					this.SendPropertyChanged("TotalFee");
					this.OnTotalFeeChanged();
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
