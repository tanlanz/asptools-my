﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mytools")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void Insertmd5(md5 instance);
  partial void Updatemd5(md5 instance);
  partial void Deletemd5(md5 instance);
  partial void InsertUserInfo(UserInfo instance);
  partial void UpdateUserInfo(UserInfo instance);
  partial void DeleteUserInfo(UserInfo instance);
  partial void Insertusers(users instance);
  partial void Updateusers(users instance);
  partial void Deleteusers(users instance);
  partial void Insertshow(show instance);
  partial void Updateshow(show instance);
  partial void Deleteshow(show instance);
  partial void Insertreport(report instance);
  partial void Updatereport(report instance);
  partial void Deletereport(report instance);
  partial void InsertIPdeny(IPdeny instance);
  partial void UpdateIPdeny(IPdeny instance);
  partial void DeleteIPdeny(IPdeny instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["mytoolsConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<md5> md5
	{
		get
		{
			return this.GetTable<md5>();
		}
	}
	
	public System.Data.Linq.Table<UserInfo> UserInfo
	{
		get
		{
			return this.GetTable<UserInfo>();
		}
	}
	
	public System.Data.Linq.Table<users> users
	{
		get
		{
			return this.GetTable<users>();
		}
	}
	
	public System.Data.Linq.Table<show> show
	{
		get
		{
			return this.GetTable<show>();
		}
	}
	
	public System.Data.Linq.Table<report> report
	{
		get
		{
			return this.GetTable<report>();
		}
	}
	
	public System.Data.Linq.Table<IPdeny> IPdeny
	{
		get
		{
			return this.GetTable<IPdeny>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.md5")]
public partial class md5 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _text1;
	
	private string _text2;
	
	private System.DateTime _time;
	
	private string _ip;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Ontext1Changing(string value);
    partial void Ontext1Changed();
    partial void Ontext2Changing(string value);
    partial void Ontext2Changed();
    partial void OntimeChanging(System.DateTime value);
    partial void OntimeChanged();
    partial void OnipChanging(string value);
    partial void OnipChanged();
    #endregion
	
	public md5()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text1", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
	public string text1
	{
		get
		{
			return this._text1;
		}
		set
		{
			if ((this._text1 != value))
			{
				this.Ontext1Changing(value);
				this.SendPropertyChanging();
				this._text1 = value;
				this.SendPropertyChanged("text1");
				this.Ontext1Changed();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text2", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string text2
	{
		get
		{
			return this._text2;
		}
		set
		{
			if ((this._text2 != value))
			{
				this.Ontext2Changing(value);
				this.SendPropertyChanging();
				this._text2 = value;
				this.SendPropertyChanged("text2");
				this.Ontext2Changed();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime NOT NULL")]
	public System.DateTime time
	{
		get
		{
			return this._time;
		}
		set
		{
			if ((this._time != value))
			{
				this.OntimeChanging(value);
				this.SendPropertyChanging();
				this._time = value;
				this.SendPropertyChanged("time");
				this.OntimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip", DbType="Char(50)")]
	public string ip
	{
		get
		{
			return this._ip;
		}
		set
		{
			if ((this._ip != value))
			{
				this.OnipChanging(value);
				this.SendPropertyChanging();
				this._ip = value;
				this.SendPropertyChanged("ip");
				this.OnipChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserInfo")]
public partial class UserInfo : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private int _userId;
	
	private string _username;
	
	private System.Nullable<int> _age;
	
	private string _sex;
	
	private System.Nullable<int> _phone;
	
	private string _ID_Card;
	
	private string _email;
	
	private string _photo;
	
	private EntityRef<users> _users;
	
	private EntityRef<users> _users1;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnuserIdChanging(int value);
    partial void OnuserIdChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnageChanging(System.Nullable<int> value);
    partial void OnageChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    partial void OnphoneChanging(System.Nullable<int> value);
    partial void OnphoneChanged();
    partial void OnID_CardChanging(string value);
    partial void OnID_CardChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnphotoChanging(string value);
    partial void OnphotoChanged();
    #endregion
	
	public UserInfo()
	{
		this._users = default(EntityRef<users>);
		this._users1 = default(EntityRef<users>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="Int NOT NULL")]
	public int userId
	{
		get
		{
			return this._userId;
		}
		set
		{
			if ((this._userId != value))
			{
				if (this._users.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnuserIdChanging(value);
				this.SendPropertyChanging();
				this._userId = value;
				this.SendPropertyChanged("userId");
				this.OnuserIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string username
	{
		get
		{
			return this._username;
		}
		set
		{
			if ((this._username != value))
			{
				if (this._users1.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnusernameChanging(value);
				this.SendPropertyChanging();
				this._username = value;
				this.SendPropertyChanged("username");
				this.OnusernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int")]
	public System.Nullable<int> age
	{
		get
		{
			return this._age;
		}
		set
		{
			if ((this._age != value))
			{
				this.OnageChanging(value);
				this.SendPropertyChanging();
				this._age = value;
				this.SendPropertyChanged("age");
				this.OnageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="NVarChar(2)")]
	public string sex
	{
		get
		{
			return this._sex;
		}
		set
		{
			if ((this._sex != value))
			{
				this.OnsexChanging(value);
				this.SendPropertyChanging();
				this._sex = value;
				this.SendPropertyChanged("sex");
				this.OnsexChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="Int")]
	public System.Nullable<int> phone
	{
		get
		{
			return this._phone;
		}
		set
		{
			if ((this._phone != value))
			{
				this.OnphoneChanging(value);
				this.SendPropertyChanging();
				this._phone = value;
				this.SendPropertyChanged("phone");
				this.OnphoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Card", DbType="VarChar(25)")]
	public string ID_Card
	{
		get
		{
			return this._ID_Card;
		}
		set
		{
			if ((this._ID_Card != value))
			{
				this.OnID_CardChanging(value);
				this.SendPropertyChanging();
				this._ID_Card = value;
				this.SendPropertyChanged("ID_Card");
				this.OnID_CardChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(25)")]
	public string email
	{
		get
		{
			return this._email;
		}
		set
		{
			if ((this._email != value))
			{
				this.OnemailChanging(value);
				this.SendPropertyChanging();
				this._email = value;
				this.SendPropertyChanged("email");
				this.OnemailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo", DbType="VarChar(50)")]
	public string photo
	{
		get
		{
			return this._photo;
		}
		set
		{
			if ((this._photo != value))
			{
				this.OnphotoChanging(value);
				this.SendPropertyChanging();
				this._photo = value;
				this.SendPropertyChanged("photo");
				this.OnphotoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="users_UserInfo", Storage="_users", ThisKey="userId", OtherKey="id", IsForeignKey=true)]
	public users users
	{
		get
		{
			return this._users.Entity;
		}
		set
		{
			users previousValue = this._users.Entity;
			if (((previousValue != value) 
						|| (this._users.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._users.Entity = null;
					previousValue.UserInfo.Remove(this);
				}
				this._users.Entity = value;
				if ((value != null))
				{
					value.UserInfo.Add(this);
					this._userId = value.id;
				}
				else
				{
					this._userId = default(int);
				}
				this.SendPropertyChanged("users");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="users_UserInfo1", Storage="_users1", ThisKey="username", OtherKey="username", IsForeignKey=true)]
	public users users1
	{
		get
		{
			return this._users1.Entity;
		}
		set
		{
			users previousValue = this._users1.Entity;
			if (((previousValue != value) 
						|| (this._users1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._users1.Entity = null;
					previousValue.UserInfo1.Remove(this);
				}
				this._users1.Entity = value;
				if ((value != null))
				{
					value.UserInfo1.Add(this);
					this._username = value.username;
				}
				else
				{
					this._username = default(string);
				}
				this.SendPropertyChanged("users1");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
public partial class users : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _username;
	
	private string _name;
	
	private string _password;
	
	private System.DateTime _signInTime;
	
	private System.Nullable<int> _state;
	
	private EntitySet<UserInfo> _UserInfo;
	
	private EntitySet<UserInfo> _UserInfo1;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnsignInTimeChanging(System.DateTime value);
    partial void OnsignInTimeChanged();
    partial void OnstateChanging(System.Nullable<int> value);
    partial void OnstateChanged();
    #endregion
	
	public users()
	{
		this._UserInfo = new EntitySet<UserInfo>(new Action<UserInfo>(this.attach_UserInfo), new Action<UserInfo>(this.detach_UserInfo));
		this._UserInfo1 = new EntitySet<UserInfo>(new Action<UserInfo>(this.attach_UserInfo1), new Action<UserInfo>(this.detach_UserInfo1));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string username
	{
		get
		{
			return this._username;
		}
		set
		{
			if ((this._username != value))
			{
				this.OnusernameChanging(value);
				this.SendPropertyChanging();
				this._username = value;
				this.SendPropertyChanged("username");
				this.OnusernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
	public string password
	{
		get
		{
			return this._password;
		}
		set
		{
			if ((this._password != value))
			{
				this.OnpasswordChanging(value);
				this.SendPropertyChanging();
				this._password = value;
				this.SendPropertyChanged("password");
				this.OnpasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_signInTime", DbType="DateTime NOT NULL")]
	public System.DateTime signInTime
	{
		get
		{
			return this._signInTime;
		}
		set
		{
			if ((this._signInTime != value))
			{
				this.OnsignInTimeChanging(value);
				this.SendPropertyChanging();
				this._signInTime = value;
				this.SendPropertyChanged("signInTime");
				this.OnsignInTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="Int")]
	public System.Nullable<int> state
	{
		get
		{
			return this._state;
		}
		set
		{
			if ((this._state != value))
			{
				this.OnstateChanging(value);
				this.SendPropertyChanging();
				this._state = value;
				this.SendPropertyChanged("state");
				this.OnstateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="users_UserInfo", Storage="_UserInfo", ThisKey="id", OtherKey="userId")]
	public EntitySet<UserInfo> UserInfo
	{
		get
		{
			return this._UserInfo;
		}
		set
		{
			this._UserInfo.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="users_UserInfo1", Storage="_UserInfo1", ThisKey="username", OtherKey="username")]
	public EntitySet<UserInfo> UserInfo1
	{
		get
		{
			return this._UserInfo1;
		}
		set
		{
			this._UserInfo1.Assign(value);
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
	
	private void attach_UserInfo(UserInfo entity)
	{
		this.SendPropertyChanging();
		entity.users = this;
	}
	
	private void detach_UserInfo(UserInfo entity)
	{
		this.SendPropertyChanging();
		entity.users = null;
	}
	
	private void attach_UserInfo1(UserInfo entity)
	{
		this.SendPropertyChanging();
		entity.users1 = this;
	}
	
	private void detach_UserInfo1(UserInfo entity)
	{
		this.SendPropertyChanging();
		entity.users1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.show")]
public partial class show : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _title;
	
	private string _name;
	
	private string _text;
	
	private System.Nullable<int> _state;
	
	private System.Nullable<System.DateTime> _changeTime;
	
	private System.Nullable<int> _sort;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void OnstateChanging(System.Nullable<int> value);
    partial void OnstateChanged();
    partial void OnchangeTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnchangeTimeChanged();
    partial void OnsortChanging(System.Nullable<int> value);
    partial void OnsortChanged();
    #endregion
	
	public show()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
	public string title
	{
		get
		{
			return this._title;
		}
		set
		{
			if ((this._title != value))
			{
				this.OntitleChanging(value);
				this.SendPropertyChanging();
				this._title = value;
				this.SendPropertyChanged("title");
				this.OntitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(25)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
	public string text
	{
		get
		{
			return this._text;
		}
		set
		{
			if ((this._text != value))
			{
				this.OntextChanging(value);
				this.SendPropertyChanging();
				this._text = value;
				this.SendPropertyChanged("text");
				this.OntextChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="Int")]
	public System.Nullable<int> state
	{
		get
		{
			return this._state;
		}
		set
		{
			if ((this._state != value))
			{
				this.OnstateChanging(value);
				this.SendPropertyChanging();
				this._state = value;
				this.SendPropertyChanged("state");
				this.OnstateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_changeTime", DbType="DateTime")]
	public System.Nullable<System.DateTime> changeTime
	{
		get
		{
			return this._changeTime;
		}
		set
		{
			if ((this._changeTime != value))
			{
				this.OnchangeTimeChanging(value);
				this.SendPropertyChanging();
				this._changeTime = value;
				this.SendPropertyChanged("changeTime");
				this.OnchangeTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sort", DbType="Int")]
	public System.Nullable<int> sort
	{
		get
		{
			return this._sort;
		}
		set
		{
			if ((this._sort != value))
			{
				this.OnsortChanging(value);
				this.SendPropertyChanging();
				this._sort = value;
				this.SendPropertyChanged("sort");
				this.OnsortChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.report")]
public partial class report : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _name;
	
	private string _email;
	
	private string _message1;
	
	private System.Nullable<System.DateTime> _send_time;
	
	private string _ip;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Onmessage1Changing(string value);
    partial void Onmessage1Changed();
    partial void Onsend_timeChanging(System.Nullable<System.DateTime> value);
    partial void Onsend_timeChanged();
    partial void OnipChanging(string value);
    partial void OnipChanged();
    #endregion
	
	public report()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(20)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
	public string email
	{
		get
		{
			return this._email;
		}
		set
		{
			if ((this._email != value))
			{
				this.OnemailChanging(value);
				this.SendPropertyChanging();
				this._email = value;
				this.SendPropertyChanged("email");
				this.OnemailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message1", DbType="NVarChar(255)")]
	public string message1
	{
		get
		{
			return this._message1;
		}
		set
		{
			if ((this._message1 != value))
			{
				this.Onmessage1Changing(value);
				this.SendPropertyChanging();
				this._message1 = value;
				this.SendPropertyChanged("message1");
				this.Onmessage1Changed();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_send_time", DbType="DateTime")]
	public System.Nullable<System.DateTime> send_time
	{
		get
		{
			return this._send_time;
		}
		set
		{
			if ((this._send_time != value))
			{
				this.Onsend_timeChanging(value);
				this.SendPropertyChanging();
				this._send_time = value;
				this.SendPropertyChanged("send_time");
				this.Onsend_timeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip", DbType="VarChar(32)")]
	public string ip
	{
		get
		{
			return this._ip;
		}
		set
		{
			if ((this._ip != value))
			{
				this.OnipChanging(value);
				this.SendPropertyChanging();
				this._ip = value;
				this.SendPropertyChanged("ip");
				this.OnipChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IPdeny")]
public partial class IPdeny : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _ip;
	
	private System.Nullable<int> _state;
	
	private string _logindate;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnipChanging(string value);
    partial void OnipChanged();
    partial void OnstateChanging(System.Nullable<int> value);
    partial void OnstateChanged();
    partial void OnlogindateChanging(string value);
    partial void OnlogindateChanged();
    #endregion
	
	public IPdeny()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip", DbType="VarChar(50)")]
	public string ip
	{
		get
		{
			return this._ip;
		}
		set
		{
			if ((this._ip != value))
			{
				this.OnipChanging(value);
				this.SendPropertyChanging();
				this._ip = value;
				this.SendPropertyChanged("ip");
				this.OnipChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="Int")]
	public System.Nullable<int> state
	{
		get
		{
			return this._state;
		}
		set
		{
			if ((this._state != value))
			{
				this.OnstateChanging(value);
				this.SendPropertyChanging();
				this._state = value;
				this.SendPropertyChanged("state");
				this.OnstateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_logindate", DbType="VarChar(50)")]
	public string logindate
	{
		get
		{
			return this._logindate;
		}
		set
		{
			if ((this._logindate != value))
			{
				this.OnlogindateChanging(value);
				this.SendPropertyChanging();
				this._logindate = value;
				this.SendPropertyChanged("logindate");
				this.OnlogindateChanged();
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
#pragma warning restore 1591