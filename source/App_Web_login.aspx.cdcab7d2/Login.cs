using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Login : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Login1")]
	private Login _Login1;

	protected virtual Login Login1
	{
		get
		{
			return _Login1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Login1 = value;
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
