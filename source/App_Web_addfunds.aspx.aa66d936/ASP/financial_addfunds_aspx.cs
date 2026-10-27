using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayPal.Web.Controls;

namespace ASP;

[CompilerGlobalScope]
public class financial_addfunds_aspx : Financial_AddFunds
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public financial_addfunds_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Financial/AddFunds.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Financial/AddFunds.aspx", "~/master1.master", "~/master1.master.vb", "~/Financial/AddFunds.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabelusr()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Label val = (Labelusr = new Label());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Labelusr";
		Unit width = new Unit(149.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabelamnt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Label val = (Labelamnt = new Label());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Labelamnt";
		Unit width = new Unit(149.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private AddToCartButton __BuildControlAddToCartButton2()
	{
		AddToCartButton addToCartButton = (AddToCartButton2 = new AddToCartButton());
		((Control)addToCartButton).TemplateControl = (TemplateControl)(object)this;
		((Control)addToCartButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)addToCartButton).ID = "AddToCartButton2";
		addToCartButton.Amount = 1499.0;
		addToCartButton.BusinessEmail = "dralaguirre2@aol.com";
		((Image)addToCartButton).DescriptionUrl = "http://HumanOilChange.com/";
		addToCartButton.DoNotAskShipping = true;
		((Image)addToCartButton).ImageUrl = "~/images/x-click-but6.gif";
		addToCartButton.ItemName = "HumanOilChange.com Quick Checkout Account Payment";
		addToCartButton.ItemNumber = "10002";
		addToCartButton.ReturlUrlBehavior = ReturnBehavior.ReturnPost;
		addToCartButton.ReturnUrl = "http://HumanOilChange.com/buy.aspx";
		addToCartButton.UseSandbox = false;
		addToCartButton.Option1FieldName = "Username";
		return addToCartButton;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 1113, true));
		Label val = __BuildControlLabelusr();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Amount of payment:</td>\r\n                <td>\r\n                    $"));
		Label val2 = __BuildControlLabelamnt();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1113, 399, true));
		AddToCartButton addToCartButton = __BuildControlAddToCartButton2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)addToCartButton);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("&nbsp;</form>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(financial_addfunds_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Add Funds";
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
		return 1232517727;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
