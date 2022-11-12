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

namespace QLSV_TEST2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLSV")]
	public partial class QLSVDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHocSinh(HocSinh instance);
    partial void UpdateHocSinh(HocSinh instance);
    partial void DeleteHocSinh(HocSinh instance);
    partial void InsertLop(Lop instance);
    partial void UpdateLop(Lop instance);
    partial void DeleteLop(Lop instance);
    #endregion
		
		public QLSVDataContext() : 
				base(global::QLSV_TEST2.Properties.Settings.Default.QLSVConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLSVDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HocSinh> HocSinhs
		{
			get
			{
				return this.GetTable<HocSinh>();
			}
		}
		
		public System.Data.Linq.Table<Lop> Lops
		{
			get
			{
				return this.GetTable<Lop>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HocSinh")]
	public partial class HocSinh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHS;
		
		private string _TenHS;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _DiaChi;
		
		private System.Nullable<float> _DTB;
		
		private string _MaLop;
		
		private EntityRef<Lop> _Lop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHSChanging(string value);
    partial void OnMaHSChanged();
    partial void OnTenHSChanging(string value);
    partial void OnTenHSChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDTBChanging(System.Nullable<float> value);
    partial void OnDTBChanged();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    #endregion
		
		public HocSinh()
		{
			this._Lop = default(EntityRef<Lop>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHS", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHS
		{
			get
			{
				return this._MaHS;
			}
			set
			{
				if ((this._MaHS != value))
				{
					this.OnMaHSChanging(value);
					this.SendPropertyChanging();
					this._MaHS = value;
					this.SendPropertyChanged("MaHS");
					this.OnMaHSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHS", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenHS
		{
			get
			{
				return this._TenHS;
			}
			set
			{
				if ((this._TenHS != value))
				{
					this.OnTenHSChanging(value);
					this.SendPropertyChanging();
					this._TenHS = value;
					this.SendPropertyChanged("TenHS");
					this.OnTenHSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(150)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DTB", DbType="Real")]
		public System.Nullable<float> DTB
		{
			get
			{
				return this._DTB;
			}
			set
			{
				if ((this._DTB != value))
				{
					this.OnDTBChanging(value);
					this.SendPropertyChanging();
					this._DTB = value;
					this.SendPropertyChanged("DTB");
					this.OnDTBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="VarChar(20)")]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					if (this._Lop.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_HocSinh", Storage="_Lop", ThisKey="MaLop", OtherKey="MaLop", IsForeignKey=true)]
		public Lop Lop
		{
			get
			{
				return this._Lop.Entity;
			}
			set
			{
				Lop previousValue = this._Lop.Entity;
				if (((previousValue != value) 
							|| (this._Lop.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lop.Entity = null;
						previousValue.HocSinhs.Remove(this);
					}
					this._Lop.Entity = value;
					if ((value != null))
					{
						value.HocSinhs.Add(this);
						this._MaLop = value.MaLop;
					}
					else
					{
						this._MaLop = default(string);
					}
					this.SendPropertyChanged("Lop");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lop")]
	public partial class Lop : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLop;
		
		private string _TenLop;
		
		private System.Nullable<short> _SiSo;
		
		private EntitySet<HocSinh> _HocSinhs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    partial void OnTenLopChanging(string value);
    partial void OnTenLopChanged();
    partial void OnSiSoChanging(System.Nullable<short> value);
    partial void OnSiSoChanged();
    #endregion
		
		public Lop()
		{
			this._HocSinhs = new EntitySet<HocSinh>(new Action<HocSinh>(this.attach_HocSinhs), new Action<HocSinh>(this.detach_HocSinhs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLop", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenLop
		{
			get
			{
				return this._TenLop;
			}
			set
			{
				if ((this._TenLop != value))
				{
					this.OnTenLopChanging(value);
					this.SendPropertyChanging();
					this._TenLop = value;
					this.SendPropertyChanged("TenLop");
					this.OnTenLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiSo", DbType="SmallInt")]
		public System.Nullable<short> SiSo
		{
			get
			{
				return this._SiSo;
			}
			set
			{
				if ((this._SiSo != value))
				{
					this.OnSiSoChanging(value);
					this.SendPropertyChanging();
					this._SiSo = value;
					this.SendPropertyChanged("SiSo");
					this.OnSiSoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lop_HocSinh", Storage="_HocSinhs", ThisKey="MaLop", OtherKey="MaLop")]
		public EntitySet<HocSinh> HocSinhs
		{
			get
			{
				return this._HocSinhs;
			}
			set
			{
				this._HocSinhs.Assign(value);
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
		
		private void attach_HocSinhs(HocSinh entity)
		{
			this.SendPropertyChanging();
			entity.Lop = this;
		}
		
		private void detach_HocSinhs(HocSinh entity)
		{
			this.SendPropertyChanging();
			entity.Lop = null;
		}
	}
}
#pragma warning restore 1591
