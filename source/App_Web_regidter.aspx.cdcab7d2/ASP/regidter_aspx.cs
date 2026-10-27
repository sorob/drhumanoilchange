using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.Web.UI.Compatibility;

namespace ASP;

[CompilerGlobalScope]
public class regidter_aspx : Regidter
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public regidter_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Regidter.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Regidter.aspx", "~/master1.master", "~/master1.master.vb", "~/Regidter.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlhearlb()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (hearlb = new Label());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "hearlb";
		val.Text = "How did you hear about us?";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlrefertb()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (refertb = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "refertb";
		Unit width = new Unit(209.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControlAnswerRequired0()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = (AnswerRequired0 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "AnswerRequired0";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "refertb";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "All the fields must be filled out.";
		((WebControl)requiredFieldValidator).ToolTip = "All the fields must be filled out.";
		((BaseValidator)requiredFieldValidator).ValidationGroup = "CreateUserWizard1";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "UserNameLabel";
		val.AssociatedControlID = "UserName";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("User Name:"));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "UserName";
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControl__control7()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = new RequiredFieldValidator();
		((Control)requiredFieldValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "UserNameRequired";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "UserName";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "User Name is required.";
		((WebControl)requiredFieldValidator).ToolTip = "User Name is required.";
		((BaseValidator)requiredFieldValidator).ValidationGroup = "CreateUserWizard1";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "PasswordLabel";
		val.AssociatedControlID = "Password";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Password:"));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Password";
		val.TextMode = (TextBoxMode)2;
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControl__control10()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = new RequiredFieldValidator();
		((Control)requiredFieldValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "PasswordRequired";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "Password";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "Password is required.";
		((WebControl)requiredFieldValidator).ToolTip = "Password is required.";
		((BaseValidator)requiredFieldValidator).ValidationGroup = "CreateUserWizard1";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "ConfirmPasswordLabel";
		val.AssociatedControlID = "ConfirmPassword";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Confirm Password:"));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "ConfirmPassword";
		val.TextMode = (TextBoxMode)2;
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControl__control13()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = new RequiredFieldValidator();
		((Control)requiredFieldValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "ConfirmPasswordRequired";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "ConfirmPassword";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "Confirm Password is required.";
		((WebControl)requiredFieldValidator).ToolTip = "Confirm Password is required.";
		((BaseValidator)requiredFieldValidator).ValidationGroup = "CreateUserWizard1";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "EmailLabel";
		val.AssociatedControlID = "Email";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("E-mail:"));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Email";
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControl__control16()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = new RequiredFieldValidator();
		((Control)requiredFieldValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "EmailRequired";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "Email";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "E-mail is required.";
		((WebControl)requiredFieldValidator).ToolTip = "E-mail is required.";
		((BaseValidator)requiredFieldValidator).ValidationGroup = "CreateUserWizard1";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "QuestionLabel";
		val.AssociatedControlID = "Question";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Security Question:"));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Question";
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControl__control19()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = new RequiredFieldValidator();
		((Control)requiredFieldValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "QuestionRequired";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "Question";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "Security question is required.";
		((WebControl)requiredFieldValidator).ToolTip = "Security question is required.";
		((BaseValidator)requiredFieldValidator).ValidationGroup = "CreateUserWizard1";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "AnswerLabel";
		val.AssociatedControlID = "Answer";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Security Answer:"));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Answer";
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControl__control22()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		RequiredFieldValidator requiredFieldValidator = new RequiredFieldValidator();
		((Control)requiredFieldValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "AnswerRequired";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "Answer";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "Security answer is required.";
		((WebControl)requiredFieldValidator).ToolTip = "Security answer is required.";
		((BaseValidator)requiredFieldValidator).ValidationGroup = "CreateUserWizard1";
		IParserAccessor val = (IParserAccessor)(object)requiredFieldValidator;
		val.AddParsedSubObject((object)new LiteralControl("*"));
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private CompareValidator __BuildControl__control23()
	{
		CompareValidator compareValidator = new CompareValidator();
		((Control)compareValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)compareValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)compareValidator).ID = "PasswordCompare";
		((CompareValidator)compareValidator).ControlToCompare = "Password";
		((BaseValidator)compareValidator).ControlToValidate = "ConfirmPassword";
		((BaseValidator)compareValidator).Display = (ValidatorDisplay)2;
		((BaseValidator)compareValidator).ErrorMessage = "The Password and Confirmation Password must match.";
		((BaseValidator)compareValidator).ValidationGroup = "CreateUserWizard1";
		return compareValidator;
	}

	[DebuggerNonUserCode]
	private Literal __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Literal val = new Literal();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "ErrorMessage";
		((Control)val).EnableViewState = false;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control4(Control __ctrl)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 458, true));
		Label val = __BuildControl__control5();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                        <td align=\"left\" style=\"width: 273px\">\r\n                                            "));
		TextBox val2 = __BuildControl__control6();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                            "));
		RequiredFieldValidator requiredFieldValidator = __BuildControl__control7();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)requiredFieldValidator);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        </td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td align=\"right\" class=\"style5\">\r\n                                            "));
		Label val3 = __BuildControl__control8();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                        <td align=\"left\" style=\"width: 273px\">\r\n                                            "));
		TextBox val4 = __BuildControl__control9();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                            "));
		RequiredFieldValidator requiredFieldValidator2 = __BuildControl__control10();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)requiredFieldValidator2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        </td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td align=\"right\" class=\"style5\">\r\n                                            "));
		Label val5 = __BuildControl__control11();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                        <td align=\"left\" style=\"width: 273px\">\r\n                                            "));
		TextBox val6 = __BuildControl__control12();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val6);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                            "));
		RequiredFieldValidator requiredFieldValidator3 = __BuildControl__control13();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)requiredFieldValidator3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        </td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td align=\"right\" class=\"style5\">\r\n                                            "));
		Label val7 = __BuildControl__control14();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val7);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                        <td align=\"left\" style=\"width: 273px\">\r\n                                            "));
		TextBox val8 = __BuildControl__control15();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val8);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                            "));
		RequiredFieldValidator requiredFieldValidator4 = __BuildControl__control16();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)requiredFieldValidator4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        </td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td align=\"right\" class=\"style5\">\r\n                                            "));
		Label val9 = __BuildControl__control17();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val9);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                        <td align=\"left\" style=\"width: 273px\">\r\n                                            "));
		TextBox val10 = __BuildControl__control18();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val10);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                            "));
		RequiredFieldValidator requiredFieldValidator5 = __BuildControl__control19();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)requiredFieldValidator5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        </td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td align=\"right\" class=\"style5\">\r\n                                            "));
		Label val11 = __BuildControl__control20();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val11);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                        <td align=\"left\" style=\"width: 273px\">\r\n                                            "));
		TextBox val12 = __BuildControl__control21();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val12);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                            "));
		RequiredFieldValidator requiredFieldValidator6 = __BuildControl__control22();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)requiredFieldValidator6);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(458, 288, true));
		CompareValidator compareValidator = __BuildControl__control23();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)compareValidator);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(746, 270, true));
		Literal val13 = __BuildControl__control24();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val13);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        </td>\r\n                                    </tr>\r\n                                </table>\r\n                            "));
	}

	[DebuggerNonUserCode]
	private CreateUserWizardStep __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		CreateUserWizardStep val = new CreateUserWizardStep();
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((TemplatedWizardStep)val).ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control4);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTname()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tname = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tname";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControlRequiredFieldValidator1()
	{
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator1 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator1";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "Tname";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "*Required Field";
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "Female";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "Male";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control26(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control27();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control28();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTsexD()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TsexD = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TsexD";
		Unit width = new Unit(185.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control26(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTadd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tadd = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tadd";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTcity()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tcity = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tcity";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Selected = true;
		val.Value = "AL";
		val.Text = "Alabama";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "AK";
		val.Text = "Alaska";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "AZ";
		val.Text = "Arizona";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "AR";
		val.Text = "Arkansas";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "CA";
		val.Text = "California";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "CO";
		val.Text = "Colorado";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control36()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "CT";
		val.Text = "Connecticut";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "DE";
		val.Text = "Delaware";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "DC";
		val.Text = "District of Columbia";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control39()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "FL";
		val.Text = "Florida";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "GA";
		val.Text = "Georgia";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control41()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "HI";
		val.Text = "Hawaii";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control42()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "ID";
		val.Text = "Idaho";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "IL";
		val.Text = "Illinois";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "IN";
		val.Text = "Indiana";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "IA";
		val.Text = "Iowa";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "KS";
		val.Text = "Kansas";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control47()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "KY";
		val.Text = "Kentucky";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "LA";
		val.Text = "Louisiana";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "ME";
		val.Text = "Maine";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "MD";
		val.Text = "Maryland";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control51()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "MA";
		val.Text = "Massachusetts";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "MI";
		val.Text = "Michigan";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control53()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "MN";
		val.Text = "Minnesota";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control54()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "MS";
		val.Text = "Mississippi";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control55()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "MO";
		val.Text = "Missouri";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control56()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "MT";
		val.Text = "Montana";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control57()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "NE";
		val.Text = "Nebraska";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control58()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "NV";
		val.Text = "Nevada";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control59()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "NH";
		val.Text = "New Hampshire";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control60()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "NJ";
		val.Text = "New Jersey";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control61()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "NM";
		val.Text = "New Mexico";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control62()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "NY";
		val.Text = "New York";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control63()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "NC";
		val.Text = "North Carolina";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control64()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "ND";
		val.Text = "North Dakota";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control65()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "OH";
		val.Text = "Ohio";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control66()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "OK";
		val.Text = "Oklahoma";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control67()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "OR";
		val.Text = "Oregon";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control68()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "PA";
		val.Text = "Pennsylvania";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control69()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "RI";
		val.Text = "Rhode Island";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control70()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "SC";
		val.Text = "South Carolina";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control71()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "SD";
		val.Text = "South Dakota";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control72()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "TN";
		val.Text = "Tennessee";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control73()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "TX";
		val.Text = "Texas";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control74()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "UT";
		val.Text = "Utah";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control75()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "VT";
		val.Text = "Vermont";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control76()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "VA";
		val.Text = "Virginia";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control77()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "WA";
		val.Text = "Washington";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control78()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "WV";
		val.Text = "West Virginia";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control79()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "WI";
		val.Text = "Wisconsin";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control80()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "WY";
		val.Text = "Wyoming";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control29(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control30();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control31();
		__ctrl.Add(val2);
		ListItem val3 = __BuildControl__control32();
		__ctrl.Add(val3);
		ListItem val4 = __BuildControl__control33();
		__ctrl.Add(val4);
		ListItem val5 = __BuildControl__control34();
		__ctrl.Add(val5);
		ListItem val6 = __BuildControl__control35();
		__ctrl.Add(val6);
		ListItem val7 = __BuildControl__control36();
		__ctrl.Add(val7);
		ListItem val8 = __BuildControl__control37();
		__ctrl.Add(val8);
		ListItem val9 = __BuildControl__control38();
		__ctrl.Add(val9);
		ListItem val10 = __BuildControl__control39();
		__ctrl.Add(val10);
		ListItem val11 = __BuildControl__control40();
		__ctrl.Add(val11);
		ListItem val12 = __BuildControl__control41();
		__ctrl.Add(val12);
		ListItem val13 = __BuildControl__control42();
		__ctrl.Add(val13);
		ListItem val14 = __BuildControl__control43();
		__ctrl.Add(val14);
		ListItem val15 = __BuildControl__control44();
		__ctrl.Add(val15);
		ListItem val16 = __BuildControl__control45();
		__ctrl.Add(val16);
		ListItem val17 = __BuildControl__control46();
		__ctrl.Add(val17);
		ListItem val18 = __BuildControl__control47();
		__ctrl.Add(val18);
		ListItem val19 = __BuildControl__control48();
		__ctrl.Add(val19);
		ListItem val20 = __BuildControl__control49();
		__ctrl.Add(val20);
		ListItem val21 = __BuildControl__control50();
		__ctrl.Add(val21);
		ListItem val22 = __BuildControl__control51();
		__ctrl.Add(val22);
		ListItem val23 = __BuildControl__control52();
		__ctrl.Add(val23);
		ListItem val24 = __BuildControl__control53();
		__ctrl.Add(val24);
		ListItem val25 = __BuildControl__control54();
		__ctrl.Add(val25);
		ListItem val26 = __BuildControl__control55();
		__ctrl.Add(val26);
		ListItem val27 = __BuildControl__control56();
		__ctrl.Add(val27);
		ListItem val28 = __BuildControl__control57();
		__ctrl.Add(val28);
		ListItem val29 = __BuildControl__control58();
		__ctrl.Add(val29);
		ListItem val30 = __BuildControl__control59();
		__ctrl.Add(val30);
		ListItem val31 = __BuildControl__control60();
		__ctrl.Add(val31);
		ListItem val32 = __BuildControl__control61();
		__ctrl.Add(val32);
		ListItem val33 = __BuildControl__control62();
		__ctrl.Add(val33);
		ListItem val34 = __BuildControl__control63();
		__ctrl.Add(val34);
		ListItem val35 = __BuildControl__control64();
		__ctrl.Add(val35);
		ListItem val36 = __BuildControl__control65();
		__ctrl.Add(val36);
		ListItem val37 = __BuildControl__control66();
		__ctrl.Add(val37);
		ListItem val38 = __BuildControl__control67();
		__ctrl.Add(val38);
		ListItem val39 = __BuildControl__control68();
		__ctrl.Add(val39);
		ListItem val40 = __BuildControl__control69();
		__ctrl.Add(val40);
		ListItem val41 = __BuildControl__control70();
		__ctrl.Add(val41);
		ListItem val42 = __BuildControl__control71();
		__ctrl.Add(val42);
		ListItem val43 = __BuildControl__control72();
		__ctrl.Add(val43);
		ListItem val44 = __BuildControl__control73();
		__ctrl.Add(val44);
		ListItem val45 = __BuildControl__control74();
		__ctrl.Add(val45);
		ListItem val46 = __BuildControl__control75();
		__ctrl.Add(val46);
		ListItem val47 = __BuildControl__control76();
		__ctrl.Add(val47);
		ListItem val48 = __BuildControl__control77();
		__ctrl.Add(val48);
		ListItem val49 = __BuildControl__control78();
		__ctrl.Add(val49);
		ListItem val50 = __BuildControl__control79();
		__ctrl.Add(val50);
		ListItem val51 = __BuildControl__control80();
		__ctrl.Add(val51);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTstateD()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TstateD = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TstateD";
		Unit width = new Unit(185.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control29(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControltzip()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (tzip = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tzip";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControlRequiredFieldValidator4()
	{
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator4 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator4";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "tzip";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "*Required Field";
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControltAera()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (tAera = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tAera";
		val.MaxLength = 3;
		Unit width = new Unit(26.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTphone1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tphone1 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tphone1";
		val.MaxLength = 3;
		Unit width = new Unit(34.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTphone2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tphone2 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tphone2";
		val.MaxLength = 4;
		Unit width = new Unit(61.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControlRequiredFieldValidator2()
	{
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator2 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator2";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "tAera";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "*Required Field";
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControlRequiredFieldValidator3()
	{
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator3 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator3";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "Tphone1";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "*";
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTplace()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tplace = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tplace";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTBDmonth()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TBDmonth = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TBDmonth";
		Unit width = new Unit(46.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTBDday()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TBDday = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TBDday";
		Unit width = new Unit(46.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTBDyear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TBDyear = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TBDyear";
		Unit width = new Unit(64.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTBDhr()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TBDhr = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TBDhr";
		Unit width = new Unit(46.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTBDmn()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TBDmn = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TBDmn";
		Unit width = new Unit(46.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control82()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "AM";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control83()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "PM";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control81(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control82();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control83();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTBDpm()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TBDpm = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TBDpm";
		Unit width = new Unit(46.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control81(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control85()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "1";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control86()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "2";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control87()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "3";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control88()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "4";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control89()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "5";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control90()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "6";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control91()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "7";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control92()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "8";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control93()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "9";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control94()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "10";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control95()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "11";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control96()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "12";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control97()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "13";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control98()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "14";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control99()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "15";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control100()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "16";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control101()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "17";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control102()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "18";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control103()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "19";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control84(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control85();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control86();
		__ctrl.Add(val2);
		ListItem val3 = __BuildControl__control87();
		__ctrl.Add(val3);
		ListItem val4 = __BuildControl__control88();
		__ctrl.Add(val4);
		ListItem val5 = __BuildControl__control89();
		__ctrl.Add(val5);
		ListItem val6 = __BuildControl__control90();
		__ctrl.Add(val6);
		ListItem val7 = __BuildControl__control91();
		__ctrl.Add(val7);
		ListItem val8 = __BuildControl__control92();
		__ctrl.Add(val8);
		ListItem val9 = __BuildControl__control93();
		__ctrl.Add(val9);
		ListItem val10 = __BuildControl__control94();
		__ctrl.Add(val10);
		ListItem val11 = __BuildControl__control95();
		__ctrl.Add(val11);
		ListItem val12 = __BuildControl__control96();
		__ctrl.Add(val12);
		ListItem val13 = __BuildControl__control97();
		__ctrl.Add(val13);
		ListItem val14 = __BuildControl__control98();
		__ctrl.Add(val14);
		ListItem val15 = __BuildControl__control99();
		__ctrl.Add(val15);
		ListItem val16 = __BuildControl__control100();
		__ctrl.Add(val16);
		ListItem val17 = __BuildControl__control101();
		__ctrl.Add(val17);
		ListItem val18 = __BuildControl__control102();
		__ctrl.Add(val18);
		ListItem val19 = __BuildControl__control103();
		__ctrl.Add(val19);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTnumberSIB()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TnumberSIB = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TnumberSIB";
		Unit width = new Unit(46.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control84(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control105()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "1";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control106()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "2";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control107()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "3";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control108()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "4";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control109()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "5";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control110()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "6";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control111()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "7";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control112()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "8";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control113()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "9";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control114()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "10";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control115()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "11";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control116()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "12";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control117()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "13";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control118()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "14";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control119()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "15";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control120()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "16";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control121()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "17";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control122()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "18";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control123()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "19";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control104(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control105();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control106();
		__ctrl.Add(val2);
		ListItem val3 = __BuildControl__control107();
		__ctrl.Add(val3);
		ListItem val4 = __BuildControl__control108();
		__ctrl.Add(val4);
		ListItem val5 = __BuildControl__control109();
		__ctrl.Add(val5);
		ListItem val6 = __BuildControl__control110();
		__ctrl.Add(val6);
		ListItem val7 = __BuildControl__control111();
		__ctrl.Add(val7);
		ListItem val8 = __BuildControl__control112();
		__ctrl.Add(val8);
		ListItem val9 = __BuildControl__control113();
		__ctrl.Add(val9);
		ListItem val10 = __BuildControl__control114();
		__ctrl.Add(val10);
		ListItem val11 = __BuildControl__control115();
		__ctrl.Add(val11);
		ListItem val12 = __BuildControl__control116();
		__ctrl.Add(val12);
		ListItem val13 = __BuildControl__control117();
		__ctrl.Add(val13);
		ListItem val14 = __BuildControl__control118();
		__ctrl.Add(val14);
		ListItem val15 = __BuildControl__control119();
		__ctrl.Add(val15);
		ListItem val16 = __BuildControl__control120();
		__ctrl.Add(val16);
		ListItem val17 = __BuildControl__control121();
		__ctrl.Add(val17);
		ListItem val18 = __BuildControl__control122();
		__ctrl.Add(val18);
		ListItem val19 = __BuildControl__control123();
		__ctrl.Add(val19);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControltPLACEsib()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (tPLACEsib = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tPLACEsib";
		Unit width = new Unit(46.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control104(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control125()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "Yes";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control126()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "No";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control124(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control125();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control126();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTmeriedD()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TmeriedD = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TmeriedD";
		Unit width = new Unit(185.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control124(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTlastgrade()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tlastgrade = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tlastgrade";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTocc()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tocc = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tocc";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTssn()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tssn = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tssn";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlT_race()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (T_race = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "T_race";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControlRequiredFieldValidator5()
	{
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator5 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator5";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "T_race";
		((BaseValidator)requiredFieldValidator).ErrorMessage = "*Required Field";
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlThb()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Thb = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Thb";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTheight()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Theight = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Theight";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTweight()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Tweight = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tweight";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTeye()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Teye = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Teye";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlThair()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Thair = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Thair";
		Unit width = new Unit(181.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control128()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "O";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control129()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "A";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control130()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "B";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control131()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "AB";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control127(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control128();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control129();
		__ctrl.Add(val2);
		ListItem val3 = __BuildControl__control130();
		__ctrl.Add(val3);
		ListItem val4 = __BuildControl__control131();
		__ctrl.Add(val4);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTbloodD()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (TbloodD = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TbloodD";
		Unit width = new Unit(185.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control127(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control133()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "No";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control134()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "Yes";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control132(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control133();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control134();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlTpsyce()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (Tpsyce = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tpsyce";
		Unit width = new Unit(185.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control132(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control136()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tname";
		((Parameter)val).Name = "Name";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control137()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "TsexD";
		((Parameter)val).Name = "sex";
		val.PropertyName = "SelectedValue";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control138()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "RegisterDate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control139()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tadd";
		((Parameter)val).Name = "Address";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control140()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Maried";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control141()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "TnumberSIB";
		((Parameter)val).Name = "NumberofChildren";
		val.PropertyName = "SelectedValue";
		((Parameter)val).Type = TypeCode.Int16;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control142()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "tPLACEsib";
		((Parameter)val).Name = "Sybling";
		val.PropertyName = "SelectedValue";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control143()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tcity";
		((Parameter)val).Name = "City";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control144()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "TstateD";
		((Parameter)val).Name = "State";
		val.PropertyName = "SelectedValue";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control145()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "tzip";
		((Parameter)val).Name = "Zipcode";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control146()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "tAera";
		((Parameter)val).Name = "areacode";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control147()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "phonenumber";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control148()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tocc";
		((Parameter)val).Name = "occupation";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control149()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Thb";
		((Parameter)val).Name = "Habbies";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control150()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control151()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tplace";
		((Parameter)val).Name = "birthplace";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control152()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tlastgrade";
		((Parameter)val).Name = "lastgrad";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control153()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tssn";
		((Parameter)val).Name = "SSN";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control154()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.DefaultValue = "0";
		val.Name = "Labnum";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control155()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "PsychologicallyStress";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control156()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Theight";
		((Parameter)val).Name = "height";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control157()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tweight";
		((Parameter)val).Name = "weight";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control158()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Teye";
		((Parameter)val).Name = "eyecolor";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control159()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Thair";
		((Parameter)val).Name = "haircolor";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control160()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "TbloodD";
		((Parameter)val).Name = "bloodtype";
		val.PropertyName = "SelectedValue";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control161()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		val.DefaultValue = "";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control162()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Code";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control163()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "T_race";
		((Parameter)val).Name = "race";
		val.PropertyName = "Text";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control164()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "referral";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control135(ParameterCollection __ctrl)
	{
		ControlParameter val = __BuildControl__control136();
		__ctrl.Add((Parameter)(object)val);
		ControlParameter val2 = __BuildControl__control137();
		__ctrl.Add((Parameter)(object)val2);
		Parameter val3 = __BuildControl__control138();
		__ctrl.Add(val3);
		ControlParameter val4 = __BuildControl__control139();
		__ctrl.Add((Parameter)(object)val4);
		Parameter val5 = __BuildControl__control140();
		__ctrl.Add(val5);
		ControlParameter val6 = __BuildControl__control141();
		__ctrl.Add((Parameter)(object)val6);
		ControlParameter val7 = __BuildControl__control142();
		__ctrl.Add((Parameter)(object)val7);
		ControlParameter val8 = __BuildControl__control143();
		__ctrl.Add((Parameter)(object)val8);
		ControlParameter val9 = __BuildControl__control144();
		__ctrl.Add((Parameter)(object)val9);
		ControlParameter val10 = __BuildControl__control145();
		__ctrl.Add((Parameter)(object)val10);
		ControlParameter val11 = __BuildControl__control146();
		__ctrl.Add((Parameter)(object)val11);
		Parameter val12 = __BuildControl__control147();
		__ctrl.Add(val12);
		ControlParameter val13 = __BuildControl__control148();
		__ctrl.Add((Parameter)(object)val13);
		ControlParameter val14 = __BuildControl__control149();
		__ctrl.Add((Parameter)(object)val14);
		Parameter val15 = __BuildControl__control150();
		__ctrl.Add(val15);
		ControlParameter val16 = __BuildControl__control151();
		__ctrl.Add((Parameter)(object)val16);
		ControlParameter val17 = __BuildControl__control152();
		__ctrl.Add((Parameter)(object)val17);
		ControlParameter val18 = __BuildControl__control153();
		__ctrl.Add((Parameter)(object)val18);
		Parameter val19 = __BuildControl__control154();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control155();
		__ctrl.Add(val20);
		ControlParameter val21 = __BuildControl__control156();
		__ctrl.Add((Parameter)(object)val21);
		ControlParameter val22 = __BuildControl__control157();
		__ctrl.Add((Parameter)(object)val22);
		ControlParameter val23 = __BuildControl__control158();
		__ctrl.Add((Parameter)(object)val23);
		ControlParameter val24 = __BuildControl__control159();
		__ctrl.Add((Parameter)(object)val24);
		ControlParameter val25 = __BuildControl__control160();
		__ctrl.Add((Parameter)(object)val25);
		Parameter val26 = __BuildControl__control161();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control162();
		__ctrl.Add(val27);
		ControlParameter val28 = __BuildControl__control163();
		__ctrl.Add((Parameter)(object)val28);
		Parameter val29 = __BuildControl__control164();
		__ctrl.Add(val29);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control166()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control167()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "sex";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control168()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "RegisterDate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control169()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Address";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control170()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Maried";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control171()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "NumberofChildren";
		val.Type = TypeCode.Int16;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control172()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Sybling";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control173()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "City";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control174()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "State";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control175()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Zipcode";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control176()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "areacode";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control177()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "phonenumber";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control178()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "occupation";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control179()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Habbies";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control180()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control181()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthplace";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control182()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "lastgrad";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control183()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "SSN";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control184()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "email";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control185()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "PsychologicallyStress";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control186()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "height";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control187()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "weight";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control188()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "eyecolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control189()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "haircolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control190()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bloodtype";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control191()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Code";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control192()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control165(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control166();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control167();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control168();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control169();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control170();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control171();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control172();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control173();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control174();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control175();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control176();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control177();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control178();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control179();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control180();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control181();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control182();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control183();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control184();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control185();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control186();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control187();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control188();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control189();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control190();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control191();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control192();
		__ctrl.Add(val27);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control194()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control193(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control194();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [UserInfo] WHERE [UserName] = @UserName";
		val.InsertCommand = "INSERT INTO [UserInfo] ([Name], [sex], [RegisterDate], [Address], [Maried], [NumberofChildren], [Sybling], [City], [State], [Zipcode], [areacode], [phonenumber], [occupation], [Habbies], [birthdate], [birthplace], [lastgrad], [SSN], [Labnum], [PsychologicallyStress], [height], [weight], [eyecolor], [haircolor], [bloodtype], [UserName], [Code], [race], [referral]) VALUES (@Name, @sex, @RegisterDate, @Address, @Maried, @NumberofChildren, @Sybling, @City, @State, @Zipcode, @areacode, @phonenumber, @occupation, @Habbies, @birthdate, @birthplace, @lastgrad, @SSN, @Labnum, @PsychologicallyStress, @height, @weight, @eyecolor, @haircolor, @bloodtype, @UserName, @Code, @race, @referral)";
		val.SelectCommand = "SELECT Name, sex, RegisterDate, Address, Maried, NumberofChildren, Sybling, City, State, Zipcode, areacode, phonenumber, occupation, Habbies, birthdate, birthplace, lastgrad, SSN, Labnum, PsychologicallyStress, height, weight, eyecolor, haircolor, bloodtype, UserName, Code, referral FROM UserInfo";
		val.UpdateCommand = "UPDATE [UserInfo] SET [Name] = @Name, [sex] = @sex, [RegisterDate] = @RegisterDate, [Address] = @Address, [Maried] = @Maried, [NumberofChildren] = @NumberofChildren, [Sybling] = @Sybling, [City] = @City, [State] = @State, [Zipcode] = @Zipcode, [areacode] = @areacode, [phonenumber] = @phonenumber, [occupation] = @occupation, [Habbies] = @Habbies, [birthdate] = @birthdate, [birthplace] = @birthplace, [lastgrad] = @lastgrad, [SSN] = @SSN, [email] = @email, [PsychologicallyStress] = @PsychologicallyStress, [height] = @height, [weight] = @weight, [eyecolor] = @eyecolor, [haircolor] = @haircolor, [bloodtype] = @bloodtype, [Code] = @Code WHERE [UserName] = @UserName";
		__BuildControl__control135(val.InsertParameters);
		__BuildControl__control165(val.UpdateParameters);
		__BuildControl__control193(val.DeleteParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("ConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private WizardStep __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		WizardStep val = new WizardStep();
		((WizardStepBase)val).AllowReturn = false;
		((WizardStepBase)val).Title = "Add more info";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1016, 730, true));
		TextBox val3 = __BuildControlTname();
		val2.AddParsedSubObject((object)val3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"width: 100px; height: 24px\">\r\n                                        "));
		RequiredFieldValidator requiredFieldValidator = __BuildControlRequiredFieldValidator1();
		val2.AddParsedSubObject((object)requiredFieldValidator);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1746, 382, true));
		DropDownList val4 = __BuildControlTsexD();
		val2.AddParsedSubObject((object)val4);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2128, 505, true));
		TextBox val5 = __BuildControlTadd();
		val2.AddParsedSubObject((object)val5);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2633, 502, true));
		TextBox val6 = __BuildControlTcity();
		val2.AddParsedSubObject((object)val6);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(3135, 574, true));
		DropDownList val7 = __BuildControlTstateD();
		val2.AddParsedSubObject((object)val7);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(3709, 521, true));
		TextBox val8 = __BuildControltzip();
		val2.AddParsedSubObject((object)val8);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"width: 100px\">\r\n                                        "));
		RequiredFieldValidator requiredFieldValidator2 = __BuildControlRequiredFieldValidator4();
		val2.AddParsedSubObject((object)requiredFieldValidator2);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(4230, 392, true));
		TextBox val9 = __BuildControltAera();
		val2.AddParsedSubObject((object)val9);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                        )-"));
		TextBox val10 = __BuildControlTphone1();
		val2.AddParsedSubObject((object)val10);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                        -"));
		TextBox val11 = __BuildControlTphone2();
		val2.AddParsedSubObject((object)val11);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"width: 100px\">\r\n                                        "));
		RequiredFieldValidator requiredFieldValidator3 = __BuildControlRequiredFieldValidator2();
		val2.AddParsedSubObject((object)requiredFieldValidator3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                        "));
		RequiredFieldValidator requiredFieldValidator4 = __BuildControlRequiredFieldValidator3();
		val2.AddParsedSubObject((object)requiredFieldValidator4);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(4622, 422, true));
		TextBox val12 = __BuildControlTplace();
		val2.AddParsedSubObject((object)val12);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(5044, 597, true));
		DropDownList val13 = __BuildControlTBDmonth();
		val2.AddParsedSubObject((object)val13);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                        <strong>/ </strong>\r\n                                        "));
		DropDownList val14 = __BuildControlTBDday();
		val2.AddParsedSubObject((object)val14);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                        <strong>/</strong>\r\n                                        "));
		DropDownList val15 = __BuildControlTBDyear();
		val2.AddParsedSubObject((object)val15);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                        <br />\r\n                                        "));
		DropDownList val16 = __BuildControlTBDhr();
		val2.AddParsedSubObject((object)val16);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                        <strong>:</strong>\r\n                                        "));
		DropDownList val17 = __BuildControlTBDmn();
		val2.AddParsedSubObject((object)val17);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                        "));
		DropDownList val18 = __BuildControlTBDpm();
		val2.AddParsedSubObject((object)val18);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(5641, 613, true));
		DropDownList val19 = __BuildControlTnumberSIB();
		val2.AddParsedSubObject((object)val19);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(6254, 558, true));
		DropDownList val20 = __BuildControltPLACEsib();
		val2.AddParsedSubObject((object)val20);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(6812, 548, true));
		DropDownList val21 = __BuildControlTmeriedD();
		val2.AddParsedSubObject((object)val21);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(7360, 522, true));
		TextBox val22 = __BuildControlTlastgrade();
		val2.AddParsedSubObject((object)val22);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(7882, 508, true));
		TextBox val23 = __BuildControlTocc();
		val2.AddParsedSubObject((object)val23);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(8390, 501, true));
		TextBox val24 = __BuildControlTssn();
		val2.AddParsedSubObject((object)val24);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(8891, 542, true));
		TextBox val25 = __BuildControlT_race();
		val2.AddParsedSubObject((object)val25);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"width: 100px; height: 24px\">\r\n                                        "));
		RequiredFieldValidator requiredFieldValidator5 = __BuildControlRequiredFieldValidator5();
		val2.AddParsedSubObject((object)requiredFieldValidator5);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(9433, 386, true));
		TextBox val26 = __BuildControlThb();
		val2.AddParsedSubObject((object)val26);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(9819, 504, true));
		TextBox val27 = __BuildControlTheight();
		val2.AddParsedSubObject((object)val27);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(10323, 504, true));
		TextBox val28 = __BuildControlTweight();
		val2.AddParsedSubObject((object)val28);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(10827, 507, true));
		TextBox val29 = __BuildControlTeye();
		val2.AddParsedSubObject((object)val29);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(11334, 537, true));
		TextBox val30 = __BuildControlThair();
		val2.AddParsedSubObject((object)val30);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(11871, 522, true));
		DropDownList val31 = __BuildControlTbloodD();
		val2.AddParsedSubObject((object)val31);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(12393, 550, true));
		DropDownList val32 = __BuildControlTpsyce();
		val2.AddParsedSubObject((object)val32);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(12943, 385, true));
		SqlDataSource val33 = __BuildControlSqlDataSource1();
		val2.AddParsedSubObject((object)val33);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(13328, 412, true));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlc1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (c1 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "c1";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlo1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (o1 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "o1";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlc2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (c2 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "c2";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlo2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (o2 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "o2";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlc3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (c3 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "c3";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlo3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (o3 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "o3";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlc4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (c4 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "c4";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlo4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (o4 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "o4";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlc5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (c5 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "c5";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlo5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (o5 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "o5";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlc6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (c6 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "c6";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlo6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (o6 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "o6";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlc7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (c7 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "c7";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlo7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (o7 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "o7";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlc8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (c8 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "c8";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlo8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (o8 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "o8";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlm1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (m1 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "m1";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControll1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (l1 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "l1";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlm2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (m2 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "m2";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControll2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (l2 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "l2";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlm3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (m3 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "m3";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControll3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (l3 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "l3";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlm4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (m4 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "m4";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControll4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (l4 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "l4";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlm5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (m5 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "m5";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControll5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (l5 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "l5";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlm6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (m6 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "m6";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControll6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (l6 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "l6";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlm7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (m7 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "m7";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControll7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (l7 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "l7";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlm8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (m8 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "m8";
		Unit width = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControll8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (l8 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "l8";
		Unit width = new Unit(99.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTextBox1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (TextBox1 = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox1";
		Unit height = new Unit(145.0, (UnitType)1);
		((WebControl)val).Height = height;
		height = new Unit(233.0, (UnitType)1);
		((WebControl)val).Width = height;
		val.TextMode = (TextBoxMode)1;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control197()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "c1";
		((Parameter)val).Name = "c1";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control198()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "o1";
		((Parameter)val).Name = "o1";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control199()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "c2";
		((Parameter)val).Name = "c2";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control200()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "o2";
		((Parameter)val).Name = "o2";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control201()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "c3";
		((Parameter)val).Name = "c3";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control202()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "o3";
		((Parameter)val).Name = "o3";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control203()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "c4";
		((Parameter)val).Name = "c4";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control204()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "o4";
		((Parameter)val).Name = "o4";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control205()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "c5";
		((Parameter)val).Name = "c5";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control206()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "o5";
		((Parameter)val).Name = "o5";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control207()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "c6";
		((Parameter)val).Name = "c6";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control208()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "o6";
		((Parameter)val).Name = "o6";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control209()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "c7";
		((Parameter)val).Name = "c7";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control210()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "o7";
		((Parameter)val).Name = "o7";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control211()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "c8";
		((Parameter)val).Name = "c8";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control212()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "o8";
		((Parameter)val).Name = "o8";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control213()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "m1";
		((Parameter)val).Name = "m1";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control214()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "l1";
		((Parameter)val).Name = "l1";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control215()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "m2";
		((Parameter)val).Name = "m2";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control216()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "l2";
		((Parameter)val).Name = "l2";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control217()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "m3";
		((Parameter)val).Name = "m3";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control218()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "l3";
		((Parameter)val).Name = "l3";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control219()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "m4";
		((Parameter)val).Name = "m4";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control220()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "l4";
		((Parameter)val).Name = "l4";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control221()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "m5";
		((Parameter)val).Name = "m5";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control222()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "l5";
		((Parameter)val).Name = "l5";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control223()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "m6";
		((Parameter)val).Name = "m6";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control224()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "l6";
		((Parameter)val).Name = "l6";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control225()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "m7";
		((Parameter)val).Name = "m7";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control226()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "l7";
		((Parameter)val).Name = "l7";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control227()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "m8";
		((Parameter)val).Name = "m8";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control228()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "l8";
		((Parameter)val).Name = "l8";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control229()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control230()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "comment";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control196(ParameterCollection __ctrl)
	{
		ControlParameter val = __BuildControl__control197();
		__ctrl.Add((Parameter)(object)val);
		ControlParameter val2 = __BuildControl__control198();
		__ctrl.Add((Parameter)(object)val2);
		ControlParameter val3 = __BuildControl__control199();
		__ctrl.Add((Parameter)(object)val3);
		ControlParameter val4 = __BuildControl__control200();
		__ctrl.Add((Parameter)(object)val4);
		ControlParameter val5 = __BuildControl__control201();
		__ctrl.Add((Parameter)(object)val5);
		ControlParameter val6 = __BuildControl__control202();
		__ctrl.Add((Parameter)(object)val6);
		ControlParameter val7 = __BuildControl__control203();
		__ctrl.Add((Parameter)(object)val7);
		ControlParameter val8 = __BuildControl__control204();
		__ctrl.Add((Parameter)(object)val8);
		ControlParameter val9 = __BuildControl__control205();
		__ctrl.Add((Parameter)(object)val9);
		ControlParameter val10 = __BuildControl__control206();
		__ctrl.Add((Parameter)(object)val10);
		ControlParameter val11 = __BuildControl__control207();
		__ctrl.Add((Parameter)(object)val11);
		ControlParameter val12 = __BuildControl__control208();
		__ctrl.Add((Parameter)(object)val12);
		ControlParameter val13 = __BuildControl__control209();
		__ctrl.Add((Parameter)(object)val13);
		ControlParameter val14 = __BuildControl__control210();
		__ctrl.Add((Parameter)(object)val14);
		ControlParameter val15 = __BuildControl__control211();
		__ctrl.Add((Parameter)(object)val15);
		ControlParameter val16 = __BuildControl__control212();
		__ctrl.Add((Parameter)(object)val16);
		ControlParameter val17 = __BuildControl__control213();
		__ctrl.Add((Parameter)(object)val17);
		ControlParameter val18 = __BuildControl__control214();
		__ctrl.Add((Parameter)(object)val18);
		ControlParameter val19 = __BuildControl__control215();
		__ctrl.Add((Parameter)(object)val19);
		ControlParameter val20 = __BuildControl__control216();
		__ctrl.Add((Parameter)(object)val20);
		ControlParameter val21 = __BuildControl__control217();
		__ctrl.Add((Parameter)(object)val21);
		ControlParameter val22 = __BuildControl__control218();
		__ctrl.Add((Parameter)(object)val22);
		ControlParameter val23 = __BuildControl__control219();
		__ctrl.Add((Parameter)(object)val23);
		ControlParameter val24 = __BuildControl__control220();
		__ctrl.Add((Parameter)(object)val24);
		ControlParameter val25 = __BuildControl__control221();
		__ctrl.Add((Parameter)(object)val25);
		ControlParameter val26 = __BuildControl__control222();
		__ctrl.Add((Parameter)(object)val26);
		ControlParameter val27 = __BuildControl__control223();
		__ctrl.Add((Parameter)(object)val27);
		ControlParameter val28 = __BuildControl__control224();
		__ctrl.Add((Parameter)(object)val28);
		ControlParameter val29 = __BuildControl__control225();
		__ctrl.Add((Parameter)(object)val29);
		ControlParameter val30 = __BuildControl__control226();
		__ctrl.Add((Parameter)(object)val30);
		ControlParameter val31 = __BuildControl__control227();
		__ctrl.Add((Parameter)(object)val31);
		ControlParameter val32 = __BuildControl__control228();
		__ctrl.Add((Parameter)(object)val32);
		Parameter val33 = __BuildControl__control229();
		__ctrl.Add(val33);
		Parameter val34 = __BuildControl__control230();
		__ctrl.Add(val34);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control232()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control233()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control234()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control235()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control236()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control237()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control238()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control239()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control240()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control241()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control242()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control243()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control244()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control245()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control246()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control247()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control248()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control249()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control250()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control251()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control252()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control253()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control254()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control255()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control256()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control257()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control258()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control259()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control260()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control261()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control262()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control263()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control264()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control231(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control232();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control233();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control234();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control235();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control236();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control237();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control238();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control239();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control240();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control241();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control242();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control243();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control244();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control245();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control246();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control247();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control248();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control249();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control250();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control251();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control252();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control253();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control254();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control255();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control256();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control257();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control258();
		__ctrl.Add(val27);
		Parameter val28 = __BuildControl__control259();
		__ctrl.Add(val28);
		Parameter val29 = __BuildControl__control260();
		__ctrl.Add(val29);
		Parameter val30 = __BuildControl__control261();
		__ctrl.Add(val30);
		Parameter val31 = __BuildControl__control262();
		__ctrl.Add(val31);
		Parameter val32 = __BuildControl__control263();
		__ctrl.Add(val32);
		Parameter val33 = __BuildControl__control264();
		__ctrl.Add(val33);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control266()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control265(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control266();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource2 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource2";
		val.DeleteCommand = "DELETE FROM [complaints] WHERE [UserName] = @UserName";
		val.InsertCommand = "INSERT INTO complaints(c1, o1, c2, o2, c3, o3, c4, o4, c5, o5, c6, o6, c7, o7, c8, o8, m1, l1, m2, l2, m3, l3, m4, l4, m5, l5, m6, l6, m7, l7, m8, l8, UserName, comment) VALUES (@c1, @o1, @c2, @o2, @c3, @o3, @c4, @o4, @c5, @o5, @c6, @o6, @c7, @o7, @c8, @o8, @m1, @l1, @m2, @l2, @m3, @l3, @m4, @l4, @m5, @l5, @m6, @l6, @m7, @l7, @m8, @l8, @UserName, @comment)";
		val.SelectCommand = "SELECT [c1], [o1], [c2], [o2], [c3], [o3], [c4], [o4], [c5], [o5], [c6], [o6], [c7], [o7], [c8], [o8], [m1], [l1], [m2], [l2], [m3], [l3], [m4], [l4], [m5], [l5], [m6], [l6], [m7], [l7], [m8], [l8], [UserName] FROM [complaints]";
		val.UpdateCommand = "UPDATE [complaints] SET [c1] = @c1, [o1] = @o1, [c2] = @c2, [o2] = @o2, [c3] = @c3, [o3] = @o3, [c4] = @c4, [o4] = @o4, [c5] = @c5, [o5] = @o5, [c6] = @c6, [o6] = @o6, [c7] = @c7, [o7] = @o7, [c8] = @c8, [o8] = @o8, [m1] = @m1, [l1] = @l1, [m2] = @m2, [l2] = @l2, [m3] = @m3, [l3] = @l3, [m4] = @m4, [l4] = @l4, [m5] = @m5, [l5] = @l5, [m6] = @m6, [l6] = @l6, [m7] = @m7, [l7] = @l7, [m8] = @m8, [l8] = @l8 WHERE [UserName] = @UserName";
		__BuildControl__control196(val.InsertParameters);
		__BuildControl__control231(val.UpdateParameters);
		__BuildControl__control265(val.DeleteParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private WizardStep __BuildControl__control195()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		WizardStep val = new WizardStep();
		((WizardStepBase)val).AllowReturn = false;
		((WizardStepBase)val).Title = "Complains";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(13740, 1387, true));
		TextBox val3 = __BuildControlc1();
		val2.AddParsedSubObject((object)val3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\">\r\n                                        "));
		TextBox val4 = __BuildControlo1();
		val2.AddParsedSubObject((object)val4);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(15127, 389, true));
		TextBox val5 = __BuildControlc2();
		val2.AddParsedSubObject((object)val5);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 24px\">\r\n                                        "));
		TextBox val6 = __BuildControlo2();
		val2.AddParsedSubObject((object)val6);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(15516, 353, true));
		TextBox val7 = __BuildControlc3();
		val2.AddParsedSubObject((object)val7);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\">\r\n                                        "));
		TextBox val8 = __BuildControlo3();
		val2.AddParsedSubObject((object)val8);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(15869, 388, true));
		TextBox val9 = __BuildControlc4();
		val2.AddParsedSubObject((object)val9);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val10 = __BuildControlo4();
		val2.AddParsedSubObject((object)val10);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(16257, 388, true));
		TextBox val11 = __BuildControlc5();
		val2.AddParsedSubObject((object)val11);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val12 = __BuildControlo5();
		val2.AddParsedSubObject((object)val12);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(16645, 388, true));
		TextBox val13 = __BuildControlc6();
		val2.AddParsedSubObject((object)val13);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val14 = __BuildControlo6();
		val2.AddParsedSubObject((object)val14);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(17033, 388, true));
		TextBox val15 = __BuildControlc7();
		val2.AddParsedSubObject((object)val15);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val16 = __BuildControlo7();
		val2.AddParsedSubObject((object)val16);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(17421, 388, true));
		TextBox val17 = __BuildControlc8();
		val2.AddParsedSubObject((object)val17);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val18 = __BuildControlo8();
		val2.AddParsedSubObject((object)val18);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(17809, 1698, true));
		TextBox val19 = __BuildControlm1();
		val2.AddParsedSubObject((object)val19);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val20 = __BuildControll1();
		val2.AddParsedSubObject((object)val20);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(19507, 389, true));
		TextBox val21 = __BuildControlm2();
		val2.AddParsedSubObject((object)val21);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val22 = __BuildControll2();
		val2.AddParsedSubObject((object)val22);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(19896, 389, true));
		TextBox val23 = __BuildControlm3();
		val2.AddParsedSubObject((object)val23);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val24 = __BuildControll3();
		val2.AddParsedSubObject((object)val24);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(20285, 389, true));
		TextBox val25 = __BuildControlm4();
		val2.AddParsedSubObject((object)val25);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val26 = __BuildControll4();
		val2.AddParsedSubObject((object)val26);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(20674, 389, true));
		TextBox val27 = __BuildControlm5();
		val2.AddParsedSubObject((object)val27);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val28 = __BuildControll5();
		val2.AddParsedSubObject((object)val28);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(21063, 389, true));
		TextBox val29 = __BuildControlm6();
		val2.AddParsedSubObject((object)val29);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val30 = __BuildControll6();
		val2.AddParsedSubObject((object)val30);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(21452, 389, true));
		TextBox val31 = __BuildControlm7();
		val2.AddParsedSubObject((object)val31);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val32 = __BuildControll7();
		val2.AddParsedSubObject((object)val32);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(21841, 389, true));
		TextBox val33 = __BuildControlm8();
		val2.AddParsedSubObject((object)val33);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                    <td align=\"left\" style=\"height: 19px\">\r\n                                        "));
		TextBox val34 = __BuildControll8();
		val2.AddParsedSubObject((object)val34);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(22230, 854, true));
		TextBox val35 = __BuildControlTextBox1();
		val2.AddParsedSubObject((object)val35);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(23084, 377, true));
		SqlDataSource val36 = __BuildControlSqlDataSource2();
		val2.AddParsedSubObject((object)val36);
		val2.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(23461, 384, true));
		return val;
	}

	[DebuggerNonUserCode]
	private CompleteWizardStep __BuildControl__control267()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CompleteWizardStep val = new CompleteWizardStep();
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(WizardStepCollection __ctrl)
	{
		CreateUserWizardStep val = __BuildControl__control3();
		__ctrl.Add((WizardStepBase)(object)val);
		WizardStep val2 = __BuildControl__control25();
		__ctrl.Add((WizardStepBase)(object)val2);
		WizardStep val3 = __BuildControl__control195();
		__ctrl.Add((WizardStepBase)(object)val3);
		CompleteWizardStep val4 = __BuildControl__control267();
		__ctrl.Add((WizardStepBase)(object)val4);
	}

	[DebuggerNonUserCode]
	private CreateUserWizard __BuildControlCreateUserWizard1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		CreateUserWizard val = (CreateUserWizard1 = new CreateUserWizard());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "CreateUserWizard1";
		Unit width = new Unit(90.0, (UnitType)7);
		((WebControl)val).Width = width;
		((Wizard)val).FinishDestinationPageUrl = "~/AddUserInfo.aspx";
		val.CompleteSuccessText = "Your account has been successfully created. Please check your email in order to confirm the registration.";
		__BuildControl__control2(val.WizardSteps);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(23845, 544, true));
		Label val = __BuildControlhearlb();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        </td>\r\n                                        <td align=\"left\" class=\"style4\">\r\n                                            "));
		TextBox val2 = __BuildControlrefertb();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                            "));
		RequiredFieldValidator requiredFieldValidator = __BuildControlAnswerRequired0();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)requiredFieldValidator);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(24389, 423, true));
		CreateUserWizard val3 = __BuildControlCreateUserWizard1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                &nbsp;\r\n            </td>\r\n        </tr>\r\n    </table>\r\n    </td>\r\n                                    </tr>\r\n     </table></div>\r\n    \r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent2(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n    <style type=\"text/css\">\r\n        .style2\r\n        {\r\n        }\r\n        .style4\r\n        {\r\n            width: 273px;\r\n        }\r\n        .style5\r\n        {\r\n            width: 136px;\r\n        }\r\n    </style>\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(regidter_aspx __ctrl)
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
		((Page)__ctrl).Title = "Human Oil Change";
		((Page)__ctrl).Theme = "Theme1";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((Page)this).AddContentTemplate("head", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent2));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).StyleSheetTheme = "Theme1";
		((Page)this).FrameworkInitialize();
		((TemplateControl)this).SetStringResourcePointer(RuntimeHelpers.GetObjectValue(__stringResource), 0);
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 1674855921;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
