using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayPal.Web.Controls;

namespace ASP;

[CompilerGlobalScope]
public class services_2p_aspx : Services_2P
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public services_2p_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Services/2P.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Services/2P.aspx", "~/master1.master", "~/master1.master.vb", "~/Services/2P.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private AddToCartButton __BuildControlAddToCartButton1()
	{
		AddToCartButton addToCartButton = (AddToCartButton1 = new AddToCartButton());
		((Control)addToCartButton).TemplateControl = (TemplateControl)(object)this;
		((Control)addToCartButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)addToCartButton).ID = "AddToCartButton1";
		addToCartButton.ItemNumber = "2000";
		addToCartButton.ItemName = "Family Health Assurance";
		addToCartButton.Option1FieldName = "Username";
		addToCartButton.UseSandbox = false;
		addToCartButton.ReturnUrl = "http://HumanOilChange.com/buy.aspx";
		addToCartButton.ReturlUrlBehavior = ReturnBehavior.ReturnPost;
		((Image)addToCartButton).ImageUrl = "~/images/buy.gif";
		addToCartButton.DoNotAskShipping = true;
		((Image)addToCartButton).DescriptionUrl = "http://HumanOilChange.com/p6psych.aspx";
		addToCartButton.BusinessEmail = "dralaguirre2@hotmail.com";
		addToCartButton.Amount = 5100.0;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)addToCartButton).SetAttribute("dtid", "4222124650659856");
		}
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)addToCartButton).SetAttribute("errorcontrol", "This control cannot be displayed because its TagPrefix is not registered in this Web Form.");
		}
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)addToCartButton).SetAttribute("wfdid", "w2");
		}
		return addToCartButton;
	}

	[DebuggerNonUserCode]
	private AddToCartButton __BuildControlAddtocartbutton2()
	{
		AddToCartButton addToCartButton = (Addtocartbutton2 = new AddToCartButton());
		((Control)addToCartButton).TemplateControl = (TemplateControl)(object)this;
		((Control)addToCartButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)addToCartButton).ID = "Addtocartbutton2";
		addToCartButton.Amount = 5100.0;
		addToCartButton.BusinessEmail = "dralaguirre2@hotmail.com";
		((Image)addToCartButton).DescriptionUrl = "http://HumanOilChange.com/p6psych.aspx";
		addToCartButton.DoNotAskShipping = true;
		((Image)addToCartButton).ImageUrl = "~/images/buy.gif";
		addToCartButton.ItemName = "Family Health Assurance";
		addToCartButton.ItemNumber = "2000";
		addToCartButton.Option1FieldName = "Username";
		addToCartButton.ReturlUrlBehavior = ReturnBehavior.ReturnPost;
		addToCartButton.ReturnUrl = "http://HumanOilChange.com/buy.aspx";
		addToCartButton.UseSandbox = false;
		return addToCartButton;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 891, true));
		AddToCartButton addToCartButton = __BuildControlAddToCartButton1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)addToCartButton);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(891, 5211, false));
		AddToCartButton addToCartButton2 = __BuildControlAddtocartbutton2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)addToCartButton2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</p>\r\n</div></p>"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(services_2p_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = " The Deal of a Lifetime-Family Plan";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n"));
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
		return -528243672;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
