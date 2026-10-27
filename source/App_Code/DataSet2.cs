using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

[Serializable]
[ToolboxItem(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("DataSet2")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
public class DataSet2 : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void UserInfoRowChangeEventHandler(object sender, UserInfoRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class UserInfoDataTable : TypedTableBase<UserInfoRow>
	{
		private DataColumn columnName;

		private DataColumn columnsex;

		private DataColumn columnRegisterDate;

		private DataColumn columnAddress;

		private DataColumn columnMaried;

		private DataColumn columnNumberofChildren;

		private DataColumn columnSybling;

		private DataColumn columnCity;

		private DataColumn columnState;

		private DataColumn columnZipcode;

		private DataColumn columnareacode;

		private DataColumn columnphonenumber;

		private DataColumn columnoccupation;

		private DataColumn columnHabbies;

		private DataColumn columnbirthdate;

		private DataColumn columnbirthplace;

		private DataColumn columnlastgrad;

		private DataColumn columnSSN;

		private DataColumn columnLabnum;

		private DataColumn columnPsychologicallyStress;

		private DataColumn columnheight;

		private DataColumn columnweight;

		private DataColumn columneyecolor;

		private DataColumn columnhaircolor;

		private DataColumn columnbloodtype;

		private DataColumn columnUserName;

		private DataColumn columnCode;

		private DataColumn columnrace;

		private DataColumn columnreferral;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NameColumn => columnName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn sexColumn => columnsex;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn RegisterDateColumn => columnRegisterDate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AddressColumn => columnAddress;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MariedColumn => columnMaried;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumberofChildrenColumn => columnNumberofChildren;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SyblingColumn => columnSybling;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CityColumn => columnCity;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn StateColumn => columnState;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ZipcodeColumn => columnZipcode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn areacodeColumn => columnareacode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn phonenumberColumn => columnphonenumber;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn occupationColumn => columnoccupation;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HabbiesColumn => columnHabbies;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn birthdateColumn => columnbirthdate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn birthplaceColumn => columnbirthplace;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn lastgradColumn => columnlastgrad;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SSNColumn => columnSSN;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LabnumColumn => columnLabnum;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PsychologicallyStressColumn => columnPsychologicallyStress;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn heightColumn => columnheight;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn weightColumn => columnweight;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn eyecolorColumn => columneyecolor;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn haircolorColumn => columnhaircolor;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn bloodtypeColumn => columnbloodtype;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserNameColumn => columnUserName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CodeColumn => columnCode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn raceColumn => columnrace;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn referralColumn => columnreferral;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public UserInfoRow this[int index] => (UserInfoRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event UserInfoRowChangeEventHandler UserInfoRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event UserInfoRowChangeEventHandler UserInfoRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event UserInfoRowChangeEventHandler UserInfoRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event UserInfoRowChangeEventHandler UserInfoRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public UserInfoDataTable()
		{
			TableName = "UserInfo";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal UserInfoDataTable(DataTable table)
		{
			TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				Namespace = table.Namespace;
			}
			Prefix = table.Prefix;
			MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected UserInfoDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddUserInfoRow(UserInfoRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public UserInfoRow AddUserInfoRow(string Name, string sex, DateTime RegisterDate, string Address, bool Maried, short NumberofChildren, string Sybling, string City, string State, string Zipcode, int areacode, int phonenumber, string occupation, string Habbies, DateTime birthdate, string birthplace, string lastgrad, string SSN, int Labnum, bool PsychologicallyStress, string height, string weight, string eyecolor, string haircolor, string bloodtype, string UserName, string Code, string race, string referral)
		{
			UserInfoRow userInfoRow = (UserInfoRow)NewRow();
			object[] itemArray = new object[29]
			{
				Name, sex, RegisterDate, Address, Maried, NumberofChildren, Sybling, City, State, Zipcode,
				areacode, phonenumber, occupation, Habbies, birthdate, birthplace, lastgrad, SSN, Labnum, PsychologicallyStress,
				height, weight, eyecolor, haircolor, bloodtype, UserName, Code, race, referral
			};
			userInfoRow.ItemArray = itemArray;
			Rows.Add(userInfoRow);
			return userInfoRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public UserInfoRow FindByUserName(string UserName)
		{
			return (UserInfoRow)Rows.Find(new object[1] { UserName });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			UserInfoDataTable userInfoDataTable = (UserInfoDataTable)base.Clone();
			userInfoDataTable.InitVars();
			return userInfoDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new UserInfoDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnName = Columns["Name"];
			columnsex = Columns["sex"];
			columnRegisterDate = Columns["RegisterDate"];
			columnAddress = Columns["Address"];
			columnMaried = Columns["Maried"];
			columnNumberofChildren = Columns["NumberofChildren"];
			columnSybling = Columns["Sybling"];
			columnCity = Columns["City"];
			columnState = Columns["State"];
			columnZipcode = Columns["Zipcode"];
			columnareacode = Columns["areacode"];
			columnphonenumber = Columns["phonenumber"];
			columnoccupation = Columns["occupation"];
			columnHabbies = Columns["Habbies"];
			columnbirthdate = Columns["birthdate"];
			columnbirthplace = Columns["birthplace"];
			columnlastgrad = Columns["lastgrad"];
			columnSSN = Columns["SSN"];
			columnLabnum = Columns["Labnum"];
			columnPsychologicallyStress = Columns["PsychologicallyStress"];
			columnheight = Columns["height"];
			columnweight = Columns["weight"];
			columneyecolor = Columns["eyecolor"];
			columnhaircolor = Columns["haircolor"];
			columnbloodtype = Columns["bloodtype"];
			columnUserName = Columns["UserName"];
			columnCode = Columns["Code"];
			columnrace = Columns["race"];
			columnreferral = Columns["referral"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
			Columns.Add(columnName);
			columnsex = new DataColumn("sex", typeof(string), null, MappingType.Element);
			Columns.Add(columnsex);
			columnRegisterDate = new DataColumn("RegisterDate", typeof(DateTime), null, MappingType.Element);
			Columns.Add(columnRegisterDate);
			columnAddress = new DataColumn("Address", typeof(string), null, MappingType.Element);
			Columns.Add(columnAddress);
			columnMaried = new DataColumn("Maried", typeof(bool), null, MappingType.Element);
			Columns.Add(columnMaried);
			columnNumberofChildren = new DataColumn("NumberofChildren", typeof(short), null, MappingType.Element);
			Columns.Add(columnNumberofChildren);
			columnSybling = new DataColumn("Sybling", typeof(string), null, MappingType.Element);
			Columns.Add(columnSybling);
			columnCity = new DataColumn("City", typeof(string), null, MappingType.Element);
			Columns.Add(columnCity);
			columnState = new DataColumn("State", typeof(string), null, MappingType.Element);
			Columns.Add(columnState);
			columnZipcode = new DataColumn("Zipcode", typeof(string), null, MappingType.Element);
			Columns.Add(columnZipcode);
			columnareacode = new DataColumn("areacode", typeof(int), null, MappingType.Element);
			Columns.Add(columnareacode);
			columnphonenumber = new DataColumn("phonenumber", typeof(int), null, MappingType.Element);
			Columns.Add(columnphonenumber);
			columnoccupation = new DataColumn("occupation", typeof(string), null, MappingType.Element);
			Columns.Add(columnoccupation);
			columnHabbies = new DataColumn("Habbies", typeof(string), null, MappingType.Element);
			Columns.Add(columnHabbies);
			columnbirthdate = new DataColumn("birthdate", typeof(DateTime), null, MappingType.Element);
			Columns.Add(columnbirthdate);
			columnbirthplace = new DataColumn("birthplace", typeof(string), null, MappingType.Element);
			Columns.Add(columnbirthplace);
			columnlastgrad = new DataColumn("lastgrad", typeof(string), null, MappingType.Element);
			Columns.Add(columnlastgrad);
			columnSSN = new DataColumn("SSN", typeof(string), null, MappingType.Element);
			Columns.Add(columnSSN);
			columnLabnum = new DataColumn("Labnum", typeof(int), null, MappingType.Element);
			Columns.Add(columnLabnum);
			columnPsychologicallyStress = new DataColumn("PsychologicallyStress", typeof(bool), null, MappingType.Element);
			Columns.Add(columnPsychologicallyStress);
			columnheight = new DataColumn("height", typeof(string), null, MappingType.Element);
			Columns.Add(columnheight);
			columnweight = new DataColumn("weight", typeof(string), null, MappingType.Element);
			Columns.Add(columnweight);
			columneyecolor = new DataColumn("eyecolor", typeof(string), null, MappingType.Element);
			Columns.Add(columneyecolor);
			columnhaircolor = new DataColumn("haircolor", typeof(string), null, MappingType.Element);
			Columns.Add(columnhaircolor);
			columnbloodtype = new DataColumn("bloodtype", typeof(string), null, MappingType.Element);
			Columns.Add(columnbloodtype);
			columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
			Columns.Add(columnUserName);
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			Columns.Add(columnCode);
			columnrace = new DataColumn("race", typeof(string), null, MappingType.Element);
			Columns.Add(columnrace);
			columnreferral = new DataColumn("referral", typeof(string), null, MappingType.Element);
			Columns.Add(columnreferral);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnUserName }, isPrimaryKey: true));
			columnName.AllowDBNull = false;
			columnName.MaxLength = 80;
			columnsex.AllowDBNull = false;
			columnsex.MaxLength = 10;
			columnAddress.MaxLength = 250;
			columnSybling.MaxLength = 50;
			columnCity.MaxLength = 50;
			columnState.MaxLength = 50;
			columnZipcode.AllowDBNull = false;
			columnZipcode.MaxLength = 50;
			columnareacode.AllowDBNull = false;
			columnphonenumber.AllowDBNull = false;
			columnoccupation.MaxLength = 50;
			columnHabbies.MaxLength = 50;
			columnbirthdate.AllowDBNull = false;
			columnbirthplace.MaxLength = 50;
			columnlastgrad.MaxLength = 50;
			columnSSN.MaxLength = 50;
			columnLabnum.AllowDBNull = false;
			columnheight.MaxLength = 10;
			columnweight.MaxLength = 10;
			columneyecolor.MaxLength = 50;
			columnhaircolor.MaxLength = 50;
			columnbloodtype.MaxLength = 50;
			columnUserName.AllowDBNull = false;
			columnUserName.Unique = true;
			columnUserName.MaxLength = 256;
			columnCode.MaxLength = 50;
			columnrace.MaxLength = 50;
			columnreferral.MaxLength = 150;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public UserInfoRow NewUserInfoRow()
		{
			return (UserInfoRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new UserInfoRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(UserInfoRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (UserInfoRowChanged != null)
			{
				UserInfoRowChanged?.Invoke(this, new UserInfoRowChangeEvent((UserInfoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (UserInfoRowChanging != null)
			{
				UserInfoRowChanging?.Invoke(this, new UserInfoRowChangeEvent((UserInfoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (UserInfoRowDeleted != null)
			{
				UserInfoRowDeleted?.Invoke(this, new UserInfoRowChangeEvent((UserInfoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (UserInfoRowDeleting != null)
			{
				UserInfoRowDeleting?.Invoke(this, new UserInfoRowChangeEvent((UserInfoRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveUserInfoRow(UserInfoRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			DataSet2 dataSet = new DataSet2();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			decimal minOccurs = 0m;
			xmlSchemaAny.MinOccurs = minOccurs;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			minOccurs = 1m;
			xmlSchemaAny2.MinOccurs = minOccurs;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = dataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "UserInfoDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	public class UserInfoRow : DataRow
	{
		private UserInfoDataTable tableUserInfo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return Conversions.ToString(this[tableUserInfo.NameColumn]);
			}
			set
			{
				this[tableUserInfo.NameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string sex
		{
			get
			{
				return Conversions.ToString(this[tableUserInfo.sexColumn]);
			}
			set
			{
				this[tableUserInfo.sexColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime RegisterDate
		{
			get
			{
				try
				{
					return Conversions.ToDate(this[tableUserInfo.RegisterDateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RegisterDate' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.RegisterDateColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Address
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.AddressColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Address' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.AddressColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Maried
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableUserInfo.MariedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Maried' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.MariedColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short NumberofChildren
		{
			get
			{
				try
				{
					return Conversions.ToShort(this[tableUserInfo.NumberofChildrenColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'NumberofChildren' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.NumberofChildrenColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Sybling
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.SyblingColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Sybling' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.SyblingColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string City
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.CityColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'City' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.CityColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string State
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.StateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'State' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.StateColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Zipcode
		{
			get
			{
				return Conversions.ToString(this[tableUserInfo.ZipcodeColumn]);
			}
			set
			{
				this[tableUserInfo.ZipcodeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int areacode
		{
			get
			{
				return Conversions.ToInteger(this[tableUserInfo.areacodeColumn]);
			}
			set
			{
				this[tableUserInfo.areacodeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int phonenumber
		{
			get
			{
				return Conversions.ToInteger(this[tableUserInfo.phonenumberColumn]);
			}
			set
			{
				this[tableUserInfo.phonenumberColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string occupation
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.occupationColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'occupation' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.occupationColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Habbies
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.HabbiesColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Habbies' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.HabbiesColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime birthdate
		{
			get
			{
				return Conversions.ToDate(this[tableUserInfo.birthdateColumn]);
			}
			set
			{
				this[tableUserInfo.birthdateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string birthplace
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.birthplaceColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'birthplace' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.birthplaceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string lastgrad
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.lastgradColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'lastgrad' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.lastgradColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SSN
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.SSNColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SSN' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.SSNColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Labnum
		{
			get
			{
				return Conversions.ToInteger(this[tableUserInfo.LabnumColumn]);
			}
			set
			{
				this[tableUserInfo.LabnumColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool PsychologicallyStress
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(this[tableUserInfo.PsychologicallyStressColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PsychologicallyStress' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.PsychologicallyStressColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string height
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.heightColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'height' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.heightColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string weight
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.weightColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'weight' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.weightColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string eyecolor
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.eyecolorColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'eyecolor' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.eyecolorColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string haircolor
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.haircolorColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'haircolor' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.haircolorColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string bloodtype
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.bloodtypeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'bloodtype' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.bloodtypeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UserName
		{
			get
			{
				return Conversions.ToString(this[tableUserInfo.UserNameColumn]);
			}
			set
			{
				this[tableUserInfo.UserNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Code
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.CodeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Code' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.CodeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string race
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.raceColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'race' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.raceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string referral
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableUserInfo.referralColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'referral' in table 'UserInfo' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableUserInfo.referralColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal UserInfoRow(DataRowBuilder rb)
			: base(rb)
		{
			tableUserInfo = (UserInfoDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsRegisterDateNull()
		{
			return IsNull(tableUserInfo.RegisterDateColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRegisterDateNull()
		{
			this[tableUserInfo.RegisterDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsAddressNull()
		{
			return IsNull(tableUserInfo.AddressColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAddressNull()
		{
			this[tableUserInfo.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMariedNull()
		{
			return IsNull(tableUserInfo.MariedColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMariedNull()
		{
			this[tableUserInfo.MariedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNumberofChildrenNull()
		{
			return IsNull(tableUserInfo.NumberofChildrenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNumberofChildrenNull()
		{
			this[tableUserInfo.NumberofChildrenColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSyblingNull()
		{
			return IsNull(tableUserInfo.SyblingColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSyblingNull()
		{
			this[tableUserInfo.SyblingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCityNull()
		{
			return IsNull(tableUserInfo.CityColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCityNull()
		{
			this[tableUserInfo.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsStateNull()
		{
			return IsNull(tableUserInfo.StateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetStateNull()
		{
			this[tableUserInfo.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsoccupationNull()
		{
			return IsNull(tableUserInfo.occupationColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetoccupationNull()
		{
			this[tableUserInfo.occupationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHabbiesNull()
		{
			return IsNull(tableUserInfo.HabbiesColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHabbiesNull()
		{
			this[tableUserInfo.HabbiesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsbirthplaceNull()
		{
			return IsNull(tableUserInfo.birthplaceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetbirthplaceNull()
		{
			this[tableUserInfo.birthplaceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IslastgradNull()
		{
			return IsNull(tableUserInfo.lastgradColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetlastgradNull()
		{
			this[tableUserInfo.lastgradColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSSNNull()
		{
			return IsNull(tableUserInfo.SSNColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSSNNull()
		{
			this[tableUserInfo.SSNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPsychologicallyStressNull()
		{
			return IsNull(tableUserInfo.PsychologicallyStressColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPsychologicallyStressNull()
		{
			this[tableUserInfo.PsychologicallyStressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsheightNull()
		{
			return IsNull(tableUserInfo.heightColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetheightNull()
		{
			this[tableUserInfo.heightColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsweightNull()
		{
			return IsNull(tableUserInfo.weightColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetweightNull()
		{
			this[tableUserInfo.weightColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IseyecolorNull()
		{
			return IsNull(tableUserInfo.eyecolorColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SeteyecolorNull()
		{
			this[tableUserInfo.eyecolorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IshaircolorNull()
		{
			return IsNull(tableUserInfo.haircolorColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SethaircolorNull()
		{
			this[tableUserInfo.haircolorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsbloodtypeNull()
		{
			return IsNull(tableUserInfo.bloodtypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetbloodtypeNull()
		{
			this[tableUserInfo.bloodtypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCodeNull()
		{
			return IsNull(tableUserInfo.CodeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCodeNull()
		{
			this[tableUserInfo.CodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsraceNull()
		{
			return IsNull(tableUserInfo.raceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetraceNull()
		{
			this[tableUserInfo.raceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsreferralNull()
		{
			return IsNull(tableUserInfo.referralColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetreferralNull()
		{
			this[tableUserInfo.referralColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class UserInfoRowChangeEvent : EventArgs
	{
		private UserInfoRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public UserInfoRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public UserInfoRowChangeEvent(UserInfoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private UserInfoDataTable tableUserInfo;

	private SchemaSerializationMode _schemaSerializationMode;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public UserInfoDataTable UserInfo => tableUserInfo;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public DataSet2()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected DataSet2(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["UserInfo"] != null)
			{
				base.Tables.Add(new UserInfoDataTable(dataSet.Tables["UserInfo"]));
			}
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public override DataSet Clone()
	{
		DataSet2 dataSet = (DataSet2)base.Clone();
		dataSet.InitVars();
		dataSet.SchemaSerializationMode = SchemaSerializationMode;
		return dataSet;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["UserInfo"] != null)
			{
				base.Tables.Add(new UserInfoDataTable(dataSet.Tables["UserInfo"]));
			}
			DataSetName = dataSet.DataSetName;
			Prefix = dataSet.Prefix;
			Namespace = dataSet.Namespace;
			Locale = dataSet.Locale;
			CaseSensitive = dataSet.CaseSensitive;
			EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars(bool initTable)
	{
		tableUserInfo = (UserInfoDataTable)base.Tables["UserInfo"];
		if (initTable && tableUserInfo != null)
		{
			tableUserInfo.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		DataSetName = "DataSet2";
		Prefix = "";
		Namespace = "http://tempuri.org/DataSet2.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableUserInfo = new UserInfoDataTable();
		base.Tables.Add(tableUserInfo);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeUserInfo()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		DataSet2 dataSet = new DataSet2();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = dataSet.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
