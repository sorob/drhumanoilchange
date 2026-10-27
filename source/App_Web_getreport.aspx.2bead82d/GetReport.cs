using System;
using System.Collections;
using System.Configuration;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;
using LabstuffTableAdapters;
using Microsoft.VisualBasic.CompilerServices;

public class GetReport : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Head1")]
	private HtmlHead _Head1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("ScriptManager1")]
	private ScriptManager _ScriptManager1;

	[AccessedThroughProperty("LinkButton1")]
	private LinkButton _LinkButton1;

	[AccessedThroughProperty("LinkButton2")]
	private LinkButton _LinkButton2;

	[AccessedThroughProperty("LinkButton3")]
	private LinkButton _LinkButton3;

	[AccessedThroughProperty("CrystalReportViewer1")]
	private CrystalReportViewer _CrystalReportViewer1;

	[AccessedThroughProperty("UpdatePanel1")]
	private UpdatePanel _UpdatePanel1;

	[AccessedThroughProperty("form1")]
	private HtmlForm _form1;

	protected virtual HtmlHead Head1
	{
		get
		{
			return _Head1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Head1 = value;
		}
	}

	protected virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	protected virtual ScriptManager ScriptManager1
	{
		get
		{
			return _ScriptManager1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ScriptManager1 = value;
		}
	}

	protected virtual LinkButton LinkButton1
	{
		get
		{
			return _LinkButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LinkButton1_Click;
			if (_LinkButton1 != null)
			{
				_LinkButton1.Click -= eventHandler;
			}
			_LinkButton1 = value;
			if (_LinkButton1 != null)
			{
				_LinkButton1.Click += eventHandler;
			}
		}
	}

	protected virtual LinkButton LinkButton2
	{
		get
		{
			return _LinkButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LinkButton2_Click;
			if (_LinkButton2 != null)
			{
				_LinkButton2.Click -= eventHandler;
			}
			_LinkButton2 = value;
			if (_LinkButton2 != null)
			{
				_LinkButton2.Click += eventHandler;
			}
		}
	}

	protected virtual LinkButton LinkButton3
	{
		get
		{
			return _LinkButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LinkButton3_Click;
			if (_LinkButton3 != null)
			{
				_LinkButton3.Click -= eventHandler;
			}
			_LinkButton3 = value;
			if (_LinkButton3 != null)
			{
				_LinkButton3.Click += eventHandler;
			}
		}
	}

	protected virtual CrystalReportViewer CrystalReportViewer1
	{
		get
		{
			return _CrystalReportViewer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			NavigateEventHandler val = CrystalReportViewer1_Navigate;
			if (_CrystalReportViewer1 != null)
			{
				_CrystalReportViewer1.Navigate -= val;
			}
			_CrystalReportViewer1 = value;
			if (_CrystalReportViewer1 != null)
			{
				_CrystalReportViewer1.Navigate += val;
			}
		}
	}

	protected virtual UpdatePanel UpdatePanel1
	{
		get
		{
			return _UpdatePanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UpdatePanel1 = value;
		}
	}

	protected virtual HtmlForm form1
	{
		get
		{
			return _form1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_form1 = value;
		}
	}

	protected DefaultProfile Profile
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected Obj, but got Unknown
			return (DefaultProfile)((Page)this).Context.Profile;
		}
	}

	protected HttpApplication ApplicationInstance => ((Page)this).Context.ApplicationInstance;

	public GetReport()
	{
		((Control)this).Load += Page_Load;
		((Page)this).LoadComplete += Page_LoadComplete;
	}

	private void ConfigureCrystalReports()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ConnectionInfo val = new ConnectionInfo();
		ConnectionStringSettings val2 = ConfigurationManager.ConnectionStrings["LocalSqlServer"];
		DbConnectionStringBuilder dbConnectionStringBuilder = new DbConnectionStringBuilder();
		dbConnectionStringBuilder.ConnectionString = val2.ConnectionString;
		ConnectionInfo val3 = val;
		object value = val3.ServerName;
		bool flag = dbConnectionStringBuilder.TryGetValue("Data Source", out value);
		val3.ServerName = Conversions.ToString(value);
		ConnectionInfo val4 = val;
		object value2 = val4.UserID;
		bool flag2 = dbConnectionStringBuilder.TryGetValue("User ID", out value2);
		val4.UserID = Conversions.ToString(value2);
		bool num = flag & flag2;
		ConnectionInfo val5 = val;
		object value3 = val5.Password;
		bool flag3 = dbConnectionStringBuilder.TryGetValue("Password", out value3);
		val5.Password = Conversions.ToString(value3);
		bool num2 = num & flag3;
		ConnectionInfo val6 = val;
		object value4 = val6.DatabaseName;
		bool flag4 = dbConnectionStringBuilder.TryGetValue("Initial Catalog", out value4);
		val6.DatabaseName = Conversions.ToString(value4);
		if (num2 & flag4)
		{
			SetDBLogonForReport(val);
		}
		else
		{
			((Page)this).Response.Write("error in connection");
		}
	}

	private void SetDBLogonForReport(ConnectionInfo myConnectionInfo)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		TableLogOnInfos logOnInfo = ((CrystalReportViewerBase)CrystalReportViewer1).LogOnInfo;
		if (((ArrayList)(object)logOnInfo).Count > 0)
		{
			foreach (TableLogOnInfo item in (ArrayList)(object)logOnInfo)
			{
				TableLogOnInfo val = item;
				val.ConnectionInfo = myConnectionInfo;
				NonHTTPCachedReportSource val2 = (NonHTTPCachedReportSource)((CrystalReportViewerBase)CrystalReportViewer1).ReportSource;
			}
			return;
		}
		TableLogOnInfo val3 = new TableLogOnInfo();
		val3.ConnectionInfo = myConnectionInfo;
		logOnInfo.Add((object)val3);
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		if (!((Page)this).IsPostBack)
		{
			showreport("sec.rpt");
			return;
		}
		try
		{
			CrystalReportViewer1.ReportSource = RuntimeHelpers.GetObjectValue(((Page)this).Session["lastreport"]);
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["currentpage"], CrystalReportViewer1.ViewInfo.PageNumber, TextCompare: false), Operators.CompareObjectGreater(((Page)this).Session["currentpage"], 0, TextCompare: false))))
			{
				CrystalReportViewer1.ShowNthPage(Conversions.ToInteger(((Page)this).Session["currentpage"]));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		ConnectionInfo val = new ConnectionInfo();
		ConnectionStringSettings val2 = ConfigurationManager.ConnectionStrings["LocalSqlServer"];
		DbConnectionStringBuilder dbConnectionStringBuilder = new DbConnectionStringBuilder();
		dbConnectionStringBuilder.ConnectionString = val2.ConnectionString;
		ConnectionInfo val3 = val;
		object value = val3.ServerName;
		bool flag = dbConnectionStringBuilder.TryGetValue("Data Source", out value);
		val3.ServerName = Conversions.ToString(value);
		ConnectionInfo val4 = val;
		object value2 = val4.UserID;
		bool flag2 = dbConnectionStringBuilder.TryGetValue("User ID", out value2);
		val4.UserID = Conversions.ToString(value2);
		bool num = flag & flag2;
		ConnectionInfo val5 = val;
		object value3 = val5.Password;
		bool flag3 = dbConnectionStringBuilder.TryGetValue("Password", out value3);
		val5.Password = Conversions.ToString(value3);
		bool num2 = num & flag3;
		ConnectionInfo val6 = val;
		object value4 = val6.DatabaseName;
		bool flag4 = dbConnectionStringBuilder.TryGetValue("Initial Catalog", out value4);
		val6.DatabaseName = Conversions.ToString(value4);
		if (num2 & flag4)
		{
			SetDBLogonForReport(val);
		}
		else
		{
			((Page)this).Response.Write("error in connection");
		}
	}

	public void Impersonate(ReportDocument myRpt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		ConnectionInfo val = new ConnectionInfo();
		ConnectionStringSettings val2 = ConfigurationManager.ConnectionStrings["LocalSqlServer"];
		DbConnectionStringBuilder dbConnectionStringBuilder = new DbConnectionStringBuilder();
		dbConnectionStringBuilder.ConnectionString = val2.ConnectionString;
		ConnectionInfo val3 = val;
		object value = val3.ServerName;
		bool flag = dbConnectionStringBuilder.TryGetValue("Data Source", out value);
		val3.ServerName = Conversions.ToString(value);
		ConnectionInfo val4 = val;
		object value2 = val4.UserID;
		bool flag2 = dbConnectionStringBuilder.TryGetValue("User ID", out value2);
		val4.UserID = Conversions.ToString(value2);
		bool num = flag & flag2;
		ConnectionInfo val5 = val;
		object value3 = val5.Password;
		bool flag3 = dbConnectionStringBuilder.TryGetValue("Password", out value3);
		val5.Password = Conversions.ToString(value3);
		bool num2 = num & flag3;
		ConnectionInfo val6 = val;
		object value4 = val6.DatabaseName;
		bool flag4 = dbConnectionStringBuilder.TryGetValue("Initial Catalog", out value4);
		val6.DatabaseName = Conversions.ToString(value4);
		if (num2 & flag4)
		{
			SetDBLogonForReport(val);
		}
		else
		{
			((Page)this).Response.Write("error in connection");
		}
		TableLogOnInfo val7 = new TableLogOnInfo();
		string text = default;
		value4 = text;
		dbConnectionStringBuilder.TryGetValue("Data Source", out value4);
		text = Conversions.ToString(value4);
		string text2 = default;
		value4 = text2;
		dbConnectionStringBuilder.TryGetValue("User ID", out value4);
		text2 = Conversions.ToString(value4);
		string text3 = default;
		value4 = text3;
		dbConnectionStringBuilder.TryGetValue("Password", out value4);
		text3 = Conversions.ToString(value4);
		string text4 = default;
		value4 = text4;
		dbConnectionStringBuilder.TryGetValue("Initial Catalog", out value4);
		text4 = Conversions.ToString(value4);
		foreach (Table item in (SCRCollection)myRpt.Database.Tables)
		{
			Table val8 = item;
			val7 = val8.LogOnInfo;
			val7.ConnectionInfo.ServerName = text;
			val7.ConnectionInfo.DatabaseName = text4;
			val7.ConnectionInfo.UserID = text2;
			val7.ConnectionInfo.Password = text3;
			val8.ApplyLogOnInfo(val7);
		}
		((Page)this).Session.Add("lastreport", (object)myRpt);
	}

	private void showreport(string rfile)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		Labstuff.ResultRef1DataTable resultRef1DataTable = new Labstuff.ResultRef1DataTable();
		ResultRef1TableAdapter resultRef1TableAdapter = new ResultRef1TableAdapter();
		int num = 443;
		int num2 = 443;
		try
		{
			num = Conversions.ToInteger(((Page)this).Request.Cookies["r1"].Value);
			num2 = Conversions.ToInteger(((Page)this).Request.Cookies["r2"].Value);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = 443;
			num2 = 443;
			ProjectData.ClearProjectError();
		}
		try
		{
			if ((Operators.CompareString(((Page)this).Request["r1"].ToString(), "", TextCompare: false) != 0) & (Operators.CompareString(((Page)this).Request["r2"].ToString(), "", TextCompare: false) != 0))
			{
				num = Conversions.ToInteger(((Page)this).Request["r1"]);
				num2 = Conversions.ToInteger(((Page)this).Request["r2"]);
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		ReportDocument val = new ReportDocument();
		string text = ((Page)this).Server.MapPath(rfile);
		ReportDocument val2 = new ReportDocument();
		val2.Load(text);
		Impersonate(val2);
		CrystalReportViewer1.ReportSource = val2;
		ParameterField val3 = ((CrystalReportViewerBase)CrystalReportViewer1).ParameterFieldInfo[0];
		ParameterField val4 = ((CrystalReportViewerBase)CrystalReportViewer1).ParameterFieldInfo[1];
		ParameterDiscreteValue val5 = new ParameterDiscreteValue();
		ParameterDiscreteValue val6 = new ParameterDiscreteValue();
		val5.Value = num;
		val6.Value = num2;
		val3.CurrentValues.Add((ParameterValue)(object)val5);
		val4.CurrentValues.Add((ParameterValue)(object)val6);
	}

	protected void LinkButton1_Click(object sender, EventArgs e)
	{
		ConfigureCrystalReports();
		ReportDocument reportDocument = getReportDocument();
		try
		{
			reportDocument.ExportToHttpResponse((ExportFormatType)5, ((Page)this).Response, true, "HumanOilChangeReport");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private ReportDocument getReportDocument()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		Labstuff.ResultRef1DataTable dataTable = new Labstuff.ResultRef1DataTable();
		ResultRef1TableAdapter resultRef1TableAdapter = new ResultRef1TableAdapter();
		resultRef1TableAdapter.Fill(dataTable, Conversions.ToInteger(((Page)this).Request.Cookies["r1"].Value), Conversions.ToInteger(((Page)this).Request.Cookies["r2"].Value));
		ReportDocument val = new ReportDocument();
		string text = ((Page)this).Server.MapPath("sec.rpt");
		val.Load(text);
		ParameterFieldDefinitions parameterFields = val.DataDefinition.ParameterFields;
		ParameterFieldDefinition val2 = parameterFields["@t1"];
		ParameterValues currentValues = val2.CurrentValues;
		ParameterDiscreteValue val3 = new ParameterDiscreteValue();
		val3.Value = ((Page)this).Request.Cookies["r1"].Value;
		currentValues.Add((ParameterValue)(object)val3);
		val2.ApplyCurrentValues(currentValues);
		val2 = parameterFields["@t2"];
		currentValues = val2.CurrentValues;
		val3 = new ParameterDiscreteValue();
		val3.Value = ((Page)this).Request.Cookies["r2"].Value;
		currentValues.Add((ParameterValue)(object)val3);
		val2.ApplyCurrentValues(currentValues);
		return val;
	}

	protected void LinkButton2_Click(object sender, EventArgs e)
	{
		showreport("sec.rpt");
	}

	protected void LinkButton3_Click(object sender, EventArgs e)
	{
		showreport("wrkd.rpt");
	}

	protected void CrystalReportViewer1_Navigate(object source, NavigateEventArgs e)
	{
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["currentpage"], e.NewPageNumber, TextCompare: false), e.NewPageNumber > 0)))
		{
			((Page)this).Session.Add("currentpage", (object)e.NewPageNumber);
		}
	}

	protected void Page_LoadComplete(object sender, EventArgs e)
	{
	}
}
