using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.CompilerServices;

public class Financial_Bank : Page, IRequiresSessionState
{
	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Image1")]
	private Image _Image1;

	[AccessedThroughProperty("TxtAmnt")]
	private TextBox _TxtAmnt;

	[AccessedThroughProperty("ImageButton1")]
	private ImageButton _ImageButton1;

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

	protected virtual TextBox TxtAmnt
	{
		get
		{
			return _TxtAmnt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TxtAmnt = value;
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

	public Financial_Bank()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default;
		int num = default;
		int num2 = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 101:
					{
						num = num2;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num + 1;
						num = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 5:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0007:
					num2 = 2;
					if (((Page)this).User == null)
					{
						goto end_IL_0000_3;
					}
					break;
					end_IL_0000_2:
					break;
				}
				num2 = 3;
				SqlDataSource1.SelectParameters[0].DefaultValue = ((Page)this).User.Identity.Name;
				break;
				end_IL_0000:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0000_dispatch = 101;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
	{
		((Page)this).Server.Transfer("AddFunds.aspx?Fund=" + TxtAmnt.Text);
	}
}
