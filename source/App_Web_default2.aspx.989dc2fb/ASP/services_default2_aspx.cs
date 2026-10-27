using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

namespace ASP;

[CompilerGlobalScope]
public class services_default2_aspx : Services_Default2
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public services_default2_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Services/Default2.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Services/Default2.aspx", "~/master1.master", "~/master1.master.vb", "~/Services/Default2.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTA1G()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TA1G = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TA1G";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender15()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender15 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender15";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TA1G";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator15()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator15 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator15";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TA1G";
		maskedEditValidator.ControlExtender = "MaskedEditExtender15";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTBILIRUBIN()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TBILIRUBIN = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TBILIRUBIN";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender16()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender16 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender16";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TBILIRUBIN";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator16()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator16 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator16";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TBILIRUBIN";
		maskedEditValidator.ControlExtender = "MaskedEditExtender16";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTPHOSPHATASE()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TPHOSPHATASE = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TPHOSPHATASE";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender17()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender17 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender17";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TPHOSPHATASE";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator17()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator17 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator17";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TPHOSPHATASE";
		maskedEditValidator.ControlExtender = "MaskedEditExtender17";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTLD()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TLD = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TLD";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender18()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender18 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender18";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TLD";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator18()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator18 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator18";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TLD";
		maskedEditValidator.ControlExtender = "MaskedEditExtender18";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTAST()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TAST = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TAST";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender19()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender19 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender19";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TAST";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator19()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator19 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator19";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TAST";
		maskedEditValidator.ControlExtender = "MaskedEditExtender19";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTALT()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TALT = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TALT";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender20()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender20 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender20";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TALT";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator20()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator20 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator20";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TALT";
		maskedEditValidator.ControlExtender = "MaskedEditExtender20";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTGGT()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TGGT = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TGGT";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender21()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender21 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender21";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TGGT";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator21()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator21 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator21";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TGGT";
		maskedEditValidator.ControlExtender = "MaskedEditExtender21";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTIRON()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TIRON = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TIRON";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender22()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender22 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender22";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TIRON";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator22()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator22 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator22";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TIRON";
		maskedEditValidator.ControlExtender = "MaskedEditExtender22";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTCHOLESTEROL()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TCHOLESTEROL = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TCHOLESTEROL";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender23()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender23 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender23";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TCHOLESTEROL";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator23()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator23 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator23";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TCHOLESTEROL";
		maskedEditValidator.ControlExtender = "MaskedEditExtender23";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTTRIGLYCERIDES()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TTRIGLYCERIDES = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TTRIGLYCERIDES";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender24()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender24 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender24";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TTRIGLYCERIDES";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator24()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator24 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator24";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TTRIGLYCERIDES";
		maskedEditValidator.ControlExtender = "MaskedEditExtender24";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTHDL()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (THDL = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "THDL";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender25()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender25 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender25";
		((ExtenderControl)maskedEditExtender).TargetControlID = "THDL";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator25()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator25 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator25";
		((BaseValidator)maskedEditValidator).ControlToValidate = "THDL";
		maskedEditValidator.ControlExtender = "MaskedEditExtender25";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTLDL()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TLDL = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TLDL";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender26()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender26 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender26";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TLDL";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator26()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator26 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator26";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TLDL";
		maskedEditValidator.ControlExtender = "MaskedEditExtender26";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTCHO()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TCHO = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TCHO";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender27()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender27 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender27";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TCHO";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator27()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator27 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator27";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TCHO";
		maskedEditValidator.ControlExtender = "MaskedEditExtender27";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTTHYROID()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (TTHYROID = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TTHYROID";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender28()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender28 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender28";
		((ExtenderControl)maskedEditExtender).TargetControlID = "TTHYROID";
		maskedEditExtender.Mask = "99,999.99";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator28()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator28 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator28";
		((BaseValidator)maskedEditValidator).ControlToValidate = "TTHYROID";
		maskedEditValidator.ControlExtender = "MaskedEditExtender28";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTHORMONE()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (THORMONE = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "THORMONE";
		return val;
	}

	[DebuggerNonUserCode]
	private MaskedEditExtender __BuildControlMaskedEditExtender29()
	{
		MaskedEditExtender maskedEditExtender = (MaskedEditExtender29 = new MaskedEditExtender());
		((Control)maskedEditExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditExtender).ID = "MaskedEditExtender29";
		((ExtenderControl)maskedEditExtender).TargetControlID = "THORMONE";
		maskedEditExtender.Mask = "N{3}";
		maskedEditExtender.MaskType = MaskedEditType.Number;
		maskedEditExtender.MessageValidatorTip = true;
		maskedEditExtender.OnFocusCssClass = "MaskedEditFocus";
		maskedEditExtender.OnInvalidCssClass = "MaskedEditError";
		maskedEditExtender.InputDirection = MaskedEditInputDirection.RightToLeft;
		maskedEditExtender.DisplayMoney = MaskedEditShowSymbol.Left;
		maskedEditExtender.AcceptNegative = MaskedEditShowSymbol.Left;
		return maskedEditExtender;
	}

	[DebuggerNonUserCode]
	private MaskedEditValidator __BuildControlMaskedEditValidator29()
	{
		MaskedEditValidator maskedEditValidator = (MaskedEditValidator29 = new MaskedEditValidator());
		((Control)maskedEditValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)maskedEditValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)maskedEditValidator).ID = "MaskedEditValidator29";
		((BaseValidator)maskedEditValidator).ControlToValidate = "THORMONE";
		maskedEditValidator.ControlExtender = "MaskedEditExtender29";
		((BaseValidator)maskedEditValidator).Display = (ValidatorDisplay)2;
		maskedEditValidator.TooltipMessage = "Please enter a value between -99999.99 and 99999.99";
		maskedEditValidator.IsValidEmpty = true;
		maskedEditValidator.InvalidValueMessage = "This Number is invalid";
		maskedEditValidator.MinimumValue = "-1000000";
		maskedEditValidator.MinimumValueMessage = "The value is too small.";
		maskedEditValidator.MaximumValue = "100000";
		maskedEditValidator.MaximumValueMessage = "The number is too large";
		return maskedEditValidator;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 262, true));
		TextBox val = __BuildControlTA1G();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		MaskedEditExtender maskedEditExtender = __BuildControlMaskedEditExtender15();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator = __BuildControlMaskedEditValidator15();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(262, 343, true));
		TextBox val2 = __BuildControlTBILIRUBIN();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		MaskedEditExtender maskedEditExtender2 = __BuildControlMaskedEditExtender16();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator2 = __BuildControlMaskedEditValidator16();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(605, 343, true));
		TextBox val3 = __BuildControlTPHOSPHATASE();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		MaskedEditExtender maskedEditExtender3 = __BuildControlMaskedEditExtender17();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator3 = __BuildControlMaskedEditValidator17();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(948, 366, true));
		TextBox val4 = __BuildControlTLD();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		MaskedEditExtender maskedEditExtender4 = __BuildControlMaskedEditExtender18();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator4 = __BuildControlMaskedEditValidator18();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1314, 367, true));
		TextBox val5 = __BuildControlTAST();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		MaskedEditExtender maskedEditExtender5 = __BuildControlMaskedEditExtender19();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator5 = __BuildControlMaskedEditValidator19();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1681, 337, true));
		TextBox val6 = __BuildControlTALT();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val6);
		MaskedEditExtender maskedEditExtender6 = __BuildControlMaskedEditExtender20();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender6);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator6 = __BuildControlMaskedEditValidator20();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator6);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2018, 330, true));
		TextBox val7 = __BuildControlTGGT();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val7);
		MaskedEditExtender maskedEditExtender7 = __BuildControlMaskedEditExtender21();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender7);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator7 = __BuildControlMaskedEditValidator21();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator7);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2348, 331, true));
		TextBox val8 = __BuildControlTIRON();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val8);
		MaskedEditExtender maskedEditExtender8 = __BuildControlMaskedEditExtender22();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender8);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator8 = __BuildControlMaskedEditValidator22();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator8);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2679, 671, true));
		TextBox val9 = __BuildControlTCHOLESTEROL();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val9);
		MaskedEditExtender maskedEditExtender9 = __BuildControlMaskedEditExtender23();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender9);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n            "));
		MaskedEditValidator maskedEditValidator9 = __BuildControlMaskedEditValidator23();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator9);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(3350, 324, true));
		TextBox val10 = __BuildControlTTRIGLYCERIDES();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val10);
		MaskedEditExtender maskedEditExtender10 = __BuildControlMaskedEditExtender24();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender10);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator10 = __BuildControlMaskedEditValidator24();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator10);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(3674, 360, true));
		TextBox val11 = __BuildControlTHDL();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val11);
		MaskedEditExtender maskedEditExtender11 = __BuildControlMaskedEditExtender25();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender11);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator11 = __BuildControlMaskedEditValidator25();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator11);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(4034, 342, true));
		TextBox val12 = __BuildControlTLDL();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val12);
		MaskedEditExtender maskedEditExtender12 = __BuildControlMaskedEditExtender26();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender12);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator12 = __BuildControlMaskedEditValidator26();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator12);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(4376, 334, true));
		TextBox val13 = __BuildControlTCHO();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val13);
		MaskedEditExtender maskedEditExtender13 = __BuildControlMaskedEditExtender27();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender13);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator13 = __BuildControlMaskedEditValidator27();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator13);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(4710, 684, true));
		TextBox val14 = __BuildControlTTHYROID();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val14);
		MaskedEditExtender maskedEditExtender14 = __BuildControlMaskedEditExtender28();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender14);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator14 = __BuildControlMaskedEditValidator28();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator14);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(5394, 334, true));
		TextBox val15 = __BuildControlTHORMONE();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val15);
		MaskedEditExtender maskedEditExtender15 = __BuildControlMaskedEditExtender29();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditExtender15);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		MaskedEditValidator maskedEditValidator15 = __BuildControlMaskedEditValidator29();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)maskedEditValidator15);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                </td>\r\n                <td style=\"width: 100px\">\r\n                </td>\r\n                <td style=\"width: 100px\">\r\n                </td>\r\n            </tr>\r\n \r\n    </table>\r\n               \r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(services_default2_aspx __ctrl)
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
		((Page)this).FrameworkInitialize();
		((TemplateControl)this).SetStringResourcePointer(RuntimeHelpers.GetObjectValue(__stringResource), 0);
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return -174856707;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
