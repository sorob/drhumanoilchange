using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using LabstuffTableAdapters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using textrefTableAdapters;

public class Admin_packageEditor : Page, IRequiresSessionState
{
	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("pnamenew")]
	private TextBox _pnamenew;

	[AccessedThroughProperty("pdescnew")]
	private TextBox _pdescnew;

	[AccessedThroughProperty("ppricenew")]
	private TextBox _ppricenew;

	[AccessedThroughProperty("pcomment")]
	private TextBox _pcomment;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("pname")]
	private Label _pname;

	[AccessedThroughProperty("pid")]
	private Label _pid;

	[AccessedThroughProperty("testList")]
	private DropDownList _testList;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("GridView2")]
	private GridView _GridView2;

	[AccessedThroughProperty("SqlDataSource2")]
	private SqlDataSource _SqlDataSource2;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	private packagedataTableAdapter packda;

	protected virtual GridView GridView1
	{
		get
		{
			return _GridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = GridView1_SelectedIndexChanged;
			if (_GridView1 != null)
			{
				_GridView1.SelectedIndexChanged -= eventHandler;
			}
			_GridView1 = value;
			if (_GridView1 != null)
			{
				_GridView1.SelectedIndexChanged += eventHandler;
			}
		}
	}

	protected virtual TextBox pnamenew
	{
		get
		{
			return _pnamenew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pnamenew = value;
		}
	}

	protected virtual TextBox pdescnew
	{
		get
		{
			return _pdescnew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pdescnew = value;
		}
	}

	protected virtual TextBox ppricenew
	{
		get
		{
			return _ppricenew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ppricenew = value;
		}
	}

	protected virtual TextBox pcomment
	{
		get
		{
			return _pcomment;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pcomment = value;
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

	protected virtual Label pname
	{
		get
		{
			return _pname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pname = value;
		}
	}

	protected virtual Label pid
	{
		get
		{
			return _pid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_pid = value;
		}
	}

	protected virtual DropDownList testList
	{
		get
		{
			return _testList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_testList = value;
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

	public Admin_packageEditor()
	{
		((Control)this).Load += Page_Load;
		packda = new packagedataTableAdapter();
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		SqlDataSource2.SelectParameters[0].DefaultValue = Conversions.ToString(GridView1.SelectedDataKey.Value);
		pname.Text = ((TableRow)GridView1.SelectedRow).Cells[1].Text;
		pid.Text = Conversions.ToString(GridView1.SelectedDataKey.Value);
		GridView2.DataBind();
		MultiView1.ActiveViewIndex = 1;
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		string aBR = getABR(((ListControl)testList).SelectedValue);
		if (Operators.CompareString(aBR, "", TextCompare: false) != 0)
		{
			try
			{
				packda.Insertabrevtopack(Conversions.ToInteger(pid.Text), aBR);
				GridView2.DataBind();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			((Control)((Control)this).Page).Focus();
		}
	}

	private string getABR(string t)
	{
		string result = default;
		try
		{
			if (Operators.CompareString(t, "", TextCompare: false) != 0)
			{
				int num = t.IndexOf("(");
				int num2 = t.IndexOf(")");
				result = checked(Strings.Mid(t, num + 2, num2 - num - 1));
				return result;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		checked
		{
			if (!((Control)this).Page.IsPostBack)
			{
				TestRefTableAdapter testRefTableAdapter = new TestRefTableAdapter();
				textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
				testRefTableAdapter.Fill(testRefDataTable);
				int count = testRefDataTable.Count;
				for (int i = 1; i <= count; i++)
				{
					NewLateBinding.LateCall(((ListControl)testList).Items, null, "Add", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(testRefDataTable.Rows[i - 1]["testName"], " ("), testRefDataTable.Rows[i - 1]["testAbrev"]), ")") }, null, null, null, IgnoreReturn: true);
				}
			}
		}
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		SqlDataSource1.Insert();
		pcomment.Text = "";
		pnamenew.Text = "";
		ppricenew.Text = "";
		pdescnew.Text = "";
		GridView1.DataBind();
	}
}
