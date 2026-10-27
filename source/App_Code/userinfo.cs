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
[XmlRoot("userinfo")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[HelpKeyword("vs.data.DataSet")]
public class userinfo : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void UserInfoRowChangeEventHandler(object sender, UserInfoRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void aspnet_MembershipRowChangeEventHandler(object sender, aspnet_MembershipRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void userListRowChangeEventHandler(object sender, userListRowChangeEvent e);

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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NameColumn => columnName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn sexColumn => columnsex;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RegisterDateColumn => columnRegisterDate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AddressColumn => columnAddress;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MariedColumn => columnMaried;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NumberofChildrenColumn => columnNumberofChildren;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SyblingColumn => columnSybling;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CityColumn => columnCity;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn StateColumn => columnState;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ZipcodeColumn => columnZipcode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn areacodeColumn => columnareacode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn phonenumberColumn => columnphonenumber;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn occupationColumn => columnoccupation;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn HabbiesColumn => columnHabbies;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn birthdateColumn => columnbirthdate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn birthplaceColumn => columnbirthplace;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn lastgradColumn => columnlastgrad;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn SSNColumn => columnSSN;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LabnumColumn => columnLabnum;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PsychologicallyStressColumn => columnPsychologicallyStress;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn heightColumn => columnheight;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn weightColumn => columnweight;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn eyecolorColumn => columneyecolor;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn haircolorColumn => columnhaircolor;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn bloodtypeColumn => columnbloodtype;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserNameColumn => columnUserName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CodeColumn => columnCode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		public UserInfoRow AddUserInfoRow(string Name, string sex, DateTime RegisterDate, string Address, bool Maried, short NumberofChildren, string Sybling, string City, string State, string Zipcode, int areacode, int phonenumber, string occupation, string Habbies, DateTime birthdate, string birthplace, string lastgrad, string SSN, int Labnum, bool PsychologicallyStress, string height, string weight, string eyecolor, string haircolor, string bloodtype, string UserName, string Code)
		{
			UserInfoRow userInfoRow = (UserInfoRow)NewRow();
			object[] itemArray = new object[27]
			{
				Name, sex, RegisterDate, Address, Maried, NumberofChildren, Sybling, City, State, Zipcode,
				areacode, phonenumber, occupation, Habbies, birthdate, birthplace, lastgrad, SSN, Labnum, PsychologicallyStress,
				height, weight, eyecolor, haircolor, bloodtype, UserName, Code
			};
			userInfoRow.ItemArray = itemArray;
			Rows.Add(userInfoRow);
			return userInfoRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public UserInfoRow FindByUserName(string UserName)
		{
			return (UserInfoRow)Rows.Find(new object[1] { UserName });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			UserInfoDataTable userInfoDataTable = (UserInfoDataTable)base.Clone();
			userInfoDataTable.InitVars();
			return userInfoDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new UserInfoDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
			ExtendedProperties.Add("Generator_TablePropName", "_UserInfo");
			ExtendedProperties.Add("Generator_UserTableName", "UserInfo");
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public UserInfoRow NewUserInfoRow()
		{
			return (UserInfoRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			userinfo userinfo2 = new userinfo();
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
			xmlSchemaAttribute.FixedValue = userinfo2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "UserInfoDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = userinfo2.GetSchemaSerializable();
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

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class aspnet_MembershipDataTable : TypedTableBase<aspnet_MembershipRow>
	{
		private DataColumn columnApplicationId;

		private DataColumn columnUserId;

		private DataColumn columnPassword;

		private DataColumn columnPasswordFormat;

		private DataColumn columnPasswordSalt;

		private DataColumn columnMobilePIN;

		private DataColumn columnEmail;

		private DataColumn columnLoweredEmail;

		private DataColumn columnPasswordQuestion;

		private DataColumn columnPasswordAnswer;

		private DataColumn columnIsApproved;

		private DataColumn columnIsLockedOut;

		private DataColumn columnCreateDate;

		private DataColumn columnLastLoginDate;

		private DataColumn columnLastPasswordChangedDate;

		private DataColumn columnLastLockoutDate;

		private DataColumn columnFailedPasswordAttemptCount;

		private DataColumn columnFailedPasswordAttemptWindowStart;

		private DataColumn columnFailedPasswordAnswerAttemptCount;

		private DataColumn columnFailedPasswordAnswerAttemptWindowStart;

		private DataColumn columnComment;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ApplicationIdColumn => columnApplicationId;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserIdColumn => columnUserId;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PasswordColumn => columnPassword;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PasswordFormatColumn => columnPasswordFormat;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PasswordSaltColumn => columnPasswordSalt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MobilePINColumn => columnMobilePIN;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EmailColumn => columnEmail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LoweredEmailColumn => columnLoweredEmail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PasswordQuestionColumn => columnPasswordQuestion;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PasswordAnswerColumn => columnPasswordAnswer;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IsApprovedColumn => columnIsApproved;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn IsLockedOutColumn => columnIsLockedOut;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CreateDateColumn => columnCreateDate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LastLoginDateColumn => columnLastLoginDate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LastPasswordChangedDateColumn => columnLastPasswordChangedDate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn LastLockoutDateColumn => columnLastLockoutDate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FailedPasswordAttemptCountColumn => columnFailedPasswordAttemptCount;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FailedPasswordAttemptWindowStartColumn => columnFailedPasswordAttemptWindowStart;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FailedPasswordAnswerAttemptCountColumn => columnFailedPasswordAnswerAttemptCount;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FailedPasswordAnswerAttemptWindowStartColumn => columnFailedPasswordAnswerAttemptWindowStart;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CommentColumn => columnComment;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public aspnet_MembershipRow this[int index] => (aspnet_MembershipRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event aspnet_MembershipRowChangeEventHandler aspnet_MembershipRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event aspnet_MembershipRowChangeEventHandler aspnet_MembershipRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event aspnet_MembershipRowChangeEventHandler aspnet_MembershipRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event aspnet_MembershipRowChangeEventHandler aspnet_MembershipRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public aspnet_MembershipDataTable()
		{
			TableName = "aspnet_Membership";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal aspnet_MembershipDataTable(DataTable table)
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected aspnet_MembershipDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Addaspnet_MembershipRow(aspnet_MembershipRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public aspnet_MembershipRow Addaspnet_MembershipRow(Guid ApplicationId, userListRow parentuserListRowByFK__aspnet_Me__UserI__15502E78, string Password, int PasswordFormat, string PasswordSalt, string MobilePIN, string Email, string LoweredEmail, string PasswordQuestion, string PasswordAnswer, bool IsApproved, bool IsLockedOut, DateTime CreateDate, DateTime LastLoginDate, DateTime LastPasswordChangedDate, DateTime LastLockoutDate, int FailedPasswordAttemptCount, DateTime FailedPasswordAttemptWindowStart, int FailedPasswordAnswerAttemptCount, DateTime FailedPasswordAnswerAttemptWindowStart, string Comment)
		{
			aspnet_MembershipRow aspnet_MembershipRow2 = (aspnet_MembershipRow)NewRow();
			object[] array = new object[21]
			{
				ApplicationId, null, Password, PasswordFormat, PasswordSalt, MobilePIN, Email, LoweredEmail, PasswordQuestion, PasswordAnswer,
				IsApproved, IsLockedOut, CreateDate, LastLoginDate, LastPasswordChangedDate, LastLockoutDate, FailedPasswordAttemptCount, FailedPasswordAttemptWindowStart, FailedPasswordAnswerAttemptCount, FailedPasswordAnswerAttemptWindowStart,
				Comment
			};
			if (parentuserListRowByFK__aspnet_Me__UserI__15502E78 != null)
			{
				array[1] = RuntimeHelpers.GetObjectValue(parentuserListRowByFK__aspnet_Me__UserI__15502E78[1]);
			}
			aspnet_MembershipRow2.ItemArray = array;
			Rows.Add(aspnet_MembershipRow2);
			return aspnet_MembershipRow2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public aspnet_MembershipRow FindByUserId(Guid UserId)
		{
			return (aspnet_MembershipRow)Rows.Find(new object[1] { UserId });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			aspnet_MembershipDataTable aspnet_MembershipDataTable2 = (aspnet_MembershipDataTable)base.Clone();
			aspnet_MembershipDataTable2.InitVars();
			return aspnet_MembershipDataTable2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new aspnet_MembershipDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnApplicationId = Columns["ApplicationId"];
			columnUserId = Columns["UserId"];
			columnPassword = Columns["Password"];
			columnPasswordFormat = Columns["PasswordFormat"];
			columnPasswordSalt = Columns["PasswordSalt"];
			columnMobilePIN = Columns["MobilePIN"];
			columnEmail = Columns["Email"];
			columnLoweredEmail = Columns["LoweredEmail"];
			columnPasswordQuestion = Columns["PasswordQuestion"];
			columnPasswordAnswer = Columns["PasswordAnswer"];
			columnIsApproved = Columns["IsApproved"];
			columnIsLockedOut = Columns["IsLockedOut"];
			columnCreateDate = Columns["CreateDate"];
			columnLastLoginDate = Columns["LastLoginDate"];
			columnLastPasswordChangedDate = Columns["LastPasswordChangedDate"];
			columnLastLockoutDate = Columns["LastLockoutDate"];
			columnFailedPasswordAttemptCount = Columns["FailedPasswordAttemptCount"];
			columnFailedPasswordAttemptWindowStart = Columns["FailedPasswordAttemptWindowStart"];
			columnFailedPasswordAnswerAttemptCount = Columns["FailedPasswordAnswerAttemptCount"];
			columnFailedPasswordAnswerAttemptWindowStart = Columns["FailedPasswordAnswerAttemptWindowStart"];
			columnComment = Columns["Comment"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnApplicationId = new DataColumn("ApplicationId", typeof(Guid), null, MappingType.Element);
			Columns.Add(columnApplicationId);
			columnUserId = new DataColumn("UserId", typeof(Guid), null, MappingType.Element);
			Columns.Add(columnUserId);
			columnPassword = new DataColumn("Password", typeof(string), null, MappingType.Element);
			Columns.Add(columnPassword);
			columnPasswordFormat = new DataColumn("PasswordFormat", typeof(int), null, MappingType.Element);
			Columns.Add(columnPasswordFormat);
			columnPasswordSalt = new DataColumn("PasswordSalt", typeof(string), null, MappingType.Element);
			Columns.Add(columnPasswordSalt);
			columnMobilePIN = new DataColumn("MobilePIN", typeof(string), null, MappingType.Element);
			Columns.Add(columnMobilePIN);
			columnEmail = new DataColumn("Email", typeof(string), null, MappingType.Element);
			Columns.Add(columnEmail);
			columnLoweredEmail = new DataColumn("LoweredEmail", typeof(string), null, MappingType.Element);
			Columns.Add(columnLoweredEmail);
			columnPasswordQuestion = new DataColumn("PasswordQuestion", typeof(string), null, MappingType.Element);
			Columns.Add(columnPasswordQuestion);
			columnPasswordAnswer = new DataColumn("PasswordAnswer", typeof(string), null, MappingType.Element);
			Columns.Add(columnPasswordAnswer);
			columnIsApproved = new DataColumn("IsApproved", typeof(bool), null, MappingType.Element);
			Columns.Add(columnIsApproved);
			columnIsLockedOut = new DataColumn("IsLockedOut", typeof(bool), null, MappingType.Element);
			Columns.Add(columnIsLockedOut);
			columnCreateDate = new DataColumn("CreateDate", typeof(DateTime), null, MappingType.Element);
			Columns.Add(columnCreateDate);
			columnLastLoginDate = new DataColumn("LastLoginDate", typeof(DateTime), null, MappingType.Element);
			Columns.Add(columnLastLoginDate);
			columnLastPasswordChangedDate = new DataColumn("LastPasswordChangedDate", typeof(DateTime), null, MappingType.Element);
			Columns.Add(columnLastPasswordChangedDate);
			columnLastLockoutDate = new DataColumn("LastLockoutDate", typeof(DateTime), null, MappingType.Element);
			Columns.Add(columnLastLockoutDate);
			columnFailedPasswordAttemptCount = new DataColumn("FailedPasswordAttemptCount", typeof(int), null, MappingType.Element);
			Columns.Add(columnFailedPasswordAttemptCount);
			columnFailedPasswordAttemptWindowStart = new DataColumn("FailedPasswordAttemptWindowStart", typeof(DateTime), null, MappingType.Element);
			Columns.Add(columnFailedPasswordAttemptWindowStart);
			columnFailedPasswordAnswerAttemptCount = new DataColumn("FailedPasswordAnswerAttemptCount", typeof(int), null, MappingType.Element);
			Columns.Add(columnFailedPasswordAnswerAttemptCount);
			columnFailedPasswordAnswerAttemptWindowStart = new DataColumn("FailedPasswordAnswerAttemptWindowStart", typeof(DateTime), null, MappingType.Element);
			Columns.Add(columnFailedPasswordAnswerAttemptWindowStart);
			columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
			Columns.Add(columnComment);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnUserId }, isPrimaryKey: true));
			columnApplicationId.AllowDBNull = false;
			columnUserId.AllowDBNull = false;
			columnUserId.Unique = true;
			columnPassword.AllowDBNull = false;
			columnPassword.MaxLength = 128;
			columnPasswordFormat.AllowDBNull = false;
			columnPasswordSalt.AllowDBNull = false;
			columnPasswordSalt.MaxLength = 128;
			columnMobilePIN.MaxLength = 16;
			columnEmail.MaxLength = 256;
			columnLoweredEmail.MaxLength = 256;
			columnPasswordQuestion.MaxLength = 256;
			columnPasswordAnswer.MaxLength = 128;
			columnIsApproved.AllowDBNull = false;
			columnIsLockedOut.AllowDBNull = false;
			columnCreateDate.AllowDBNull = false;
			columnLastLoginDate.AllowDBNull = false;
			columnLastPasswordChangedDate.AllowDBNull = false;
			columnLastLockoutDate.AllowDBNull = false;
			columnFailedPasswordAttemptCount.AllowDBNull = false;
			columnFailedPasswordAttemptWindowStart.AllowDBNull = false;
			columnFailedPasswordAnswerAttemptCount.AllowDBNull = false;
			columnFailedPasswordAnswerAttemptWindowStart.AllowDBNull = false;
			columnComment.MaxLength = 1073741823;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public aspnet_MembershipRow Newaspnet_MembershipRow()
		{
			return (aspnet_MembershipRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new aspnet_MembershipRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(aspnet_MembershipRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (aspnet_MembershipRowChanged != null)
			{
				aspnet_MembershipRowChanged?.Invoke(this, new aspnet_MembershipRowChangeEvent((aspnet_MembershipRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (aspnet_MembershipRowChanging != null)
			{
				aspnet_MembershipRowChanging?.Invoke(this, new aspnet_MembershipRowChangeEvent((aspnet_MembershipRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (aspnet_MembershipRowDeleted != null)
			{
				aspnet_MembershipRowDeleted?.Invoke(this, new aspnet_MembershipRowChangeEvent((aspnet_MembershipRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (aspnet_MembershipRowDeleting != null)
			{
				aspnet_MembershipRowDeleting?.Invoke(this, new aspnet_MembershipRowChangeEvent((aspnet_MembershipRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Removeaspnet_MembershipRow(aspnet_MembershipRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			userinfo userinfo2 = new userinfo();
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
			xmlSchemaAttribute.FixedValue = userinfo2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "aspnet_MembershipDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = userinfo2.GetSchemaSerializable();
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

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class userListDataTable : TypedTableBase<userListRow>
	{
		private DataColumn columnUserName;

		private DataColumn columnUserId;

		private DataColumn columninSysUser;

		private DataColumn columnName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserNameColumn => columnUserName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserIdColumn => columnUserId;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn inSysUserColumn => columninSysUser;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NameColumn => columnName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public userListRow this[int index] => (userListRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event userListRowChangeEventHandler userListRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event userListRowChangeEventHandler userListRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event userListRowChangeEventHandler userListRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event userListRowChangeEventHandler userListRowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public userListDataTable()
		{
			TableName = "userList";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal userListDataTable(DataTable table)
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected userListDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AdduserListRow(userListRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public userListRow AdduserListRow(string UserName, Guid UserId, string inSysUser, string Name)
		{
			userListRow userListRow2 = (userListRow)NewRow();
			object[] itemArray = new object[4] { UserName, UserId, inSysUser, Name };
			userListRow2.ItemArray = itemArray;
			Rows.Add(userListRow2);
			return userListRow2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			userListDataTable userListDataTable2 = (userListDataTable)base.Clone();
			userListDataTable2.InitVars();
			return userListDataTable2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new userListDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnUserName = Columns["UserName"];
			columnUserId = Columns["UserId"];
			columninSysUser = Columns["inSysUser"];
			columnName = Columns["Name"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
			Columns.Add(columnUserName);
			columnUserId = new DataColumn("UserId", typeof(Guid), null, MappingType.Element);
			Columns.Add(columnUserId);
			columninSysUser = new DataColumn("inSysUser", typeof(string), null, MappingType.Element);
			Columns.Add(columninSysUser);
			columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
			Columns.Add(columnName);
			columnUserName.AllowDBNull = false;
			columnUserName.MaxLength = 256;
			columnUserId.AllowDBNull = false;
			columninSysUser.MaxLength = 256;
			columnName.MaxLength = 80;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public userListRow NewuserListRow()
		{
			return (userListRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new userListRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(userListRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (userListRowChanged != null)
			{
				userListRowChanged?.Invoke(this, new userListRowChangeEvent((userListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (userListRowChanging != null)
			{
				userListRowChanging?.Invoke(this, new userListRowChangeEvent((userListRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (userListRowDeleted != null)
			{
				userListRowDeleted?.Invoke(this, new userListRowChangeEvent((userListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (userListRowDeleting != null)
			{
				userListRowDeleting?.Invoke(this, new userListRowChangeEvent((userListRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveuserListRow(userListRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			userinfo userinfo2 = new userinfo();
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
			xmlSchemaAttribute.FixedValue = userinfo2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "userListDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = userinfo2.GetSchemaSerializable();
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal UserInfoRow(DataRowBuilder rb)
			: base(rb)
		{
			tableUserInfo = (UserInfoDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRegisterDateNull()
		{
			return IsNull(tableUserInfo.RegisterDateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMariedNull()
		{
			return IsNull(tableUserInfo.MariedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNumberofChildrenNull()
		{
			this[tableUserInfo.NumberofChildrenColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsStateNull()
		{
			return IsNull(tableUserInfo.StateColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHabbiesNull()
		{
			return IsNull(tableUserInfo.HabbiesColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetbirthplaceNull()
		{
			this[tableUserInfo.birthplaceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsbloodtypeNull()
		{
			return IsNull(tableUserInfo.bloodtypeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
	}

	public class aspnet_MembershipRow : DataRow
	{
		private aspnet_MembershipDataTable tableaspnet_Membership;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Guid ApplicationId
		{
			get
			{
				object obj = this[tableaspnet_Membership.ApplicationIdColumn];
				Guid guid = default;
				return (obj != null) ? ((Guid)obj) : guid;
			}
			set
			{
				this[tableaspnet_Membership.ApplicationIdColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Guid UserId
		{
			get
			{
				object obj = this[tableaspnet_Membership.UserIdColumn];
				Guid guid = default;
				return (obj != null) ? ((Guid)obj) : guid;
			}
			set
			{
				this[tableaspnet_Membership.UserIdColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Password
		{
			get
			{
				return Conversions.ToString(this[tableaspnet_Membership.PasswordColumn]);
			}
			set
			{
				this[tableaspnet_Membership.PasswordColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int PasswordFormat
		{
			get
			{
				return Conversions.ToInteger(this[tableaspnet_Membership.PasswordFormatColumn]);
			}
			set
			{
				this[tableaspnet_Membership.PasswordFormatColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PasswordSalt
		{
			get
			{
				return Conversions.ToString(this[tableaspnet_Membership.PasswordSaltColumn]);
			}
			set
			{
				this[tableaspnet_Membership.PasswordSaltColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string MobilePIN
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableaspnet_Membership.MobilePINColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MobilePIN' in table 'aspnet_Membership' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableaspnet_Membership.MobilePINColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Email
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableaspnet_Membership.EmailColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Email' in table 'aspnet_Membership' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableaspnet_Membership.EmailColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string LoweredEmail
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableaspnet_Membership.LoweredEmailColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LoweredEmail' in table 'aspnet_Membership' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableaspnet_Membership.LoweredEmailColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PasswordQuestion
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableaspnet_Membership.PasswordQuestionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PasswordQuestion' in table 'aspnet_Membership' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableaspnet_Membership.PasswordQuestionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PasswordAnswer
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableaspnet_Membership.PasswordAnswerColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PasswordAnswer' in table 'aspnet_Membership' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableaspnet_Membership.PasswordAnswerColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsApproved
		{
			get
			{
				return Conversions.ToBoolean(this[tableaspnet_Membership.IsApprovedColumn]);
			}
			set
			{
				this[tableaspnet_Membership.IsApprovedColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLockedOut
		{
			get
			{
				return Conversions.ToBoolean(this[tableaspnet_Membership.IsLockedOutColumn]);
			}
			set
			{
				this[tableaspnet_Membership.IsLockedOutColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime CreateDate
		{
			get
			{
				return Conversions.ToDate(this[tableaspnet_Membership.CreateDateColumn]);
			}
			set
			{
				this[tableaspnet_Membership.CreateDateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime LastLoginDate
		{
			get
			{
				return Conversions.ToDate(this[tableaspnet_Membership.LastLoginDateColumn]);
			}
			set
			{
				this[tableaspnet_Membership.LastLoginDateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime LastPasswordChangedDate
		{
			get
			{
				return Conversions.ToDate(this[tableaspnet_Membership.LastPasswordChangedDateColumn]);
			}
			set
			{
				this[tableaspnet_Membership.LastPasswordChangedDateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime LastLockoutDate
		{
			get
			{
				return Conversions.ToDate(this[tableaspnet_Membership.LastLockoutDateColumn]);
			}
			set
			{
				this[tableaspnet_Membership.LastLockoutDateColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int FailedPasswordAttemptCount
		{
			get
			{
				return Conversions.ToInteger(this[tableaspnet_Membership.FailedPasswordAttemptCountColumn]);
			}
			set
			{
				this[tableaspnet_Membership.FailedPasswordAttemptCountColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime FailedPasswordAttemptWindowStart
		{
			get
			{
				return Conversions.ToDate(this[tableaspnet_Membership.FailedPasswordAttemptWindowStartColumn]);
			}
			set
			{
				this[tableaspnet_Membership.FailedPasswordAttemptWindowStartColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int FailedPasswordAnswerAttemptCount
		{
			get
			{
				return Conversions.ToInteger(this[tableaspnet_Membership.FailedPasswordAnswerAttemptCountColumn]);
			}
			set
			{
				this[tableaspnet_Membership.FailedPasswordAnswerAttemptCountColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime FailedPasswordAnswerAttemptWindowStart
		{
			get
			{
				return Conversions.ToDate(this[tableaspnet_Membership.FailedPasswordAnswerAttemptWindowStartColumn]);
			}
			set
			{
				this[tableaspnet_Membership.FailedPasswordAnswerAttemptWindowStartColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Comment
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableaspnet_Membership.CommentColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Comment' in table 'aspnet_Membership' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableaspnet_Membership.CommentColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public userListRow userListRow
		{
			get
			{
				return (userListRow)GetParentRow(Table.ParentRelations["FK__aspnet_Me__UserI__15502E78"]);
			}
			set
			{
				SetParentRow(value, Table.ParentRelations["FK__aspnet_Me__UserI__15502E78"]);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal aspnet_MembershipRow(DataRowBuilder rb)
			: base(rb)
		{
			tableaspnet_Membership = (aspnet_MembershipDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMobilePINNull()
		{
			return IsNull(tableaspnet_Membership.MobilePINColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMobilePINNull()
		{
			this[tableaspnet_Membership.MobilePINColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsEmailNull()
		{
			return IsNull(tableaspnet_Membership.EmailColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetEmailNull()
		{
			this[tableaspnet_Membership.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsLoweredEmailNull()
		{
			return IsNull(tableaspnet_Membership.LoweredEmailColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLoweredEmailNull()
		{
			this[tableaspnet_Membership.LoweredEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPasswordQuestionNull()
		{
			return IsNull(tableaspnet_Membership.PasswordQuestionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPasswordQuestionNull()
		{
			this[tableaspnet_Membership.PasswordQuestionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPasswordAnswerNull()
		{
			return IsNull(tableaspnet_Membership.PasswordAnswerColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPasswordAnswerNull()
		{
			this[tableaspnet_Membership.PasswordAnswerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCommentNull()
		{
			return IsNull(tableaspnet_Membership.CommentColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCommentNull()
		{
			this[tableaspnet_Membership.CommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class userListRow : DataRow
	{
		private userListDataTable tableuserList;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string UserName
		{
			get
			{
				return Conversions.ToString(this[tableuserList.UserNameColumn]);
			}
			set
			{
				this[tableuserList.UserNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Guid UserId
		{
			get
			{
				object obj = this[tableuserList.UserIdColumn];
				Guid guid = default;
				return (obj != null) ? ((Guid)obj) : guid;
			}
			set
			{
				this[tableuserList.UserIdColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string inSysUser
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableuserList.inSysUserColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'inSysUser' in table 'userList' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableuserList.inSysUserColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Name
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableuserList.NameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Name' in table 'userList' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableuserList.NameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal userListRow(DataRowBuilder rb)
			: base(rb)
		{
			tableuserList = (userListDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsinSysUserNull()
		{
			return IsNull(tableuserList.inSysUserColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetinSysUserNull()
		{
			this[tableuserList.inSysUserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNameNull()
		{
			return IsNull(tableuserList.NameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNameNull()
		{
			this[tableuserList.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public aspnet_MembershipRow[] Getaspnet_MembershipRows()
		{
			if (Table.ChildRelations["FK__aspnet_Me__UserI__15502E78"] == null)
			{
				return new aspnet_MembershipRow[0];
			}
			return (aspnet_MembershipRow[])GetChildRows(Table.ChildRelations["FK__aspnet_Me__UserI__15502E78"]);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class UserInfoRowChangeEvent : EventArgs
	{
		private UserInfoRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public UserInfoRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public UserInfoRowChangeEvent(UserInfoRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class aspnet_MembershipRowChangeEvent : EventArgs
	{
		private aspnet_MembershipRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public aspnet_MembershipRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public aspnet_MembershipRowChangeEvent(aspnet_MembershipRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class userListRowChangeEvent : EventArgs
	{
		private userListRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public userListRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public userListRowChangeEvent(userListRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private UserInfoDataTable tableUserInfo;

	private aspnet_MembershipDataTable tableaspnet_Membership;

	private userListDataTable tableuserList;

	private DataRelation relationFK__aspnet_Me__UserI__15502E78;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public UserInfoDataTable _UserInfo => tableUserInfo;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public aspnet_MembershipDataTable aspnet_Membership => tableaspnet_Membership;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public userListDataTable userList => tableuserList;

	[DebuggerNonUserCode]
	[Browsable(true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public userinfo()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected userinfo(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["aspnet_Membership"] != null)
			{
				base.Tables.Add(new aspnet_MembershipDataTable(dataSet.Tables["aspnet_Membership"]));
			}
			if (dataSet.Tables["userList"] != null)
			{
				base.Tables.Add(new userListDataTable(dataSet.Tables["userList"]));
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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
		userinfo userinfo2 = (userinfo)base.Clone();
		userinfo2.InitVars();
		userinfo2.SchemaSerializationMode = SchemaSerializationMode;
		return userinfo2;
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
			if (dataSet.Tables["aspnet_Membership"] != null)
			{
				base.Tables.Add(new aspnet_MembershipDataTable(dataSet.Tables["aspnet_Membership"]));
			}
			if (dataSet.Tables["userList"] != null)
			{
				base.Tables.Add(new userListDataTable(dataSet.Tables["userList"]));
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableUserInfo = (UserInfoDataTable)base.Tables["UserInfo"];
		if (initTable && tableUserInfo != null)
		{
			tableUserInfo.InitVars();
		}
		tableaspnet_Membership = (aspnet_MembershipDataTable)base.Tables["aspnet_Membership"];
		if (initTable && tableaspnet_Membership != null)
		{
			tableaspnet_Membership.InitVars();
		}
		tableuserList = (userListDataTable)base.Tables["userList"];
		if (initTable && tableuserList != null)
		{
			tableuserList.InitVars();
		}
		relationFK__aspnet_Me__UserI__15502E78 = Relations["FK__aspnet_Me__UserI__15502E78"];
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		DataSetName = "userinfo";
		Prefix = "";
		Namespace = "http://tempuri.org/userinfo.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableUserInfo = new UserInfoDataTable();
		base.Tables.Add(tableUserInfo);
		tableaspnet_Membership = new aspnet_MembershipDataTable();
		base.Tables.Add(tableaspnet_Membership);
		tableuserList = new userListDataTable();
		base.Tables.Add(tableuserList);
		relationFK__aspnet_Me__UserI__15502E78 = new DataRelation("FK__aspnet_Me__UserI__15502E78", new DataColumn[1] { tableuserList.UserIdColumn }, new DataColumn[1] { tableaspnet_Membership.UserIdColumn }, createConstraints: false);
		Relations.Add(relationFK__aspnet_Me__UserI__15502E78);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerialize_UserInfo()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeaspnet_Membership()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeuserList()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		userinfo userinfo2 = new userinfo();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = userinfo2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = userinfo2.GetSchemaSerializable();
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
