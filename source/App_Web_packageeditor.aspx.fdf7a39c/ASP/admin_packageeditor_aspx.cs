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
public class admin_packageeditor_aspx : Admin_packageEditor
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_packageeditor_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/packageEditor.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/packageEditor.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/packageEditor.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <style type=\"text/css\">\r\n        .style2\r\n        {\r\n            width: 100%;\r\n        }\r\n        .style3\r\n        {\r\n            width: 253px;\r\n        }\r\n    </style>\r\n"));
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowEditButton = true;
		val.ShowSelectButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Packname";
		val.HeaderText = "Packname";
		((DataControlField)val).SortExpression = "Packname";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "packdescription";
		val.HeaderText = "packdescription";
		((DataControlField)val).SortExpression = "packdescription";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "packprice";
		val.HeaderText = "packprice";
		((DataControlField)val).SortExpression = "packprice";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "packcomments";
		val.HeaderText = "packcomments";
		((DataControlField)val).SortExpression = "packcomments";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "packid";
		val.HeaderText = "packid";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "packid";
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LinkButton val = new LinkButton();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton1";
		val.CausesValidation = false;
		val.CommandName = "Delete";
		val.OnClientClick = "return confirm(\"Are you sure you want to delete this entry?\");";
		val.Text = "Delete";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control10(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		LinkButton val = __BuildControl__control11();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control10, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).ShowHeader = false;
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
		BoundField val6 = __BuildControl__control8();
		__ctrl.Add((DataControlField)(object)val6);
		TemplateField val7 = __BuildControl__control9();
		__ctrl.Add((DataControlField)(object)val7);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView1 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AllowSorting = true;
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[1] { "packid" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control2(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlpnamenew()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (pnamenew = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "pnamenew";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlpdescnew()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (pdescnew = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "pdescnew";
		Unit height = new Unit(73.0, (UnitType)1);
		((WebControl)val).Height = height;
		height = new Unit(333.0, (UnitType)1);
		((WebControl)val).Width = height;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlppricenew()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (ppricenew = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "ppricenew";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlpcomment()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (pcomment = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "pcomment";
		Unit width = new Unit(333.0, (UnitType)1);
		((WebControl)val).Width = width;
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
		val.Text = "Add as a new package";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control12(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control13();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "pnamenew";
		((Parameter)val).Name = "Packname";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "pdescnew";
		((Parameter)val).Name = "packdescription";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "ppricenew";
		((Parameter)val).Name = "packprice";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.Decimal;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "pcomment";
		((Parameter)val).Name = "packcomments";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control14(ParameterCollection __ctrl)
	{
		ControlParameter val = __BuildControl__control15();
		__ctrl.Add((Parameter)(object)val);
		ControlParameter val2 = __BuildControl__control16();
		__ctrl.Add((Parameter)(object)val2);
		ControlParameter val3 = __BuildControl__control17();
		__ctrl.Add((Parameter)(object)val3);
		ControlParameter val4 = __BuildControl__control18();
		__ctrl.Add((Parameter)(object)val4);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Packname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packdescription";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packprice";
		val.Type = TypeCode.Decimal;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packcomments";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packid";
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
		Parameter val5 = __BuildControl__control24();
		__ctrl.Add(val5);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [package] WHERE [packid] = @packid";
		val.InsertCommand = "INSERT INTO [package] ([Packname], [packdescription], [packprice], [packcomments]) VALUES (@Packname, @packdescription, @packprice, @packcomments)";
		val.SelectCommand = "SELECT [Packname], [packdescription], [packprice], [packcomments], [packid] FROM [package]";
		val.UpdateCommand = "UPDATE [package] SET [Packname] = @Packname, [packdescription] = @packdescription, [packprice] = @packprice, [packcomments] = @packcomments WHERE [packid] = @packid";
		__BuildControl__control12(val.DeleteParameters);
		__BuildControl__control14(val.InsertParameters);
		__BuildControl__control19(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
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
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		GridView val4 = __BuildControlGridView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <br />\r\n            <strong>Add a new package:</strong><br />\r\n            <table>\r\n                <tr>\r\n                    <td>\r\n                        Package Name:</td>\r\n                    <td>\r\n                        "));
		TextBox val5 = __BuildControlpnamenew();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Description:</td>\r\n                    <td>\r\n                        "));
		TextBox val6 = __BuildControlpdescnew();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Price:</td>\r\n                    <td>\r\n                        "));
		TextBox val7 = __BuildControlppricenew();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Comments:</td>\r\n                    <td>\r\n                        "));
		TextBox val8 = __BuildControlpcomment();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        &nbsp;</td>\r\n                    <td>\r\n                        "));
		Button val9 = __BuildControlButton2();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n            <br />\r\n            "));
		SqlDataSource val10 = __BuildControlSqlDataSource1();
		val3.AddParsedSubObject((object)val10);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlpname()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (pname = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "pname";
		val.Text = "Label";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlpid()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (pid = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "pid";
		val.Text = "Label";
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControltestList()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (testList = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "testList";
		Unit width = new Unit(287.0, (UnitType)1);
		((WebControl)val).Width = width;
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
		val.Text = "Add test to the package";
		return val;
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowDeleteButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "testAbrev";
		val.HeaderText = "testAbrev";
		((DataControlField)val).SortExpression = "testAbrev";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control25(DataControlFieldCollection __ctrl)
	{
		CommandField val = __BuildControl__control26();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control27();
		__ctrl.Add((DataControlField)(object)val2);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView2 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView2";
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[1] { "pid" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource2";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control25(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control28(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control29();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "pid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control30(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control31();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control32(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control33();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control34();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control36()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "pid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control35(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control36();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control37();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control38();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource2 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource2";
		val.DeleteCommand = "DELETE FROM [packagedata] WHERE [pid] = @pid";
		val.InsertCommand = "INSERT INTO [packagedata] ([packid], [testAbrev]) VALUES (@packid, @testAbrev)";
		val.SelectCommand = "SELECT [packid], [testAbrev], [pid] FROM [packagedata] WHERE ([packid] = @packid)";
		val.UpdateCommand = "UPDATE [packagedata] SET [packid] = @packid, [testAbrev] = @testAbrev WHERE [pid] = @pid";
		__BuildControl__control28(val.SelectParameters);
		__BuildControl__control30(val.DeleteParameters);
		__BuildControl__control32(val.InsertParameters);
		__BuildControl__control35(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView2()
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
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <table class=\"style2\">\r\n                <tr>\r\n                    <td class=\"style3\">\r\n                        Package Name:\r\n                        "));
		Label val4 = __BuildControlpname();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                    <td>\r\n                        Package ID:\r\n                        "));
		Label val5 = __BuildControlpid();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"style3\">\r\n                        "));
		DropDownList val6 = __BuildControltestList();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                    <td>\r\n                        "));
		Button val7 = __BuildControlButton1();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"2\">\r\n                        "));
		GridView val8 = __BuildControlGridView2();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n            "));
		SqlDataSource val9 = __BuildControlSqlDataSource2();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
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
	private void __BuildControlContent2(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		MultiView val = __BuildControlMultiView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_packageeditor_aspx __ctrl)
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
		return 1627273962;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
