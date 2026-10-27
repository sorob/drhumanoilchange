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
[XmlRoot("Labstuff")]
[HelpKeyword("vs.data.DataSet")]
[DesignerCategory("code")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
public class Labstuff : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void ResultRefRowChangeEventHandler(object sender, ResultRefRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void RxRowChangeEventHandler(object sender, RxRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void gotadviseRowChangeEventHandler(object sender, gotadviseRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Rx1RowChangeEventHandler(object sender, Rx1RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void ResultRef1RowChangeEventHandler(object sender, ResultRef1RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void testbookrefRowChangeEventHandler(object sender, testbookrefRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void packagedataRowChangeEventHandler(object sender, packagedataRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void testbookref1RowChangeEventHandler(object sender, testbookref1RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void ratioRefRowChangeEventHandler(object sender, ratioRefRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class ResultRefDataTable : TypedTableBase<ResultRefRow>
	{
		private DataColumn columnResult;

		private DataColumn columnrid;

		private DataColumn columnTestAbrev;

		private DataColumn columnMedLow;

		private DataColumn columnMedHigh;

		private DataColumn columnMedopt;

		private DataColumn columnMedScale;

		private DataColumn columnUserName;

		private DataColumn columnDocLow;

		private DataColumn columnDocOpt;

		private DataColumn columnDocHigh;

		private DataColumn columnDocScale;

		private DataColumn columnTestid;

		private DataColumn columnRRefindex;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ResultColumn => columnResult;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ridColumn => columnrid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TestAbrevColumn => columnTestAbrev;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MedLowColumn => columnMedLow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MedHighColumn => columnMedHigh;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MedoptColumn => columnMedopt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MedScaleColumn => columnMedScale;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn UserNameColumn => columnUserName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DocLowColumn => columnDocLow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DocOptColumn => columnDocOpt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DocHighColumn => columnDocHigh;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DocScaleColumn => columnDocScale;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn TestidColumn => columnTestid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn RRefindexColumn => columnRRefindex;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ResultRefRow this[int index] => (ResultRefRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ResultRefRowChangeEventHandler ResultRefRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ResultRefRowChangeEventHandler ResultRefRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ResultRefRowChangeEventHandler ResultRefRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ResultRefRowChangeEventHandler ResultRefRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ResultRefDataTable()
		{
			TableName = "ResultRef";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal ResultRefDataTable(DataTable table)
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
		protected ResultRefDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddResultRefRow(ResultRefRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ResultRefRow AddResultRefRow(double Result, int rid, string TestAbrev, double MedLow, double MedHigh, double Medopt, double MedScale, string UserName, double DocLow, double DocOpt, double DocHigh, double DocScale)
		{
			ResultRefRow resultRefRow = (ResultRefRow)NewRow();
			object[] itemArray = new object[14]
			{
				Result, rid, TestAbrev, MedLow, MedHigh, Medopt, MedScale, UserName, DocLow, DocOpt,
				DocHigh, DocScale, null, null
			};
			resultRefRow.ItemArray = itemArray;
			Rows.Add(resultRefRow);
			return resultRefRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ResultRefRow FindByTestid(int Testid)
		{
			return (ResultRefRow)Rows.Find(new object[1] { Testid });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			ResultRefDataTable resultRefDataTable = (ResultRefDataTable)base.Clone();
			resultRefDataTable.InitVars();
			return resultRefDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new ResultRefDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnResult = Columns["Result"];
			columnrid = Columns["rid"];
			columnTestAbrev = Columns["TestAbrev"];
			columnMedLow = Columns["MedLow"];
			columnMedHigh = Columns["MedHigh"];
			columnMedopt = Columns["Medopt"];
			columnMedScale = Columns["MedScale"];
			columnUserName = Columns["UserName"];
			columnDocLow = Columns["DocLow"];
			columnDocOpt = Columns["DocOpt"];
			columnDocHigh = Columns["DocHigh"];
			columnDocScale = Columns["DocScale"];
			columnTestid = Columns["Testid"];
			columnRRefindex = Columns["RRefindex"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnResult = new DataColumn("Result", typeof(double), null, MappingType.Element);
			Columns.Add(columnResult);
			columnrid = new DataColumn("rid", typeof(int), null, MappingType.Element);
			Columns.Add(columnrid);
			columnTestAbrev = new DataColumn("TestAbrev", typeof(string), null, MappingType.Element);
			Columns.Add(columnTestAbrev);
			columnMedLow = new DataColumn("MedLow", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedLow);
			columnMedHigh = new DataColumn("MedHigh", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedHigh);
			columnMedopt = new DataColumn("Medopt", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedopt);
			columnMedScale = new DataColumn("MedScale", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedScale);
			columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
			Columns.Add(columnUserName);
			columnDocLow = new DataColumn("DocLow", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocLow);
			columnDocOpt = new DataColumn("DocOpt", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocOpt);
			columnDocHigh = new DataColumn("DocHigh", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocHigh);
			columnDocScale = new DataColumn("DocScale", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocScale);
			columnTestid = new DataColumn("Testid", typeof(int), null, MappingType.Element);
			Columns.Add(columnTestid);
			columnRRefindex = new DataColumn("RRefindex", typeof(int), null, MappingType.Element);
			Columns.Add(columnRRefindex);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnTestid }, isPrimaryKey: true));
			Constraints.Add(new UniqueConstraint("Constraint2", new DataColumn[1] { columnRRefindex }, isPrimaryKey: false));
			columnrid.AllowDBNull = false;
			columnTestAbrev.AllowDBNull = false;
			columnTestAbrev.MaxLength = 50;
			columnUserName.MaxLength = 256;
			columnTestid.AutoIncrement = true;
			columnTestid.AllowDBNull = false;
			columnTestid.ReadOnly = true;
			columnTestid.Unique = true;
			columnRRefindex.AutoIncrement = true;
			columnRRefindex.AllowDBNull = false;
			columnRRefindex.ReadOnly = true;
			columnRRefindex.Unique = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ResultRefRow NewResultRefRow()
		{
			return (ResultRefRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new ResultRefRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(ResultRefRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (ResultRefRowChanged != null)
			{
				ResultRefRowChanged?.Invoke(this, new ResultRefRowChangeEvent((ResultRefRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (ResultRefRowChanging != null)
			{
				ResultRefRowChanging?.Invoke(this, new ResultRefRowChangeEvent((ResultRefRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (ResultRefRowDeleted != null)
			{
				ResultRefRowDeleted?.Invoke(this, new ResultRefRowChangeEvent((ResultRefRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (ResultRefRowDeleting != null)
			{
				ResultRefRowDeleting?.Invoke(this, new ResultRefRowChangeEvent((ResultRefRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveResultRefRow(ResultRefRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Labstuff labstuff = new Labstuff();
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
			xmlSchemaAttribute.FixedValue = labstuff.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "ResultRefDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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
	public class RxDataTable : TypedTableBase<RxRow>
	{
		private DataColumn _columnProd_ID;

		private DataColumn columnProduct;

		private DataColumn columnDosage;

		private DataColumn columnCo;

		private DataColumn columnOrder;

		private DataColumn columnBody_Part;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn _Prod_IDColumn => _columnProd_ID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ProductColumn => columnProduct;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DosageColumn => columnDosage;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CoColumn => columnCo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn OrderColumn => columnOrder;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Body_PartColumn => columnBody_Part;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public RxRow this[int index] => (RxRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event RxRowChangeEventHandler RxRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event RxRowChangeEventHandler RxRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event RxRowChangeEventHandler RxRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event RxRowChangeEventHandler RxRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public RxDataTable()
		{
			TableName = "Rx";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal RxDataTable(DataTable table)
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
		protected RxDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddRxRow(RxRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public RxRow AddRxRow(double _Prod_ID, string Product, string Dosage, string Co, double Order, string Body_Part)
		{
			RxRow rxRow = (RxRow)NewRow();
			object[] itemArray = new object[6] { _Prod_ID, Product, Dosage, Co, Order, Body_Part };
			rxRow.ItemArray = itemArray;
			Rows.Add(rxRow);
			return rxRow;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			RxDataTable rxDataTable = (RxDataTable)base.Clone();
			rxDataTable.InitVars();
			return rxDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new RxDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			_columnProd_ID = Columns["Prod-ID"];
			columnProduct = Columns["Product"];
			columnDosage = Columns["Dosage"];
			columnCo = Columns["Co"];
			columnOrder = Columns["Order"];
			columnBody_Part = Columns["Body_Part"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			_columnProd_ID = new DataColumn("Prod-ID", typeof(double), null, MappingType.Element);
			_columnProd_ID.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnProd_ID");
			_columnProd_ID.ExtendedProperties.Add("Generator_UserColumnName", "Prod-ID");
			Columns.Add(_columnProd_ID);
			columnProduct = new DataColumn("Product", typeof(string), null, MappingType.Element);
			Columns.Add(columnProduct);
			columnDosage = new DataColumn("Dosage", typeof(string), null, MappingType.Element);
			Columns.Add(columnDosage);
			columnCo = new DataColumn("Co", typeof(string), null, MappingType.Element);
			Columns.Add(columnCo);
			columnOrder = new DataColumn("Order", typeof(double), null, MappingType.Element);
			Columns.Add(columnOrder);
			columnBody_Part = new DataColumn("Body_Part", typeof(string), null, MappingType.Element);
			Columns.Add(columnBody_Part);
			columnProduct.MaxLength = 255;
			columnDosage.MaxLength = 255;
			columnCo.MaxLength = 255;
			columnBody_Part.MaxLength = 255;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public RxRow NewRxRow()
		{
			return (RxRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new RxRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(RxRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (RxRowChanged != null)
			{
				RxRowChanged?.Invoke(this, new RxRowChangeEvent((RxRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (RxRowChanging != null)
			{
				RxRowChanging?.Invoke(this, new RxRowChangeEvent((RxRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (RxRowDeleted != null)
			{
				RxRowDeleted?.Invoke(this, new RxRowChangeEvent((RxRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (RxRowDeleting != null)
			{
				RxRowDeleting?.Invoke(this, new RxRowChangeEvent((RxRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveRxRow(RxRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Labstuff labstuff = new Labstuff();
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
			xmlSchemaAttribute.FixedValue = labstuff.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "RxDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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
	public class gotadviseDataTable : TypedTableBase<gotadviseRow>
	{
		private DataColumn columnTestid;

		private DataColumn columnUserName;

		private DataColumn columngotadid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TestidColumn => columnTestid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UserNameColumn => columnUserName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn gotadidColumn => columngotadid;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public gotadviseRow this[int index] => (gotadviseRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event gotadviseRowChangeEventHandler gotadviseRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event gotadviseRowChangeEventHandler gotadviseRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event gotadviseRowChangeEventHandler gotadviseRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event gotadviseRowChangeEventHandler gotadviseRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public gotadviseDataTable()
		{
			TableName = "gotadvise";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal gotadviseDataTable(DataTable table)
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
		protected gotadviseDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddgotadviseRow(gotadviseRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public gotadviseRow AddgotadviseRow(int Testid, string UserName)
		{
			gotadviseRow gotadviseRow2 = (gotadviseRow)NewRow();
			object[] itemArray = new object[3] { Testid, UserName, null };
			gotadviseRow2.ItemArray = itemArray;
			Rows.Add(gotadviseRow2);
			return gotadviseRow2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public gotadviseRow FindBygotadid(int gotadid)
		{
			return (gotadviseRow)Rows.Find(new object[1] { gotadid });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			gotadviseDataTable gotadviseDataTable2 = (gotadviseDataTable)base.Clone();
			gotadviseDataTable2.InitVars();
			return gotadviseDataTable2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new gotadviseDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnTestid = Columns["Testid"];
			columnUserName = Columns["UserName"];
			columngotadid = Columns["gotadid"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnTestid = new DataColumn("Testid", typeof(int), null, MappingType.Element);
			Columns.Add(columnTestid);
			columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
			Columns.Add(columnUserName);
			columngotadid = new DataColumn("gotadid", typeof(int), null, MappingType.Element);
			Columns.Add(columngotadid);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columngotadid }, isPrimaryKey: true));
			columnTestid.AllowDBNull = false;
			columnUserName.AllowDBNull = false;
			columnUserName.MaxLength = 256;
			columngotadid.AutoIncrement = true;
			columngotadid.AllowDBNull = false;
			columngotadid.ReadOnly = true;
			columngotadid.Unique = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public gotadviseRow NewgotadviseRow()
		{
			return (gotadviseRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new gotadviseRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(gotadviseRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (gotadviseRowChanged != null)
			{
				gotadviseRowChanged?.Invoke(this, new gotadviseRowChangeEvent((gotadviseRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (gotadviseRowChanging != null)
			{
				gotadviseRowChanging?.Invoke(this, new gotadviseRowChangeEvent((gotadviseRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (gotadviseRowDeleted != null)
			{
				gotadviseRowDeleted?.Invoke(this, new gotadviseRowChangeEvent((gotadviseRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (gotadviseRowDeleting != null)
			{
				gotadviseRowDeleting?.Invoke(this, new gotadviseRowChangeEvent((gotadviseRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovegotadviseRow(gotadviseRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Labstuff labstuff = new Labstuff();
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
			xmlSchemaAttribute.FixedValue = labstuff.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "gotadviseDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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
	public class Rx1DataTable : TypedTableBase<Rx1Row>
	{
		private DataColumn _columnProd_ID;

		private DataColumn columnProduct;

		private DataColumn columnDosage;

		private DataColumn columnCo;

		private DataColumn columnOrder;

		private DataColumn columnBody_Part;

		private DataColumn _columnProd_ID1;

		private DataColumn columnOrder1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn _Prod_IDColumn => _columnProd_ID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ProductColumn => columnProduct;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DosageColumn => columnDosage;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CoColumn => columnCo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn OrderColumn => columnOrder;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn Body_PartColumn => columnBody_Part;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn _Prod_ID1Column => _columnProd_ID1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn Order1Column => columnOrder1;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Rx1Row this[int index] => (Rx1Row)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Rx1RowChangeEventHandler Rx1RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Rx1RowChangeEventHandler Rx1RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Rx1RowChangeEventHandler Rx1RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Rx1RowChangeEventHandler Rx1RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Rx1DataTable()
		{
			TableName = "Rx1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Rx1DataTable(DataTable table)
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
		protected Rx1DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddRx1Row(Rx1Row row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Rx1Row AddRx1Row(double _Prod_ID, string Product, string Dosage, string Co, double Order, string Body_Part, string _Prod_ID1, int Order1)
		{
			Rx1Row rx1Row = (Rx1Row)NewRow();
			object[] itemArray = new object[8] { _Prod_ID, Product, Dosage, Co, Order, Body_Part, _Prod_ID1, Order1 };
			rx1Row.ItemArray = itemArray;
			Rows.Add(rx1Row);
			return rx1Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Rx1DataTable rx1DataTable = (Rx1DataTable)base.Clone();
			rx1DataTable.InitVars();
			return rx1DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Rx1DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			_columnProd_ID = Columns["Prod-ID"];
			columnProduct = Columns["Product"];
			columnDosage = Columns["Dosage"];
			columnCo = Columns["Co"];
			columnOrder = Columns["Order"];
			columnBody_Part = Columns["Body_Part"];
			_columnProd_ID1 = Columns["Prod-ID1"];
			columnOrder1 = Columns["Order1"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			_columnProd_ID = new DataColumn("Prod-ID", typeof(double), null, MappingType.Element);
			_columnProd_ID.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnProd_ID");
			_columnProd_ID.ExtendedProperties.Add("Generator_UserColumnName", "Prod-ID");
			Columns.Add(_columnProd_ID);
			columnProduct = new DataColumn("Product", typeof(string), null, MappingType.Element);
			Columns.Add(columnProduct);
			columnDosage = new DataColumn("Dosage", typeof(string), null, MappingType.Element);
			Columns.Add(columnDosage);
			columnCo = new DataColumn("Co", typeof(string), null, MappingType.Element);
			Columns.Add(columnCo);
			columnOrder = new DataColumn("Order", typeof(double), null, MappingType.Element);
			Columns.Add(columnOrder);
			columnBody_Part = new DataColumn("Body_Part", typeof(string), null, MappingType.Element);
			Columns.Add(columnBody_Part);
			_columnProd_ID1 = new DataColumn("Prod-ID1", typeof(string), null, MappingType.Element);
			_columnProd_ID1.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnProd_ID1");
			_columnProd_ID1.ExtendedProperties.Add("Generator_UserColumnName", "Prod-ID1");
			Columns.Add(_columnProd_ID1);
			columnOrder1 = new DataColumn("Order1", typeof(int), null, MappingType.Element);
			Columns.Add(columnOrder1);
			columnProduct.MaxLength = 255;
			columnDosage.MaxLength = 255;
			columnCo.MaxLength = 255;
			columnBody_Part.MaxLength = 255;
			_columnProd_ID1.Caption = "Prod-ID";
			_columnProd_ID1.MaxLength = 50;
			columnOrder1.Caption = "Order";
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Rx1Row NewRx1Row()
		{
			return (Rx1Row)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Rx1Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Rx1Row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (Rx1RowChanged != null)
			{
				Rx1RowChanged?.Invoke(this, new Rx1RowChangeEvent((Rx1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (Rx1RowChanging != null)
			{
				Rx1RowChanging?.Invoke(this, new Rx1RowChangeEvent((Rx1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (Rx1RowDeleted != null)
			{
				Rx1RowDeleted?.Invoke(this, new Rx1RowChangeEvent((Rx1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (Rx1RowDeleting != null)
			{
				Rx1RowDeleting?.Invoke(this, new Rx1RowChangeEvent((Rx1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveRx1Row(Rx1Row row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Labstuff labstuff = new Labstuff();
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
			xmlSchemaAttribute.FixedValue = labstuff.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Rx1DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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
	public class ResultRef1DataTable : TypedTableBase<ResultRef1Row>
	{
		private DataColumn columnR1;

		private DataColumn columnR2;

		private DataColumn columnMedScale;

		private DataColumn columnDocScale;

		private DataColumn columnDocLow;

		private DataColumn columnDocHigh;

		private DataColumn columnDocOpt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn R1Column => columnR1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn R2Column => columnR2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MedScaleColumn => columnMedScale;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DocScaleColumn => columnDocScale;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DocLowColumn => columnDocLow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DocHighColumn => columnDocHigh;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DocOptColumn => columnDocOpt;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ResultRef1Row this[int index] => (ResultRef1Row)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ResultRef1RowChangeEventHandler ResultRef1RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ResultRef1RowChangeEventHandler ResultRef1RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ResultRef1RowChangeEventHandler ResultRef1RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ResultRef1RowChangeEventHandler ResultRef1RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ResultRef1DataTable()
		{
			TableName = "ResultRef1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal ResultRef1DataTable(DataTable table)
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
		protected ResultRef1DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddResultRef1Row(ResultRef1Row row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ResultRef1Row AddResultRef1Row(double R1, double R2, double MedScale, double DocScale, double DocLow, double DocHigh, double DocOpt)
		{
			ResultRef1Row resultRef1Row = (ResultRef1Row)NewRow();
			object[] itemArray = new object[7] { R1, R2, MedScale, DocScale, DocLow, DocHigh, DocOpt };
			resultRef1Row.ItemArray = itemArray;
			Rows.Add(resultRef1Row);
			return resultRef1Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			ResultRef1DataTable resultRef1DataTable = (ResultRef1DataTable)base.Clone();
			resultRef1DataTable.InitVars();
			return resultRef1DataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new ResultRef1DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnR1 = Columns["R1"];
			columnR2 = Columns["R2"];
			columnMedScale = Columns["MedScale"];
			columnDocScale = Columns["DocScale"];
			columnDocLow = Columns["DocLow"];
			columnDocHigh = Columns["DocHigh"];
			columnDocOpt = Columns["DocOpt"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnR1 = new DataColumn("R1", typeof(double), null, MappingType.Element);
			Columns.Add(columnR1);
			columnR2 = new DataColumn("R2", typeof(double), null, MappingType.Element);
			Columns.Add(columnR2);
			columnMedScale = new DataColumn("MedScale", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedScale);
			columnDocScale = new DataColumn("DocScale", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocScale);
			columnDocLow = new DataColumn("DocLow", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocLow);
			columnDocHigh = new DataColumn("DocHigh", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocHigh);
			columnDocOpt = new DataColumn("DocOpt", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocOpt);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ResultRef1Row NewResultRef1Row()
		{
			return (ResultRef1Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new ResultRef1Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(ResultRef1Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (ResultRef1RowChanged != null)
			{
				ResultRef1RowChanged?.Invoke(this, new ResultRef1RowChangeEvent((ResultRef1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (ResultRef1RowChanging != null)
			{
				ResultRef1RowChanging?.Invoke(this, new ResultRef1RowChangeEvent((ResultRef1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (ResultRef1RowDeleted != null)
			{
				ResultRef1RowDeleted?.Invoke(this, new ResultRef1RowChangeEvent((ResultRef1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (ResultRef1RowDeleting != null)
			{
				ResultRef1RowDeleting?.Invoke(this, new ResultRef1RowChangeEvent((ResultRef1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveResultRef1Row(ResultRef1Row row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Labstuff labstuff = new Labstuff();
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
			xmlSchemaAttribute.FixedValue = labstuff.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "ResultRef1DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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
	public class testbookrefDataTable : TypedTableBase<testbookrefRow>
	{
		private DataColumn columntestAbrev;

		private DataColumn columnbookname;

		private DataColumn columnauthur;

		private DataColumn columndatepublished;

		private DataColumn columnpagenum;

		private DataColumn columnnote;

		private DataColumn columnF1;

		private DataColumn columnbookreid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn testAbrevColumn => columntestAbrev;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn booknameColumn => columnbookname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn authurColumn => columnauthur;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn datepublishedColumn => columndatepublished;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn pagenumColumn => columnpagenum;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn noteColumn => columnnote;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn F1Column => columnF1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn bookreidColumn => columnbookreid;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public testbookrefRow this[int index] => (testbookrefRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event testbookrefRowChangeEventHandler testbookrefRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event testbookrefRowChangeEventHandler testbookrefRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event testbookrefRowChangeEventHandler testbookrefRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event testbookrefRowChangeEventHandler testbookrefRowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public testbookrefDataTable()
		{
			TableName = "testbookref";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal testbookrefDataTable(DataTable table)
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
		protected testbookrefDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddtestbookrefRow(testbookrefRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public testbookrefRow AddtestbookrefRow(string testAbrev, string bookname, string authur, string datepublished, string pagenum, string note, string F1, int bookreid)
		{
			testbookrefRow testbookrefRow2 = (testbookrefRow)NewRow();
			object[] itemArray = new object[8] { testAbrev, bookname, authur, datepublished, pagenum, note, F1, bookreid };
			testbookrefRow2.ItemArray = itemArray;
			Rows.Add(testbookrefRow2);
			return testbookrefRow2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public testbookrefRow FindBybookreid(int bookreid)
		{
			return (testbookrefRow)Rows.Find(new object[1] { bookreid });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			testbookrefDataTable testbookrefDataTable2 = (testbookrefDataTable)base.Clone();
			testbookrefDataTable2.InitVars();
			return testbookrefDataTable2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new testbookrefDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columntestAbrev = Columns["testAbrev"];
			columnbookname = Columns["bookname"];
			columnauthur = Columns["authur"];
			columndatepublished = Columns["datepublished"];
			columnpagenum = Columns["pagenum"];
			columnnote = Columns["note"];
			columnF1 = Columns["F1"];
			columnbookreid = Columns["bookreid"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columntestAbrev = new DataColumn("testAbrev", typeof(string), null, MappingType.Element);
			Columns.Add(columntestAbrev);
			columnbookname = new DataColumn("bookname", typeof(string), null, MappingType.Element);
			Columns.Add(columnbookname);
			columnauthur = new DataColumn("authur", typeof(string), null, MappingType.Element);
			Columns.Add(columnauthur);
			columndatepublished = new DataColumn("datepublished", typeof(string), null, MappingType.Element);
			Columns.Add(columndatepublished);
			columnpagenum = new DataColumn("pagenum", typeof(string), null, MappingType.Element);
			Columns.Add(columnpagenum);
			columnnote = new DataColumn("note", typeof(string), null, MappingType.Element);
			Columns.Add(columnnote);
			columnF1 = new DataColumn("F1", typeof(string), null, MappingType.Element);
			Columns.Add(columnF1);
			columnbookreid = new DataColumn("bookreid", typeof(int), null, MappingType.Element);
			Columns.Add(columnbookreid);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnbookreid }, isPrimaryKey: true));
			columntestAbrev.MaxLength = 50;
			columnbookname.MaxLength = 100;
			columnauthur.MaxLength = 100;
			columndatepublished.MaxLength = 100;
			columnpagenum.MaxLength = 100;
			columnnote.MaxLength = 100;
			columnF1.MaxLength = 100;
			columnbookreid.AllowDBNull = false;
			columnbookreid.Unique = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public testbookrefRow NewtestbookrefRow()
		{
			return (testbookrefRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new testbookrefRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(testbookrefRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (testbookrefRowChanged != null)
			{
				testbookrefRowChanged?.Invoke(this, new testbookrefRowChangeEvent((testbookrefRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (testbookrefRowChanging != null)
			{
				testbookrefRowChanging?.Invoke(this, new testbookrefRowChangeEvent((testbookrefRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (testbookrefRowDeleted != null)
			{
				testbookrefRowDeleted?.Invoke(this, new testbookrefRowChangeEvent((testbookrefRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (testbookrefRowDeleting != null)
			{
				testbookrefRowDeleting?.Invoke(this, new testbookrefRowChangeEvent((testbookrefRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovetestbookrefRow(testbookrefRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Labstuff labstuff = new Labstuff();
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
			xmlSchemaAttribute.FixedValue = labstuff.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "testbookrefDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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
	public class packagedataDataTable : TypedTableBase<packagedataRow>
	{
		private DataColumn columnpackid;

		private DataColumn columntestAbrev;

		private DataColumn columnpid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn packidColumn => columnpackid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn testAbrevColumn => columntestAbrev;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn pidColumn => columnpid;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public packagedataRow this[int index] => (packagedataRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event packagedataRowChangeEventHandler packagedataRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event packagedataRowChangeEventHandler packagedataRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event packagedataRowChangeEventHandler packagedataRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event packagedataRowChangeEventHandler packagedataRowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public packagedataDataTable()
		{
			TableName = "packagedata";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal packagedataDataTable(DataTable table)
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
		protected packagedataDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddpackagedataRow(packagedataRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public packagedataRow AddpackagedataRow(int packid, string testAbrev)
		{
			packagedataRow packagedataRow2 = (packagedataRow)NewRow();
			object[] itemArray = new object[3] { packid, testAbrev, null };
			packagedataRow2.ItemArray = itemArray;
			Rows.Add(packagedataRow2);
			return packagedataRow2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public packagedataRow FindBypid(int pid)
		{
			return (packagedataRow)Rows.Find(new object[1] { pid });
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			packagedataDataTable packagedataDataTable2 = (packagedataDataTable)base.Clone();
			packagedataDataTable2.InitVars();
			return packagedataDataTable2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new packagedataDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnpackid = Columns["packid"];
			columntestAbrev = Columns["testAbrev"];
			columnpid = Columns["pid"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnpackid = new DataColumn("packid", typeof(int), null, MappingType.Element);
			Columns.Add(columnpackid);
			columntestAbrev = new DataColumn("testAbrev", typeof(string), null, MappingType.Element);
			Columns.Add(columntestAbrev);
			columnpid = new DataColumn("pid", typeof(int), null, MappingType.Element);
			Columns.Add(columnpid);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnpid }, isPrimaryKey: true));
			columntestAbrev.MaxLength = 50;
			columnpid.AutoIncrement = true;
			columnpid.AutoIncrementSeed = -1L;
			columnpid.AutoIncrementStep = -1L;
			columnpid.AllowDBNull = false;
			columnpid.ReadOnly = true;
			columnpid.Unique = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public packagedataRow NewpackagedataRow()
		{
			return (packagedataRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new packagedataRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(packagedataRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (packagedataRowChanged != null)
			{
				packagedataRowChanged?.Invoke(this, new packagedataRowChangeEvent((packagedataRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (packagedataRowChanging != null)
			{
				packagedataRowChanging?.Invoke(this, new packagedataRowChangeEvent((packagedataRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (packagedataRowDeleted != null)
			{
				packagedataRowDeleted?.Invoke(this, new packagedataRowChangeEvent((packagedataRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (packagedataRowDeleting != null)
			{
				packagedataRowDeleting?.Invoke(this, new packagedataRowChangeEvent((packagedataRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemovepackagedataRow(packagedataRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Labstuff labstuff = new Labstuff();
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
			xmlSchemaAttribute.FixedValue = labstuff.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "packagedataDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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
	public class testbookref1DataTable : TypedTableBase<testbookref1Row>
	{
		private DataColumn columnbookname;

		private DataColumn columnauthur;

		private DataColumn columndatepublished;

		private DataColumn columnpagenum;

		private DataColumn columnnote;

		private DataColumn columnbookreid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn booknameColumn => columnbookname;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn authurColumn => columnauthur;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn datepublishedColumn => columndatepublished;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn pagenumColumn => columnpagenum;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn noteColumn => columnnote;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn bookreidColumn => columnbookreid;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public testbookref1Row this[int index] => (testbookref1Row)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event testbookref1RowChangeEventHandler testbookref1RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event testbookref1RowChangeEventHandler testbookref1RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event testbookref1RowChangeEventHandler testbookref1RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event testbookref1RowChangeEventHandler testbookref1RowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public testbookref1DataTable()
		{
			TableName = "testbookref1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal testbookref1DataTable(DataTable table)
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
		protected testbookref1DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Addtestbookref1Row(testbookref1Row row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public testbookref1Row Addtestbookref1Row(string bookname, string authur, string datepublished, string pagenum, string note)
		{
			testbookref1Row testbookref1Row2 = (testbookref1Row)NewRow();
			object[] itemArray = new object[6] { bookname, authur, datepublished, pagenum, note, null };
			testbookref1Row2.ItemArray = itemArray;
			Rows.Add(testbookref1Row2);
			return testbookref1Row2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public testbookref1Row FindBybookreid(int bookreid)
		{
			return (testbookref1Row)Rows.Find(new object[1] { bookreid });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			testbookref1DataTable testbookref1DataTable2 = (testbookref1DataTable)base.Clone();
			testbookref1DataTable2.InitVars();
			return testbookref1DataTable2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new testbookref1DataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnbookname = Columns["bookname"];
			columnauthur = Columns["authur"];
			columndatepublished = Columns["datepublished"];
			columnpagenum = Columns["pagenum"];
			columnnote = Columns["note"];
			columnbookreid = Columns["bookreid"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnbookname = new DataColumn("bookname", typeof(string), null, MappingType.Element);
			Columns.Add(columnbookname);
			columnauthur = new DataColumn("authur", typeof(string), null, MappingType.Element);
			Columns.Add(columnauthur);
			columndatepublished = new DataColumn("datepublished", typeof(string), null, MappingType.Element);
			Columns.Add(columndatepublished);
			columnpagenum = new DataColumn("pagenum", typeof(string), null, MappingType.Element);
			Columns.Add(columnpagenum);
			columnnote = new DataColumn("note", typeof(string), null, MappingType.Element);
			Columns.Add(columnnote);
			columnbookreid = new DataColumn("bookreid", typeof(int), null, MappingType.Element);
			Columns.Add(columnbookreid);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnbookreid }, isPrimaryKey: true));
			columnbookname.MaxLength = 100;
			columnauthur.MaxLength = 100;
			columndatepublished.MaxLength = 100;
			columnpagenum.MaxLength = 100;
			columnnote.MaxLength = 100;
			columnbookreid.AutoIncrement = true;
			columnbookreid.AutoIncrementSeed = -1L;
			columnbookreid.AutoIncrementStep = -1L;
			columnbookreid.AllowDBNull = false;
			columnbookreid.ReadOnly = true;
			columnbookreid.Unique = true;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public testbookref1Row Newtestbookref1Row()
		{
			return (testbookref1Row)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new testbookref1Row(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(testbookref1Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (testbookref1RowChanged != null)
			{
				testbookref1RowChanged?.Invoke(this, new testbookref1RowChangeEvent((testbookref1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (testbookref1RowChanging != null)
			{
				testbookref1RowChanging?.Invoke(this, new testbookref1RowChangeEvent((testbookref1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (testbookref1RowDeleted != null)
			{
				testbookref1RowDeleted?.Invoke(this, new testbookref1RowChangeEvent((testbookref1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (testbookref1RowDeleting != null)
			{
				testbookref1RowDeleting?.Invoke(this, new testbookref1RowChangeEvent((testbookref1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Removetestbookref1Row(testbookref1Row row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Labstuff labstuff = new Labstuff();
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
			xmlSchemaAttribute.FixedValue = labstuff.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "testbookref1DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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
	public class ratioRefDataTable : TypedTableBase<ratioRefRow>
	{
		private DataColumn columntestAbrev1;

		private DataColumn columntestAbrev2;

		private DataColumn columnratioAbrev;

		private DataColumn columnratioId;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn testAbrev1Column => columntestAbrev1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn testAbrev2Column => columntestAbrev2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ratioAbrevColumn => columnratioAbrev;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ratioIdColumn => columnratioId;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ratioRefRow this[int index] => (ratioRefRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ratioRefRowChangeEventHandler ratioRefRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ratioRefRowChangeEventHandler ratioRefRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ratioRefRowChangeEventHandler ratioRefRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ratioRefRowChangeEventHandler ratioRefRowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ratioRefDataTable()
		{
			TableName = "ratioRef";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal ratioRefDataTable(DataTable table)
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
		protected ratioRefDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddratioRefRow(ratioRefRow row)
		{
			Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ratioRefRow AddratioRefRow(string testAbrev1, string testAbrev2, string ratioAbrev)
		{
			ratioRefRow ratioRefRow2 = (ratioRefRow)NewRow();
			object[] itemArray = new object[4] { testAbrev1, testAbrev2, ratioAbrev, null };
			ratioRefRow2.ItemArray = itemArray;
			Rows.Add(ratioRefRow2);
			return ratioRefRow2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ratioRefRow FindByratioId(int ratioId)
		{
			return (ratioRefRow)Rows.Find(new object[1] { ratioId });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			ratioRefDataTable ratioRefDataTable2 = (ratioRefDataTable)base.Clone();
			ratioRefDataTable2.InitVars();
			return ratioRefDataTable2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new ratioRefDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columntestAbrev1 = Columns["testAbrev1"];
			columntestAbrev2 = Columns["testAbrev2"];
			columnratioAbrev = Columns["ratioAbrev"];
			columnratioId = Columns["ratioId"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columntestAbrev1 = new DataColumn("testAbrev1", typeof(string), null, MappingType.Element);
			Columns.Add(columntestAbrev1);
			columntestAbrev2 = new DataColumn("testAbrev2", typeof(string), null, MappingType.Element);
			Columns.Add(columntestAbrev2);
			columnratioAbrev = new DataColumn("ratioAbrev", typeof(string), null, MappingType.Element);
			Columns.Add(columnratioAbrev);
			columnratioId = new DataColumn("ratioId", typeof(int), null, MappingType.Element);
			Columns.Add(columnratioId);
			Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnratioId }, isPrimaryKey: true));
			columntestAbrev1.MaxLength = 255;
			columntestAbrev2.MaxLength = 255;
			columnratioAbrev.MaxLength = 10;
			columnratioId.AutoIncrement = true;
			columnratioId.AutoIncrementSeed = -1L;
			columnratioId.AutoIncrementStep = -1L;
			columnratioId.AllowDBNull = false;
			columnratioId.ReadOnly = true;
			columnratioId.Unique = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ratioRefRow NewratioRefRow()
		{
			return (ratioRefRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new ratioRefRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(ratioRefRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (ratioRefRowChanged != null)
			{
				ratioRefRowChanged?.Invoke(this, new ratioRefRowChangeEvent((ratioRefRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (ratioRefRowChanging != null)
			{
				ratioRefRowChanging?.Invoke(this, new ratioRefRowChangeEvent((ratioRefRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (ratioRefRowDeleted != null)
			{
				ratioRefRowDeleted?.Invoke(this, new ratioRefRowChangeEvent((ratioRefRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (ratioRefRowDeleting != null)
			{
				ratioRefRowDeleting?.Invoke(this, new ratioRefRowChangeEvent((ratioRefRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveratioRefRow(ratioRefRow row)
		{
			Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Labstuff labstuff = new Labstuff();
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
			xmlSchemaAttribute.FixedValue = labstuff.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "ratioRefDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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

	public class ResultRefRow : DataRow
	{
		private ResultRefDataTable tableResultRef;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double Result
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef.ResultColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Result' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.ResultColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int rid
		{
			get
			{
				return Conversions.ToInteger(this[tableResultRef.ridColumn]);
			}
			set
			{
				this[tableResultRef.ridColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TestAbrev
		{
			get
			{
				return Conversions.ToString(this[tableResultRef.TestAbrevColumn]);
			}
			set
			{
				this[tableResultRef.TestAbrevColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double MedLow
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef.MedLowColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MedLow' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.MedLowColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double MedHigh
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef.MedHighColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MedHigh' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.MedHighColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double Medopt
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef.MedoptColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Medopt' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.MedoptColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double MedScale
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef.MedScaleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MedScale' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.MedScaleColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UserName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableResultRef.UserNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'UserName' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.UserNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DocLow
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef.DocLowColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocLow' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.DocLowColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DocOpt
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef.DocOptColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocOpt' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.DocOptColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DocHigh
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef.DocHighColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocHigh' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.DocHighColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double DocScale
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef.DocScaleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocScale' in table 'ResultRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef.DocScaleColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Testid
		{
			get
			{
				return Conversions.ToInteger(this[tableResultRef.TestidColumn]);
			}
			set
			{
				this[tableResultRef.TestidColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int RRefindex
		{
			get
			{
				return Conversions.ToInteger(this[tableResultRef.RRefindexColumn]);
			}
			set
			{
				this[tableResultRef.RRefindexColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal ResultRefRow(DataRowBuilder rb)
			: base(rb)
		{
			tableResultRef = (ResultRefDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsResultNull()
		{
			return IsNull(tableResultRef.ResultColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetResultNull()
		{
			this[tableResultRef.ResultColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMedLowNull()
		{
			return IsNull(tableResultRef.MedLowColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMedLowNull()
		{
			this[tableResultRef.MedLowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMedHighNull()
		{
			return IsNull(tableResultRef.MedHighColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMedHighNull()
		{
			this[tableResultRef.MedHighColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMedoptNull()
		{
			return IsNull(tableResultRef.MedoptColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMedoptNull()
		{
			this[tableResultRef.MedoptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMedScaleNull()
		{
			return IsNull(tableResultRef.MedScaleColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMedScaleNull()
		{
			this[tableResultRef.MedScaleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsUserNameNull()
		{
			return IsNull(tableResultRef.UserNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetUserNameNull()
		{
			this[tableResultRef.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDocLowNull()
		{
			return IsNull(tableResultRef.DocLowColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDocLowNull()
		{
			this[tableResultRef.DocLowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocOptNull()
		{
			return IsNull(tableResultRef.DocOptColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocOptNull()
		{
			this[tableResultRef.DocOptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocHighNull()
		{
			return IsNull(tableResultRef.DocHighColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocHighNull()
		{
			this[tableResultRef.DocHighColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocScaleNull()
		{
			return IsNull(tableResultRef.DocScaleColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocScaleNull()
		{
			this[tableResultRef.DocScaleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class RxRow : DataRow
	{
		private RxDataTable tableRx;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double _Prod_ID
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableRx._Prod_IDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Prod-ID' in table 'Rx' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx._Prod_IDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Product
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableRx.ProductColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Product' in table 'Rx' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx.ProductColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Dosage
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableRx.DosageColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Dosage' in table 'Rx' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx.DosageColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Co
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableRx.CoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Co' in table 'Rx' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx.CoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double Order
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableRx.OrderColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Order' in table 'Rx' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx.OrderColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Body_Part
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableRx.Body_PartColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Body_Part' in table 'Rx' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx.Body_PartColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal RxRow(DataRowBuilder rb)
			: base(rb)
		{
			tableRx = (RxDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Is_Prod_IDNull()
		{
			return IsNull(tableRx._Prod_IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Set_Prod_IDNull()
		{
			this[tableRx._Prod_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsProductNull()
		{
			return IsNull(tableRx.ProductColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetProductNull()
		{
			this[tableRx.ProductColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDosageNull()
		{
			return IsNull(tableRx.DosageColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDosageNull()
		{
			this[tableRx.DosageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCoNull()
		{
			return IsNull(tableRx.CoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCoNull()
		{
			this[tableRx.CoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsOrderNull()
		{
			return IsNull(tableRx.OrderColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetOrderNull()
		{
			this[tableRx.OrderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBody_PartNull()
		{
			return IsNull(tableRx.Body_PartColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBody_PartNull()
		{
			this[tableRx.Body_PartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class gotadviseRow : DataRow
	{
		private gotadviseDataTable tablegotadvise;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Testid
		{
			get
			{
				return Conversions.ToInteger(this[tablegotadvise.TestidColumn]);
			}
			set
			{
				this[tablegotadvise.TestidColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UserName
		{
			get
			{
				return Conversions.ToString(this[tablegotadvise.UserNameColumn]);
			}
			set
			{
				this[tablegotadvise.UserNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int gotadid
		{
			get
			{
				return Conversions.ToInteger(this[tablegotadvise.gotadidColumn]);
			}
			set
			{
				this[tablegotadvise.gotadidColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal gotadviseRow(DataRowBuilder rb)
			: base(rb)
		{
			tablegotadvise = (gotadviseDataTable)Table;
		}
	}

	public class Rx1Row : DataRow
	{
		private Rx1DataTable tableRx1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double _Prod_ID
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableRx1._Prod_IDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Prod-ID' in table 'Rx1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx1._Prod_IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Product
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableRx1.ProductColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Product' in table 'Rx1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx1.ProductColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Dosage
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableRx1.DosageColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Dosage' in table 'Rx1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx1.DosageColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Co
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableRx1.CoColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Co' in table 'Rx1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx1.CoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double Order
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableRx1.OrderColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Order' in table 'Rx1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx1.OrderColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Body_Part
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableRx1.Body_PartColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Body_Part' in table 'Rx1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx1.Body_PartColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string _Prod_ID1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableRx1._Prod_ID1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Prod-ID1' in table 'Rx1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx1._Prod_ID1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Order1
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tableRx1.Order1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Order1' in table 'Rx1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableRx1.Order1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Rx1Row(DataRowBuilder rb)
			: base(rb)
		{
			tableRx1 = (Rx1DataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Is_Prod_IDNull()
		{
			return IsNull(tableRx1._Prod_IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Set_Prod_IDNull()
		{
			this[tableRx1._Prod_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsProductNull()
		{
			return IsNull(tableRx1.ProductColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetProductNull()
		{
			this[tableRx1.ProductColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDosageNull()
		{
			return IsNull(tableRx1.DosageColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDosageNull()
		{
			this[tableRx1.DosageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCoNull()
		{
			return IsNull(tableRx1.CoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCoNull()
		{
			this[tableRx1.CoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsOrderNull()
		{
			return IsNull(tableRx1.OrderColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetOrderNull()
		{
			this[tableRx1.OrderColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBody_PartNull()
		{
			return IsNull(tableRx1.Body_PartColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBody_PartNull()
		{
			this[tableRx1.Body_PartColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Is_Prod_ID1Null()
		{
			return IsNull(tableRx1._Prod_ID1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Set_Prod_ID1Null()
		{
			this[tableRx1._Prod_ID1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsOrder1Null()
		{
			return IsNull(tableRx1.Order1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetOrder1Null()
		{
			this[tableRx1.Order1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class ResultRef1Row : DataRow
	{
		private ResultRef1DataTable tableResultRef1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double R1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef1.R1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'R1' in table 'ResultRef1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef1.R1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double R2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef1.R2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'R2' in table 'ResultRef1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef1.R2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double MedScale
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef1.MedScaleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MedScale' in table 'ResultRef1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef1.MedScaleColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DocScale
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef1.DocScaleColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocScale' in table 'ResultRef1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef1.DocScaleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double DocLow
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef1.DocLowColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocLow' in table 'ResultRef1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef1.DocLowColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DocHigh
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef1.DocHighColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocHigh' in table 'ResultRef1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef1.DocHighColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double DocOpt
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableResultRef1.DocOptColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocOpt' in table 'ResultRef1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableResultRef1.DocOptColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal ResultRef1Row(DataRowBuilder rb)
			: base(rb)
		{
			tableResultRef1 = (ResultRef1DataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsR1Null()
		{
			return IsNull(tableResultRef1.R1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetR1Null()
		{
			this[tableResultRef1.R1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsR2Null()
		{
			return IsNull(tableResultRef1.R2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetR2Null()
		{
			this[tableResultRef1.R2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMedScaleNull()
		{
			return IsNull(tableResultRef1.MedScaleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMedScaleNull()
		{
			this[tableResultRef1.MedScaleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocScaleNull()
		{
			return IsNull(tableResultRef1.DocScaleColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocScaleNull()
		{
			this[tableResultRef1.DocScaleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocLowNull()
		{
			return IsNull(tableResultRef1.DocLowColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDocLowNull()
		{
			this[tableResultRef1.DocLowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDocHighNull()
		{
			return IsNull(tableResultRef1.DocHighColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDocHighNull()
		{
			this[tableResultRef1.DocHighColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocOptNull()
		{
			return IsNull(tableResultRef1.DocOptColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocOptNull()
		{
			this[tableResultRef1.DocOptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class testbookrefRow : DataRow
	{
		private testbookrefDataTable tabletestbookref;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string testAbrev
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref.testAbrevColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'testAbrev' in table 'testbookref' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref.testAbrevColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string bookname
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref.booknameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'bookname' in table 'testbookref' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref.booknameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string authur
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref.authurColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'authur' in table 'testbookref' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref.authurColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string datepublished
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref.datepublishedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'datepublished' in table 'testbookref' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref.datepublishedColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string pagenum
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref.pagenumColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'pagenum' in table 'testbookref' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref.pagenumColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string note
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref.noteColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'note' in table 'testbookref' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref.noteColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string F1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref.F1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'F1' in table 'testbookref' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref.F1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int bookreid
		{
			get
			{
				return Conversions.ToInteger(this[tabletestbookref.bookreidColumn]);
			}
			set
			{
				this[tabletestbookref.bookreidColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal testbookrefRow(DataRowBuilder rb)
			: base(rb)
		{
			tabletestbookref = (testbookrefDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstestAbrevNull()
		{
			return IsNull(tabletestbookref.testAbrevColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettestAbrevNull()
		{
			this[tabletestbookref.testAbrevColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsbooknameNull()
		{
			return IsNull(tabletestbookref.booknameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetbooknameNull()
		{
			this[tabletestbookref.booknameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsauthurNull()
		{
			return IsNull(tabletestbookref.authurColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetauthurNull()
		{
			this[tabletestbookref.authurColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdatepublishedNull()
		{
			return IsNull(tabletestbookref.datepublishedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdatepublishedNull()
		{
			this[tabletestbookref.datepublishedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspagenumNull()
		{
			return IsNull(tabletestbookref.pagenumColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetpagenumNull()
		{
			this[tabletestbookref.pagenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsnoteNull()
		{
			return IsNull(tabletestbookref.noteColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetnoteNull()
		{
			this[tabletestbookref.noteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsF1Null()
		{
			return IsNull(tabletestbookref.F1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetF1Null()
		{
			this[tabletestbookref.F1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class packagedataRow : DataRow
	{
		private packagedataDataTable tablepackagedata;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int packid
		{
			get
			{
				try
				{
					return Conversions.ToInteger(this[tablepackagedata.packidColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'packid' in table 'packagedata' is DBNull.", innerException);
				}
			}
			set
			{
				this[tablepackagedata.packidColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string testAbrev
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tablepackagedata.testAbrevColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'testAbrev' in table 'packagedata' is DBNull.", innerException);
				}
			}
			set
			{
				this[tablepackagedata.testAbrevColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int pid
		{
			get
			{
				return Conversions.ToInteger(this[tablepackagedata.pidColumn]);
			}
			set
			{
				this[tablepackagedata.pidColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal packagedataRow(DataRowBuilder rb)
			: base(rb)
		{
			tablepackagedata = (packagedataDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspackidNull()
		{
			return IsNull(tablepackagedata.packidColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetpackidNull()
		{
			this[tablepackagedata.packidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstestAbrevNull()
		{
			return IsNull(tablepackagedata.testAbrevColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettestAbrevNull()
		{
			this[tablepackagedata.testAbrevColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class testbookref1Row : DataRow
	{
		private testbookref1DataTable tabletestbookref1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string bookname
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref1.booknameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'bookname' in table 'testbookref1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref1.booknameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string authur
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref1.authurColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'authur' in table 'testbookref1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref1.authurColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string datepublished
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref1.datepublishedColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'datepublished' in table 'testbookref1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref1.datepublishedColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string pagenum
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref1.pagenumColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'pagenum' in table 'testbookref1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref1.pagenumColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string note
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tabletestbookref1.noteColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'note' in table 'testbookref1' is DBNull.", innerException);
				}
			}
			set
			{
				this[tabletestbookref1.noteColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int bookreid
		{
			get
			{
				return Conversions.ToInteger(this[tabletestbookref1.bookreidColumn]);
			}
			set
			{
				this[tabletestbookref1.bookreidColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal testbookref1Row(DataRowBuilder rb)
			: base(rb)
		{
			tabletestbookref1 = (testbookref1DataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsbooknameNull()
		{
			return IsNull(tabletestbookref1.booknameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetbooknameNull()
		{
			this[tabletestbookref1.booknameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsauthurNull()
		{
			return IsNull(tabletestbookref1.authurColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetauthurNull()
		{
			this[tabletestbookref1.authurColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdatepublishedNull()
		{
			return IsNull(tabletestbookref1.datepublishedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdatepublishedNull()
		{
			this[tabletestbookref1.datepublishedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspagenumNull()
		{
			return IsNull(tabletestbookref1.pagenumColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpagenumNull()
		{
			this[tabletestbookref1.pagenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsnoteNull()
		{
			return IsNull(tabletestbookref1.noteColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetnoteNull()
		{
			this[tabletestbookref1.noteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class ratioRefRow : DataRow
	{
		private ratioRefDataTable tableratioRef;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string testAbrev1
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableratioRef.testAbrev1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'testAbrev1' in table 'ratioRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableratioRef.testAbrev1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string testAbrev2
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableratioRef.testAbrev2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'testAbrev2' in table 'ratioRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableratioRef.testAbrev2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ratioAbrev
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableratioRef.ratioAbrevColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ratioAbrev' in table 'ratioRef' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableratioRef.ratioAbrevColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int ratioId
		{
			get
			{
				return Conversions.ToInteger(this[tableratioRef.ratioIdColumn]);
			}
			set
			{
				this[tableratioRef.ratioIdColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal ratioRefRow(DataRowBuilder rb)
			: base(rb)
		{
			tableratioRef = (ratioRefDataTable)Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstestAbrev1Null()
		{
			return IsNull(tableratioRef.testAbrev1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettestAbrev1Null()
		{
			this[tableratioRef.testAbrev1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstestAbrev2Null()
		{
			return IsNull(tableratioRef.testAbrev2Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettestAbrev2Null()
		{
			this[tableratioRef.testAbrev2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsratioAbrevNull()
		{
			return IsNull(tableratioRef.ratioAbrevColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetratioAbrevNull()
		{
			this[tableratioRef.ratioAbrevColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class ResultRefRowChangeEvent : EventArgs
	{
		private ResultRefRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ResultRefRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ResultRefRowChangeEvent(ResultRefRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class RxRowChangeEvent : EventArgs
	{
		private RxRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public RxRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public RxRowChangeEvent(RxRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class gotadviseRowChangeEvent : EventArgs
	{
		private gotadviseRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public gotadviseRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public gotadviseRowChangeEvent(gotadviseRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Rx1RowChangeEvent : EventArgs
	{
		private Rx1Row eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Rx1Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Rx1RowChangeEvent(Rx1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class ResultRef1RowChangeEvent : EventArgs
	{
		private ResultRef1Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ResultRef1Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ResultRef1RowChangeEvent(ResultRef1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class testbookrefRowChangeEvent : EventArgs
	{
		private testbookrefRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public testbookrefRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public testbookrefRowChangeEvent(testbookrefRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class packagedataRowChangeEvent : EventArgs
	{
		private packagedataRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public packagedataRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public packagedataRowChangeEvent(packagedataRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class testbookref1RowChangeEvent : EventArgs
	{
		private testbookref1Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public testbookref1Row Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public testbookref1RowChangeEvent(testbookref1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class ratioRefRowChangeEvent : EventArgs
	{
		private ratioRefRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ratioRefRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public ratioRefRowChangeEvent(ratioRefRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private ResultRefDataTable tableResultRef;

	private RxDataTable tableRx;

	private gotadviseDataTable tablegotadvise;

	private Rx1DataTable tableRx1;

	private ResultRef1DataTable tableResultRef1;

	private testbookrefDataTable tabletestbookref;

	private packagedataDataTable tablepackagedata;

	private testbookref1DataTable tabletestbookref1;

	private ratioRefDataTable tableratioRef;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public ResultRefDataTable ResultRef => tableResultRef;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public RxDataTable Rx => tableRx;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public gotadviseDataTable gotadvise => tablegotadvise;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Rx1DataTable Rx1 => tableRx1;

	[DebuggerNonUserCode]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ResultRef1DataTable ResultRef1 => tableResultRef1;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	public testbookrefDataTable testbookref => tabletestbookref;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public packagedataDataTable packagedata => tablepackagedata;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	public testbookref1DataTable testbookref1 => tabletestbookref1;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ratioRefDataTable ratioRef => tableratioRef;

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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Labstuff()
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
	protected Labstuff(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["ResultRef"] != null)
			{
				base.Tables.Add(new ResultRefDataTable(dataSet.Tables["ResultRef"]));
			}
			if (dataSet.Tables["Rx"] != null)
			{
				base.Tables.Add(new RxDataTable(dataSet.Tables["Rx"]));
			}
			if (dataSet.Tables["gotadvise"] != null)
			{
				base.Tables.Add(new gotadviseDataTable(dataSet.Tables["gotadvise"]));
			}
			if (dataSet.Tables["Rx1"] != null)
			{
				base.Tables.Add(new Rx1DataTable(dataSet.Tables["Rx1"]));
			}
			if (dataSet.Tables["ResultRef1"] != null)
			{
				base.Tables.Add(new ResultRef1DataTable(dataSet.Tables["ResultRef1"]));
			}
			if (dataSet.Tables["testbookref"] != null)
			{
				base.Tables.Add(new testbookrefDataTable(dataSet.Tables["testbookref"]));
			}
			if (dataSet.Tables["packagedata"] != null)
			{
				base.Tables.Add(new packagedataDataTable(dataSet.Tables["packagedata"]));
			}
			if (dataSet.Tables["testbookref1"] != null)
			{
				base.Tables.Add(new testbookref1DataTable(dataSet.Tables["testbookref1"]));
			}
			if (dataSet.Tables["ratioRef"] != null)
			{
				base.Tables.Add(new ratioRefDataTable(dataSet.Tables["ratioRef"]));
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
		Labstuff labstuff = (Labstuff)base.Clone();
		labstuff.InitVars();
		labstuff.SchemaSerializationMode = SchemaSerializationMode;
		return labstuff;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["ResultRef"] != null)
			{
				base.Tables.Add(new ResultRefDataTable(dataSet.Tables["ResultRef"]));
			}
			if (dataSet.Tables["Rx"] != null)
			{
				base.Tables.Add(new RxDataTable(dataSet.Tables["Rx"]));
			}
			if (dataSet.Tables["gotadvise"] != null)
			{
				base.Tables.Add(new gotadviseDataTable(dataSet.Tables["gotadvise"]));
			}
			if (dataSet.Tables["Rx1"] != null)
			{
				base.Tables.Add(new Rx1DataTable(dataSet.Tables["Rx1"]));
			}
			if (dataSet.Tables["ResultRef1"] != null)
			{
				base.Tables.Add(new ResultRef1DataTable(dataSet.Tables["ResultRef1"]));
			}
			if (dataSet.Tables["testbookref"] != null)
			{
				base.Tables.Add(new testbookrefDataTable(dataSet.Tables["testbookref"]));
			}
			if (dataSet.Tables["packagedata"] != null)
			{
				base.Tables.Add(new packagedataDataTable(dataSet.Tables["packagedata"]));
			}
			if (dataSet.Tables["testbookref1"] != null)
			{
				base.Tables.Add(new testbookref1DataTable(dataSet.Tables["testbookref1"]));
			}
			if (dataSet.Tables["ratioRef"] != null)
			{
				base.Tables.Add(new ratioRefDataTable(dataSet.Tables["ratioRef"]));
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		tableResultRef = (ResultRefDataTable)base.Tables["ResultRef"];
		if (initTable && tableResultRef != null)
		{
			tableResultRef.InitVars();
		}
		tableRx = (RxDataTable)base.Tables["Rx"];
		if (initTable && tableRx != null)
		{
			tableRx.InitVars();
		}
		tablegotadvise = (gotadviseDataTable)base.Tables["gotadvise"];
		if (initTable && tablegotadvise != null)
		{
			tablegotadvise.InitVars();
		}
		tableRx1 = (Rx1DataTable)base.Tables["Rx1"];
		if (initTable && tableRx1 != null)
		{
			tableRx1.InitVars();
		}
		tableResultRef1 = (ResultRef1DataTable)base.Tables["ResultRef1"];
		if (initTable && tableResultRef1 != null)
		{
			tableResultRef1.InitVars();
		}
		tabletestbookref = (testbookrefDataTable)base.Tables["testbookref"];
		if (initTable && tabletestbookref != null)
		{
			tabletestbookref.InitVars();
		}
		tablepackagedata = (packagedataDataTable)base.Tables["packagedata"];
		if (initTable && tablepackagedata != null)
		{
			tablepackagedata.InitVars();
		}
		tabletestbookref1 = (testbookref1DataTable)base.Tables["testbookref1"];
		if (initTable && tabletestbookref1 != null)
		{
			tabletestbookref1.InitVars();
		}
		tableratioRef = (ratioRefDataTable)base.Tables["ratioRef"];
		if (initTable && tableratioRef != null)
		{
			tableratioRef.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		DataSetName = "Labstuff";
		Prefix = "";
		Namespace = "http://tempuri.org/Labstuff.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableResultRef = new ResultRefDataTable();
		base.Tables.Add(tableResultRef);
		tableRx = new RxDataTable();
		base.Tables.Add(tableRx);
		tablegotadvise = new gotadviseDataTable();
		base.Tables.Add(tablegotadvise);
		tableRx1 = new Rx1DataTable();
		base.Tables.Add(tableRx1);
		tableResultRef1 = new ResultRef1DataTable();
		base.Tables.Add(tableResultRef1);
		tabletestbookref = new testbookrefDataTable();
		base.Tables.Add(tabletestbookref);
		tablepackagedata = new packagedataDataTable();
		base.Tables.Add(tablepackagedata);
		tabletestbookref1 = new testbookref1DataTable();
		base.Tables.Add(tabletestbookref1);
		tableratioRef = new ratioRefDataTable();
		base.Tables.Add(tableratioRef);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeResultRef()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeRx()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializegotadvise()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeRx1()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeResultRef1()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializetestbookref()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializepackagedata()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializetestbookref1()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeratioRef()
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		Labstuff labstuff = new Labstuff();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = labstuff.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = labstuff.GetSchemaSerializable();
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
