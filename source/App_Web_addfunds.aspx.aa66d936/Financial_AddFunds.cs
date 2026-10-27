using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PayPal.Web.Controls;

public class Financial_AddFunds : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Labelusr")]
	private Label _Labelusr;

	[AccessedThroughProperty("Labelamnt")]
	private Label _Labelamnt;

	[AccessedThroughProperty("AddToCartButton2")]
	private AddToCartButton _AddToCartButton2;

	protected virtual Label Labelusr
	{
		get
		{
			return _Labelusr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Labelusr = value;
		}
	}

	protected virtual Label Labelamnt
	{
		get
		{
			return _Labelamnt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Labelamnt = value;
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

	public Financial_AddFunds()
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
				case 168:
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
							goto IL_0024;
						case 4:
							goto IL_0041;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0041:
					num2 = 4;
					AddToCartButton2.Amount = Conversion.Val(Labelamnt.Text);
					break;
					IL_0007:
					num2 = 2;
					Labelamnt.Text = ((Page)this).Request["Fund"];
					goto IL_0024;
					IL_0024:
					num2 = 3;
					Labelusr.Text = ((Page)this).User.Identity.Name;
					goto IL_0041;
					end_IL_0000_2:
					break;
				}
				num2 = 5;
				AddToCartButton2.Option1Values = ((Page)this).User.Identity.Name;
				break;
				end_IL_0000:;
			}
			catch (Exception ex) when ((num3 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0000_dispatch = 168;
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
}
