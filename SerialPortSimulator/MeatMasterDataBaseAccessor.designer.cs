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

namespace SerialPortSimulator
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MeatMasterII")]
	public partial class MeatMasterDataBaseAccessorDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblMfCdSample(tblMfCdSample instance);
    partial void UpdatetblMfCdSample(tblMfCdSample instance);
    partial void DeletetblMfCdSample(tblMfCdSample instance);
    #endregion
		
		public MeatMasterDataBaseAccessorDataContext() : 
				base(global::SerialPortSimulator.Properties.Settings.Default.MeatMasterIIConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MeatMasterDataBaseAccessorDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MeatMasterDataBaseAccessorDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MeatMasterDataBaseAccessorDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MeatMasterDataBaseAccessorDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblMfCdSample> tblMfCdSamples
		{
			get
			{
				return this.GetTable<tblMfCdSample>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblMfCdSample")]
	public partial class tblMfCdSample : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SystemID;
		
		private long _SampleID;
		
		private int _InstrumentLogicalID;
		
		private int _SampleType;
		
		private string _SampleNumber;
		
		private int _ProductLogicalID;
		
		private System.Nullable<int> _AuditTrailID;
		
		private System.Nullable<System.DateTime> _AnalysisStartUTC;
		
		private System.Nullable<System.DateTime> _AnalysisEndUTC;
		
		private System.Nullable<System.DateTime> _CreatedAtUTC;
		
		private System.Nullable<System.DateTime> _ModifiedAtUTC;
		
		private System.Nullable<long> _ModifiedBy;
		
		private int _RawDataStatus;
		
		private int _EventsStatus;
		
		private int _OutlierStatus;
		
		private int _ProductLimitsStatus;
		
		private System.Nullable<System.Guid> _SampleInstrumentID;
		
		private bool _Obsolete;
		
		private string _Signature;
		
		private System.Nullable<int> _SignatureVersion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSystemIDChanging(int value);
    partial void OnSystemIDChanged();
    partial void OnSampleIDChanging(long value);
    partial void OnSampleIDChanged();
    partial void OnInstrumentLogicalIDChanging(int value);
    partial void OnInstrumentLogicalIDChanged();
    partial void OnSampleTypeChanging(int value);
    partial void OnSampleTypeChanged();
    partial void OnSampleNumberChanging(string value);
    partial void OnSampleNumberChanged();
    partial void OnProductLogicalIDChanging(int value);
    partial void OnProductLogicalIDChanged();
    partial void OnAuditTrailIDChanging(System.Nullable<int> value);
    partial void OnAuditTrailIDChanged();
    partial void OnAnalysisStartUTCChanging(System.Nullable<System.DateTime> value);
    partial void OnAnalysisStartUTCChanged();
    partial void OnAnalysisEndUTCChanging(System.Nullable<System.DateTime> value);
    partial void OnAnalysisEndUTCChanged();
    partial void OnCreatedAtUTCChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedAtUTCChanged();
    partial void OnModifiedAtUTCChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedAtUTCChanged();
    partial void OnModifiedByChanging(System.Nullable<long> value);
    partial void OnModifiedByChanged();
    partial void OnRawDataStatusChanging(int value);
    partial void OnRawDataStatusChanged();
    partial void OnEventsStatusChanging(int value);
    partial void OnEventsStatusChanged();
    partial void OnOutlierStatusChanging(int value);
    partial void OnOutlierStatusChanged();
    partial void OnProductLimitsStatusChanging(int value);
    partial void OnProductLimitsStatusChanged();
    partial void OnSampleInstrumentIDChanging(System.Nullable<System.Guid> value);
    partial void OnSampleInstrumentIDChanged();
    partial void OnObsoleteChanging(bool value);
    partial void OnObsoleteChanged();
    partial void OnSignatureChanging(string value);
    partial void OnSignatureChanged();
    partial void OnSignatureVersionChanging(System.Nullable<int> value);
    partial void OnSignatureVersionChanged();
    #endregion
		
		public tblMfCdSample()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SystemID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SystemID
		{
			get
			{
				return this._SystemID;
			}
			set
			{
				if ((this._SystemID != value))
				{
					this.OnSystemIDChanging(value);
					this.SendPropertyChanging();
					this._SystemID = value;
					this.SendPropertyChanged("SystemID");
					this.OnSystemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SampleID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long SampleID
		{
			get
			{
				return this._SampleID;
			}
			set
			{
				if ((this._SampleID != value))
				{
					this.OnSampleIDChanging(value);
					this.SendPropertyChanging();
					this._SampleID = value;
					this.SendPropertyChanged("SampleID");
					this.OnSampleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstrumentLogicalID", DbType="Int NOT NULL")]
		public int InstrumentLogicalID
		{
			get
			{
				return this._InstrumentLogicalID;
			}
			set
			{
				if ((this._InstrumentLogicalID != value))
				{
					this.OnInstrumentLogicalIDChanging(value);
					this.SendPropertyChanging();
					this._InstrumentLogicalID = value;
					this.SendPropertyChanged("InstrumentLogicalID");
					this.OnInstrumentLogicalIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SampleType", DbType="Int NOT NULL")]
		public int SampleType
		{
			get
			{
				return this._SampleType;
			}
			set
			{
				if ((this._SampleType != value))
				{
					this.OnSampleTypeChanging(value);
					this.SendPropertyChanging();
					this._SampleType = value;
					this.SendPropertyChanged("SampleType");
					this.OnSampleTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SampleNumber", DbType="NVarChar(50)")]
		public string SampleNumber
		{
			get
			{
				return this._SampleNumber;
			}
			set
			{
				if ((this._SampleNumber != value))
				{
					this.OnSampleNumberChanging(value);
					this.SendPropertyChanging();
					this._SampleNumber = value;
					this.SendPropertyChanged("SampleNumber");
					this.OnSampleNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductLogicalID", DbType="Int NOT NULL")]
		public int ProductLogicalID
		{
			get
			{
				return this._ProductLogicalID;
			}
			set
			{
				if ((this._ProductLogicalID != value))
				{
					this.OnProductLogicalIDChanging(value);
					this.SendPropertyChanging();
					this._ProductLogicalID = value;
					this.SendPropertyChanged("ProductLogicalID");
					this.OnProductLogicalIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuditTrailID", DbType="Int")]
		public System.Nullable<int> AuditTrailID
		{
			get
			{
				return this._AuditTrailID;
			}
			set
			{
				if ((this._AuditTrailID != value))
				{
					this.OnAuditTrailIDChanging(value);
					this.SendPropertyChanging();
					this._AuditTrailID = value;
					this.SendPropertyChanged("AuditTrailID");
					this.OnAuditTrailIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnalysisStartUTC", DbType="DateTime")]
		public System.Nullable<System.DateTime> AnalysisStartUTC
		{
			get
			{
				return this._AnalysisStartUTC;
			}
			set
			{
				if ((this._AnalysisStartUTC != value))
				{
					this.OnAnalysisStartUTCChanging(value);
					this.SendPropertyChanging();
					this._AnalysisStartUTC = value;
					this.SendPropertyChanged("AnalysisStartUTC");
					this.OnAnalysisStartUTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnalysisEndUTC", DbType="DateTime")]
		public System.Nullable<System.DateTime> AnalysisEndUTC
		{
			get
			{
				return this._AnalysisEndUTC;
			}
			set
			{
				if ((this._AnalysisEndUTC != value))
				{
					this.OnAnalysisEndUTCChanging(value);
					this.SendPropertyChanging();
					this._AnalysisEndUTC = value;
					this.SendPropertyChanged("AnalysisEndUTC");
					this.OnAnalysisEndUTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedAtUTC", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedAtUTC
		{
			get
			{
				return this._CreatedAtUTC;
			}
			set
			{
				if ((this._CreatedAtUTC != value))
				{
					this.OnCreatedAtUTCChanging(value);
					this.SendPropertyChanging();
					this._CreatedAtUTC = value;
					this.SendPropertyChanged("CreatedAtUTC");
					this.OnCreatedAtUTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedAtUTC", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedAtUTC
		{
			get
			{
				return this._ModifiedAtUTC;
			}
			set
			{
				if ((this._ModifiedAtUTC != value))
				{
					this.OnModifiedAtUTCChanging(value);
					this.SendPropertyChanging();
					this._ModifiedAtUTC = value;
					this.SendPropertyChanged("ModifiedAtUTC");
					this.OnModifiedAtUTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedBy", DbType="BigInt")]
		public System.Nullable<long> ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RawDataStatus", DbType="Int NOT NULL")]
		public int RawDataStatus
		{
			get
			{
				return this._RawDataStatus;
			}
			set
			{
				if ((this._RawDataStatus != value))
				{
					this.OnRawDataStatusChanging(value);
					this.SendPropertyChanging();
					this._RawDataStatus = value;
					this.SendPropertyChanged("RawDataStatus");
					this.OnRawDataStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventsStatus", DbType="Int NOT NULL")]
		public int EventsStatus
		{
			get
			{
				return this._EventsStatus;
			}
			set
			{
				if ((this._EventsStatus != value))
				{
					this.OnEventsStatusChanging(value);
					this.SendPropertyChanging();
					this._EventsStatus = value;
					this.SendPropertyChanged("EventsStatus");
					this.OnEventsStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OutlierStatus", DbType="Int NOT NULL")]
		public int OutlierStatus
		{
			get
			{
				return this._OutlierStatus;
			}
			set
			{
				if ((this._OutlierStatus != value))
				{
					this.OnOutlierStatusChanging(value);
					this.SendPropertyChanging();
					this._OutlierStatus = value;
					this.SendPropertyChanged("OutlierStatus");
					this.OnOutlierStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductLimitsStatus", DbType="Int NOT NULL")]
		public int ProductLimitsStatus
		{
			get
			{
				return this._ProductLimitsStatus;
			}
			set
			{
				if ((this._ProductLimitsStatus != value))
				{
					this.OnProductLimitsStatusChanging(value);
					this.SendPropertyChanging();
					this._ProductLimitsStatus = value;
					this.SendPropertyChanged("ProductLimitsStatus");
					this.OnProductLimitsStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SampleInstrumentID", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> SampleInstrumentID
		{
			get
			{
				return this._SampleInstrumentID;
			}
			set
			{
				if ((this._SampleInstrumentID != value))
				{
					this.OnSampleInstrumentIDChanging(value);
					this.SendPropertyChanging();
					this._SampleInstrumentID = value;
					this.SendPropertyChanged("SampleInstrumentID");
					this.OnSampleInstrumentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Obsolete", DbType="Bit NOT NULL")]
		public bool Obsolete
		{
			get
			{
				return this._Obsolete;
			}
			set
			{
				if ((this._Obsolete != value))
				{
					this.OnObsoleteChanging(value);
					this.SendPropertyChanging();
					this._Obsolete = value;
					this.SendPropertyChanged("Obsolete");
					this.OnObsoleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Signature", DbType="NVarChar(300)")]
		public string Signature
		{
			get
			{
				return this._Signature;
			}
			set
			{
				if ((this._Signature != value))
				{
					this.OnSignatureChanging(value);
					this.SendPropertyChanging();
					this._Signature = value;
					this.SendPropertyChanged("Signature");
					this.OnSignatureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SignatureVersion", DbType="Int")]
		public System.Nullable<int> SignatureVersion
		{
			get
			{
				return this._SignatureVersion;
			}
			set
			{
				if ((this._SignatureVersion != value))
				{
					this.OnSignatureVersionChanging(value);
					this.SendPropertyChanging();
					this._SignatureVersion = value;
					this.SendPropertyChanged("SignatureVersion");
					this.OnSignatureVersionChanged();
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
