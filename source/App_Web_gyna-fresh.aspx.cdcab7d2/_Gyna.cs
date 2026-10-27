using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using PayPal.Web.Controls;

public class _Gyna : Page, IRequiresSessionState
{
	[AccessedThroughProperty("AddToCartButton2")]
	private AddToCartButton _AddToCartButton2;

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
