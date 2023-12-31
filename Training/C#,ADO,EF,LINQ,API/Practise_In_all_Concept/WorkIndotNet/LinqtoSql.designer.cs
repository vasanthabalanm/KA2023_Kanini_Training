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

namespace WorkIndotNet
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Adocase_study")]
	public partial class LinqtoSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer_transaction(Customer_transaction instance);
    partial void UpdateCustomer_transaction(Customer_transaction instance);
    partial void DeleteCustomer_transaction(Customer_transaction instance);
    partial void InsertRegion(Region instance);
    partial void UpdateRegion(Region instance);
    partial void DeleteRegion(Region instance);
    #endregion
		
		public LinqtoSqlDataContext() : 
				base(global::WorkIndotNet.Properties.Settings.Default.Adocase_studyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqtoSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqtoSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqtoSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqtoSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer_Node> Customer_Nodes
		{
			get
			{
				return this.GetTable<Customer_Node>();
			}
		}
		
		public System.Data.Linq.Table<Customer_transaction> Customer_transactions
		{
			get
			{
				return this.GetTable<Customer_transaction>();
			}
		}
		
		public System.Data.Linq.Table<Region> Regions
		{
			get
			{
				return this.GetTable<Region>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer_Nodes")]
	public partial class Customer_Node
	{
		
		private System.Nullable<int> _customer_id;
		
		private System.Nullable<int> _region_id;
		
		private System.Nullable<int> _node_id;
		
		private System.Nullable<System.DateTime> _start_dates;
		
		private System.Nullable<System.DateTime> _end_dates;
		
		public Customer_Node()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int")]
		public System.Nullable<int> customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					this._customer_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_region_id", DbType="Int")]
		public System.Nullable<int> region_id
		{
			get
			{
				return this._region_id;
			}
			set
			{
				if ((this._region_id != value))
				{
					this._region_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_node_id", DbType="Int")]
		public System.Nullable<int> node_id
		{
			get
			{
				return this._node_id;
			}
			set
			{
				if ((this._node_id != value))
				{
					this._node_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start_dates", DbType="Date")]
		public System.Nullable<System.DateTime> start_dates
		{
			get
			{
				return this._start_dates;
			}
			set
			{
				if ((this._start_dates != value))
				{
					this._start_dates = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_end_dates", DbType="Date")]
		public System.Nullable<System.DateTime> end_dates
		{
			get
			{
				return this._end_dates;
			}
			set
			{
				if ((this._end_dates != value))
				{
					this._end_dates = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer_transactions")]
	public partial class Customer_transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _customer_id;
		
		private System.Nullable<System.DateTime> _txn_date;
		
		private string _txn_type;
		
		private System.Nullable<int> _txn_amount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncustomer_idChanging(int value);
    partial void Oncustomer_idChanged();
    partial void Ontxn_dateChanging(System.Nullable<System.DateTime> value);
    partial void Ontxn_dateChanged();
    partial void Ontxn_typeChanging(string value);
    partial void Ontxn_typeChanged();
    partial void Ontxn_amountChanging(System.Nullable<int> value);
    partial void Ontxn_amountChanged();
    #endregion
		
		public Customer_transaction()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					this.Oncustomer_idChanging(value);
					this.SendPropertyChanging();
					this._customer_id = value;
					this.SendPropertyChanged("customer_id");
					this.Oncustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txn_date", DbType="Date")]
		public System.Nullable<System.DateTime> txn_date
		{
			get
			{
				return this._txn_date;
			}
			set
			{
				if ((this._txn_date != value))
				{
					this.Ontxn_dateChanging(value);
					this.SendPropertyChanging();
					this._txn_date = value;
					this.SendPropertyChanged("txn_date");
					this.Ontxn_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txn_type", DbType="VarChar(30)")]
		public string txn_type
		{
			get
			{
				return this._txn_type;
			}
			set
			{
				if ((this._txn_type != value))
				{
					this.Ontxn_typeChanging(value);
					this.SendPropertyChanging();
					this._txn_type = value;
					this.SendPropertyChanged("txn_type");
					this.Ontxn_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_txn_amount", DbType="Int")]
		public System.Nullable<int> txn_amount
		{
			get
			{
				return this._txn_amount;
			}
			set
			{
				if ((this._txn_amount != value))
				{
					this.Ontxn_amountChanging(value);
					this.SendPropertyChanging();
					this._txn_amount = value;
					this.SendPropertyChanged("txn_amount");
					this.Ontxn_amountChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Regions")]
	public partial class Region : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _region_id;
		
		private string _region_name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onregion_idChanging(int value);
    partial void Onregion_idChanged();
    partial void Onregion_nameChanging(string value);
    partial void Onregion_nameChanged();
    #endregion
		
		public Region()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_region_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int region_id
		{
			get
			{
				return this._region_id;
			}
			set
			{
				if ((this._region_id != value))
				{
					this.Onregion_idChanging(value);
					this.SendPropertyChanging();
					this._region_id = value;
					this.SendPropertyChanged("region_id");
					this.Onregion_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_region_name", DbType="VarChar(30)")]
		public string region_name
		{
			get
			{
				return this._region_name;
			}
			set
			{
				if ((this._region_name != value))
				{
					this.Onregion_nameChanging(value);
					this.SendPropertyChanging();
					this._region_name = value;
					this.SendPropertyChanged("region_name");
					this.Onregion_nameChanged();
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
