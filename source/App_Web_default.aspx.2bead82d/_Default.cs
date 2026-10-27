using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public class _Default : Page, IRequiresSessionState
{
	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("form1")]
	private HtmlForm _form1;

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
			return (DefaultProfile)((Page)this).Context.Profile;
		}
	}

	protected HttpApplication ApplicationInstance => ((Page)this).Context.ApplicationInstance;
}
