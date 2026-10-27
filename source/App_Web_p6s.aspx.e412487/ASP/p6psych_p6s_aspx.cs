using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayPal.Web.Controls;

namespace ASP;

[CompilerGlobalScope]
public class p6psych_p6s_aspx : P6Psych_P6s
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public p6psych_p6s_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/P6Psych/P6s.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/P6Psych/P6s.aspx", "~/master1.master", "~/master1.master.vb", "~/P6Psych/P6s.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private Image __BuildControlImage2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = (Image2 = new Image());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Image2";
		val.ImageUrl = "~/images/P6-Psych.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private AddToCartButton __BuildControlAddToCartButton1()
	{
		AddToCartButton addToCartButton = (AddToCartButton1 = new AddToCartButton());
		((Control)addToCartButton).TemplateControl = (TemplateControl)(object)this;
		((Control)addToCartButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)addToCartButton).ID = "AddToCartButton1";
		addToCartButton.Amount = 2999.0;
		addToCartButton.BusinessEmail = "dralaguirre2@hotmail.com";
		((Image)addToCartButton).DescriptionUrl = "http://HumanOilChange.com/p6psych.aspx";
		addToCartButton.DoNotAskShipping = true;
		((Image)addToCartButton).ImageUrl = "~/images/basket.gif";
		addToCartButton.ItemName = "P6-Psych Professional Edition (Single Licensed Doctor)";
		addToCartButton.ItemNumber = "17552";
		addToCartButton.ReturlUrlBehavior = ReturnBehavior.ReturnPost;
		addToCartButton.ReturnUrl = "http://HumanOilChange.com/buy.aspx";
		addToCartButton.UseSandbox = false;
		addToCartButton.Option1FieldName = "Username";
		return addToCartButton;
	}

	[DebuggerNonUserCode]
	private AddToCartButton __BuildControlAddToCartButton2()
	{
		AddToCartButton addToCartButton = (AddToCartButton2 = new AddToCartButton());
		((Control)addToCartButton).TemplateControl = (TemplateControl)(object)this;
		((Control)addToCartButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)addToCartButton).ID = "AddToCartButton2";
		addToCartButton.Amount = 1499.0;
		addToCartButton.BusinessEmail = "dralaguirre2@hotmail.com";
		((Image)addToCartButton).DescriptionUrl = "http://HumanOilChange.com/p6psych.aspx";
		addToCartButton.DoNotAskShipping = true;
		((Image)addToCartButton).ImageUrl = "~/images/basket.gif";
		addToCartButton.ItemName = "P6-Psych Businesses Edition ";
		addToCartButton.ItemNumber = "17552";
		addToCartButton.ReturlUrlBehavior = ReturnBehavior.ReturnPost;
		addToCartButton.ReturnUrl = "http://HumanOilChange.com/buy.aspx";
		addToCartButton.UseSandbox = false;
		addToCartButton.Option1FieldName = "Username";
		return addToCartButton;
	}

	[DebuggerNonUserCode]
	private AddToCartButton __BuildControlAddToCartButton3()
	{
		AddToCartButton addToCartButton = (AddToCartButton3 = new AddToCartButton());
		((Control)addToCartButton).TemplateControl = (TemplateControl)(object)this;
		((Control)addToCartButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)addToCartButton).ID = "AddToCartButton3";
		addToCartButton.Amount = 999.0;
		addToCartButton.BusinessEmail = "dralaguirre2@hotmail.com";
		((Image)addToCartButton).DescriptionUrl = "http://HumanOilChange.com/p6psych.aspx";
		addToCartButton.DoNotAskShipping = true;
		((Image)addToCartButton).ImageUrl = "~/images/basket.gif";
		addToCartButton.ItemName = "P6-Psych Non-Professional Edition";
		addToCartButton.ItemNumber = "17552";
		addToCartButton.ReturlUrlBehavior = ReturnBehavior.ReturnPost;
		addToCartButton.ReturnUrl = "http://HumanOilChange.com/buy.aspx";
		addToCartButton.UseSandbox = false;
		addToCartButton.Option1FieldName = "Username";
		return addToCartButton;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <table border=\"0\" style=\"width: 100%; height: 100%\">\r\n        <tr>\r\n            <td width=\"100\">\r\n                "));
		Image val = __BuildControlImage2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 634, true));
		AddToCartButton addToCartButton = __BuildControlAddToCartButton1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)addToCartButton);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(634, 640, true));
		AddToCartButton addToCartButton2 = __BuildControlAddToCartButton2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)addToCartButton2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1274, 563, true));
		AddToCartButton addToCartButton3 = __BuildControlAddToCartButton3();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)addToCartButton3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1837, 402, true));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(p6psych_p6s_aspx __ctrl)
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
		return -2125414751;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
