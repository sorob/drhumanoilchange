using System;
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
public class labcalc_default_aspx : LabCalc_Default
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public labcalc_default_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/LabCalc/Default.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/LabCalc/Default.aspx", "~/master1.master", "~/master1.master.vb", "~/LabCalc/Default.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label2 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label2";
		((WebControl)val).Font.Bold = true;
		val.Text = "Label";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButtonadd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Buttonadd = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Buttonadd";
		val.Text = "Add a new Lab Result Manually";
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
		val.Text = "Upload Lab Results";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button5 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button5";
		val.Text = "One by One Data Entry";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button4 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button4";
		val.Text = "Review Previous Tests";
		Unit width = new Unit(177.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button6 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button6";
		val.Text = "Compare Tests";
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 509, true));
		Label val4 = __BuildControlLabel2();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(509, 734, true));
		Button val5 = __BuildControlButtonadd();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("&nbsp;"));
		Button val6 = __BuildControlButton2();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("<br />\r\n                "));
		Button val7 = __BuildControlButton5();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)new LiteralControl("<br />\r\n                <br />\r\n                You can also review your previous tests:<br />\r\n                "));
		Button val8 = __BuildControlButton4();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("&nbsp;"));
		Button val9 = __BuildControlButton6();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)new LiteralControl("<br />\r\n            "));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTextBox1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TextBox1 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox1";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender1()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender1 = new MaskedEditExtender());
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender1";
		maskedEditExtender.MaskType = MaskedEditType.Date;
		((ExtenderControl)maskedEditExtender).TargetControlID = "TextBox1";
		maskedEditExtender.Mask = "99/99/9999";
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator1()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator1 = new MaskedEditValidator());
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator1";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TextBox1";
		maskedEditValidator.ControlExtender = "MaskedEditExtender1";
		maskedEditValidator.EmptyValueMessage = "Please enter a date";
		maskedEditValidator.InvalidValueMessage = "Please enter a valid date";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTextBox2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TextBox2 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox2";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender2()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender2 = new MaskedEditExtender());
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender2";
		maskedEditExtender.MaskType = MaskedEditType.Date;
		((ExtenderControl)maskedEditExtender).TargetControlID = "TextBox2";
		maskedEditExtender.Mask = "99/99/9999";
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator2()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator2 = new MaskedEditValidator());
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator2";
		maskedEditValidator.ControlExtender = "MaskedEditExtender2";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TextBox2";
		maskedEditValidator.EmptyValueMessage = "Please enter a date";
		maskedEditValidator.InvalidValueMessage = "Please enter a valid date";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlDropDownList1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (DropDownList1 = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DropDownList1";
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		((ListControl)val).DataTextField = "Packname";
		((ListControl)val).DataValueField = "packid";
		Unit width = new Unit(263.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control3();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Packname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packdescription";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packprice";
		val.Type = TypeCode.Decimal;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packcomments";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control4(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control5();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control6();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control7();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control8();
		__ctrl.Add(val4);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Packname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packdescription";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packprice";
		val.Type = TypeCode.Decimal;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packcomments";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control9(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control10();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control11();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control12();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control13();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control14();
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
		__BuildControl__control2(val.DeleteParameters);
		__BuildControl__control4(val.InsertParameters);
		__BuildControl__control9(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button1 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		val.Text = "Next >>>";
		Unit width = new Unit(193.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1243, 581, true));
		TextBox val4 = __BuildControlTextBox1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		MaskedEditExtender maskedEditExtender = __BuildControlMaskedEditExtender1();
		val3.AddParsedSubObject((object)maskedEditExtender);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		MaskedEditValidator maskedEditValidator = __BuildControlMaskedEditValidator1();
		val3.AddParsedSubObject((object)maskedEditValidator);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1824, 273, true));
		TextBox val5 = __BuildControlTextBox2();
		val3.AddParsedSubObject((object)val5);
		MaskedEditExtender maskedEditExtender2 = __BuildControlMaskedEditExtender2();
		val3.AddParsedSubObject((object)maskedEditExtender2);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		MaskedEditValidator maskedEditValidator2 = __BuildControlMaskedEditValidator2();
		val3.AddParsedSubObject((object)maskedEditValidator2);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td width=\"50\">\r\n                            <b>Package:</b></td>\r\n                        <td style=\"width: 100px\">\r\n                            "));
		DropDownList val6 = __BuildControlDropDownList1();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		SqlDataSource val7 = __BuildControlSqlDataSource1();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2097, 273, true));
		Button val8 = __BuildControlButton1();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            "));
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender3()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender3 = new MaskedEditExtender());
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender3";
		maskedEditExtender.Mask = "99/99/9999";
		maskedEditExtender.MaskType = MaskedEditType.Date;
		((ExtenderControl)maskedEditExtender).TargetControlID = "TextBox3";
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTextBox3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TextBox3 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox3";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator3()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator3 = new MaskedEditValidator());
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator3";
		maskedEditValidator.ControlExtender = "MaskedEditExtender3";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TextBox1";
		maskedEditValidator.EmptyValueMessage = "Please enter a date";
		maskedEditValidator.InvalidValueMessage = "Please enter a valid date";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTextBox4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TextBox4 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox4";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator4()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator4 = new MaskedEditValidator());
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator4";
		maskedEditValidator.ControlExtender = "MaskedEditExtender4";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TextBox1";
		maskedEditValidator.EmptyValueMessage = "Please enter a date";
		maskedEditValidator.InvalidValueMessage = "Please enter a valid date";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlDropDownList2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (DropDownList2 = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DropDownList2";
		((DataBoundControl)val).DataSourceID = "SqlDataSource2";
		((ListControl)val).DataTextField = "Packname";
		((ListControl)val).DataValueField = "packid";
		Unit width = new Unit(263.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private FileUpload __BuildControlFileUpload1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		FileUpload val = (FileUpload1 = new FileUpload());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "FileUpload1";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button3 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button3";
		val.Text = "Upload";
		Unit width = new Unit(102.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender4()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender4 = new MaskedEditExtender());
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender4";
		maskedEditExtender.Mask = "99/99/9999";
		maskedEditExtender.MaskType = MaskedEditType.Date;
		((ExtenderControl)maskedEditExtender).TargetControlID = "TextBox4";
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control15(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control16();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Packname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packdescription";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packprice";
		val.Type = TypeCode.Decimal;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packcomments";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control17(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control18();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control19();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control20();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control21();
		__ctrl.Add(val4);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Packname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packdescription";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packprice";
		val.Type = TypeCode.Decimal;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packcomments";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "packid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control22(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control23();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control24();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control25();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control26();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control27();
		__ctrl.Add(val5);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource2 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource2";
		val.DeleteCommand = "DELETE FROM [package] WHERE [packid] = @packid";
		val.InsertCommand = "INSERT INTO [package] ([Packname], [packdescription], [packprice], [packcomments]) VALUES (@Packname, @packdescription, @packprice, @packcomments)";
		val.SelectCommand = "SELECT [Packname], [packdescription], [packprice], [packcomments], [packid] FROM [package]";
		val.UpdateCommand = "UPDATE [package] SET [Packname] = @Packname, [packdescription] = @packdescription, [packprice] = @packprice, [packcomments] = @packcomments WHERE [packid] = @packid";
		__BuildControl__control15(val.DeleteParameters);
		__BuildControl__control17(val.InsertParameters);
		__BuildControl__control22(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		View val = (View3 = new View());
		((Control)val).ID = "View3";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                <strong>Please upload your lab results in .TXT format.<br />\r\n                </strong>&nbsp;&nbsp;\r\n                <br />\r\n                &nbsp;"));
		MaskedEditExtender maskedEditExtender = __BuildControlMaskedEditExtender3();
		val3.AddParsedSubObject((object)maskedEditExtender);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2370, 272, true));
		TextBox val4 = __BuildControlTextBox3();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        </td>\r\n                        <td>\r\n                            "));
		MaskedEditValidator maskedEditValidator = __BuildControlMaskedEditValidator3();
		val3.AddParsedSubObject((object)maskedEditValidator);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2642, 265, true));
		TextBox val5 = __BuildControlTextBox4();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        </td>\r\n                        <td>\r\n                            "));
		MaskedEditValidator maskedEditValidator2 = __BuildControlMaskedEditValidator4();
		val3.AddParsedSubObject((object)maskedEditValidator2);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"style3\">\r\n                            Package:</td>\r\n                        <td class=\"style4\">\r\n                            "));
		DropDownList val6 = __BuildControlDropDownList2();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2907, 316, true));
		FileUpload val7 = __BuildControlFileUpload1();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        </td>\r\n                        <td>\r\n                            "));
		Button val8 = __BuildControlButton3();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n                <br />            &nbsp;"));
		MaskedEditExtender maskedEditExtender2 = __BuildControlMaskedEditExtender4();
		val3.AddParsedSubObject((object)maskedEditExtender2);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    \r\n                &nbsp;<br />\r\n                <br /><div>\r\n                \r\n                    "));
		SqlDataSource val9 = __BuildControlSqlDataSource2();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                \r\n                </div>\r\n                &nbsp;<div>\r\n                </div>\r\n            "));
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
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		MultiView val = (MultiView1 = new MultiView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "MultiView1";
		val.ActiveViewIndex = 0;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		View val4 = __BuildControlView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		View val5 = __BuildControlView2();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		View val6 = __BuildControlView3();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <div style=\"position: static; width: 99%; height: 100%; overflow: auto; padding-right: 2px;\r\n        padding-left: 2px; padding-bottom: 2px; padding-top: 2px;\">\r\n        "));
		MultiView val = __BuildControlMultiView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n        &nbsp;&nbsp;\r\n    </div>\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent2(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n    <style type=\"text/css\">\r\n        .style2\r\n        {\r\n            width: 100%;\r\n        }\r\n        .style3\r\n        {\r\n            width: 165px;\r\n        }\r\n        .style4\r\n        {\r\n            width: 272px;\r\n        }\r\n    </style>\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(labcalc_default_aspx __ctrl)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Mental StressTester :: Online Lab";
		((Page)__ctrl).Theme = "Theme1";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((Page)this).AddContentTemplate("head", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent2));
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
		return 1787986809;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
