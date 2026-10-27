using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using DataSet2TableAdapters;
using Microsoft.VisualBasic.CompilerServices;
using addtestTableAdapters;

public class LabCalc_Default : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Buttonadd")]
	private Button _Buttonadd;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("MaskedEditExtender1")]
	private MaskedEditExtender _MaskedEditExtender1;

	[AccessedThroughProperty("MaskedEditValidator1")]
	private MaskedEditValidator _MaskedEditValidator1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("MaskedEditExtender2")]
	private MaskedEditExtender _MaskedEditExtender2;

	[AccessedThroughProperty("MaskedEditValidator2")]
	private MaskedEditValidator _MaskedEditValidator2;

	[AccessedThroughProperty("DropDownList1")]
	private DropDownList _DropDownList1;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("MaskedEditExtender3")]
	private MaskedEditExtender _MaskedEditExtender3;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("MaskedEditValidator3")]
	private MaskedEditValidator _MaskedEditValidator3;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("MaskedEditValidator4")]
	private MaskedEditValidator _MaskedEditValidator4;

	[AccessedThroughProperty("DropDownList2")]
	private DropDownList _DropDownList2;

	[AccessedThroughProperty("FileUpload1")]
	private FileUpload _FileUpload1;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("MaskedEditExtender4")]
	private MaskedEditExtender _MaskedEditExtender4;

	[AccessedThroughProperty("SqlDataSource2")]
	private SqlDataSource _SqlDataSource2;

	[AccessedThroughProperty("View3")]
	private View _View3;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	protected virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	protected virtual Button Buttonadd
	{
		get
		{
			return _Buttonadd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Buttonadd_Click;
			if (_Buttonadd != null)
			{
				_Buttonadd.Click -= eventHandler;
			}
			_Buttonadd = value;
			if (_Buttonadd != null)
			{
				_Buttonadd.Click += eventHandler;
			}
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
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				_Button2.Click -= eventHandler;
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				_Button2.Click += eventHandler;
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
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				_Button5.Click -= eventHandler;
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				_Button5.Click += eventHandler;
			}
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
			EventHandler eventHandler = Button4_Click;
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

	protected virtual Button Button6
	{
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button6_Click;
			if (_Button6 != null)
			{
				_Button6.Click -= eventHandler;
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				_Button6.Click += eventHandler;
			}
		}
	}

	protected virtual View View1
	{
		get
		{
			return _View1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_View1 = value;
		}
	}

	protected virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender1
	{
		get
		{
			return _MaskedEditExtender1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender1 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator1
	{
		get
		{
			return _MaskedEditValidator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator1 = value;
		}
	}

	protected virtual TextBox TextBox2
	{
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox2 = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender2
	{
		get
		{
			return _MaskedEditExtender2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender2 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator2
	{
		get
		{
			return _MaskedEditValidator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator2 = value;
		}
	}

	protected virtual DropDownList DropDownList1
	{
		get
		{
			return _DropDownList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = DropDownList1_DataBound;
			if (_DropDownList1 != null)
			{
				((BaseDataBoundControl)_DropDownList1).DataBound -= eventHandler;
			}
			_DropDownList1 = value;
			if (_DropDownList1 != null)
			{
				((BaseDataBoundControl)_DropDownList1).DataBound += eventHandler;
			}
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

	protected virtual View View2
	{
		get
		{
			return _View2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_View2 = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender3
	{
		get
		{
			return _MaskedEditExtender3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender3 = value;
		}
	}

	protected virtual TextBox TextBox3
	{
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox3 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator3
	{
		get
		{
			return _MaskedEditValidator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator3 = value;
		}
	}

	protected virtual TextBox TextBox4
	{
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox4 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator4
	{
		get
		{
			return _MaskedEditValidator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator4 = value;
		}
	}

	protected virtual DropDownList DropDownList2
	{
		get
		{
			return _DropDownList2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = DropDownList2_DataBound;
			if (_DropDownList2 != null)
			{
				((BaseDataBoundControl)_DropDownList2).DataBound -= eventHandler;
			}
			_DropDownList2 = value;
			if (_DropDownList2 != null)
			{
				((BaseDataBoundControl)_DropDownList2).DataBound += eventHandler;
			}
		}
	}

	protected virtual FileUpload FileUpload1
	{
		get
		{
			return _FileUpload1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FileUpload1 = value;
		}
	}

	protected virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				_Button3.Click -= eventHandler;
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				_Button3.Click += eventHandler;
			}
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender4
	{
		get
		{
			return _MaskedEditExtender4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender4 = value;
		}
	}

	protected virtual SqlDataSource SqlDataSource2
	{
		get
		{
			return _SqlDataSource2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SqlDataSource2 = value;
		}
	}

	protected virtual View View3
	{
		get
		{
			return _View3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_View3 = value;
		}
	}

	protected virtual MultiView MultiView1
	{
		get
		{
			return _MultiView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MultiView1 = value;
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

	public HttpPostedFile upfile => FileUpload1.PostedFile;

	public LabCalc_Default()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsPostBack)
		{
			TestsTableAdapter testsTableAdapter = new TestsTableAdapter();
			int num = Conversions.ToInteger(testsTableAdapter.getnum(((Page)this).User.Identity.Name));
			UserInfoTableAdapter userInfoTableAdapter = new UserInfoTableAdapter();
			Label2.Text = Conversions.ToString(num);
		}
	}

	protected void Buttonadd_Click(object sender, EventArgs e)
	{
		((Page)this).Session.Add("noe", (object)"manual");
		MultiView1.SetActiveView(View2);
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsValid)
		{
			return;
		}
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0)))
		{
			TestsTableAdapter testsTableAdapter = new TestsTableAdapter();
			int num = Conversions.ToInteger(testsTableAdapter.addgettest(Conversions.ToString(((Page)this).Session["userid"]), Conversions.ToDate(TextBox1.Text), Conversions.ToDate(TextBox2.Text)));
			((Page)this).Session.Add("TestId", (object)num);
			if (Operators.ConditionalCompareObjectEqual(((Page)this).Session["noe"], "manual", TextCompare: false))
			{
				((Page)this).Server.Transfer("resultin.aspx?mode=admin&package=" + ((ListControl)DropDownList1).SelectedValue);
			}
			else
			{
				((Page)this).Server.Transfer("onebyone.aspx?mode=admin&package=" + ((ListControl)DropDownList1).SelectedValue);
			}
			return;
		}
		TestsTableAdapter testsTableAdapter2 = new TestsTableAdapter();
		int num2 = Conversions.ToInteger(testsTableAdapter2.addgettest(((Page)this).User.Identity.Name, Conversions.ToDate(TextBox1.Text), Conversions.ToDate(TextBox2.Text)));
		((Page)this).Session.Add("TestId", (object)num2);
		if (Operators.ConditionalCompareObjectEqual(((Page)this).Session["noe"], "manual", TextCompare: false))
		{
			((Page)this).Server.Transfer("resultin.aspx?package=" + ((ListControl)DropDownList1).SelectedValue);
		}
		else if (Operators.ConditionalCompareObjectEqual(((Page)this).Session["noe"], "onebyone", TextCompare: false))
		{
			((Page)this).Server.Transfer("onebyone.aspx?package=" + ((ListControl)DropDownList1).SelectedValue);
		}
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		MultiView1.SetActiveView(View3);
	}

	protected void Button3_Click(object sender, EventArgs e)
	{
		if (((Control)this).Page.IsValid)
		{
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0)))
			{
				TestsTableAdapter testsTableAdapter = new TestsTableAdapter();
				int num = Conversions.ToInteger(testsTableAdapter.addgettest(Conversions.ToString(((Page)this).Session["userid"]), Conversions.ToDate(TextBox3.Text), Conversions.ToDate(TextBox4.Text)));
				((Page)this).Session.Add("TestId", (object)num);
				((Page)this).Server.Transfer("resultin.aspx?package=" + ((ListControl)DropDownList2).SelectedValue);
			}
			else
			{
				TestsTableAdapter testsTableAdapter2 = new TestsTableAdapter();
				int num2 = Conversions.ToInteger(testsTableAdapter2.addgettest(((Page)this).User.Identity.Name, Conversions.ToDate(TextBox3.Text), Conversions.ToDate(TextBox4.Text)));
				((Page)this).Session.Add("TestId", (object)num2);
				((Page)this).Server.Transfer("resultin.aspx?package=" + ((ListControl)DropDownList2).SelectedValue);
			}
		}
	}

	protected void Button4_Click(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0)))
		{
			((Page)this).Response.Redirect("history.aspx?mode=admin");
		}
		else
		{
			((Page)this).Response.Redirect("history.aspx");
		}
	}

	protected void Button5_Click(object sender, EventArgs e)
	{
		((Page)this).Session.Add("noe", (object)"onebyone");
		MultiView1.SetActiveView(View2);
	}

	protected void Button6_Click(object sender, EventArgs e)
	{
		((Page)this).Response.Redirect("Compare.aspx");
	}

	protected void DropDownList2_DataBound(object sender, EventArgs e)
	{
		((ListControl)DropDownList2).Items.Insert(0, "Everything");
	}

	protected void DropDownList1_DataBound(object sender, EventArgs e)
	{
		((ListControl)DropDownList1).Items.Insert(0, "Everything");
	}
}
