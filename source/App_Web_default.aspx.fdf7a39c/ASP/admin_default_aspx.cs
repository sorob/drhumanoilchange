using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreeTextBoxControls;
using Sample.Web.UI.Compatibility;

namespace ASP;

[CompilerGlobalScope]
public class admin_default_aspx : WebManager
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_default_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/Default.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/Default.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/Default.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControlHyperLink4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		HyperLink val = (HyperLink4 = new HyperLink());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "HyperLink4";
		val.ImageUrl = "~/images/editblog.png";
		val.NavigateUrl = "~/ADMIN/default.aspx";
		((WebControl)val).ToolTip = "ارسال بلاگ جدید";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("Compose"));
		return val;
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControlHyperLink5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		HyperLink val = (HyperLink5 = new HyperLink());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "HyperLink5";
		val.NavigateUrl = "~/ADMIN/default.aspx";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("Edit Documents"));
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlEditView()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		View val = (EditView = new View());
		((Control)val).ID = "EditView";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <table style=\"width: 249px\">\r\n                <tr>\r\n                    <td width=\"32\">\r\n                        "));
		HyperLink val4 = __BuildControlHyperLink4();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                    <td>\r\n                        "));
		HyperLink val5 = __BuildControlHyperLink5();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                </tr>\r\n            </table>\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControlHyperLink3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		HyperLink val = (HyperLink3 = new HyperLink());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "HyperLink3";
		val.ImageUrl = "~/images/compose.png";
		val.NavigateUrl = "~/ADMIN/default.aspx?mode=new";
		((WebControl)val).ToolTip = "ارسال بلاگ جدید";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("Compose"));
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControladdView()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		View val = (addView = new View());
		((Control)val).ID = "addView";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <table style=\"width: 249px\">\r\n                <tr>\r\n                    <td width=\"32\" style=\"height: 47px\">\r\n                        "));
		HyperLink val4 = __BuildControlHyperLink3();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                    <td style=\"height: 47px\">\r\n                        <a href=\"default.aspx?mode=new\">f</a></td>\r\n                </tr>\r\n            </table>\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private MultiView __BuildControlMultiView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		MultiView val = (MultiView2 = new MultiView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "MultiView2";
		val.ActiveViewIndex = 1;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val4 = __BuildControlEditView();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val5 = __BuildControladdView();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    "));
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControllblmsg()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (lblmsg = new Label());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "lblmsg";
		((WebControl)val).ForeColor = Color.Red;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private SessionParameter __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SessionParameter val = new SessionParameter();
		((Parameter)val).Name = "un";
		val.SessionField = "Un";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control3();
		__ctrl.Add(val);
		SessionParameter val2 = __BuildControl__control4();
		__ctrl.Add((Parameter)(object)val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "blogtext";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "blogtitle";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "sdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "un";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "lang";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "img";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control5(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control6();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control7();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control8();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control9();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control10();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control11();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control12();
		__ctrl.Add(val7);
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		((Parameter)val).Name = "blogtext";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "txtsubject";
		((Parameter)val).Name = "blogtitle";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "sdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private SessionParameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SessionParameter val = new SessionParameter();
		((Parameter)val).Name = "un";
		val.SessionField = "Un";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "lang";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "img";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "thumb";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "commenting";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control13(ParameterCollection __ctrl)
	{
		ControlParameter val = __BuildControl__control14();
		__ctrl.Add((Parameter)(object)val);
		ControlParameter val2 = __BuildControl__control15();
		__ctrl.Add((Parameter)(object)val2);
		Parameter val3 = __BuildControl__control16();
		__ctrl.Add(val3);
		SessionParameter val4 = __BuildControl__control17();
		__ctrl.Add((Parameter)(object)val4);
		Parameter val5 = __BuildControl__control18();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control19();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control20();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control21();
		__ctrl.Add(val8);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [blog] WHERE [bid] = @bid and [un] = @un";
		val.InsertCommand = "INSERT INTO blog(blogtext, blogtitle, sdate, un, lang, img, thumb, commenting) VALUES (@blogtext, @blogtitle, @sdate, @un, @lang, @img, @thumb, @commenting)";
		val.SelectCommand = "SELECT blogtext, blogtitle, sdate, bid, un, lang, img, thumb, commenting FROM blog  ORDER BY sdate DESC";
		val.UpdateCommand = "UPDATE [blog] SET [blogtext] = @blogtext, [blogtitle] = @blogtitle, [sdate] = @sdate, [un] = @un, [lang] = @lang, [img] = @img WHERE [bid] = @bid";
		__BuildControl__control2(val.DeleteParameters);
		__BuildControl__control5(val.UpdateParameters);
		__BuildControl__control13(val.InsertParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control22(TableItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(80, 124, 209);
		((Style)__ctrl).Font.Bold = true;
		((Style)__ctrl).ForeColor = Color.White;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox1";
		((Control)val).DataBinding += __DataBinding__control26;
		return val;
	}

	public void __DataBinding__control26(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("img")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control25(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		TextBox val = __BuildControl__control26();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control25(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox1");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["img"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TitleLbl";
		((WebControl)val).Font.Bold = true;
		((WebControl)val).ForeColor = Color.White;
		((Control)val).DataBinding += __DataBinding__control28;
		return val;
	}

	public void __DataBinding__control28(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("blogtitle")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextLbl";
		((Control)val).DataBinding += __DataBinding__control29;
		return val;
	}

	public void __DataBinding__control29(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("blogtext")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DateLbl";
		((Control)val).DataBinding += __DataBinding__control30;
		return val;
	}

	public void __DataBinding__control30(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("sdate")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		HyperLink val = new HyperLink();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "HyperLink1";
		val.ImageUrl = "~/images/edit.png";
		((WebControl)val).ToolTip = "Edit";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Edit"));
		((Control)val).DataBinding += __DataBinding__control31;
		return val;
	}

	public void __DataBinding__control31(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		HyperLink val = (HyperLink)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.NavigateUrl = Convert.ToString(((TemplateControl)this).Eval("bid", "default.aspx?editid={0}"), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private ImageButton __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ImageButton val = new ImageButton();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "cmdDel2";
		((Image)val).ImageUrl = "~/images/delete.png";
		val.CausesValidation = false;
		val.CommandName = "Delete";
		((WebControl)val).ToolTip = "Delete";
		((Control)val).DataBinding += __DataBinding__control32;
		return val;
	}

	public void __DataBinding__control32(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		ImageButton val = (ImageButton)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.CommandArgument = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("bid")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control27(Control __ctrl)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 419, true));
		Label val = __BuildControl__control28();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td colspan=\"3\">\r\n                                        "));
		Label val2 = __BuildControl__control29();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td style=\"width: 80%; height: 21px\">\r\n                                        "));
		Label val3 = __BuildControl__control30();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(419, 473, true));
		HyperLink val4 = __BuildControl__control31();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                                <td style=\"width: 100px\" align=\"center\">\r\n                                                    "));
		ImageButton val5 = __BuildControl__control32();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                            </tr>\r\n                                        </table>\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                        "));
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TitleLbl";
		((WebControl)val).Font.Bold = true;
		((WebControl)val).ForeColor = Color.White;
		((Control)val).DataBinding += __DataBinding__control34;
		return val;
	}

	public void __DataBinding__control34(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("blogtitle")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextLbl";
		((Control)val).DataBinding += __DataBinding__control35;
		return val;
	}

	public void __DataBinding__control35(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("blogtext")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control36()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DateLbl";
		((Control)val).DataBinding += __DataBinding__control36;
		return val;
	}

	public void __DataBinding__control36(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("sdate")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControl__control37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		HyperLink val = new HyperLink();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "HyperLink1";
		val.ImageUrl = "~/images/edit.png";
		((WebControl)val).ToolTip = "Edit";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Edit"));
		((Control)val).DataBinding += __DataBinding__control37;
		return val;
	}

	public void __DataBinding__control37(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		HyperLink val = (HyperLink)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.NavigateUrl = Convert.ToString(((TemplateControl)this).Eval("bid", "default.aspx?editid={0}"), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private ImageButton __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ImageButton val = new ImageButton();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "cmdDel1";
		val.CausesValidation = false;
		val.CommandName = "Delete";
		((Image)val).ImageUrl = "~/images/delete.png";
		((Control)val).DataBinding += __DataBinding__control38;
		return val;
	}

	public void __DataBinding__control38(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		ImageButton val = (ImageButton)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.CommandArgument = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("bid")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control33(Control __ctrl)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(892, 402, true));
		Label val = __BuildControl__control34();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td colspan=\"3\">\r\n                                        "));
		Label val2 = __BuildControl__control35();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td style=\"width: 80%; height: 21px\">\r\n                                        "));
		Label val3 = __BuildControl__control36();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1294, 473, true));
		HyperLink val4 = __BuildControl__control37();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                                <td style=\"width: 100px\" align=\"center\">\r\n                                                    "));
		ImageButton val5 = __BuildControl__control38();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                            </tr>\r\n                                        </table>\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                        "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control25, (ExtractTemplateValuesMethod)__ExtractValues__control25);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control27, (ExtractTemplateValuesMethod)null);
		val.AlternatingItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control33, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).HeaderText = "img";
		((DataControlField)val).SortExpression = "img";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control23(DataControlFieldCollection __ctrl)
	{
		TemplateField val = __BuildControl__control24();
		__ctrl.Add((DataControlField)(object)val);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control39(TableItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(36, 97, 191);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control40(TableItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(209, 221, 241);
		((Style)__ctrl).Font.Bold = true;
		((Style)__ctrl).ForeColor = Color.FromArgb(51, 51, 51);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control41(TableItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(36, 97, 191);
		((Style)__ctrl).ForeColor = Color.White;
		__ctrl.HorizontalAlign = (HorizontalAlign)2;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control42(TableItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(80, 124, 209);
		((Style)__ctrl).Font.Bold = true;
		((Style)__ctrl).ForeColor = Color.White;
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		GridView val = (GridView1 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AllowPaging = true;
		val.AutoGenerateColumns = false;
		val.CellPadding = 4;
		val.DataKeyNames = new string[1] { "bid" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		((WebControl)val).ForeColor = Color.FromArgb(51, 51, 51);
		val.GridLines = (GridLines)0;
		Unit width = new Unit(100.0, (UnitType)7);
		((WebControl)val).Width = width;
		val.ShowHeader = false;
		val.PageSize = 4;
		((DataBoundControl)val).DataMember = "DefaultView";
		__BuildControl__control22(val.FooterStyle);
		__BuildControl__control23(val.Columns);
		__BuildControl__control39(val.EditRowStyle);
		__BuildControl__control40(val.SelectedRowStyle);
		__BuildControl__control41(val.PagerStyle);
		__BuildControl__control42(val.HeaderStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		GridView val4 = __BuildControlGridView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label1 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label1";
		val.Text = "Subject :";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControltxtsubject()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (txtsubject = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "txtsubject";
		Unit width = new Unit(282.0, (UnitType)1);
		((WebControl)val).Width = width;
		val.MaxLength = 199;
		val.TextMode = (TextBoxMode)1;
		return val;
	}

	[DebuggerNonUserCode]
	private RequiredFieldValidator __BuildControlRequiredFieldValidator1()
	{
		RequiredFieldValidator requiredFieldValidator = (RequiredFieldValidator1 = new RequiredFieldValidator());
		((Control)requiredFieldValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)requiredFieldValidator).ID = "RequiredFieldValidator1";
		((BaseValidator)requiredFieldValidator).ControlToValidate = "txtsubject";
		((BaseValidator)requiredFieldValidator).Display = (ValidatorDisplay)2;
		((BaseValidator)requiredFieldValidator).ErrorMessage = "Please enter the subject";
		return requiredFieldValidator;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label3 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label3";
		val.Text = "Picture :";
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
		((Control)val).Visible = false;
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label2 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label2";
		val.Text = "Category:";
		return val;
	}

	[DebuggerNonUserCode]
	private Image __BuildControlImage1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = (Image1 = new Image());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Image1";
		val.ImageUrl = "~/images/spacer.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "doc";
		val.Text = "Documents";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "faq";
		val.Text = "F.A.Q";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "lab";
		val.Text = "Lab Results";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control43(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control44();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control45();
		__ctrl.Add(val2);
		ListItem val3 = __BuildControl__control46();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControldrcat()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (drcat = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "drcat";
		Unit width = new Unit(153.0, (UnitType)1);
		((WebControl)val).Width = width;
		__BuildControl__control43(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private FreeTextBox __BuildControlFreeTextBox1()
	{
		FreeTextBox freeTextBox = (FreeTextBox1 = new FreeTextBox());
		((Control)freeTextBox).ID = "FreeTextBox1";
		freeTextBox.StartMode = EditorMode.DesignMode;
		freeTextBox.ToolbarLayout = "ParagraphMenu,FontFacesMenu,FontSizesMenu,FontForeColorsMenu,FontForeColorPicker,FontBackColorsMenu,FontBackColorPicker|Bold,Italic,Underline,Strikethrough,Superscript,Subscript,RemoveFormat|JustifyLeft,JustifyRight,JustifyCenter,JustifyFull;BulletedList,NumberedList,Indent,Outdent;CreateLink,Unlink,InsertImage|Cut,Copy,Paste,Delete;Undo,Redo,Print,Save|SymbolsMenu,StylesMenu,InsertHtmlMenu|InsertRule,InsertDate,InsertTime|InsertTable,EditTable;InsertTableRowAfter,InsertTableRowBefore,DeleteTableRow;InsertTableColumnAfter,InsertTableColumnBefore,DeleteTableColumn|InsertForm,InsertTextBox,InsertTextArea,InsertRadioButton,InsertCheckBox,InsertDropDownList,InsertButton|InsertDiv,EditStyle,InsertImageFromGallery,Preview,SelectAll,WordClean,NetSpell";
		return freeTextBox;
	}

	[DebuggerNonUserCode]
	private CheckBox __BuildControlCheckBox1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CheckBox val = (CheckBox1 = new CheckBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "CheckBox1";
		val.Checked = true;
		val.Text = "Enable Commenting System";
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1767, 543, true));
		Label val4 = __BuildControlLabel1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                                            <td width=\"150\">\r\n                                                "));
		TextBox val5 = __BuildControltxtsubject();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                                            <td>\r\n                                                "));
		RequiredFieldValidator requiredFieldValidator = __BuildControlRequiredFieldValidator1();
		val3.AddParsedSubObject((object)requiredFieldValidator);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td style=\"width: 60px\">\r\n                                                "));
		Label val6 = __BuildControlLabel3();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                                            <td width=\"150\">\r\n                                                "));
		FileUpload val7 = __BuildControlFileUpload1();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2310, 323, true));
		Label val8 = __BuildControlLabel2();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                                            <td width=\"150\">\r\n                                                "));
		Image val9 = __BuildControlImage1();
		val3.AddParsedSubObject((object)val9);
		DropDownList val10 = __BuildControldrcat();
		val3.AddParsedSubObject((object)val10);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n                                            <td>\r\n                                            </td>\r\n                                        </tr>\r\n                                    </table>\r\n                                    "));
		FreeTextBox freeTextBox = __BuildControlFreeTextBox1();
		val3.AddParsedSubObject((object)freeTextBox);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>\r\n                                    "));
		CheckBox val11 = __BuildControlCheckBox1();
		val3.AddParsedSubObject((object)val11);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2633, 407, true));
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
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		MultiView val = __BuildControlMultiView2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"width: 100%\">\r\n        <tr>\r\n            <td align=\"center\">\r\n                "));
		Label val2 = __BuildControllblmsg();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n        </tr>\r\n    </table>\r\n    <br />\r\n    "));
		SqlDataSource val3 = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		MultiView val4 = __BuildControlMultiView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("<br />\r\n    &nbsp;\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_default_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "New Lab result entry";
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
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 1093655682;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
