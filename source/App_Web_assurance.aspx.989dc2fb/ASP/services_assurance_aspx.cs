using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using PayPal.Web.Controls;

namespace ASP;

[CompilerGlobalScope]
public class services_assurance_aspx : Services_Assurance
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public services_assurance_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Services/Assurance.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[2] { "~/Services/Assurance.aspx", "~/Services/Assurance.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private HtmlTitle __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		HtmlTitle val = new HtmlTitle();
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Human Oil Change"));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlHead __BuildControl__control2()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		HtmlHead val = new HtmlHead("head");
		HtmlTitle val2 = __BuildControl__control3();
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)val2);
		return val;
	}

	[DebuggerNonUserCode]
	private AddToCartButton __BuildControlAddToCartButton3()
	{
		AddToCartButton addToCartButton = (AddToCartButton3 = new AddToCartButton());
		((Control)addToCartButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)addToCartButton).ID = "AddToCartButton3";
		addToCartButton.Amount = 1020.0;
		addToCartButton.BusinessEmail = "dralaguirre2@hotmail.com";
		((Image)addToCartButton).DescriptionUrl = "http://HumanOilChange.com/p6psych.aspx";
		addToCartButton.DoNotAskShipping = true;
		((Image)addToCartButton).ImageUrl = "~/images/basket.gif";
		addToCartButton.ItemName = "21-day trial Health Insurance Membership";
		addToCartButton.ItemNumber = "18976";
		addToCartButton.ReturlUrlBehavior = ReturnBehavior.ReturnPost;
		addToCartButton.ReturnUrl = "http://HumanOilChange.com/buy.aspx";
		addToCartButton.UseSandbox = false;
		addToCartButton.Option1FieldName = "UserName";
		return addToCartButton;
	}

	[DebuggerNonUserCode]
	private HtmlForm __BuildControlform1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlForm val = (form1 = new HtmlForm());
		((Control)val).ID = "form1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 37744, false));
		AddToCartButton addToCartButton = __BuildControlAddToCartButton3();
		val3.AddParsedSubObject((object)addToCartButton);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(37744, 5463, false));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(services_assurance_aspx __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		((Page)this).InitializeCulture();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\" >\r\n"));
		HtmlHead val = __BuildControl__control2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n<body bottommargin=\"0\" leftmargin=\"0\" rightmargin=\"0\" topmargin=\"0\">\r\n    "));
		HtmlForm val2 = __BuildControlform1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n</body>\r\n</html>\r\n"));
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
		return -284508058;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
