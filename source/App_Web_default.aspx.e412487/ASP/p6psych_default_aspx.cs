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
public class p6psych_default_aspx : P6Psych_Default
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public p6psych_default_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/P6Psych/Default.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/P6Psych/Default.aspx", "~/master1.master", "~/master1.master.vb", "~/P6Psych/Default.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label1 = new Label());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label1";
		val.Text = "Label";
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControlLinkButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		LinkButton val = (LinkButton1 = new LinkButton());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton1";
		((WebControl)val).Font.Bold = true;
		((WebControl)val).Font.Size = FontUnit.Medium;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("Download P6-Psych V1.1 Trial Version"));
		return val;
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControlHyperLink1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		HyperLink val = (HyperLink1 = new HyperLink());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "HyperLink1";
		val.ImageUrl = "~/images/buy.gif";
		val.NavigateUrl = "~/P6Psych/P6s.aspx";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("Buy"));
		return val;
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControlHyperLink2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		HyperLink val = (HyperLink2 = new HyperLink());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "HyperLink2";
		((WebControl)val).Font.Bold = true;
		((WebControl)val).Font.Size = FontUnit.Medium;
		val.NavigateUrl = "http://www.microsoft.com/downloads/details.aspx?familyid=262D25E3-F589-4842-8157-034D1E7CF3A3&displaylang=en";
		val.Target = "_blank";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("Download Microsoft Framewor V1.1.4"));
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Download_name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "download_date";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control3();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control4();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control5();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Download_name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "download_date";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "id";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control6(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control7();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control8();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control9();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control10();
		__ctrl.Add(val4);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "id";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control11(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control12();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [download] WHERE [id] = @id";
		val.InsertCommand = "INSERT INTO [download] ([UserName], [Download_name], [download_date]) VALUES (@UserName, @Download_name, @download_date)";
		val.SelectCommand = "SELECT [UserName], [Download_name], [download_date], [id] FROM [download]";
		val.UpdateCommand = "UPDATE [download] SET [UserName] = @UserName, [Download_name] = @Download_name, [download_date] = @download_date WHERE [id] = @id";
		__BuildControl__control2(val.InsertParameters);
		__BuildControl__control6(val.UpdateParameters);
		__BuildControl__control11(val.DeleteParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 318, true));
		Label val = __BuildControlLabel1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n        </tr>\r\n        <tr>\r\n            <td align=\"center\" style=\"height: 19px\">\r\n                "));
		LinkButton val2 = __BuildControlLinkButton1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("<br />\r\n                "));
		HyperLink val3 = __BuildControlHyperLink1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(318, 283, true));
		HyperLink val4 = __BuildControlHyperLink2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n        </tr>\r\n    </table>\r\n    "));
		SqlDataSource val5 = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(p6psych_default_aspx __ctrl)
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
		return 964415479;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
