using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataSet2TableAdapters;
using Microsoft.VisualBasic.CompilerServices;
using addtestTableAdapters;

public class Admin_usermanager : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("DropDownList1")]
	private DropDownList _DropDownList1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("LinkButton1")]
	private LinkButton _LinkButton1;

	[AccessedThroughProperty("LinkButton5")]
	private LinkButton _LinkButton5;

	[AccessedThroughProperty("LinkButton2")]
	private LinkButton _LinkButton2;

	[AccessedThroughProperty("LinkButton4")]
	private LinkButton _LinkButton4;

	protected virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
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

	protected virtual DropDownList DropDownList1
	{
		get
		{
			return _DropDownList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DropDownList1 = value;
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

	protected virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
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
			EventHandler eventHandler2 = LinkButton1_Click;
			if (_LinkButton1 != null)
			{
				_LinkButton1.Click -= eventHandler;
				_LinkButton1.Click -= eventHandler2;
			}
			_LinkButton1 = value;
			if (_LinkButton1 != null)
			{
				_LinkButton1.Click += eventHandler;
				_LinkButton1.Click += eventHandler2;
			}
		}
	}

	protected virtual LinkButton LinkButton5
	{
		get
		{
			return _LinkButton5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LinkButton5_Click;
			if (_LinkButton5 != null)
			{
				_LinkButton5.Click -= eventHandler;
			}
			_LinkButton5 = value;
			if (_LinkButton5 != null)
			{
				_LinkButton5.Click += eventHandler;
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

	protected virtual LinkButton LinkButton4
	{
		get
		{
			return _LinkButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LinkButton4_Click;
			if (_LinkButton4 != null)
			{
				_LinkButton4.Click -= eventHandler;
			}
			_LinkButton4 = value;
			if (_LinkButton4 != null)
			{
				_LinkButton4.Click += eventHandler;
			}
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

	public Admin_usermanager()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}

	private void userChanged()
	{
		TestsTableAdapter testsTableAdapter = new TestsTableAdapter();
		int num = Conversions.ToInteger(testsTableAdapter.getnum(((ListControl)DropDownList1).SelectedValue));
		UserInfoTableAdapter userInfoTableAdapter = new UserInfoTableAdapter();
		int num2 = Conversions.ToInteger(userInfoTableAdapter.ScalarQuery(((ListControl)DropDownList1).SelectedValue));
		Label2.Text = Conversions.ToString(num);
		TextBox1.Text = Conversions.ToString(num2);
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		UserInfoTableAdapter userInfoTableAdapter = new UserInfoTableAdapter();
		userInfoTableAdapter.UpdateNum(Conversions.ToInteger(TextBox1.Text), ((ListControl)DropDownList1).SelectedValue);
		Label3.Text = "The user \"" + ((ListControl)DropDownList1).SelectedValue + "\" has been updated.";
	}

	protected void LinkButton1_Click(object sender, EventArgs e)
	{
		((Page)this).Session.Add("userid", (object)((ListControl)DropDownList1).SelectedValue);
		((Page)this).Response.Redirect("../LabCalc/history.aspx?mode=admin");
	}

	protected void LinkButton2_Click(object sender, EventArgs e)
	{
		((Page)this).Session.Add("userid", (object)((ListControl)DropDownList1).SelectedValue);
		((Page)this).Response.Redirect("../LabCalc/history.aspx?mode=admin");
	}

	protected void LinkButton4_Click(object sender, EventArgs e)
	{
		((Page)this).Response.Redirect("WatView.aspx?un=" + ((ListControl)DropDownList1).SelectedValue);
	}

	protected void LinkButton5_Click(object sender, EventArgs e)
	{
		((Page)this).Response.Redirect("watList.aspx?un=" + ((ListControl)DropDownList1).SelectedValue);
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		userChanged();
	}
}
