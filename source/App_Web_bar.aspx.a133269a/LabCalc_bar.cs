using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using Microsoft.VisualBasic.CompilerServices;

public class LabCalc_bar : Page, IRequiresSessionState
{
	[AccessedThroughProperty("form1")]
	private HtmlForm _form1;

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

	public LabCalc_bar()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		int try0000_dispatch = -1;
		checked
		{
			int num3 = default;
			int num = default;
			int num2 = default;
			Bitmap val = default;
			Graphics val2 = default;
			double num5 = default;
			double num6 = default;
			double num7 = default;
			double num8 = default;
			double point = default;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					double num9;
					SolidBrush val3;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 621:
						{
							num = num2;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num + 1);
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0019;
							case 4:
								goto IL_0025;
							case 5:
								goto IL_003e;
							case 6:
								goto IL_0057;
							case 7:
								goto IL_0071;
							case 8:
								goto IL_008a;
							case 9:
								goto IL_0092;
							case 10:
								goto IL_00ad;
							case 11:
								goto IL_00bd;
							case 12:
								goto IL_00d6;
							case 13:
								goto IL_00ef;
							case 14:
								goto IL_0119;
							case 15:
								goto IL_0141;
							case 16:
								goto IL_0168;
							case 17:
								goto IL_018f;
							case 18:
								goto IL_01af;
							case 19:
								goto IL_01cf;
							case 20:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 21:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_01cf:
						num2 = 19;
						((Page)this).Response.ContentType = "image/jpeg";
						break;
						IL_0008:
						num2 = 2;
						val = new Bitmap(150, 15);
						goto IL_0019;
						IL_0019:
						num2 = 3;
						val2 = Graphics.FromImage((Image)(object)val);
						goto IL_0025;
						IL_0025:
						num2 = 4;
						num5 = Conversions.ToDouble(((Page)this).Request["dl"]);
						goto IL_003e;
						IL_003e:
						num2 = 5;
						num6 = Conversions.ToDouble(((Page)this).Request["dh"]);
						goto IL_0057;
						IL_0057:
						num2 = 6;
						num7 = Conversions.ToDouble(((Page)this).Request["ml"]);
						goto IL_0071;
						IL_0071:
						num2 = 7;
						num8 = Conversions.ToDouble(((Page)this).Request["mh"]);
						goto IL_008a;
						IL_008a:
						num2 = 8;
						num9 = num8 - num7;
						goto IL_0092;
						IL_0092:
						num2 = 9;
						point = Conversions.ToDouble(((Page)this).Request["scale"]);
						goto IL_00ad;
						IL_00ad:
						num2 = 10;
						val3 = new SolidBrush(Color.White);
						goto IL_00bd;
						IL_00bd:
						num2 = 11;
						val2.FillRectangle(Brushes.White, 0, 0, 150, 20);
						goto IL_00d6;
						IL_00d6:
						num2 = 12;
						val2.FillRectangle(Brushes.Red, 0, 0, 150, 15);
						goto IL_00ef;
						IL_00ef:
						num2 = 13;
						val2.FillRectangle(Brushes.Orange, getx(num7, num8, num7), 0, getw(num7, num8, num7, num8), 15);
						goto IL_0119;
						IL_0119:
						num2 = 14;
						val2.FillRectangle(Brushes.Green, getx(num7, num8, num5), 0, getw(num7, num8, num5, num6), 15);
						goto IL_0141;
						IL_0141:
						num2 = 15;
						val2.FillRectangle(Brushes.Yellow, getx(num7, num8, getOpt(num7, num8)) - 2, 0, 4, 5);
						goto IL_0168;
						IL_0168:
						num2 = 16;
						val2.FillRectangle(Brushes.LightGreen, getx(num7, num8, getOpt(num5, num6)) - 2, 10, 4, 5);
						goto IL_018f;
						IL_018f:
						num2 = 17;
						val2.FillRectangle(Brushes.White, getx(num7, num8, point) - 2, 4, 4, 7);
						goto IL_01af;
						IL_01af:
						num2 = 18;
						val2.FillRectangle(Brushes.White, getx(num7, num8, point) - 3, 6, 6, 3);
						goto IL_01cf;
						end_IL_0000_2:
						break;
					}
					num2 = 20;
					((Image)val).Save(((Page)this).Response.OutputStream, ImageFormat.Gif);
					break;
					end_IL_0000:;
				}
				catch (Exception ex) when ((num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0000_dispatch = 621;
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

	private int getx(double medL, double medH, double point)
	{
		double num = 0.0 - medL;
		double num2 = medL + num;
		double num3 = medH + num;
		double num4 = 50.0 / (num3 - num2);
		return checked((int)Math.Round(roundIt((point + num) * num4, 0) + 50.0));
	}

	private int getw(double medl, double medH, double a, double b)
	{
		return checked((int)Math.Round(roundIt(getx(medl, medH, b) - getx(medl, medH, a), 0)));
	}

	private double getDif(double low, double high)
	{
		return high - low;
	}

	private double getOpt(double low, double high)
	{
		return (high - low) / 2.0 + low;
	}

	private double getScale(double low, double high, double result)
	{
		return roundIt((result - getOpt(low, high)) / getDif(low, high) * 100.0, 3);
	}

	public double roundIt(double num, int inPower)
	{
		int num2 = checked((int)Math.Round(Math.Pow(10.0, inPower)));
		num *= (double)num2;
		num = Math.Round(num);
		num /= (double)num2;
		return num;
	}
}
