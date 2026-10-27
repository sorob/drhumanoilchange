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

namespace ASP;

[CompilerGlobalScope]
public class lab_aspx : Lab
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public lab_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Lab.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Lab.aspx", "~/master1.master", "~/master1.master.vb", "~/Lab.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(TableItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(80, 124, 209);
		((Style)__ctrl).Font.Bold = true;
		((Style)__ctrl).ForeColor = Color.White;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox1";
		((Control)val).DataBinding += __DataBinding__control6;
		return val;
	}

	public void __DataBinding__control6(object sender, EventArgs e)
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
	private void __BuildControl__control5(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		TextBox val = __BuildControl__control6();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control5(Control __container)
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
	private HyperLink __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HyperLink val = new HyperLink();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "HyperLink1";
		((Control)val).DataBinding += __DataBinding__control8;
		return val;
	}

	public void __DataBinding__control8(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		HyperLink val = (HyperLink)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.NavigateUrl = Convert.ToString(((TemplateControl)this).Eval("bid", "LabReader.aspx?id={0}"), CultureInfo.CurrentCulture);
		val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("blogtitle")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control7(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            <ul>\r\n                                <li style=\"color: #ff9900\">\r\n                            "));
		HyperLink val = __BuildControl__control8();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                </li>\r\n                            </ul>\r\n                        "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control4()
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
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control5, (ExtractTemplateValuesMethod)__ExtractValues__control5);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control7, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).HeaderText = "img";
		((DataControlField)val).SortExpression = "img";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control3(DataControlFieldCollection __ctrl)
	{
		TemplateField val = __BuildControl__control4();
		__ctrl.Add((DataControlField)(object)val);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control9(TableItemStyle __ctrl)
	{
		__ctrl.HorizontalAlign = (HorizontalAlign)1;
		((Style)__ctrl).BorderColor = Color.LightBlue;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control10(TableItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(209, 221, 241);
		((Style)__ctrl).Font.Bold = true;
		((Style)__ctrl).ForeColor = Color.FromArgb(51, 51, 51);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control11(TableItemStyle __ctrl)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		__ctrl.HorizontalAlign = (HorizontalAlign)2;
		((Style)__ctrl).BorderColor = Color.FromArgb(255, 128, 0);
		((Style)__ctrl).BorderStyle = (BorderStyle)4;
		Unit borderWidth = new Unit(1.0, (UnitType)1);
		((Style)__ctrl).BorderWidth = borderWidth;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control12(TableItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(80, 124, 209);
		((Style)__ctrl).Font.Bold = true;
		((Style)__ctrl).ForeColor = Color.White;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control13(TableItemStyle __ctrl)
	{
		__ctrl.HorizontalAlign = (HorizontalAlign)1;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control14(TableItemStyle __ctrl)
	{
		__ctrl.HorizontalAlign = (HorizontalAlign)1;
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		GridView val = (GridView1 = new GridView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
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
		val.PageSize = 4;
		val.ShowHeader = false;
		Unit width = new Unit(93.0, (UnitType)7);
		((WebControl)val).Width = width;
		val.HorizontalAlign = (HorizontalAlign)2;
		__BuildControl__control2(val.FooterStyle);
		__BuildControl__control3(val.Columns);
		__BuildControl__control9(val.EditRowStyle);
		__BuildControl__control10(val.SelectedRowStyle);
		__BuildControl__control11(val.PagerStyle);
		__BuildControl__control12(val.HeaderStyle);
		__BuildControl__control13(val.AlternatingRowStyle);
		__BuildControl__control14(val.RowStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bid";
		val.Type = TypeCode.Int32;
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
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control15(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control16();
		__ctrl.Add(val);
		SessionParameter val2 = __BuildControl__control17();
		__ctrl.Add((Parameter)(object)val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "blogtext";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "blogtitle";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "sdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "un";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "lang";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "img";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control18(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control19();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control20();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control21();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control22();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control23();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control24();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control25();
		__ctrl.Add(val7);
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		((Parameter)val).Name = "blogtext";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control28()
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
	private Parameter __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "sdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private SessionParameter __BuildControl__control30()
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
	private Parameter __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "lang";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "img";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "thumb";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "commenting";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control26(ParameterCollection __ctrl)
	{
		ControlParameter val = __BuildControl__control27();
		__ctrl.Add((Parameter)(object)val);
		ControlParameter val2 = __BuildControl__control28();
		__ctrl.Add((Parameter)(object)val2);
		Parameter val3 = __BuildControl__control29();
		__ctrl.Add(val3);
		SessionParameter val4 = __BuildControl__control30();
		__ctrl.Add((Parameter)(object)val4);
		Parameter val5 = __BuildControl__control31();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control32();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control33();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control34();
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
		val.SelectCommand = "SELECT blogtext, blogtitle, sdate, bid, un, lang, img, thumb, commenting FROM blog WHERE (lang = 'lab') ORDER BY sdate DESC";
		val.UpdateCommand = "UPDATE [blog] SET [blogtext] = @blogtext, [blogtitle] = @blogtitle, [sdate] = @sdate, [un] = @un, [lang] = @lang, [img] = @img WHERE [bid] = @bid";
		__BuildControl__control15(val.DeleteParameters);
		__BuildControl__control18(val.UpdateParameters);
		__BuildControl__control26(val.InsertParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 508, true));
		GridView val = __BuildControlGridView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n            &nbsp;"));
		SqlDataSource val2 = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n       \r\n    </div>\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(lab_aspx __ctrl)
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
		return -758816345;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
