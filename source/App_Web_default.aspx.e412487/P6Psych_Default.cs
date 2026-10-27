using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Configuration;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class P6Psych_Default : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("LinkButton1")]
	private LinkButton _LinkButton1;

	[AccessedThroughProperty("HyperLink1")]
	private HyperLink _HyperLink1;

	[AccessedThroughProperty("HyperLink2")]
	private HyperLink _HyperLink2;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

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

	protected virtual HyperLink HyperLink1
	{
		get
		{
			return _HyperLink1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HyperLink1 = value;
		}
	}

	protected virtual HyperLink HyperLink2
	{
		get
		{
			return _HyperLink2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HyperLink2 = value;
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

	public P6Psych_Default()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (((HttpCapabilitiesBase)((Page)this).Request.Browser).Browser.ToUpper().IndexOf("IE") > -1)
		{
			Label1.Text = ((Page)this).User.Identity.Name.ToString() + " You have .Net Framework V." + ((HttpCapabilitiesBase)((Page)this).Request.Browser).ClrVersion.ToString() + " Installed on your computer";
		}
		else
		{
			Label1.Text = "";
		}
	}

	protected void LinkButton1_Click(object sender, EventArgs e)
	{
		SqlDataSource1.InsertParameters["UserName"].DefaultValue = ((Page)this).User.Identity.Name.ToString();
		SqlDataSource1.InsertParameters["Download_name"].DefaultValue = "P6-Psych";
		SqlDataSource1.InsertParameters["Download_date"].DefaultValue = Conversions.ToString(DateAndTime.Now);
		SqlDataSource1.Insert();
		((Page)this).Response.Redirect("WATSetup.msi");
	}
}
