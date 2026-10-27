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
[HelpKeyword("vs.data.DataSet")]
[DesignerCategory("code")]
[XmlRoot("orders")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[ToolboxItem(true)]
public class orders : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void ahnRowChangeEventHandler(object sender, ahnRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void FundsRowChangeEventHandler(object sender, FundsRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void depositsRowChangeEventHandler(object sender, depositsRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class ahnDataTable : TypedTableBase<ahnRow>
	{
		private DataColumn columnmc_gross;

		private DataColumn columnitem_number1;

		private DataColumn columnpayer_id;

		private DataColumn columntax;

		private DataColumn columnpayment_date;

		private DataColumn columnpayment_status;

		private DataColumn columncharset;

		private DataColumn columnmc_tax1;

		private DataColumn columnmc_shipping;

		private DataColumn columnmc_handling;

		private DataColumn columnfirst_name;

		private DataColumn columnnotify_version;

		private DataColumn columncustom;

		private DataColumn columnpayer_status;

		private DataColumn columnnum_cart_items;

		private DataColumn columnmc_handling1;

		private DataColumn columnverify_sign;

		private DataColumn columnpayer_email;

		private DataColumn columnmc_shipping1;

		private DataColumn columntax1;

		private DataColumn columntxn_id;

		private DataColumn columnpayment_type;

		private DataColumn columnlast_name;

		private DataColumn columnitem_name1;

		private DataColumn columnquantity1;

		private DataColumn columnpending_reason;

		private DataColumn columntxn_type;

		private DataColumn columnmc_gross_1;

		private DataColumn columnmc_currency;

		private DataColumn columnresidence_country;

		private DataColumn columntest_ipn;

		private DataColumn columnpayment_gross;

		private DataColumn columnusername;

		private DataColumn columnid;

		private DataColumn column25receiver_email;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mc_grossColumn => columnmc_gross;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn item_number1Column => columnitem_number1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn payer_idColumn => columnpayer_id;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn taxColumn => columntax;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn payment_dateColumn => columnpayment_date;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn payment_statusColumn => columnpayment_status;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn charsetColumn => columncharset;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn mc_tax1Column => columnmc_tax1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn mc_shippingColumn => columnmc_shipping;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mc_handlingColumn => columnmc_handling;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn first_nameColumn => columnfirst_name;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn notify_versionColumn => columnnotify_version;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn customColumn => columncustom;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn payer_statusColumn => columnpayer_status;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn num_cart_itemsColumn => columnnum_cart_items;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn mc_handling1Column => columnmc_handling1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn verify_signColumn => columnverify_sign;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn payer_emailColumn => columnpayer_email;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mc_shipping1Column => columnmc_shipping1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn tax1Column => columntax1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn txn_idColumn => columntxn_id;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn payment_typeColumn => columnpayment_type;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn last_nameColumn => columnlast_name;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn item_name1Column => columnitem_name1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn quantity1Column => columnquantity1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn pending_reasonColumn => columnpending_reason;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn txn_typeColumn => columntxn_type;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mc_gross_1Column => columnmc_gross_1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mc_currencyColumn => columnmc_currency;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn residence_countryColumn => columnresidence_country;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn test_ipnColumn => columntest_ipn;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn payment_grossColumn => columnpayment_gross;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn usernameColumn => columnusername;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idColumn => columnid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn _25receiver_emailColumn => column25receiver_email;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ahnRow this[int index] => (ahnRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ahnRowChangeEventHandler ahnRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ahnRowChangeEventHandler ahnRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ahnRowChangeEventHandler ahnRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ahnRowChangeEventHandler ahnRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ahnDataTable()
		{
			TableName = "ahn";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal ahnDataTable(DataTable table)
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
		protected ahnDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddahnRow(ahnRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ahnRow AddahnRow(string mc_gross, string item_number1, string payer_id, string tax, string payment_date, string payment_status, string charset, string mc_tax1, string mc_shipping, string mc_handling, string first_name, string notify_version, string custom, string payer_status, string num_cart_items, string mc_handling1, string verify_sign, string payer_email, string mc_shipping1, string tax1, string txn_id, string payment_type, string last_name, string item_name1, string quantity1, string pending_reason, string txn_type, string mc_gross_1, string mc_currency, string residence_country, string test_ipn, string payment_gross, string username, string _25receiver_email)
		{
			ahnRow ahnRow2 = (ahnRow)NewRow();
			object[] itemArray = new object[35]
			{
				mc_gross, item_number1, payer_id, tax, payment_date, payment_status, charset, mc_tax1, mc_shipping, mc_handling,
				first_name, notify_version, custom, payer_status, num_cart_items, mc_handling1, verify_sign, payer_email, mc_shipping1, tax1,
				txn_id, payment_type, last_name, item_name1, quantity1, pending_reason, txn_type, mc_gross_1, mc_currency, residence_country,
				test_ipn, payment_gross, username, null, _25receiver_email
			};
			ahnRow2.ItemArray = itemArray;
			Rows.Add(ahnRow2);
			return ahnRow2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ahnRow FindByid(int id)
		{
			return (ahnRow)Rows.Find(new object[1] { id });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			ahnDataTable ahnDataTable2 = (ahnDataTable)base.Clone();
			ahnDataTable2.InitVars();
			return ahnDataTable2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new ahnDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnmc_gross = Columns["mc_gross"];
			columnitem_number1 = Columns["item_number1"];
			columnpayer_id = Columns["payer_id"];
			columntax = Columns["tax"];
			columnpayment_date = Columns["payment_date"];
			columnpayment_status = Columns["payment_status"];
			columncharset = Columns["charset"];
			columnmc_tax1 = Columns["mc_tax1"];
			columnmc_shipping = Columns["mc_shipping"];
			columnmc_handling = Columns["mc_handling"];
			columnfirst_name = Columns["first_name"];
			columnnotify_version = Columns["notify_version"];
			columncustom = Columns["custom"];
			columnpayer_status = Columns["payer_status"];
			columnnum_cart_items = Columns["num_cart_items"];
			columnmc_handling1 = Columns["mc_handling1"];
			columnverify_sign = Columns["verify_sign"];
			columnpayer_email = Columns["payer_email"];
			columnmc_shipping1 = Columns["mc_shipping1"];
			columntax1 = Columns["tax1"];
			columntxn_id = Columns["txn_id"];
			columnpayment_type = Columns["payment_type"];
			columnlast_name = Columns["last_name"];
			columnitem_name1 = Columns["item_name1"];
			columnquantity1 = Columns["quantity1"];
			columnpending_reason = Columns["pending_reason"];
			columntxn_type = Columns["txn_type"];
			columnmc_gross_1 = Columns["mc_gross_1"];
			columnmc_currency = Columns["mc_currency"];
			columnresidence_country = Columns["residence_country"];
			columntest_ipn = Columns["test_ipn"];
			columnpayment_gross = Columns["payment_gross"];
			columnusername = Columns["username"];
			columnid = Columns["id"];
			column25receiver_email = Columns["25receiver_email"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnmc_gross = new DataColumn("mc_gross", typeof(string), null, MappingType.Element);
			Columns.Add(columnmc_gross);
			columnitem_number1 = new DataColumn("item_number1", typeof(string), null, MappingType.Element);
			Columns.Add(columnitem_number1);
			columnpayer_id = new DataColumn("payer_id", typeof(string), null, MappingType.Element);
			Columns.Add(columnpayer_id);
			columntax = new DataColumn("tax", typeof(string), null, MappingType.Element);
			Columns.Add(columntax);
			columnpayment_date = new DataColumn("payment_date", typeof(string), null, MappingType.Element);
			Columns.Add(columnpayment_date);
			columnpayment_status = new DataColumn("payment_status", typeof(string), null, MappingType.Element);
			Columns.Add(columnpayment_status);
			columncharset = new DataColumn("charset", typeof(string), null, MappingType.Element);
			Columns.Add(columncharset);
			columnmc_tax1 = new DataColumn("mc_tax1", typeof(string), null, MappingType.Element);
			Columns.Add(columnmc_tax1);
			columnmc_shipping = new DataColumn("mc_shipping", typeof(string), null, MappingType.Element);
			Columns.Add(columnmc_shipping);
			columnmc_handling = new DataColumn("mc_handling", typeof(string), null, MappingType.Element);
			Columns.Add(columnmc_handling);
			columnfirst_name = new DataColumn("first_name", typeof(string), null, MappingType.Element);
			Columns.Add(columnfirst_name);
			columnnotify_version = new DataColumn("notify_version", typeof(string), null, MappingType.Element);
			Columns.Add(columnnotify_version);
			columncustom = new DataColumn("custom", typeof(string), null, MappingType.Element);
			Columns.Add(columncustom);
			columnpayer_status = new DataColumn("payer_status", typeof(string), null, MappingType.Element);
			Columns.Add(columnpayer_status);
			columnnum_cart_items = new DataColumn("num_cart_items", typeof(string), null, MappingType.Element);
			Columns.Add(columnnum_cart_items);
			columnmc_handling1 = new DataColumn("mc_handling1", typeof(string), null, MappingType.Element);
			Columns.Add(columnmc_handling1);
			columnverify_sign = new DataColumn("verify_sign", typeof(string), null, MappingType.Element);
			Columns.Add(columnverify_sign);
			columnpayer_email = new DataColumn("payer_email", typeof(string), null, MappingType.Element);
			Columns.Add(columnpayer_email);
			columnmc_shipping1 = new DataColumn("mc_shipping1", typeof(string), null, MappingType.Element);
			Columns.Add(columnmc_shipping1);
			columntax1 = new DataColumn("tax1", typeof(string), null, MappingType.Element);
			Columns.Add(columntax1);
			columntxn_id = new DataColumn("txn_id", typeof(string), null, MappingType.Element);
			Columns.Add(columntxn_id);
			columnpayment_type = new DataColumn("payment_type", typeof(string), null, MappingType.Element);
			Columns.Add(columnpayment_type);
			columnlast_name = new DataColumn("last_name", typeof(string), null, MappingType.Element);
			Columns.Add(columnlast_name);
			columnitem_name1 = new DataColumn("item_name1", typeof(string), null, MappingType.Element);
			Columns.Add(columnitem_name1);
			columnquantity1 = new DataColumn("quantity1", typeof(string), null, MappingType.Element);
			Columns.Add(columnquantity1);
			columnpending_reason = new DataColumn("pending_reason", typeof(string), null, MappingType.Element);
			Columns.Add(columnpending_reason);
			columntxn_type = new DataColumn("txn_type", typeof(string), null, MappingType.Element);
			Columns.Add(columntxn_type);
			columnmc_gross_1 = new DataColumn("mc_gross_1", typeof(string), null, MappingType.Element);
			Columns.Add(columnmc_gross_1);
			columnmc_currency = new DataColumn("mc_currency", typeof(string), null, MappingType.Element);
			Columns.Add(columnmc_currency);
			columnresidence_country = new DataColumn("residence_country", typeof(string), null, MappingType.Element);
			Columns.Add(columnresidence_country);
			columntest_ipn = new DataColumn("test_ipn", typeof(string), null, MappingType.Element);
			Columns.Add(columntest_ipn);
			columnpayment_gross = new DataColumn("payment_gross", typeof(string), null, MappingType.Element);
			Columns.Add(columnpayment_gross);
			columnusername = new DataColumn("username", typeof(string), null, MappingType.Element);
			Columns.Add(columnusername);
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			Columns.Add(columnid);
			column25receiver_email = new DataColumn("25receiver_email", typeof(string), null, MappingType.Element);
			column25receiver_email.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column25receiver_email");
			column25receiver_email.ExtendedProperties.Add("Generator_UserColumnName", "25receiver_email");
			Columns.Add(column25receiver_email);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnid }, isPrimaryKey: true));
			columnmc_gross.MaxLength = 255;
			columnitem_number1.MaxLength = 255;
			columnpayer_id.MaxLength = 255;
			columntax.MaxLength = 255;
			columnpayment_date.MaxLength = 255;
			columnpayment_status.MaxLength = 255;
			columncharset.MaxLength = 255;
			columnmc_tax1.MaxLength = 255;
			columnmc_shipping.MaxLength = 255;
			columnmc_handling.MaxLength = 255;
			columnfirst_name.MaxLength = 255;
			columnnotify_version.MaxLength = 255;
			columncustom.MaxLength = 255;
			columnpayer_status.MaxLength = 255;
			columnnum_cart_items.MaxLength = 255;
			columnmc_handling1.MaxLength = 255;
			columnverify_sign.MaxLength = 255;
			columnpayer_email.MaxLength = 255;
			columnmc_shipping1.MaxLength = 255;
			columntax1.MaxLength = 255;
			columntxn_id.MaxLength = 255;
			columnpayment_type.MaxLength = 255;
			columnlast_name.MaxLength = 255;
			columnitem_name1.MaxLength = 255;
			columnquantity1.MaxLength = 255;
			columnpending_reason.MaxLength = 255;
			columntxn_type.MaxLength = 255;
			columnmc_gross_1.MaxLength = 255;
			columnmc_currency.MaxLength = 255;
			columnresidence_country.MaxLength = 255;
			columntest_ipn.MaxLength = 255;
			columnpayment_gross.MaxLength = 255;
			columnusername.AllowDBNull = false;
			columnusername.MaxLength = 256;
			columnid.AutoIncrement = true;
			columnid.AllowDBNull = false;
			columnid.ReadOnly = true;
			columnid.Unique = true;
			column25receiver_email.MaxLength = 255;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ahnRow NewahnRow()
		{
			return (ahnRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new ahnRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(ahnRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (ahnRowChanged != null)
			{
				ahnRowChanged?.Invoke(this, new ahnRowChangeEvent((ahnRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (ahnRowChanging != null)
			{
				ahnRowChanging?.Invoke(this, new ahnRowChangeEvent((ahnRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (ahnRowDeleted != null)
			{
				ahnRowDeleted?.Invoke(this, new ahnRowChangeEvent((ahnRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (ahnRowDeleting != null)
			{
				ahnRowDeleting?.Invoke(this, new ahnRowChangeEvent((ahnRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveahnRow(ahnRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			orders orders2 = new orders();
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
			xmlSchemaAttribute.FixedValue = orders2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "ahnDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = orders2.GetSchemaSerializable();
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
	public class FundsDataTable : TypedTableBase<FundsRow>
	{
		private DataColumn columnAmount;

		private DataColumn columnUserName;

		private DataColumn columnDescription;

		private DataColumn columntarikh;

		private DataColumn columnid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn AmountColumn => columnAmount;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn UserNameColumn => columnUserName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DescriptionColumn => columnDescription;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn tarikhColumn => columntarikh;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idColumn => columnid;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FundsRow this[int index] => (FundsRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event FundsRowChangeEventHandler FundsRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event FundsRowChangeEventHandler FundsRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event FundsRowChangeEventHandler FundsRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event FundsRowChangeEventHandler FundsRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FundsDataTable()
		{
			TableName = "Funds";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal FundsDataTable(DataTable table)
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
		protected FundsDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddFundsRow(FundsRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FundsRow AddFundsRow(decimal Amount, string UserName, string Description, DateTime tarikh)
		{
			FundsRow fundsRow = (FundsRow)NewRow();
			object[] itemArray = new object[5] { Amount, UserName, Description, tarikh, null };
			fundsRow.ItemArray = itemArray;
			Rows.Add(fundsRow);
			return fundsRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public FundsRow FindByid(int id)
		{
			return (FundsRow)Rows.Find(new object[1] { id });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			FundsDataTable fundsDataTable = (FundsDataTable)base.Clone();
			fundsDataTable.InitVars();
			return fundsDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new FundsDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnAmount = Columns["Amount"];
			columnUserName = Columns["UserName"];
			columnDescription = Columns["Description"];
			columntarikh = Columns["tarikh"];
			columnid = Columns["id"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnAmount = new DataColumn("Amount", typeof(decimal), null, MappingType.Element);
			Columns.Add(columnAmount);
			columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
			Columns.Add(columnUserName);
			columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
			Columns.Add(columnDescription);
			columntarikh = new DataColumn("tarikh", typeof(DateTime), null, MappingType.Element);
			Columns.Add(columntarikh);
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			Columns.Add(columnid);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnid }, isPrimaryKey: true));
			columnAmount.AllowDBNull = false;
			columnUserName.AllowDBNull = false;
			columnUserName.MaxLength = 256;
			columnDescription.MaxLength = 250;
			columntarikh.AllowDBNull = false;
			columnid.AutoIncrement = true;
			columnid.AllowDBNull = false;
			columnid.ReadOnly = true;
			columnid.Unique = true;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public FundsRow NewFundsRow()
		{
			return (FundsRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new FundsRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(FundsRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (FundsRowChanged != null)
			{
				FundsRowChanged?.Invoke(this, new FundsRowChangeEvent((FundsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (FundsRowChanging != null)
			{
				FundsRowChanging?.Invoke(this, new FundsRowChangeEvent((FundsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (FundsRowDeleted != null)
			{
				FundsRowDeleted?.Invoke(this, new FundsRowChangeEvent((FundsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (FundsRowDeleting != null)
			{
				FundsRowDeleting?.Invoke(this, new FundsRowChangeEvent((FundsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveFundsRow(FundsRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			orders orders2 = new orders();
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
			xmlSchemaAttribute.FixedValue = orders2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "FundsDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = orders2.GetSchemaSerializable();
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
	public class depositsDataTable : TypedTableBase<depositsRow>
	{
		private DataColumn columnneme;

		private DataColumn columnuname;

		private DataColumn columnphone;

		private DataColumn columnemail;

		private DataColumn columnamount;

		private DataColumn columnconfirm;

		private DataColumn columndate;

		private DataColumn columnpurpose;

		private DataColumn columntid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn nemeColumn => columnneme;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn unameColumn => columnuname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn phoneColumn => columnphone;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn emailColumn => columnemail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn amountColumn => columnamount;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn confirmColumn => columnconfirm;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn dateColumn => columndate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn purposeColumn => columnpurpose;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn tidColumn => columntid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public depositsRow this[int index] => (depositsRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event depositsRowChangeEventHandler depositsRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event depositsRowChangeEventHandler depositsRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event depositsRowChangeEventHandler depositsRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event depositsRowChangeEventHandler depositsRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public depositsDataTable()
		{
			TableName = "deposits";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal depositsDataTable(DataTable table)
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
		protected depositsDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AdddepositsRow(depositsRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public depositsRow AdddepositsRow(string neme, string uname, string phone, string email, string amount, string confirm, string _date, string purpose)
		{
			depositsRow depositsRow2 = (depositsRow)NewRow();
			object[] itemArray = new object[9] { neme, uname, phone, email, amount, confirm, _date, purpose, null };
			depositsRow2.ItemArray = itemArray;
			Rows.Add(depositsRow2);
			return depositsRow2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public depositsRow FindBytid(int tid)
		{
			return (depositsRow)Rows.Find(new object[1] { tid });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			depositsDataTable depositsDataTable2 = (depositsDataTable)base.Clone();
			depositsDataTable2.InitVars();
			return depositsDataTable2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new depositsDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnneme = Columns["neme"];
			columnuname = Columns["uname"];
			columnphone = Columns["phone"];
			columnemail = Columns["email"];
			columnamount = Columns["amount"];
			columnconfirm = Columns["confirm"];
			columndate = Columns["date"];
			columnpurpose = Columns["purpose"];
			columntid = Columns["tid"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnneme = new DataColumn("neme", typeof(string), null, MappingType.Element);
			Columns.Add(columnneme);
			columnuname = new DataColumn("uname", typeof(string), null, MappingType.Element);
			Columns.Add(columnuname);
			columnphone = new DataColumn("phone", typeof(string), null, MappingType.Element);
			Columns.Add(columnphone);
			columnemail = new DataColumn("email", typeof(string), null, MappingType.Element);
			Columns.Add(columnemail);
			columnamount = new DataColumn("amount", typeof(string), null, MappingType.Element);
			Columns.Add(columnamount);
			columnconfirm = new DataColumn("confirm", typeof(string), null, MappingType.Element);
			Columns.Add(columnconfirm);
			columndate = new DataColumn("date", typeof(string), null, MappingType.Element);
			columndate.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "dateColumn");
			columndate.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columndate");
			columndate.ExtendedProperties.Add("Generator_UserColumnName", "date");
			Columns.Add(columndate);
			columnpurpose = new DataColumn("purpose", typeof(string), null, MappingType.Element);
			Columns.Add(columnpurpose);
			columntid = new DataColumn("tid", typeof(int), null, MappingType.Element);
			Columns.Add(columntid);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columntid }, isPrimaryKey: true));
			columnneme.MaxLength = 150;
			columnuname.MaxLength = 50;
			columnphone.MaxLength = 50;
			columnemail.MaxLength = 150;
			columnamount.MaxLength = 50;
			columnconfirm.MaxLength = 50;
			columndate.MaxLength = 50;
			columnpurpose.MaxLength = 500;
			columntid.AutoIncrement = true;
			columntid.AutoIncrementSeed = -1L;
			columntid.AutoIncrementStep = -1L;
			columntid.AllowDBNull = false;
			columntid.ReadOnly = true;
			columntid.Unique = true;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public depositsRow NewdepositsRow()
		{
			return (depositsRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new depositsRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(depositsRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (depositsRowChanged != null)
			{
				depositsRowChanged?.Invoke(this, new depositsRowChangeEvent((depositsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (depositsRowChanging != null)
			{
				depositsRowChanging?.Invoke(this, new depositsRowChangeEvent((depositsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (depositsRowDeleted != null)
			{
				depositsRowDeleted?.Invoke(this, new depositsRowChangeEvent((depositsRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (depositsRowDeleting != null)
			{
				depositsRowDeleting?.Invoke(this, new depositsRowChangeEvent((depositsRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovedepositsRow(depositsRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			orders orders2 = new orders();
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
			xmlSchemaAttribute.FixedValue = orders2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "depositsDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = orders2.GetSchemaSerializable();
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

	public class ahnRow : DataRow
	{
		private ahnDataTable tableahn;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string mc_gross
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.mc_grossColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'mc_gross' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.mc_grossColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string item_number1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.item_number1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'item_number1' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.item_number1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string payer_id
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.payer_idColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'payer_id' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.payer_idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string tax
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.taxColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'tax' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.taxColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string payment_date
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.payment_dateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'payment_date' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.payment_dateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string payment_status
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.payment_statusColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'payment_status' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.payment_statusColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string charset
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.charsetColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'charset' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.charsetColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string mc_tax1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.mc_tax1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'mc_tax1' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.mc_tax1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string mc_shipping
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.mc_shippingColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'mc_shipping' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.mc_shippingColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string mc_handling
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.mc_handlingColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'mc_handling' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.mc_handlingColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string first_name
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.first_nameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'first_name' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.first_nameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string notify_version
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.notify_versionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'notify_version' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.notify_versionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string custom
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.customColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'custom' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.customColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string payer_status
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.payer_statusColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'payer_status' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.payer_statusColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string num_cart_items
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.num_cart_itemsColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'num_cart_items' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.num_cart_itemsColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string mc_handling1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.mc_handling1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'mc_handling1' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.mc_handling1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string verify_sign
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.verify_signColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'verify_sign' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.verify_signColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string payer_email
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.payer_emailColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'payer_email' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.payer_emailColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string mc_shipping1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.mc_shipping1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'mc_shipping1' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.mc_shipping1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string tax1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.tax1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'tax1' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.tax1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string txn_id
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.txn_idColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'txn_id' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.txn_idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string payment_type
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.payment_typeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'payment_type' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.payment_typeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string last_name
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.last_nameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'last_name' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.last_nameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string item_name1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.item_name1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'item_name1' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.item_name1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string quantity1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.quantity1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'quantity1' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.quantity1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string pending_reason
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.pending_reasonColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'pending_reason' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.pending_reasonColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string txn_type
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.txn_typeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'txn_type' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.txn_typeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string mc_gross_1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.mc_gross_1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'mc_gross_1' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.mc_gross_1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string mc_currency
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.mc_currencyColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'mc_currency' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.mc_currencyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string residence_country
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.residence_countryColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'residence_country' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.residence_countryColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string test_ipn
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.test_ipnColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'test_ipn' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.test_ipnColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string payment_gross
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn.payment_grossColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'payment_gross' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn.payment_grossColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string username
		{
			get
			{
				return Conversions.ToString(this[tableahn.usernameColumn]);
			}
			set
			{
				this[tableahn.usernameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return Conversions.ToInteger(this[tableahn.idColumn]);
			}
			set
			{
				this[tableahn.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string _25receiver_email
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableahn._25receiver_emailColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column '25receiver_email' in table 'ahn' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableahn._25receiver_emailColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal ahnRow(DataRowBuilder rb)
			: base(rb)
		{
			tableahn = (ahnDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ismc_grossNull()
		{
			return IsNull(tableahn.mc_grossColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setmc_grossNull()
		{
			this[tableahn.mc_grossColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isitem_number1Null()
		{
			return IsNull(tableahn.item_number1Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setitem_number1Null()
		{
			this[tableahn.item_number1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ispayer_idNull()
		{
			return IsNull(tableahn.payer_idColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setpayer_idNull()
		{
			this[tableahn.payer_idColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstaxNull()
		{
			return IsNull(tableahn.taxColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettaxNull()
		{
			this[tableahn.taxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ispayment_dateNull()
		{
			return IsNull(tableahn.payment_dateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setpayment_dateNull()
		{
			this[tableahn.payment_dateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ispayment_statusNull()
		{
			return IsNull(tableahn.payment_statusColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setpayment_statusNull()
		{
			this[tableahn.payment_statusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IscharsetNull()
		{
			return IsNull(tableahn.charsetColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetcharsetNull()
		{
			this[tableahn.charsetColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ismc_tax1Null()
		{
			return IsNull(tableahn.mc_tax1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setmc_tax1Null()
		{
			this[tableahn.mc_tax1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ismc_shippingNull()
		{
			return IsNull(tableahn.mc_shippingColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setmc_shippingNull()
		{
			this[tableahn.mc_shippingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ismc_handlingNull()
		{
			return IsNull(tableahn.mc_handlingColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setmc_handlingNull()
		{
			this[tableahn.mc_handlingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isfirst_nameNull()
		{
			return IsNull(tableahn.first_nameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setfirst_nameNull()
		{
			this[tableahn.first_nameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isnotify_versionNull()
		{
			return IsNull(tableahn.notify_versionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setnotify_versionNull()
		{
			this[tableahn.notify_versionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IscustomNull()
		{
			return IsNull(tableahn.customColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetcustomNull()
		{
			this[tableahn.customColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ispayer_statusNull()
		{
			return IsNull(tableahn.payer_statusColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setpayer_statusNull()
		{
			this[tableahn.payer_statusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isnum_cart_itemsNull()
		{
			return IsNull(tableahn.num_cart_itemsColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setnum_cart_itemsNull()
		{
			this[tableahn.num_cart_itemsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ismc_handling1Null()
		{
			return IsNull(tableahn.mc_handling1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setmc_handling1Null()
		{
			this[tableahn.mc_handling1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isverify_signNull()
		{
			return IsNull(tableahn.verify_signColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setverify_signNull()
		{
			this[tableahn.verify_signColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ispayer_emailNull()
		{
			return IsNull(tableahn.payer_emailColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setpayer_emailNull()
		{
			this[tableahn.payer_emailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ismc_shipping1Null()
		{
			return IsNull(tableahn.mc_shipping1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setmc_shipping1Null()
		{
			this[tableahn.mc_shipping1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Istax1Null()
		{
			return IsNull(tableahn.tax1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Settax1Null()
		{
			this[tableahn.tax1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Istxn_idNull()
		{
			return IsNull(tableahn.txn_idColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Settxn_idNull()
		{
			this[tableahn.txn_idColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ispayment_typeNull()
		{
			return IsNull(tableahn.payment_typeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setpayment_typeNull()
		{
			this[tableahn.payment_typeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Islast_nameNull()
		{
			return IsNull(tableahn.last_nameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setlast_nameNull()
		{
			this[tableahn.last_nameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isitem_name1Null()
		{
			return IsNull(tableahn.item_name1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setitem_name1Null()
		{
			this[tableahn.item_name1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isquantity1Null()
		{
			return IsNull(tableahn.quantity1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setquantity1Null()
		{
			this[tableahn.quantity1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ispending_reasonNull()
		{
			return IsNull(tableahn.pending_reasonColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setpending_reasonNull()
		{
			this[tableahn.pending_reasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Istxn_typeNull()
		{
			return IsNull(tableahn.txn_typeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Settxn_typeNull()
		{
			this[tableahn.txn_typeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ismc_gross_1Null()
		{
			return IsNull(tableahn.mc_gross_1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setmc_gross_1Null()
		{
			this[tableahn.mc_gross_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ismc_currencyNull()
		{
			return IsNull(tableahn.mc_currencyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setmc_currencyNull()
		{
			this[tableahn.mc_currencyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isresidence_countryNull()
		{
			return IsNull(tableahn.residence_countryColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setresidence_countryNull()
		{
			this[tableahn.residence_countryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Istest_ipnNull()
		{
			return IsNull(tableahn.test_ipnColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Settest_ipnNull()
		{
			this[tableahn.test_ipnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ispayment_grossNull()
		{
			return IsNull(tableahn.payment_grossColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setpayment_grossNull()
		{
			this[tableahn.payment_grossColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Is_25receiver_emailNull()
		{
			return IsNull(tableahn._25receiver_emailColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Set_25receiver_emailNull()
		{
			this[tableahn._25receiver_emailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class FundsRow : DataRow
	{
		private FundsDataTable tableFunds;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal Amount
		{
			get
			{
				return Conversions.ToDecimal(this[tableFunds.AmountColumn]);
			}
			set
			{
				this[tableFunds.AmountColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UserName
		{
			get
			{
				return Conversions.ToString(this[tableFunds.UserNameColumn]);
			}
			set
			{
				this[tableFunds.UserNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableFunds.DescriptionColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Description' in table 'Funds' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableFunds.DescriptionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime tarikh
		{
			get
			{
				return Conversions.ToDate(this[tableFunds.tarikhColumn]);
			}
			set
			{
				this[tableFunds.tarikhColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return Conversions.ToInteger(this[tableFunds.idColumn]);
			}
			set
			{
				this[tableFunds.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal FundsRow(DataRowBuilder rb)
			: base(rb)
		{
			tableFunds = (FundsDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDescriptionNull()
		{
			return IsNull(tableFunds.DescriptionColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDescriptionNull()
		{
			this[tableFunds.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class depositsRow : DataRow
	{
		private depositsDataTable tabledeposits;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string neme
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabledeposits.nemeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'neme' in table 'deposits' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabledeposits.nemeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string uname
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabledeposits.unameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'uname' in table 'deposits' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabledeposits.unameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string phone
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabledeposits.phoneColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'phone' in table 'deposits' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabledeposits.phoneColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string email
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabledeposits.emailColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'email' in table 'deposits' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabledeposits.emailColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string amount
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabledeposits.amountColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'amount' in table 'deposits' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabledeposits.amountColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string confirm
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabledeposits.confirmColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'confirm' in table 'deposits' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabledeposits.confirmColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string _date
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabledeposits.dateColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'date' in table 'deposits' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabledeposits.dateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string purpose
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabledeposits.purposeColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'purpose' in table 'deposits' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabledeposits.purposeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int tid
		{
			get
			{
				return Conversions.ToInteger(this[tabledeposits.tidColumn]);
			}
			set
			{
				this[tabledeposits.tidColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal depositsRow(DataRowBuilder rb)
			: base(rb)
		{
			tabledeposits = (depositsDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsnemeNull()
		{
			return IsNull(tabledeposits.nemeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetnemeNull()
		{
			this[tabledeposits.nemeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsunameNull()
		{
			return IsNull(tabledeposits.unameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetunameNull()
		{
			this[tabledeposits.unameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsphoneNull()
		{
			return IsNull(tabledeposits.phoneColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetphoneNull()
		{
			this[tabledeposits.phoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsemailNull()
		{
			return IsNull(tabledeposits.emailColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetemailNull()
		{
			this[tabledeposits.emailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsamountNull()
		{
			return IsNull(tabledeposits.amountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetamountNull()
		{
			this[tabledeposits.amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsconfirmNull()
		{
			return IsNull(tabledeposits.confirmColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetconfirmNull()
		{
			this[tabledeposits.confirmColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Is_dateNull()
		{
			return IsNull(tabledeposits.dateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Set_dateNull()
		{
			this[tabledeposits.dateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IspurposeNull()
		{
			return IsNull(tabledeposits.purposeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetpurposeNull()
		{
			this[tabledeposits.purposeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class ahnRowChangeEvent : EventArgs
	{
		private ahnRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ahnRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ahnRowChangeEvent(ahnRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class FundsRowChangeEvent : EventArgs
	{
		private FundsRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public FundsRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public FundsRowChangeEvent(FundsRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class depositsRowChangeEvent : EventArgs
	{
		private depositsRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public depositsRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public depositsRowChangeEvent(depositsRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private ahnDataTable tableahn;

	private FundsDataTable tableFunds;

	private depositsDataTable tabledeposits;

	private SchemaSerializationMode _schemaSerializationMode;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public ahnDataTable ahn => tableahn;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public FundsDataTable Funds => tableFunds;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public depositsDataTable deposits => tabledeposits;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public orders()
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
	protected orders(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["ahn"] != null)
			{
				base.Tables.Add(new ahnDataTable(dataSet.Tables["ahn"]));
			}
			if (dataSet.Tables["Funds"] != null)
			{
				base.Tables.Add(new FundsDataTable(dataSet.Tables["Funds"]));
			}
			if (dataSet.Tables["deposits"] != null)
			{
				base.Tables.Add(new depositsDataTable(dataSet.Tables["deposits"]));
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
		orders orders2 = (orders)base.Clone();
		orders2.InitVars();
		orders2.SchemaSerializationMode = SchemaSerializationMode;
		return orders2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			if (dataSet.Tables["ahn"] != null)
			{
				base.Tables.Add(new ahnDataTable(dataSet.Tables["ahn"]));
			}
			if (dataSet.Tables["Funds"] != null)
			{
				base.Tables.Add(new FundsDataTable(dataSet.Tables["Funds"]));
			}
			if (dataSet.Tables["deposits"] != null)
			{
				base.Tables.Add(new depositsDataTable(dataSet.Tables["deposits"]));
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
		tableahn = (ahnDataTable)base.Tables["ahn"];
		if (initTable && tableahn != null)
		{
			tableahn.InitVars();
		}
		tableFunds = (FundsDataTable)base.Tables["Funds"];
		if (initTable && tableFunds != null)
		{
			tableFunds.InitVars();
		}
		tabledeposits = (depositsDataTable)base.Tables["deposits"];
		if (initTable && tabledeposits != null)
		{
			tabledeposits.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		DataSetName = "orders";
		Prefix = "";
		Namespace = "http://tempuri.org/orders.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableahn = new ahnDataTable();
		base.Tables.Add(tableahn);
		tableFunds = new FundsDataTable();
		base.Tables.Add(tableFunds);
		tabledeposits = new depositsDataTable();
		base.Tables.Add(tabledeposits);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeahn()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeFunds()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializedeposits()
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		orders orders2 = new orders();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = orders2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = orders2.GetSchemaSerializable();
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
