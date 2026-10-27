using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.Web.UI.Compatibility;

namespace ASP;

[CompilerGlobalScope]
public class contact_aspx : Contact
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public contact_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Contact.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Contact.aspx", "~/master1.master", "~/master1.master.vb", "~/Contact.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private ValidationSummary __BuildControlValidationSummary1()
	{
		ValidationSummary validationSummary = (ValidationSummary1 = new ValidationSummary());
		((Control)validationSummary).ApplyStyleSheetSkin((Page)(object)this);
		((Control)validationSummary).ID = "ValidationSummary1";
		return validationSummary;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label1 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label1";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "Management";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control3();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlDropDownList1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (DropDownList1 = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DropDownList1";
		Unit width = new Unit(156.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control2(((ListControl)val).Items);
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
	private RequiredFieldValidator __BuildControlRequiredFieldValidator2()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator2 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator2";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "TextBox1";
		((BaseValidator)requiredFieldValidator).Display = (ValidatorDisplay)2;
		((BaseValidator)requiredFieldValidator).ErrorMessage = "Please enter your namr";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
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
	private RequiredFieldValidator __BuildControlRequiredFieldValidator3()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator3 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator3";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "TextBox4";
		((BaseValidator)requiredFieldValidator).Display = (ValidatorDisplay)2;
		((BaseValidator)requiredFieldValidator).ErrorMessage = "Please enter your email address";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private CustomValidator __BuildControlCustomValidator1()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		CustomValidator customValidator = (CustomValidator1 = new CustomValidator());
		((Control)customValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)customValidator).ID = "CustomValidator1";
		((BaseValidator)customValidator).ErrorMessage = "Invalid E-mail Address";
		IParserAccessor val = (IParserAccessor)(object)customValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return customValidator;
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
	private RequiredFieldValidator __BuildControlRequiredFieldValidator1()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator1 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator1";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "TextBox2";
		((BaseValidator)requiredFieldValidator).Display = (ValidatorDisplay)2;
		((BaseValidator)requiredFieldValidator).ErrorMessage = "Please enter the subject";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTextBox3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (TextBox3 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox3";
		Unit height = new Unit(122.0, (UnitType)1);
		((WebControl)val).Height = height;
		val.TextMode = (TextBoxMode)1;
		height = new Unit(271.0, (UnitType)1);
		((WebControl)val).Width = height;
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControlRequiredFieldValidator4()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator4 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator4";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "TextBox2";
		((BaseValidator)requiredFieldValidator).Display = (ValidatorDisplay)2;
		((BaseValidator)requiredFieldValidator).ErrorMessage = "Please enter the message";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button1 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		val.Text = "Submit";
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 481, true));
		ValidationSummary validationSummary = __BuildControlValidationSummary1();
		val3.AddParsedSubObject((object)validationSummary);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                    <td style=\"width: 100px\">\r\n                        "));
		Label val4 = __BuildControlLabel1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                </tr>\r\n                <tr style=\"font-size: 12pt\">\r\n                    <td style=\"width: 20%\">\r\n                        <strong>Contact to :</strong></td>\r\n                    <td style=\"width: 100px\">\r\n                        "));
		DropDownList val5 = __BuildControlDropDownList1();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(481, 308, true));
		TextBox val6 = __BuildControlTextBox1();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                    <td style=\"width: 100px\">\r\n                        "));
		RequiredFieldValidator requiredFieldValidator = __BuildControlRequiredFieldValidator2();
		val3.AddParsedSubObject((object)requiredFieldValidator);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                </tr>\r\n                <tr style=\"font-size: 12pt\">\r\n                    <td style=\"width: 20%\">\r\n                        Your Email:</td>\r\n                    <td style=\"width: 100px\">\r\n                        "));
		TextBox val7 = __BuildControlTextBox4();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                    <td style=\"width: 100px\">\r\n                        "));
		RequiredFieldValidator requiredFieldValidator2 = __BuildControlRequiredFieldValidator3();
		val3.AddParsedSubObject((object)requiredFieldValidator2);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		CustomValidator customValidator = __BuildControlCustomValidator1();
		val3.AddParsedSubObject((object)customValidator);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                </tr>\r\n                <tr style=\"font-size: 12pt\">\r\n                    <td style=\"width: 20%\">\r\n                        <strong>Subject :</strong></td>\r\n                    <td style=\"width: 100px\">\r\n                        "));
		TextBox val8 = __BuildControlTextBox2();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                    <td style=\"width: 100px\">\r\n                        "));
		RequiredFieldValidator requiredFieldValidator3 = __BuildControlRequiredFieldValidator1();
		val3.AddParsedSubObject((object)requiredFieldValidator3);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(789, 279, true));
		TextBox val9 = __BuildControlTextBox3();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                    <td style=\"height: 130px\">\r\n                        "));
		RequiredFieldValidator requiredFieldValidator4 = __BuildControlRequiredFieldValidator4();
		val3.AddParsedSubObject((object)requiredFieldValidator4);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                </tr>\r\n                <tr style=\"font-size: 12pt\">\r\n                    <td style=\"width: 20%; height: 24px\">\r\n                    </td>\r\n                    <td style=\"width: 100px; height: 24px\">\r\n                        "));
		Button val10 = __BuildControlButton1();
		val3.AddParsedSubObject((object)val10);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                    <td style=\"width: 100px; height: 24px\">\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1068, 542, true));
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1610, 684, false));
		MultiView val = __BuildControlMultiView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent2(Control __ctrl)
	{
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2294, 432, true));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(contact_aspx __ctrl)
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
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Human Oil Change";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((Page)this).AddContentTemplate("head", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent2));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n\r\n"));
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
		return 1408234647;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
