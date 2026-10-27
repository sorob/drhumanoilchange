using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using textrefTableAdapters;

public class LabCalc_ONEBYONE : Page, IRequiresSessionState
{
	[AccessedThroughProperty("AutoCompleteExtender1")]
	private AutoCompleteExtender _AutoCompleteExtender1;

	[AccessedThroughProperty("myTextBox")]
	private TextBox _myTextBox;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TLow")]
	private TextBox _TLow;

	[AccessedThroughProperty("Topt")]
	private TextBox _Topt;

	[AccessedThroughProperty("Thigh")]
	private TextBox _Thigh;

	[AccessedThroughProperty("dLow")]
	private Label _dLow;

	[AccessedThroughProperty("dHigh")]
	private Label _dHigh;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("TABLE1")]
	private HtmlTable _TABLE1;

	[AccessedThroughProperty("GridView2")]
	private GridView _GridView2;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	protected virtual AutoCompleteExtender AutoCompleteExtender1
	{
		get
		{
			return _AutoCompleteExtender1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_AutoCompleteExtender1 = value;
		}
	}

	protected virtual TextBox myTextBox
	{
		get
		{
			return _myTextBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_myTextBox = value;
		}
	}

	protected virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				_Button1.Click -= eventHandler;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				_Button1.Click += eventHandler;
			}
		}
	}

	protected virtual TextBox TLow
	{
		get
		{
			return _TLow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TLow = value;
		}
	}

	protected virtual TextBox Topt
	{
		get
		{
			return _Topt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Topt = value;
		}
	}

	protected virtual TextBox Thigh
	{
		get
		{
			return _Thigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Thigh = value;
		}
	}

	protected virtual Label dLow
	{
		get
		{
			return _dLow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dLow = value;
		}
	}

	protected virtual Label dHigh
	{
		get
		{
			return _dHigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_dHigh = value;
		}
	}

	protected virtual Button Button4
	{
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button4 != null)
			{
				_Button4.Click -= eventHandler;
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				_Button4.Click += eventHandler;
			}
		}
	}

	protected virtual Button Button5
	{
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button5 = value;
		}
	}

	protected virtual HtmlTable TABLE1
	{
		get
		{
			return _TABLE1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TABLE1 = value;
		}
	}

	protected virtual GridView GridView2
	{
		get
		{
			return _GridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GridView2 = value;
		}
	}

	protected virtual SqlDataSource SqlDataSource1
	{
		get
		{
			return _SqlDataSource1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SqlDataSource1 = value;
		}
	}

	protected virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button2 = value;
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

	public LabCalc_ONEBYONE()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		TestRefTableAdapter testRefTableAdapter = new TestRefTableAdapter();
		textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
		testRefTableAdapter.FillBy1(testRefDataTable, getABR(myTextBox.Text));
		Thigh.Text = Conversions.ToString(testRefDataTable.Rows[0]["MedHigh"]);
		TLow.Text = Conversions.ToString(testRefDataTable.Rows[0]["MedLow"]);
		dHigh.Text = Conversions.ToString(testRefDataTable.Rows[0]["DocHigh"]);
		dLow.Text = Conversions.ToString(testRefDataTable.Rows[0]["DocLow"]);
		Topt.Text = Conversions.ToString(getOpt(Conversions.ToDouble(testRefDataTable.Rows[0]["MedLow"]), Conversions.ToDouble(testRefDataTable.Rows[0]["MedHigh"])));
		((Page)this).Session.Add("rid", RuntimeHelpers.GetObjectValue(testRefDataTable.Rows[0]["rid"]));
		((WebControl)myTextBox).Enabled = false;
		((WebControl)Button1).Enabled = false;
		((Control)Topt).Focus();
		((WebControl)Topt).Attributes.Add("onfocusin", " select();");
		((Control)TABLE1).Visible = true;
	}

	private string getABR(string t)
	{
		if (Operators.CompareString(t, "", TextCompare: false) != 0)
		{
			int num = t.IndexOf("(");
			int num2 = t.IndexOf(")");
			return checked(Strings.Mid(t, num + 2, num2 - num - 1));
		}
		string result = default;
		return result;
	}

	public double roundIt(double num, int inPower)
	{
		int num2 = checked((int)Math.Round(Math.Pow(10.0, inPower)));
		num *= (double)num2;
		num = Math.Round(num);
		num /= (double)num2;
		return num;
	}

	private double getDif(double low, double high)
	{
		return high - low;
	}

	private double getOpt(double low, double high)
	{
		return (high - low) / 2.0 + low;
	}

	private double getScale(double low, double high, double result)
	{
		return roundIt((result - getOpt(low, high)) / getDif(low, high) * 100.0, 4);
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		string defaultValue = ((!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0))) ? ((Page)this).User.Identity.Name : Conversions.ToString(((Page)this).Session["userid"]));
		int num = Conversions.ToInteger(((Page)this).Request.Cookies["testid"]["Data"]);
		SqlDataSource1.InsertParameters["DocLow"].DefaultValue = dLow.Text;
		SqlDataSource1.InsertParameters["DocHigh"].DefaultValue = dHigh.Text;
		SqlDataSource1.InsertParameters["Medopt"].DefaultValue = Conversions.ToString(getOpt(Conversions.ToDouble(TLow.Text), Conversions.ToDouble(Thigh.Text)));
		SqlDataSource1.InsertParameters["Docopt"].DefaultValue = Conversions.ToString(getOpt(Conversions.ToDouble(dLow.Text), Conversions.ToDouble(dHigh.Text)));
		SqlDataSource1.InsertParameters["MedScale"].DefaultValue = Conversions.ToString(getScale(Conversions.ToDouble(TLow.Text), Conversions.ToDouble(Thigh.Text), Conversions.ToDouble(Topt.Text)));
		SqlDataSource1.InsertParameters["DocScale"].DefaultValue = Conversions.ToString(getScale(Conversions.ToDouble(dLow.Text), Conversions.ToDouble(dHigh.Text), Conversions.ToDouble(Topt.Text)));
		SqlDataSource1.InsertParameters["Testid"].DefaultValue = Conversions.ToString(num);
		SqlDataSource1.InsertParameters["TestAbrev"].DefaultValue = getABR(myTextBox.Text);
		SqlDataSource1.InsertParameters["UserName"].DefaultValue = defaultValue;
		SqlDataSource1.InsertParameters["rid"].DefaultValue = Conversions.ToString(((Page)this).Session["rid"]);
		try
		{
			if (Operators.CompareString(myTextBox.Text, "", TextCompare: false) != 0)
			{
				SqlDataSource1.Insert();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		((Control)TABLE1).Visible = false;
		((WebControl)myTextBox).Enabled = true;
		myTextBox.Text = "";
		((WebControl)Button1).Enabled = true;
	}

	protected void Button3_Click(object sender, EventArgs e)
	{
		((WebControl)myTextBox).Enabled = true;
		((WebControl)Button1).Enabled = true;
		((Control)TABLE1).Visible = false;
		myTextBox.Text = "";
		((Control)myTextBox).Focus();
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsPostBack)
		{
			((Control)TABLE1).Visible = false;
			((Page)this).Response.Cookies["testid"]["Data"] = Conversions.ToString(((Page)this).Session["TestId"]);
			((Page)this).Response.Cookies["testid"]["Time"] = DateAndTime.Now.ToString("G");
			((Page)this).Response.Cookies["testid"].Expires = DateAndTime.Now.AddHours(2.0);
			SqlDataSource1.SelectParameters[0].DefaultValue = Conversions.ToString(((Page)this).Session["TestId"]);
		}
	}

	protected void Button2_Click1(object sender, EventArgs e)
	{
		((Page)this).Session.Add("TestId", (object)((Page)this).Request.Cookies["testid"]["Data"]);
		((Page)this).Response.Redirect("ResultView.aspx?mode=admin");
	}
}
