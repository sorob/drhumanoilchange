using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public class p6psych : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Image1")]
	private Image _Image1;

	[AccessedThroughProperty("ImageButton1")]
	private ImageButton _ImageButton1;

	[AccessedThroughProperty("ImageButton2")]
	private ImageButton _ImageButton2;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	protected virtual Image Image1
	{
		get
		{
			return _Image1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Image1 = value;
		}
	}

	protected virtual ImageButton ImageButton1
	{
		get
		{
			return _ImageButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			ImageClickEventHandler val = ImageButton1_Click;
			if (_ImageButton1 != null)
			{
				_ImageButton1.Click -= val;
			}
			_ImageButton1 = value;
			if (_ImageButton1 != null)
			{
				_ImageButton1.Click += val;
			}
		}
	}

	protected virtual ImageButton ImageButton2
	{
		get
		{
			return _ImageButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			ImageClickEventHandler val = ImageButton2_Click;
			if (_ImageButton2 != null)
			{
				_ImageButton2.Click -= val;
			}
			_ImageButton2 = value;
			if (_ImageButton2 != null)
			{
				_ImageButton2.Click += val;
			}
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

	protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
	{
		((Page)this).Response.Redirect("P6Psych");
	}

	private void sss()
	{
	}

	protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
	{
		((Page)this).Response.Redirect("P6Psych/P6s.aspx");
	}
}
