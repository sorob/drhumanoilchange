using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConwayControls.Web;

namespace ASP;

[CompilerGlobalScope]
public class labcalc_compare_aspx : LabCalc_compare
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public labcalc_compare_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/LabCalc/compare.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/LabCalc/compare.aspx", "~/master1.master", "~/master1.master.vb", "~/LabCalc/compare.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlmsglbl()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (msglbl = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "msglbl";
		val.Text = "Select two tests to compare:";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox1";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control4(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		TextBox val = __BuildControl__control5();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
	}

	[DebuggerNonUserCode]
	private RadioButton __BuildControl__control7()
	{
		RadioButton radioButton = new RadioButton();
		((Control)radioButton).TemplateControl = (TemplateControl)(object)this;
		((Control)radioButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)radioButton).ID = "RadioButton1";
		radioButton.GroupName = "T1";
		return radioButton;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control6(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		RadioButton radioButton = __BuildControl__control7();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)radioButton);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control4, (ExtractTemplateValuesMethod)null);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control6, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).HeaderText = "1st Test";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox2";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control9(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		TextBox val = __BuildControl__control10();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
	}

	[DebuggerNonUserCode]
	private RadioButton __BuildControl__control12()
	{
		RadioButton radioButton = new RadioButton();
		((Control)radioButton).TemplateControl = (TemplateControl)(object)this;
		((Control)radioButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)radioButton).ID = "RadioButton2";
		radioButton.GroupName = "T2";
		return radioButton;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control11(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		RadioButton radioButton = __BuildControl__control12();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)radioButton);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control9, (ExtractTemplateValuesMethod)null);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control11, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).HeaderText = "2nd Test";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "datecol";
		val.HeaderText = "Date Collected";
		((DataControlField)val).SortExpression = "datecol";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "daterep";
		val.HeaderText = "Date Reported";
		((DataControlField)val).SortExpression = "daterep";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.HeaderText = "Day #";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "testid";
		val.HeaderText = "testid";
		((DataControlField)val).InsertVisible = false;
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "testid";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(DataControlFieldCollection __ctrl)
	{
		TemplateField val = __BuildControl__control3();
		__ctrl.Add((DataControlField)(object)val);
		TemplateField val2 = __BuildControl__control8();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control13();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control14();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control15();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control16();
		__ctrl.Add((DataControlField)(object)val6);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		GridView val = (GridView1 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[1] { "testid" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		((WebControl)val).Font.Bold = true;
		Unit width = new Unit(80.0, (UnitType)7);
		((WebControl)val).Width = width;
		((DataBoundControl)val).DataMember = "DefaultView";
		__BuildControl__control2(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control17(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control18();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DateCollected";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DateReported";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control19(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control20();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control21();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control22();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control23();
		__ctrl.Add(val4);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control24(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control25();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DateCollected";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DateReported";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control26(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control27();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control28();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control29();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [Tests] WHERE [testid] = @testid";
		val.InsertCommand = "INSERT INTO [Tests] ([UserName], [DateCollected], [DateReported]) VALUES (@UserName, @DateCollected, @DateReported)";
		val.SelectCommand = "SELECT UserName, CONVERT (char(10), DateCollected, 101) AS datecol, testid, CONVERT (char(10), DateReported, 101) AS daterep FROM Tests WHERE (UserName = @UserName) ORDER BY DateCollected";
		val.UpdateCommand = "UPDATE [Tests] SET [UserName] = @UserName, [DateCollected] = @DateCollected, [DateReported] = @DateReported WHERE [testid] = @testid";
		__BuildControl__control17(val.DeleteParameters);
		__BuildControl__control19(val.UpdateParameters);
		__BuildControl__control24(val.SelectParameters);
		__BuildControl__control26(val.InsertParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button1 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		val.Text = "Compare";
		((IAttributeAccessor)val).SetAttribute("style", "height: 26px");
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button2 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button2";
		val.Text = "Complete Report";
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <br />\r\n            "));
		Label val4 = __BuildControlmsglbl();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <br />\r\n            <br />\r\n            "));
		GridView val5 = __BuildControlGridView1();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		SqlDataSource val6 = __BuildControlSqlDataSource1();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		Button val7 = __BuildControlButton1();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		Button val8 = __BuildControlButton2();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        <div style=\"background-color: White\">\r\n            <br />\r\n     </div>       "));
		return val;
	}

	[DebuggerNonUserCode]
	private MultiView __BuildControlMultiView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		MultiView val = (MultiView1 = new MultiView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "MultiView1";
		val.ActiveViewIndex = 0;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val4 = __BuildControlView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val5 = __BuildControlView2();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    &nbsp;\r\n    "));
		MultiView val = __BuildControlMultiView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(labcalc_compare_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Human Oil Change";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).StyleSheetTheme = "Theme1";
		((Page)this).FrameworkInitialize();
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return -675395953;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
