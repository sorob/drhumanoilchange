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
public class admin_medman_aspx : Admin_medman
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_medman_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/medman.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/medman.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/medman.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <style type=\"text/css\">\r\n        .style1\r\n        {\r\n            width: 100%;\r\n        }\r\n        .style2\r\n        {\r\n            font-size: large;\r\n        }\r\n    </style>\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                <img alt=\"\" src=\"../WAT/ajax-loader.gif\" \r\n    style=\"width: 32px; height: 32px\" class=\"style2\" /><span class=\"style2\">Loading...</span>\r\n            "));
	}

	[DebuggerNonUserCode]
	private UpdateProgress __BuildControlUpdateProgress1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		UpdateProgress val = (UpdateProgress1 = new UpdateProgress());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		val.ProgressTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control2);
		((Control)val).ID = "UpdateProgress1";
		val.AssociatedUpdatePanelID = "UpdatePanel3";
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlDropDownList1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (DropDownList1 = new DropDownList());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DropDownList1";
		((ListControl)val).AutoPostBack = true;
		((DataBoundControl)val).DataMember = "DefaultView";
		((DataBoundControl)val).DataSourceID = "SqlDataSource4";
		((ListControl)val).DataTextField = "testName";
		((ListControl)val).DataValueField = "testAbrev";
		Unit width = new Unit(280.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control4(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control5();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testName";
		val.Type = TypeCode.String;
		return val;
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
	private void __BuildControl__control6(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control7();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control8();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control9(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control10();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control11();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource4 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource4";
		val.DeleteCommand = "DELETE FROM [TestRef] WHERE [testAbrev] = @testAbrev";
		val.InsertCommand = "INSERT INTO [TestRef] ([testName], [testAbrev]) VALUES (@testName, @testAbrev)";
		val.SelectCommand = "SELECT [testName], [testAbrev] FROM [TestRef]";
		val.UpdateCommand = "UPDATE [TestRef] SET [testName] = @testName WHERE [testAbrev] = @testAbrev";
		__BuildControl__control4(val.DeleteParameters);
		__BuildControl__control6(val.InsertParameters);
		__BuildControl__control9(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control3(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
		DropDownList val = __BuildControlDropDownList1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
		SqlDataSource val2 = __BuildControlSqlDataSource4();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n            "));
	}

	[DebuggerNonUserCode]
	private UpdatePanel __BuildControlUpdatePanel3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		UpdatePanel val = (UpdatePanel3 = new UpdatePanel());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		val.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control3);
		((Control)val).ID = "UpdatePanel3";
		return val;
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowEditButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Abrev";
		val.HeaderText = "Abrev";
		((DataControlField)val).SortExpression = "Abrev";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "H_L";
		val.HeaderText = "H_L";
		((DataControlField)val).SortExpression = "H_L";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Prod_id";
		val.HeaderText = "Product ID";
		((DataControlField)val).SortExpression = "Prod_id";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Product";
		val.HeaderText = "Product";
		((DataControlField)val).SortExpression = "Product";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Dosage";
		val.HeaderText = "Dosage";
		((DataControlField)val).SortExpression = "Dosage";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Co";
		val.HeaderText = "Co";
		((DataControlField)val).SortExpression = "Co";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Order";
		val.HeaderText = "Order";
		((DataControlField)val).SortExpression = "Order";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Body_Part";
		val.HeaderText = "Body_Part";
		((DataControlField)val).SortExpression = "Body_Part";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "minScale2Show";
		val.HeaderText = "minScale2Show";
		((DataControlField)val).SortExpression = "minScale2Show";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "gender";
		val.HeaderText = "gender";
		((DataControlField)val).SortExpression = "gender";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "rxid";
		val.HeaderText = "rxid";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "rxid";
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LinkButton val = new LinkButton();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton1";
		val.CausesValidation = false;
		val.CommandName = "Delete";
		val.OnClientClick = "return confirm('Are you sure you want to delete this record? There will be no way to recover a deleted treatment.');";
		val.Text = "Delete";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control27(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		LinkButton val = __BuildControl__control28();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control27, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).ShowHeader = false;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control13(DataControlFieldCollection __ctrl)
	{
		CommandField val = __BuildControl__control14();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control15();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control16();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control17();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control18();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control19();
		__ctrl.Add((DataControlField)(object)val6);
		BoundField val7 = __BuildControl__control20();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control21();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control22();
		__ctrl.Add((DataControlField)(object)val9);
		BoundField val10 = __BuildControl__control23();
		__ctrl.Add((DataControlField)(object)val10);
		BoundField val11 = __BuildControl__control24();
		__ctrl.Add((DataControlField)(object)val11);
		BoundField val12 = __BuildControl__control25();
		__ctrl.Add((DataControlField)(object)val12);
		TemplateField val13 = __BuildControl__control26();
		__ctrl.Add((DataControlField)(object)val13);
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
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[1] { "rxid" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource2";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control13(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "DropDownList1";
		((Parameter)val).Name = "abrev";
		val.PropertyName = "SelectedValue";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control29(ParameterCollection __ctrl)
	{
		ControlParameter val = __BuildControl__control30();
		__ctrl.Add((Parameter)(object)val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rxid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control31(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control32();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "TxtAbrev";
		((Parameter)val).Name = "Abrev";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "ddhl";
		((Parameter)val).Name = "H_L";
		val.PropertyName = "SelectedValue";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control36()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "TprodId";
		((Parameter)val).Name = "prodid";
		val.PropertyName = "Text";
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tprod";
		((Parameter)val).Name = "Product";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tdosage";
		((Parameter)val).Name = "Dosage";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control39()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "TCo";
		((Parameter)val).Name = "Co";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Torder";
		((Parameter)val).Name = "Order";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control41()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tbodyp";
		((Parameter)val).Name = "Body_Part";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control42()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tminscale";
		((Parameter)val).Name = "minScale2Show";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "DropDownList2";
		((Parameter)val).Name = "gender";
		val.PropertyName = "SelectedValue";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control33(ParameterCollection __ctrl)
	{
		ControlParameter val = __BuildControl__control34();
		__ctrl.Add((Parameter)(object)val);
		ControlParameter val2 = __BuildControl__control35();
		__ctrl.Add((Parameter)(object)val2);
		ControlParameter val3 = __BuildControl__control36();
		__ctrl.Add((Parameter)(object)val3);
		ControlParameter val4 = __BuildControl__control37();
		__ctrl.Add((Parameter)(object)val4);
		ControlParameter val5 = __BuildControl__control38();
		__ctrl.Add((Parameter)(object)val5);
		ControlParameter val6 = __BuildControl__control39();
		__ctrl.Add((Parameter)(object)val6);
		ControlParameter val7 = __BuildControl__control40();
		__ctrl.Add((Parameter)(object)val7);
		ControlParameter val8 = __BuildControl__control41();
		__ctrl.Add((Parameter)(object)val8);
		ControlParameter val9 = __BuildControl__control42();
		__ctrl.Add((Parameter)(object)val9);
		ControlParameter val10 = __BuildControl__control43();
		__ctrl.Add((Parameter)(object)val10);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Abrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "H_L";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control47()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Product";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Dosage";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Co";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Order";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control51()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Body_Part";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "minScale2Show";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control53()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "gender";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control54()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rxid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control55()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Prod_id";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control44(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control45();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control46();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control47();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control48();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control49();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control50();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control51();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control52();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control53();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control54();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control55();
		__ctrl.Add(val11);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource2 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource2";
		val.DeleteCommand = "DELETE FROM [Rx] WHERE [rxid] = @rxid";
		val.InsertCommand = "INSERT INTO Rx(Abrev, H_L, [Prod-ID], Product, Dosage, Co, [Order], Body_Part, minScale2Show, gender) VALUES (@Abrev, @H_L, @prodid, @Product , @Dosage, @Co, @Order , @Body_Part, @minScale2Show, @gender)";
		val.SelectCommand = "SELECT Abrev, H_L, [Prod-ID] AS Prod_id, Product, Dosage, Co, [Order], Body_Part, minScale2Show, rxid, gender FROM Rx WHERE (Abrev = @abrev)";
		val.UpdateCommand = "UPDATE Rx SET Abrev = @Abrev, H_L = @H_L, [Prod-ID] = @Prod_id, Product = @Product , Dosage = @Dosage, Co = @Co, [Order] = @Order , Body_Part = @Body_Part, minScale2Show = @minScale2Show, gender = @gender WHERE (rxid = @rxid)";
		__BuildControl__control29(val.SelectParameters);
		__BuildControl__control31(val.DeleteParameters);
		__BuildControl__control33(val.InsertParameters);
		__BuildControl__control44(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control12(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
		GridView val = __BuildControlGridView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
		SqlDataSource val2 = __BuildControlSqlDataSource2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n            "));
	}

	[DebuggerNonUserCode]
	private UpdatePanel __BuildControlUpdatePanel2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		UpdatePanel val = (UpdatePanel2 = new UpdatePanel());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		val.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control12);
		((Control)val).ID = "UpdatePanel2";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTxtAbrev()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TxtAbrev = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TxtAbrev";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control58()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "High";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control59()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "Low";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control57(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control58();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control59();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlddhl()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (ddhl = new DropDownList());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "ddhl";
		Unit width = new Unit(122.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control57(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTprodId()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TprodId = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TprodId";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTprod()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tprod = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tprod";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTdosage()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tdosage = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tdosage";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTCo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TCo = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TCo";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTorder()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Torder = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Torder";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTbodyp()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tbodyp = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tbodyp";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTminscale()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tminscale = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tminscale";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control61()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "Male";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control62()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "Female";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control63()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "Child";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control60(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control61();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control62();
		__ctrl.Add(val2);
		ListItem val3 = __BuildControl__control63();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlDropDownList2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (DropDownList2 = new DropDownList());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DropDownList2";
		Unit width = new Unit(122.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control60(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button1 = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		val.Text = "Submit";
		Unit width = new Unit(100.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control56(Control __ctrl)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 469, true));
		TextBox val = __BuildControlTxtAbrev();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(469, 273, true));
		DropDownList val2 = __BuildControlddhl();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(742, 280, true));
		TextBox val3 = __BuildControlTprodId();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1022, 277, true));
		TextBox val4 = __BuildControlTprod();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1299, 298, true));
		TextBox val5 = __BuildControlTdosage();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1597, 272, true));
		TextBox val6 = __BuildControlTCo();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val6);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1869, 275, true));
		TextBox val7 = __BuildControlTorder();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val7);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2144, 279, true));
		TextBox val8 = __BuildControlTbodyp();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val8);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2423, 289, true));
		TextBox val9 = __BuildControlTminscale();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val9);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2712, 274, true));
		DropDownList val10 = __BuildControlDropDownList2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val10);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2986, 274, true));
		Button val11 = __BuildControlButton1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val11);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                    <td>\r\n                        &nbsp;</td>\r\n                </tr>\r\n            </table>\r\n        "));
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
		val.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control56);
		((Control)val).ID = "UpdatePanel1";
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
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <br />\r\n    \r\n    \r\n    \r\n    <p>\r\n        &nbsp;"));
		UpdateProgress val = __BuildControlUpdateProgress1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</p><p>\r\n        \r\n        "));
		UpdatePanel val2 = __BuildControlUpdatePanel3();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    </p>\r\n    <p>\r\n        "));
		UpdatePanel val3 = __BuildControlUpdatePanel2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    </p>\r\n    "));
		UpdatePanel val4 = __BuildControlUpdatePanel1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_medman_aspx __ctrl)
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
		((TemplateControl)this).SetStringResourcePointer(RuntimeHelpers.GetObjectValue(__stringResource), 0);
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 264476184;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
