using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ordersTableAdapters;

public class buy : Page, IRequiresSessionState
{
	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label31")]
	private Label _Label31;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("contentdiv1")]
	private HtmlGenericControl _contentdiv1;

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

	protected virtual Label Label30
	{
		get
		{
			return _Label30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label30 = value;
		}
	}

	protected virtual Label Label19
	{
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label19 = value;
		}
	}

	protected virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	protected virtual Label Label31
	{
		get
		{
			return _Label31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label31 = value;
		}
	}

	protected virtual Label Label5
	{
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label5 = value;
		}
	}

	protected virtual Label Label6
	{
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label6 = value;
		}
	}

	protected virtual Label Label7
	{
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label7 = value;
		}
	}

	protected virtual Label Label23
	{
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label23 = value;
		}
	}

	protected virtual Label Label9
	{
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label9 = value;
		}
	}

	protected virtual Label Label10
	{
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label10 = value;
		}
	}

	protected virtual Label Label11
	{
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label11 = value;
		}
	}

	protected virtual Label Label12
	{
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label12 = value;
		}
	}

	protected virtual Label Label24
	{
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label24 = value;
		}
	}

	protected virtual HtmlGenericControl contentdiv1
	{
		get
		{
			return _contentdiv1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_contentdiv1 = value;
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

	public buy()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		string text = ((Page)this).Request.Form.ToString();
		SmtpClient smtpClient = new SmtpClient();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.paypal.com/cgi-bin/webscr");
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		string text2 = text + "&cmd=_notify-validate";
		httpWebRequest.ContentLength = text2.Length;
		StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream(), Encoding.ASCII);
		streamWriter.Write(text2);
		streamWriter.Close();
		StreamReader streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream());
		string text3 = streamReader.ReadToEnd();
		streamReader.Close();
		string text5 = default;
		try
		{
			string text4 = ((Page)this).Request.Form["option_selection1_1"];
			if (((Page)this).User.Identity.IsAuthenticated)
			{
				text5 = ((Page)this).User.Identity.Name;
			}
			else
			{
				text5 = ((Operators.CompareString(text4, "", TextCompare: false) != 0) ? text4 : ((Page)this).Request.Form["payer_id"]);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			smtpClient.Send("Support@HumanOilChange.com", "blueapple_s@yahoo.com", "Formvalues", text);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text3, "VERIFIED", TextCompare: false) == 0)
		{
			((Page)this).Session["Verified"] = "OK";
			ahnTableAdapter ahnTableAdapter2 = new ahnTableAdapter();
			ahnTableAdapter2.InsertQuery(((Page)this).Request.Form["mc_gross"], ((Page)this).Request.Form["item_number1"], ((Page)this).Request.Form["payer_id"], ((Page)this).Request.Form["tax"], ((Page)this).Request.Form["payment_date"], ((Page)this).Request.Form["payment_status"], ((Page)this).Request.Form["charset"], ((Page)this).Request.Form["mc_tax1"], ((Page)this).Request.Form["mc_shipping"], ((Page)this).Request.Form["mc_handling"], ((Page)this).Request.Form["first_name"], ((Page)this).Request.Form["notify_version"], ((Page)this).Request.Form["custom"], ((Page)this).Request.Form["payer_status"], ((Page)this).Request.Form["num_cart_items"], ((Page)this).Request.Form["mc_handling1"], ((Page)this).Request.Form["verify_sign"], ((Page)this).Request.Form["payer_email"], ((Page)this).Request.Form["mc_shipping1"], ((Page)this).Request.Form["tax1"], ((Page)this).Request.Form["txn_id"], ((Page)this).Request.Form["payment_type"], ((Page)this).Request.Form["last_name"], ((Page)this).Request.Form["item_name1"], ((Page)this).Request.Form["quantity1"], ((Page)this).Request.Form["pending_reason"], ((Page)this).Request.Form["txn_type"], ((Page)this).Request.Form["mc_gross_1"], ((Page)this).Request.Form["mc_currency"], ((Page)this).Request.Form["residence_country"], ((Page)this).Request.Form["test_ipn"], ((Page)this).Request.Form["payment_gross"], text5, ((Page)this).Request.Form["receiver_email"]);
			Label2.Text = ((Page)this).Request.Form["mc_gross"];
			Label3.Text = ((Page)this).Request.Form["item_number1"];
			Label5.Text = ((Page)this).Request.Form["tax"];
			Label6.Text = ((Page)this).Request.Form["payment_date"];
			Label7.Text = ((Page)this).Request.Form["payment_status"];
			Label9.Text = ((Page)this).Request.Form["mc_tax1"];
			Label10.Text = ((Page)this).Request.Form["mc_shipping"];
			Label11.Text = ((Page)this).Request.Form["mc_handling"];
			Label12.Text = ((Page)this).Request.Form["first_name"];
			Label19.Text = ((Page)this).Request.Form["payer_email"];
			Label23.Text = ((Page)this).Request.Form["payment_type"];
			Label24.Text = ((Page)this).Request.Form["last_name"];
			Label30.Text = ((Page)this).Request.Form["mc_currency"];
			Label31.Text = ((Page)this).Request.Form["residence_country"];
			if (Conversions.ToDouble(Label3.Text) == 10002.0)
			{
				FundsTableAdapter fundsTableAdapter = new FundsTableAdapter();
				fundsTableAdapter.InsertFund(Conversions.ToDecimal(Label2.Text), text5, "Quick Checkout Account Payment", DateAndTime.Now);
			}
			string text6 = Label19.Text;
			MailMessage mailMessage = new MailMessage("Support@HumanOilChange.com", text6);
			mailMessage.Bcc.Add("sibabi@gmail.com");
			mailMessage.Bcc.Add("dralaguirre2@aol.com");
			mailMessage.Subject = "Your Mental Stress Tester Order";
			mailMessage.Body = getbody();
			mailMessage.IsBodyHtml = true;
			smtpClient.Send(mailMessage);
		}
		else
		{
			((Page)this).Response.Write(text3);
		}
	}

	private string getbody()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		string path = ((Page)this).Server.MapPath("emailtemplate.htm");
		StreamReader streamReader = File.OpenText(path);
		string text = streamReader.ReadToEnd();
		streamReader.Close();
		int num = 2;
		do
		{
			if (((Control)contentdiv1).FindControl("Label" + Conversions.ToString(num)) != null)
			{
				Label val = (Label)((Control)contentdiv1).FindControl("Label" + Conversions.ToString(num));
				text = Strings.Replace(text, "\"Label" + Conversions.ToString(num) + "\"", val.Text);
			}
			num = checked(num + 1);
		}
		while (num <= 40);
		return text;
	}
}
