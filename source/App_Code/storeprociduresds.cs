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
[DesignerCategory("code")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("storeprociduresds")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
public class storeprociduresds : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void view3RowChangeEventHandler(object sender, view3RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void viewWorkedRowChangeEventHandler(object sender, viewWorkedRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class view3DataTable : TypedTableBase<view3Row>
	{
		private DataColumn columnR1;

		private DataColumn columnR2;

		private DataColumn columnMS1;

		private DataColumn columnDS1;

		private DataColumn columnDocLow;

		private DataColumn columnDocHigh;

		private DataColumn columnDocOpt;

		private DataColumn columnMedLow;

		private DataColumn columnMedHigh;

		private DataColumn columnMedopt;

		private DataColumn columnCategory;

		private DataColumn columntestName;

		private DataColumn columntestAbrev;

		private DataColumn columnMS2;

		private DataColumn columnDS2;

		private DataColumn columninf;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn R1Column => columnR1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn R2Column => columnR2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MS1Column => columnMS1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DS1Column => columnDS1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DocLowColumn => columnDocLow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DocHighColumn => columnDocHigh;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DocOptColumn => columnDocOpt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MedLowColumn => columnMedLow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MedHighColumn => columnMedHigh;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MedoptColumn => columnMedopt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CategoryColumn => columnCategory;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn testNameColumn => columntestName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn testAbrevColumn => columntestAbrev;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MS2Column => columnMS2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DS2Column => columnDS2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn infColumn => columninf;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public view3Row this[int index] => (view3Row)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event view3RowChangeEventHandler view3RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event view3RowChangeEventHandler view3RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event view3RowChangeEventHandler view3RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event view3RowChangeEventHandler view3RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public view3DataTable()
		{
			TableName = "view3";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal view3DataTable(DataTable table)
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
		protected view3DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Addview3Row(view3Row row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public view3Row Addview3Row(double R1, double R2, double MS1, double DS1, double DocLow, double DocHigh, double DocOpt, double MedLow, double MedHigh, double Medopt, string Category, string testName, string testAbrev, double MS2, double DS2, string inf)
		{
			view3Row view3Row2 = (view3Row)NewRow();
			object[] itemArray = new object[16]
			{
				R1, R2, MS1, DS1, DocLow, DocHigh, DocOpt, MedLow, MedHigh, Medopt,
				Category, testName, testAbrev, MS2, DS2, inf
			};
			view3Row2.ItemArray = itemArray;
			Rows.Add(view3Row2);
			return view3Row2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			view3DataTable view3DataTable2 = (view3DataTable)base.Clone();
			view3DataTable2.InitVars();
			return view3DataTable2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new view3DataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnR1 = Columns["R1"];
			columnR2 = Columns["R2"];
			columnMS1 = Columns["MS1"];
			columnDS1 = Columns["DS1"];
			columnDocLow = Columns["DocLow"];
			columnDocHigh = Columns["DocHigh"];
			columnDocOpt = Columns["DocOpt"];
			columnMedLow = Columns["MedLow"];
			columnMedHigh = Columns["MedHigh"];
			columnMedopt = Columns["Medopt"];
			columnCategory = Columns["Category"];
			columntestName = Columns["testName"];
			columntestAbrev = Columns["testAbrev"];
			columnMS2 = Columns["MS2"];
			columnDS2 = Columns["DS2"];
			columninf = Columns["inf"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnR1 = new DataColumn("R1", typeof(double), null, MappingType.Element);
			Columns.Add(columnR1);
			columnR2 = new DataColumn("R2", typeof(double), null, MappingType.Element);
			Columns.Add(columnR2);
			columnMS1 = new DataColumn("MS1", typeof(double), null, MappingType.Element);
			Columns.Add(columnMS1);
			columnDS1 = new DataColumn("DS1", typeof(double), null, MappingType.Element);
			Columns.Add(columnDS1);
			columnDocLow = new DataColumn("DocLow", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocLow);
			columnDocHigh = new DataColumn("DocHigh", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocHigh);
			columnDocOpt = new DataColumn("DocOpt", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocOpt);
			columnMedLow = new DataColumn("MedLow", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedLow);
			columnMedHigh = new DataColumn("MedHigh", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedHigh);
			columnMedopt = new DataColumn("Medopt", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedopt);
			columnCategory = new DataColumn("Category", typeof(string), null, MappingType.Element);
			Columns.Add(columnCategory);
			columntestName = new DataColumn("testName", typeof(string), null, MappingType.Element);
			Columns.Add(columntestName);
			columntestAbrev = new DataColumn("testAbrev", typeof(string), null, MappingType.Element);
			Columns.Add(columntestAbrev);
			columnMS2 = new DataColumn("MS2", typeof(double), null, MappingType.Element);
			Columns.Add(columnMS2);
			columnDS2 = new DataColumn("DS2", typeof(double), null, MappingType.Element);
			Columns.Add(columnDS2);
			columninf = new DataColumn("inf", typeof(string), null, MappingType.Element);
			Columns.Add(columninf);
			columnCategory.MaxLength = 50;
			columntestName.MaxLength = 50;
			columntestAbrev.AllowDBNull = false;
			columntestAbrev.MaxLength = 50;
			columninf.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public view3Row Newview3Row()
		{
			return (view3Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new view3Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(view3Row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (view3RowChanged != null)
			{
				view3RowChanged?.Invoke(this, new view3RowChangeEvent((view3Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (view3RowChanging != null)
			{
				view3RowChanging?.Invoke(this, new view3RowChangeEvent((view3Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (view3RowDeleted != null)
			{
				view3RowDeleted?.Invoke(this, new view3RowChangeEvent((view3Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (view3RowDeleting != null)
			{
				view3RowDeleting?.Invoke(this, new view3RowChangeEvent((view3Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Removeview3Row(view3Row row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			storeprociduresds storeprociduresds2 = new storeprociduresds();
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
			xmlSchemaAttribute.FixedValue = storeprociduresds2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "view3DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = storeprociduresds2.GetSchemaSerializable();
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
	public class viewWorkedDataTable : TypedTableBase<viewWorkedRow>
	{
		private DataColumn columnR1;

		private DataColumn columnR2;

		private DataColumn columnMS1;

		private DataColumn columnDS1;

		private DataColumn columnDocLow;

		private DataColumn columnDocHigh;

		private DataColumn columnDocOpt;

		private DataColumn columnMedLow;

		private DataColumn columnMedHigh;

		private DataColumn columnMedopt;

		private DataColumn columnCategory;

		private DataColumn columntestName;

		private DataColumn columntestAbrev;

		private DataColumn columnMS2;

		private DataColumn columnDS2;

		private DataColumn columninf;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn R1Column => columnR1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn R2Column => columnR2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MS1Column => columnMS1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DS1Column => columnDS1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DocLowColumn => columnDocLow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DocHighColumn => columnDocHigh;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DocOptColumn => columnDocOpt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MedLowColumn => columnMedLow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MedHighColumn => columnMedHigh;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MedoptColumn => columnMedopt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn CategoryColumn => columnCategory;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn testNameColumn => columntestName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn testAbrevColumn => columntestAbrev;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MS2Column => columnMS2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DS2Column => columnDS2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn infColumn => columninf;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public viewWorkedRow this[int index] => (viewWorkedRow)Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event viewWorkedRowChangeEventHandler viewWorkedRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event viewWorkedRowChangeEventHandler viewWorkedRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event viewWorkedRowChangeEventHandler viewWorkedRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event viewWorkedRowChangeEventHandler viewWorkedRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public viewWorkedDataTable()
		{
			TableName = "viewWorked";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal viewWorkedDataTable(DataTable table)
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
		protected viewWorkedDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddviewWorkedRow(viewWorkedRow row)
		{
			Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public viewWorkedRow AddviewWorkedRow(double R1, double R2, double MS1, double DS1, double DocLow, double DocHigh, double DocOpt, double MedLow, double MedHigh, double Medopt, string Category, string testName, string testAbrev, double MS2, double DS2, string inf)
		{
			viewWorkedRow viewWorkedRow2 = (viewWorkedRow)NewRow();
			object[] itemArray = new object[16]
			{
				R1, R2, MS1, DS1, DocLow, DocHigh, DocOpt, MedLow, MedHigh, Medopt,
				Category, testName, testAbrev, MS2, DS2, inf
			};
			viewWorkedRow2.ItemArray = itemArray;
			Rows.Add(viewWorkedRow2);
			return viewWorkedRow2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			viewWorkedDataTable viewWorkedDataTable2 = (viewWorkedDataTable)base.Clone();
			viewWorkedDataTable2.InitVars();
			return viewWorkedDataTable2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new viewWorkedDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnR1 = Columns["R1"];
			columnR2 = Columns["R2"];
			columnMS1 = Columns["MS1"];
			columnDS1 = Columns["DS1"];
			columnDocLow = Columns["DocLow"];
			columnDocHigh = Columns["DocHigh"];
			columnDocOpt = Columns["DocOpt"];
			columnMedLow = Columns["MedLow"];
			columnMedHigh = Columns["MedHigh"];
			columnMedopt = Columns["Medopt"];
			columnCategory = Columns["Category"];
			columntestName = Columns["testName"];
			columntestAbrev = Columns["testAbrev"];
			columnMS2 = Columns["MS2"];
			columnDS2 = Columns["DS2"];
			columninf = Columns["inf"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnR1 = new DataColumn("R1", typeof(double), null, MappingType.Element);
			Columns.Add(columnR1);
			columnR2 = new DataColumn("R2", typeof(double), null, MappingType.Element);
			Columns.Add(columnR2);
			columnMS1 = new DataColumn("MS1", typeof(double), null, MappingType.Element);
			Columns.Add(columnMS1);
			columnDS1 = new DataColumn("DS1", typeof(double), null, MappingType.Element);
			Columns.Add(columnDS1);
			columnDocLow = new DataColumn("DocLow", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocLow);
			columnDocHigh = new DataColumn("DocHigh", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocHigh);
			columnDocOpt = new DataColumn("DocOpt", typeof(double), null, MappingType.Element);
			Columns.Add(columnDocOpt);
			columnMedLow = new DataColumn("MedLow", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedLow);
			columnMedHigh = new DataColumn("MedHigh", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedHigh);
			columnMedopt = new DataColumn("Medopt", typeof(double), null, MappingType.Element);
			Columns.Add(columnMedopt);
			columnCategory = new DataColumn("Category", typeof(string), null, MappingType.Element);
			Columns.Add(columnCategory);
			columntestName = new DataColumn("testName", typeof(string), null, MappingType.Element);
			Columns.Add(columntestName);
			columntestAbrev = new DataColumn("testAbrev", typeof(string), null, MappingType.Element);
			Columns.Add(columntestAbrev);
			columnMS2 = new DataColumn("MS2", typeof(double), null, MappingType.Element);
			Columns.Add(columnMS2);
			columnDS2 = new DataColumn("DS2", typeof(double), null, MappingType.Element);
			Columns.Add(columnDS2);
			columninf = new DataColumn("inf", typeof(string), null, MappingType.Element);
			Columns.Add(columninf);
			columnCategory.MaxLength = 50;
			columntestName.MaxLength = 50;
			columntestAbrev.AllowDBNull = false;
			columntestAbrev.MaxLength = 50;
			columninf.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public viewWorkedRow NewviewWorkedRow()
		{
			return (viewWorkedRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new viewWorkedRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(viewWorkedRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (viewWorkedRowChanged != null)
			{
				viewWorkedRowChanged?.Invoke(this, new viewWorkedRowChangeEvent((viewWorkedRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (viewWorkedRowChanging != null)
			{
				viewWorkedRowChanging?.Invoke(this, new viewWorkedRowChangeEvent((viewWorkedRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (viewWorkedRowDeleted != null)
			{
				viewWorkedRowDeleted?.Invoke(this, new viewWorkedRowChangeEvent((viewWorkedRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (viewWorkedRowDeleting != null)
			{
				viewWorkedRowDeleting?.Invoke(this, new viewWorkedRowChangeEvent((viewWorkedRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveviewWorkedRow(viewWorkedRow row)
		{
			Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			storeprociduresds storeprociduresds2 = new storeprociduresds();
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
			xmlSchemaAttribute.FixedValue = storeprociduresds2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "viewWorkedDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = storeprociduresds2.GetSchemaSerializable();
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

	public class view3Row : DataRow
	{
		private view3DataTable tableview3;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double R1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableview3.R1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'R1' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.R1Column] = value;
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
					return Conversions.ToDouble(this[tableview3.R2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'R2' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.R2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double MS1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableview3.MS1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MS1' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.MS1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double DS1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableview3.DS1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DS1' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.DS1Column] = value;
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
					return Conversions.ToDouble(this[tableview3.DocLowColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocLow' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.DocLowColumn] = value;
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
					return Conversions.ToDouble(this[tableview3.DocHighColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocHigh' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.DocHighColumn] = value;
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
					return Conversions.ToDouble(this[tableview3.DocOptColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocOpt' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.DocOptColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double MedLow
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableview3.MedLowColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MedLow' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.MedLowColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double MedHigh
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableview3.MedHighColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MedHigh' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.MedHighColumn] = value;
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
					return Conversions.ToDouble(this[tableview3.MedoptColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Medopt' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.MedoptColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Category
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableview3.CategoryColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Category' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.CategoryColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string testName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableview3.testNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'testName' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.testNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string testAbrev
		{
			get
			{
				return Conversions.ToString(this[tableview3.testAbrevColumn]);
			}
			set
			{
				this[tableview3.testAbrevColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double MS2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableview3.MS2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MS2' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.MS2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double DS2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableview3.DS2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DS2' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.DS2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string inf
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableview3.infColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'inf' in table 'view3' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableview3.infColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal view3Row(DataRowBuilder rb)
			: base(rb)
		{
			tableview3 = (view3DataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsR1Null()
		{
			return IsNull(tableview3.R1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetR1Null()
		{
			this[tableview3.R1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsR2Null()
		{
			return IsNull(tableview3.R2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetR2Null()
		{
			this[tableview3.R2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMS1Null()
		{
			return IsNull(tableview3.MS1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMS1Null()
		{
			this[tableview3.MS1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDS1Null()
		{
			return IsNull(tableview3.DS1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDS1Null()
		{
			this[tableview3.DS1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocLowNull()
		{
			return IsNull(tableview3.DocLowColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocLowNull()
		{
			this[tableview3.DocLowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDocHighNull()
		{
			return IsNull(tableview3.DocHighColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocHighNull()
		{
			this[tableview3.DocHighColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocOptNull()
		{
			return IsNull(tableview3.DocOptColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocOptNull()
		{
			this[tableview3.DocOptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMedLowNull()
		{
			return IsNull(tableview3.MedLowColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMedLowNull()
		{
			this[tableview3.MedLowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMedHighNull()
		{
			return IsNull(tableview3.MedHighColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMedHighNull()
		{
			this[tableview3.MedHighColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMedoptNull()
		{
			return IsNull(tableview3.MedoptColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMedoptNull()
		{
			this[tableview3.MedoptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsCategoryNull()
		{
			return IsNull(tableview3.CategoryColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCategoryNull()
		{
			this[tableview3.CategoryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstestNameNull()
		{
			return IsNull(tableview3.testNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettestNameNull()
		{
			this[tableview3.testNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMS2Null()
		{
			return IsNull(tableview3.MS2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMS2Null()
		{
			this[tableview3.MS2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDS2Null()
		{
			return IsNull(tableview3.DS2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDS2Null()
		{
			this[tableview3.DS2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsinfNull()
		{
			return IsNull(tableview3.infColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetinfNull()
		{
			this[tableview3.infColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	public class viewWorkedRow : DataRow
	{
		private viewWorkedDataTable tableviewWorked;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double R1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableviewWorked.R1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'R1' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.R1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double R2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableviewWorked.R2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'R2' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.R2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double MS1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableviewWorked.MS1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MS1' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.MS1Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double DS1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableviewWorked.DS1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DS1' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.DS1Column] = value;
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
					return Conversions.ToDouble(this[tableviewWorked.DocLowColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocLow' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.DocLowColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double DocHigh
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableviewWorked.DocHighColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocHigh' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.DocHighColumn] = value;
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
					return Conversions.ToDouble(this[tableviewWorked.DocOptColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DocOpt' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.DocOptColumn] = value;
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
					return Conversions.ToDouble(this[tableviewWorked.MedLowColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MedLow' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.MedLowColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double MedHigh
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableviewWorked.MedHighColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MedHigh' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.MedHighColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double Medopt
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableviewWorked.MedoptColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Medopt' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.MedoptColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Category
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableviewWorked.CategoryColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'Category' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.CategoryColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string testName
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableviewWorked.testNameColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'testName' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.testNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string testAbrev
		{
			get
			{
				return Conversions.ToString(this[tableviewWorked.testAbrevColumn]);
			}
			set
			{
				this[tableviewWorked.testAbrevColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double MS2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableviewWorked.MS2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MS2' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.MS2Column] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double DS2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(this[tableviewWorked.DS2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DS2' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.DS2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string inf
		{
			get
			{
				try
				{
					return Conversions.ToString(this[tableviewWorked.infColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'inf' in table 'viewWorked' is DBNull.", innerException);
				}
			}
			set
			{
				this[tableviewWorked.infColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal viewWorkedRow(DataRowBuilder rb)
			: base(rb)
		{
			tableviewWorked = (viewWorkedDataTable)Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsR1Null()
		{
			return IsNull(tableviewWorked.R1Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetR1Null()
		{
			this[tableviewWorked.R1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsR2Null()
		{
			return IsNull(tableviewWorked.R2Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetR2Null()
		{
			this[tableviewWorked.R2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMS1Null()
		{
			return IsNull(tableviewWorked.MS1Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMS1Null()
		{
			this[tableviewWorked.MS1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDS1Null()
		{
			return IsNull(tableviewWorked.DS1Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDS1Null()
		{
			this[tableviewWorked.DS1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocLowNull()
		{
			return IsNull(tableviewWorked.DocLowColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocLowNull()
		{
			this[tableviewWorked.DocLowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDocHighNull()
		{
			return IsNull(tableviewWorked.DocHighColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDocHighNull()
		{
			this[tableviewWorked.DocHighColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDocOptNull()
		{
			return IsNull(tableviewWorked.DocOptColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDocOptNull()
		{
			this[tableviewWorked.DocOptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMedLowNull()
		{
			return IsNull(tableviewWorked.MedLowColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMedLowNull()
		{
			this[tableviewWorked.MedLowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMedHighNull()
		{
			return IsNull(tableviewWorked.MedHighColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMedHighNull()
		{
			this[tableviewWorked.MedHighColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMedoptNull()
		{
			return IsNull(tableviewWorked.MedoptColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMedoptNull()
		{
			this[tableviewWorked.MedoptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCategoryNull()
		{
			return IsNull(tableviewWorked.CategoryColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetCategoryNull()
		{
			this[tableviewWorked.CategoryColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstestNameNull()
		{
			return IsNull(tableviewWorked.testNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettestNameNull()
		{
			this[tableviewWorked.testNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMS2Null()
		{
			return IsNull(tableviewWorked.MS2Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetMS2Null()
		{
			this[tableviewWorked.MS2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDS2Null()
		{
			return IsNull(tableviewWorked.DS2Column);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDS2Null()
		{
			this[tableviewWorked.DS2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsinfNull()
		{
			return IsNull(tableviewWorked.infColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetinfNull()
		{
			this[tableviewWorked.infColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class view3RowChangeEvent : EventArgs
	{
		private view3Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public view3Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public view3RowChangeEvent(view3Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class viewWorkedRowChangeEvent : EventArgs
	{
		private viewWorkedRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public viewWorkedRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public viewWorkedRowChangeEvent(viewWorkedRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private view3DataTable tableview3;

	private viewWorkedDataTable tableviewWorked;

	private SchemaSerializationMode _schemaSerializationMode;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public view3DataTable view3 => tableview3;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public viewWorkedDataTable viewWorked => tableviewWorked;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	public storeprociduresds()
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
	protected storeprociduresds(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["view3"] != null)
			{
				base.Tables.Add(new view3DataTable(dataSet.Tables["view3"]));
			}
			if (dataSet.Tables["viewWorked"] != null)
			{
				base.Tables.Add(new viewWorkedDataTable(dataSet.Tables["viewWorked"]));
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
		storeprociduresds storeprociduresds2 = (storeprociduresds)base.Clone();
		storeprociduresds2.InitVars();
		storeprociduresds2.SchemaSerializationMode = SchemaSerializationMode;
		return storeprociduresds2;
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
			if (dataSet.Tables["view3"] != null)
			{
				base.Tables.Add(new view3DataTable(dataSet.Tables["view3"]));
			}
			if (dataSet.Tables["viewWorked"] != null)
			{
				base.Tables.Add(new viewWorkedDataTable(dataSet.Tables["viewWorked"]));
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
		tableview3 = (view3DataTable)base.Tables["view3"];
		if (initTable && tableview3 != null)
		{
			tableview3.InitVars();
		}
		tableviewWorked = (viewWorkedDataTable)base.Tables["viewWorked"];
		if (initTable && tableviewWorked != null)
		{
			tableviewWorked.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		DataSetName = "storeprociduresds";
		Prefix = "";
		Namespace = "http://tempuri.org/storeprociduresds.xsd";
		EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableview3 = new view3DataTable();
		base.Tables.Add(tableview3);
		tableviewWorked = new viewWorkedDataTable();
		base.Tables.Add(tableviewWorked);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeview3()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeviewWorked()
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
		storeprociduresds storeprociduresds2 = new storeprociduresds();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = storeprociduresds2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = storeprociduresds2.GetSchemaSerializable();
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
