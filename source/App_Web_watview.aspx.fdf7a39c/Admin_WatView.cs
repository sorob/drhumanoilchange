using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.CompilerServices;
using WATTableAdapters;

public class Admin_WatView : Page, IRequiresSessionState
{
	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("SqlDataSource2")]
	private SqlDataSource _SqlDataSource2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("DetailsView1")]
	private DetailsView _DetailsView1;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("DetailsView2")]
	private DetailsView _DetailsView2;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("DetailsView3")]
	private DetailsView _DetailsView3;

	[AccessedThroughProperty("SqlDataSource3")]
	private SqlDataSource _SqlDataSource3;

	[AccessedThroughProperty("View3")]
	private View _View3;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	protected virtual GridView GridView1
	{
		get
		{
			return _GridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GridView1 = value;
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

	protected virtual DetailsView DetailsView1
	{
		get
		{
			return _DetailsView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DetailsView1 = value;
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

	protected virtual DetailsView DetailsView2
	{
		get
		{
			return _DetailsView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DetailsView2 = value;
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

	protected virtual DetailsView DetailsView3
	{
		get
		{
			return _DetailsView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DetailsView3 = value;
		}
	}

	protected virtual SqlDataSource SqlDataSource3
	{
		get
		{
			return _SqlDataSource3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SqlDataSource3 = value;
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

	public Admin_WatView()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsPostBack)
		{
			SqlDataSource1.SelectParameters["tid"].DefaultValue = ((Page)this).Request["testid"];
			SqlDataSource2.SelectParameters["un"].DefaultValue = ((Page)this).Request["un"];
			DetailsView1.DataBind();
			GridView1.DataBind();
			DataTable1TableAdapter dataTable1TableAdapter = new DataTable1TableAdapter();
			int num = Conversions.ToInteger(dataTable1TableAdapter.getscore(Conversions.ToInteger(((Page)this).Request["testid"])));
			Label1.Text = "Score=" + Conversions.ToString(num);
		}
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		MultiView1.ActiveViewIndex = 1;
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		MultiView1.ActiveViewIndex = 2;
	}
}
