using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public class master1 : MasterPage
{
	[AccessedThroughProperty("head")]
	private ContentPlaceHolder _head;

	[AccessedThroughProperty("ScriptManager1")]
	private ScriptManager _ScriptManager1;

	[AccessedThroughProperty("Image3")]
	private Image _Image3;

	[AccessedThroughProperty("SiteMapDS1")]
	private SiteMapDataSource _SiteMapDS1;

	[AccessedThroughProperty("Menu1")]
	private Menu _Menu1;

	[AccessedThroughProperty("LoginView1")]
	private LoginView _LoginView1;

	[AccessedThroughProperty("ContentPlaceHolder1")]
	private ContentPlaceHolder _ContentPlaceHolder1;

	[AccessedThroughProperty("form1")]
	private HtmlForm _form1;

	protected virtual ContentPlaceHolder head
	{
		get
		{
			return _head;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_head = value;
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

	protected virtual Image Image3
	{
		get
		{
			return _Image3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Image3 = value;
		}
	}

	protected virtual SiteMapDataSource SiteMapDS1
	{
		get
		{
			return _SiteMapDS1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SiteMapDS1 = value;
		}
	}

	protected virtual Menu Menu1
	{
		get
		{
			return _Menu1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Menu1 = value;
		}
	}

	protected virtual LoginView LoginView1
	{
		get
		{
			return _LoginView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LoginView1_ViewChanged;
			if (_LoginView1 != null)
			{
				_LoginView1.ViewChanged -= eventHandler;
			}
			_LoginView1 = value;
			if (_LoginView1 != null)
			{
				_LoginView1.ViewChanged += eventHandler;
			}
		}
	}

	protected virtual ContentPlaceHolder ContentPlaceHolder1
	{
		get
		{
			return _ContentPlaceHolder1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ContentPlaceHolder1 = value;
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
			return (DefaultProfile)((Control)this).Context.Profile;
		}
	}

	protected HttpApplication ApplicationInstance => ((Control)this).Context.ApplicationInstance;

	public master1()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void LoginView1_ViewChanged(object sender, EventArgs e)
	{
	}
}
