using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Admin_RefEdit : Page, IRequiresSessionState
{
	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("GridView2")]
	private GridView _GridView2;

	[AccessedThroughProperty("UpdatePanel2")]
	private UpdatePanel _UpdatePanel2;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("tname")]
	private TextBox _tname;

	[AccessedThroughProperty("Tabrev")]
	private TextBox _Tabrev;

	[AccessedThroughProperty("Dlow")]
	private TextBox _Dlow;

	[AccessedThroughProperty("Dhigh")]
	private TextBox _Dhigh;

	[AccessedThroughProperty("medlow")]
	private TextBox _medlow;

	[AccessedThroughProperty("medHigh")]
	private TextBox _medHigh;

	[AccessedThroughProperty("Categor")]
	private TextBox _Categor;

	[AccessedThroughProperty("Tdefval")]
	private TextBox _Tdefval;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

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

	protected virtual GridView GridView2
	{
		get
		{
			return _GridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			GridViewUpdateEventHandler val = GridView2_RowUpdating;
			GridViewUpdatedEventHandler val2 = GridView2_RowUpdated;
			if (_GridView2 != null)
			{
				_GridView2.RowUpdating -= val;
				_GridView2.RowUpdated -= val2;
			}
			_GridView2 = value;
			if (_GridView2 != null)
			{
				_GridView2.RowUpdating += val;
				_GridView2.RowUpdated += val2;
			}
		}
	}

	protected virtual UpdatePanel UpdatePanel2
	{
		get
		{
			return _UpdatePanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UpdatePanel2 = value;
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

	protected virtual TextBox tname
	{
		get
		{
			return _tname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tname = value;
		}
	}

	protected virtual TextBox Tabrev
	{
		get
		{
			return _Tabrev;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tabrev = value;
		}
	}

	protected virtual TextBox Dlow
	{
		get
		{
			return _Dlow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Dlow = value;
		}
	}

	protected virtual TextBox Dhigh
	{
		get
		{
			return _Dhigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Dhigh = value;
		}
	}

	protected virtual TextBox medlow
	{
		get
		{
			return _medlow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_medlow = value;
		}
	}

	protected virtual TextBox medHigh
	{
		get
		{
			return _medHigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_medHigh = value;
		}
	}

	protected virtual TextBox Categor
	{
		get
		{
			return _Categor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Categor = value;
		}
	}

	protected virtual TextBox Tdefval
	{
		get
		{
			return _Tdefval;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tdefval = value;
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

	public Admin_RefEdit()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		MultiView1.ActiveViewIndex = 1;
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		Categor.Text = Categor.Text.Trim();
		SqlDataSource1.Insert();
		GridView2.DataBind();
		MultiView1.ActiveViewIndex = 0;
	}

	protected void Button3_Click(object sender, EventArgs e)
	{
		MultiView1.ActiveViewIndex = 0;
	}

	protected void GridView2_RowUpdated(object sender, GridViewUpdatedEventArgs e)
	{
	}

	protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
	{
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (((Control)this).Page.IsPostBack)
		{
		}
	}
}
