using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using PayPal.Web.Controls;

public class P6Psych_P6s : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Image2")]
	private Image _Image2;

	[AccessedThroughProperty("AddToCartButton1")]
	private AddToCartButton _AddToCartButton1;

	[AccessedThroughProperty("AddToCartButton2")]
	private AddToCartButton _AddToCartButton2;

	[AccessedThroughProperty("AddToCartButton3")]
	private AddToCartButton _AddToCartButton3;

	protected virtual Image Image2
	{
		get
		{
			return _Image2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Image2 = value;
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

	protected virtual AddToCartButton AddToCartButton2
	{
		get
		{
			return _AddToCartButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_AddToCartButton2 = value;
		}
	}

	protected virtual AddToCartButton AddToCartButton3
	{
		get
		{
			return _AddToCartButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_AddToCartButton3 = value;
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

	public P6Psych_P6s()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		AddToCartButton1.Option1Values = ((Page)this).User.Identity.Name;
		AddToCartButton2.Option1Values = ((Page)this).User.Identity.Name;
		AddToCartButton3.Option1Values = ((Page)this).User.Identity.Name;
	}
}
