using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class admin_ratioeditor_aspx : Admin_ratioEditor
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_ratioeditor_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/ratioEditor.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/ratioEditor.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/ratioEditor.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowDeleteButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "testAbrev1";
		val.HeaderText = "testAbrev1";
		((DataControlField)val).SortExpression = "testAbrev1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "testAbrev2";
		val.HeaderText = "testAbrev2";
		((DataControlField)val).SortExpression = "testAbrev2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "ratioAbrev";
		val.HeaderText = "ratioAbrev";
		((DataControlField)val).SortExpression = "ratioAbrev";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "ratioId";
		val.HeaderText = "ratioId";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "ratioId";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(DataControlFieldCollection __ctrl)
	{
		CommandField val = __BuildControl__control3();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control4();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control5();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control6();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control7();
		__ctrl.Add((DataControlField)(object)val5);
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
		val.DataKeyNames = new string[1] { "ratioId" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control2(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControltestSelector1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (testSelector1 = new DropDownList());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "testSelector1";
		((DataBoundControl)val).DataSourceID = "SqlDataSource2";
		((ListControl)val).DataTextField = "testName";
		((ListControl)val).DataValueField = "testAbrev";
		Unit width = new Unit(264.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource2 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource2";
		val.SelectCommand = "SELECT [testName], [testAbrev] FROM [TestRef]";
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiktarinConnectionString1"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControltestSelector2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (testSelector2 = new DropDownList());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "testSelector2";
		((DataBoundControl)val).DataSourceID = "SqlDataSource3";
		((ListControl)val).DataTextField = "testName";
		((ListControl)val).DataValueField = "testAbrev";
		Unit width = new Unit(264.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource3 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource3";
		val.SelectCommand = "SELECT [testName], [testAbrev] FROM [TestRef]";
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControltestSelectorRatio()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (testSelectorRatio = new DropDownList());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "testSelectorRatio";
		((DataBoundControl)val).DataSourceID = "SqlDataSource4";
		((ListControl)val).DataTextField = "testName";
		((ListControl)val).DataValueField = "testAbrev";
		Unit width = new Unit(264.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource4 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource4";
		val.SelectCommand = "SELECT [testName], [testAbrev] FROM [TestRef]";
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControladdRatio()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (addRatio = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "addRatio";
		val.Text = "Add Ratio Logic";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "ratioId";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control8(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control9();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "ratioAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control10(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control11();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control12();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control13();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "ratioAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "ratioId";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control14(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control15();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control16();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control17();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control18();
		__ctrl.Add(val4);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [ratioRef] WHERE [ratioId] = @ratioId";
		val.InsertCommand = "INSERT INTO [ratioRef] ([testAbrev1], [testAbrev2], [ratioAbrev]) VALUES (@testAbrev1, @testAbrev2, @ratioAbrev)";
		val.SelectCommand = "SELECT [testAbrev1], [testAbrev2], [ratioAbrev], [ratioId] FROM [ratioRef]";
		val.UpdateCommand = "UPDATE [ratioRef] SET [testAbrev1] = @testAbrev1, [testAbrev2] = @testAbrev2, [ratioAbrev] = @ratioAbrev WHERE [ratioId] = @ratioId";
		__BuildControl__control8(val.DeleteParameters);
		__BuildControl__control10(val.InsertParameters);
		__BuildControl__control14(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent2(Control __ctrl)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <br />\r\n    "));
		GridView val = __BuildControlGridView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <br />\r\n    Add a new Ratio Logic<table class=\"wrapper\">\r\n        <tr>\r\n            <td>\r\n                Test 1:</td>\r\n            <td>\r\n                        "));
		DropDownList val2 = __BuildControltestSelector1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		SqlDataSource val3 = __BuildControlSqlDataSource2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n            <td>\r\n                &nbsp;</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Divide By Test 2:</td>\r\n            <td>\r\n                        "));
		DropDownList val4 = __BuildControltestSelector2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		SqlDataSource val5 = __BuildControlSqlDataSource3();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n            <td>\r\n                &nbsp;</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Equals :\r\n            </td>\r\n            <td>\r\n                        "));
		DropDownList val6 = __BuildControltestSelectorRatio();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val6);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		SqlDataSource val7 = __BuildControlSqlDataSource4();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val7);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n            <td>\r\n                &nbsp;</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                &nbsp;</td>\r\n            <td>\r\n                "));
		Button val8 = __BuildControladdRatio();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val8);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n            </td>\r\n            <td>\r\n                &nbsp;</td>\r\n        </tr>\r\n    </table>\r\n    <br />\r\n    "));
		SqlDataSource val9 = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val9);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_ratioeditor_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		((Page)__ctrl).Title = "";
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("head", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent2));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).FrameworkInitialize();
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return -316696930;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
