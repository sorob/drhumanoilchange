using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using PayPal.Web.Controls;

public class Services_2P : Page, IRequiresSessionState
{
	[AccessedThroughProperty("AddToCartButton1")]
	private AddToCartButton _AddToCartButton1;

	[AccessedThroughProperty("Addtocartbutton2")]
	private AddToCartButton _Addtocartbutton2;

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

	protected virtual AddToCartButton Addtocartbutton2
	{
		get
		{
			return _Addtocartbutton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Addtocartbutton2 = value;
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
}
