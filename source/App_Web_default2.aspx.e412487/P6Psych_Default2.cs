using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayPal.Web.Controls;

public class P6Psych_Default2 : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("AddToCartButton1")]
	private AddToCartButton _AddToCartButton1;

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

	protected virtual AddToCartButton AddToCartButton1
	{
		get
		{
			return _AddToCartButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_AddToCartButton1 = value;
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

	public P6Psych_Default2()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		Label1.Text = ((Page)this).Request.Form.ToString();
		if (!((Control)this).Page.IsPostBack)
		{
			AddToCartButton1.Option1Values = ((Page)this).User.Identity.Name;
		}
	}
}
