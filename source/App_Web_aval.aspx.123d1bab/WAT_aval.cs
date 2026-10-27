using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WATTableAdapters;

public class WAT_aval : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

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

	protected virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
		}
	}

	protected virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				_Button1.Click -= eventHandler;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				_Button1.Click += eventHandler;
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

	public WAT_aval()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		Label1.Text = ((Page)this).User.Identity.Name;
		Label2.Text = DateAndTime.Now.ToShortDateString();
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		checked
		{
			int num2 = default;
			int num = default;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						testInstanceTableAdapter testInstanceTableAdapter2 = new testInstanceTableAdapter();
						int num3 = Conversions.ToInteger(testInstanceTableAdapter2.INSERTtESTINST(((Page)this).User.Identity.Name, 0, DateAndTime.Now, DateAndTime.Now, -1));
						int[] array = new int[80];
						Random random = new Random();
						VBMath.Randomize();
						int num4 = 0;
						while (true)
						{
							int num5 = random.Next(119);
							if (num4 > 0)
							{
								if (Array.IndexOf(array, num5) >= 0)
								{
									continue;
								}
								array[num4] = num5;
							}
							else
							{
								if (num4 != 0)
								{
									((Page)this).Response.Redirect("error.aspx");
									break;
								}
								array[0] = num5;
							}
							num4++;
							if (num4 > 79)
							{
								WAT.testWordInstanceDataTable testWordInstanceDataTable = new WAT.testWordInstanceDataTable();
								num4 = 0;
								do
								{
									testWordInstanceDataTable.AddtestWordInstanceRow(num3, array[num4], -1, Conversions.ToString(-1));
									num4++;
								}
								while (num4 <= 79);
								testWordInstanceTableAdapter testWordInstanceTableAdapter2 = new testWordInstanceTableAdapter();
								testWordInstanceTableAdapter2.Update(testWordInstanceDataTable);
								((Page)this).Context.Items.Add("tstId", num3);
								((Page)this).Server.Transfer("test.aspx");
								break;
							}
						}
						goto end_IL_0000;
					}
					case 306:
						num = -1;
						switch (num2)
						{
						case 2:
							((Page)this).Response.Redirect("error.aspx?er=" + Information.Err().Description);
							goto end_IL_0000;
						}
						break;
					}
				}
				catch (Exception ex) when ((num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0000_dispatch = 306;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}
}
