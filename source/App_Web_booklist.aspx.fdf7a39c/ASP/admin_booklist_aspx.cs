using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

namespace ASP;

[CompilerGlobalScope]
public class admin_booklist_aspx : Admin_booklist
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_booklist_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/booklist.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/booklist.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/booklist.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <link href=\"tabs.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n    "));
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control3(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        View/Edit\r\n                    "));
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bookreid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control5(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control6();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bookname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "authur";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "datepublished";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "pagenum";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "note";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "F1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bookreid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control7(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control8();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control9();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control10();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control11();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control12();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control13();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control14();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control15();
		__ctrl.Add(val8);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bookname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "authur";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "datepublished";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "pagenum";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "note";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "F1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bookreid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control16(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control17();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control18();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control19();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control20();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control21();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control22();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control23();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control24();
		__ctrl.Add(val8);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [testbookref] WHERE [bookreid] = @bookreid";
		val.InsertCommand = "INSERT INTO [testbookref] ([testAbrev], [bookname], [authur], [datepublished], [pagenum], [note], [F1], [bookreid]) VALUES (@testAbrev, @bookname, @authur, @datepublished, @pagenum, @note, @F1, @bookreid)";
		val.SelectCommand = "SELECT [testAbrev], [bookname], [authur], [datepublished], [pagenum], [note], [F1], [bookreid] FROM [testbookref]";
		val.UpdateCommand = "UPDATE [testbookref] SET [testAbrev] = @testAbrev, [bookname] = @bookname, [authur] = @authur, [datepublished] = @datepublished, [pagenum] = @pagenum, [note] = @note, [F1] = @F1 WHERE [bookreid] = @bookreid";
		__BuildControl__control5(val.DeleteParameters);
		__BuildControl__control7(val.InsertParameters);
		__BuildControl__control16(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowEditButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = new DropDownList();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DropDownList2";
		((DataBoundControl)val).DataSourceID = "SqlDataSource3";
		((ListControl)val).DataTextField = "testName";
		Unit width = new Unit(167.0, (UnitType)1);
		((WebControl)val).Width = width;
		((DataBoundControl)val).DataMember = "DefaultView";
		((ListControl)val).DataValueField = "testAbrev";
		((Control)val).DataBinding += __DataBinding__control29;
		return val;
	}

	public void __DataBinding__control29(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		DropDownList val = (DropDownList)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			((ListControl)val).SelectedValue = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("testAbrev")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control31(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control32();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control33(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control34();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control35();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control36(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control37();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control38();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = new SqlDataSource();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource3";
		val.DeleteCommand = "DELETE FROM [TestRef] WHERE [testAbrev] = @testAbrev";
		val.InsertCommand = "INSERT INTO [TestRef] ([testName], [testAbrev]) VALUES (@testName, @testAbrev)";
		val.SelectCommand = "SELECT [testName], [testAbrev] FROM [TestRef]";
		val.UpdateCommand = "UPDATE [TestRef] SET [testName] = @testName WHERE [testAbrev] = @testAbrev";
		__BuildControl__control31(val.DeleteParameters);
		__BuildControl__control33(val.InsertParameters);
		__BuildControl__control36(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control28(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                           "));
		DropDownList val = __BuildControl__control29();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                           "));
		SqlDataSource val2 = __BuildControl__control30();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                       "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control28(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		DropDownList val = (DropDownList)__container.FindControl("DropDownList2");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["testAbrev"] = ((ListControl)val).SelectedValue;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label1";
		((Control)val).DataBinding += __DataBinding__control40;
		return val;
	}

	public void __DataBinding__control40(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("testAbrev")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control39(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                           "));
		Label val = __BuildControl__control40();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                       "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control39(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		Label val = (Label)__container.FindControl("Label1");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["testAbrev"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control28, (ExtractTemplateValuesMethod)__ExtractValues__control28);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control39, (ExtractTemplateValuesMethod)__ExtractValues__control39);
		((DataControlField)val).HeaderText = "testAbrev";
		((DataControlField)val).SortExpression = "testAbrev";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control41()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "bookname";
		val.HeaderText = "bookname";
		((DataControlField)val).SortExpression = "bookname";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control42()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "authur";
		val.HeaderText = "authur";
		((DataControlField)val).SortExpression = "authur";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "datepublished";
		val.HeaderText = "datepublished";
		((DataControlField)val).SortExpression = "datepublished";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "pagenum";
		val.HeaderText = "pagenum";
		((DataControlField)val).SortExpression = "pagenum";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "note";
		val.HeaderText = "note";
		((DataControlField)val).SortExpression = "note";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "F1";
		val.HeaderText = "F1";
		((DataControlField)val).SortExpression = "F1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control47()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "bookreid";
		val.HeaderText = "bookreid";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "bookreid";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control25(DataControlFieldCollection __ctrl)
	{
		CommandField val = __BuildControl__control26();
		__ctrl.Add((DataControlField)(object)val);
		TemplateField val2 = __BuildControl__control27();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control41();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control42();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control43();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control44();
		__ctrl.Add((DataControlField)(object)val6);
		BoundField val7 = __BuildControl__control45();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control46();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control47();
		__ctrl.Add((DataControlField)(object)val9);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView1 = new GridView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AllowSorting = true;
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[1] { "bookreid" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control25(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control4(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                       <div >  \r\n                           "));
		SqlDataSource val = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                           "));
		GridView val2 = __BuildControlGridView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        </div>\r\n                    "));
	}

	[DebuggerNonUserCode]
	private TabPanel __BuildControlTabPanel1()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		TabPanel tabPanel = (TabPanel1 = new TabPanel());
		((Control)tabPanel).ApplyStyleSheetSkin((Page)(object)this);
		tabPanel.HeaderTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control3);
		tabPanel.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control4);
		tabPanel.HeaderText = "View/Edit";
		((Control)tabPanel).ID = "TabPanel1";
		return tabPanel;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control48(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        Add a New Book Reference\r\n                    "));
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlDropDownList1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (DropDownList1 = new DropDownList());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DropDownList1";
		((DataBoundControl)val).DataSourceID = "SqlDataSource2";
		((ListControl)val).DataTextField = "testName";
		((ListControl)val).DataValueField = "testAbrev";
		Unit width = new Unit(289.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control51()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control50(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control51();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control53()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control54()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control52(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control53();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control54();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control56()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control57()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control55(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control56();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control57();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource2 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource2";
		val.DeleteCommand = "DELETE FROM [TestRef] WHERE [testAbrev] = @testAbrev";
		val.InsertCommand = "INSERT INTO [TestRef] ([testName], [testAbrev]) VALUES (@testName, @testAbrev)";
		val.SelectCommand = "SELECT [testName], [testAbrev] FROM [TestRef]";
		val.UpdateCommand = "UPDATE [TestRef] SET [testName] = @testName WHERE [testAbrev] = @testAbrev";
		__BuildControl__control50(val.DeleteParameters);
		__BuildControl__control52(val.InsertParameters);
		__BuildControl__control55(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControltbookname()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (tbookname = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tbookname";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTpnum()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tpnum = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tpnum";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControltdatepub()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (tdatepub = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tdatepub";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControltAuthor()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (tAuthor = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tAuthor";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControltnote()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (tnote = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tnote";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControltresearch()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (tresearch = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tresearch";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlSubmitbtn()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Submitbtn = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Submitbtn";
		val.Text = "Submit";
		Unit width = new Unit(159.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control49(Control __ctrl)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 364, true));
		DropDownList val = __BuildControlDropDownList1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
		SqlDataSource val2 = __BuildControlSqlDataSource2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(364, 362, true));
		TextBox val3 = __BuildControltbookname();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(726, 364, true));
		TextBox val4 = __BuildControlTpnum();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1090, 367, true));
		TextBox val5 = __BuildControltdatepub();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1457, 359, true));
		TextBox val6 = __BuildControltAuthor();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val6);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1816, 357, true));
		TextBox val7 = __BuildControltnote();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val7);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2173, 366, true));
		TextBox val8 = __BuildControltresearch();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val8);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2539, 358, true));
		Button val9 = __BuildControlSubmitbtn();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val9);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2897, 375, true));
	}

	[DebuggerNonUserCode]
	private TabPanel __BuildControlTabPanel2()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		TabPanel tabPanel = (TabPanel2 = new TabPanel());
		((Control)tabPanel).ApplyStyleSheetSkin((Page)(object)this);
		tabPanel.HeaderTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control48);
		tabPanel.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control49);
		tabPanel.HeaderText = "Add a New Book Reference";
		((Control)tabPanel).ID = "TabPanel2";
		return tabPanel;
	}

	[DebuggerNonUserCode]
	private TabContainer __BuildControlTabContainer1()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		TabContainer tabContainer = (TabContainer1 = new TabContainer());
		((Control)tabContainer).TemplateControl = (TemplateControl)(object)this;
		((Control)tabContainer).ApplyStyleSheetSkin((Page)(object)this);
		((Control)tabContainer).ID = "TabContainer1";
		tabContainer.ActiveTabIndex = 0;
		tabContainer.CssClass = "ajax__tab_technorati-theme";
		IParserAccessor val = (IParserAccessor)(object)tabContainer;
		val.AddParsedSubObject((object)new LiteralControl("\r\n                "));
		TabPanel tabPanel = __BuildControlTabPanel1();
		val.AddParsedSubObject((object)tabPanel);
		val.AddParsedSubObject((object)new LiteralControl("\r\n                  "));
		TabPanel tabPanel2 = __BuildControlTabPanel2();
		val.AddParsedSubObject((object)tabPanel2);
		val.AddParsedSubObject((object)new LiteralControl(">\r\n            "));
		return tabContainer;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n       \r\n            "));
		TabContainer tabContainer = __BuildControlTabContainer1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)tabContainer);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n        "));
	}

	[DebuggerNonUserCode]
	private UpdatePanel __BuildControlUpdatePanel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		UpdatePanel val = (UpdatePanel1 = new UpdatePanel());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		val.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control2);
		((Control)val).ID = "UpdatePanel1";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent2(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		UpdatePanel val = __BuildControlUpdatePanel1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_booklist_aspx __ctrl)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		((Page)__ctrl).EnableEventValidation = true;
		((Page)__ctrl).Title = "";
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("head", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent2));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n    "));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).FrameworkInitialize();
		((TemplateControl)this).SetStringResourcePointer(RuntimeHelpers.GetObjectValue(__stringResource), 0);
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 1498105048;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
