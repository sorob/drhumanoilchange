using System;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.CompilerServices;

public class WAT_score : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

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

	public WAT_score()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		string text = "You have passed the stress test with flying colors. So if you do have stresses, as we all do, you are mentally handling them very well. From these results we predict that you will do very well as a member of our \"Health Assurance Plan (HA)\". With these WAT test results we will guarantee that as a member of our \"Health Assurance Plan\" that the majority of your abnormal biochemical test results that we are working on will get better. All referrals that you send to us that give you as the referral that join one our HA plans you will receive $100 of credit towards products and/or services.";
		string text2 = "You have barely passed the stress test. Whatever you are doing you are handling your stress factors but are on the edge. We highly recommend you do the complete stress test in which the second part will give you actual treatments of natural products that will help you deal with your stress factors more effectively. With these WAT test results we will guarantee that as a member of our ''Health Assurance Plan'' some of your abnormal biochemical test results that we are working on will get better. All referrals that you send to us that give you as the referral that join one our HA plans you will receive $100 of credit towards products and/or services.";
		string text3 = "According to your stress score you are under severe stress and need to continue the rest of the test (complete test with second part) that will give you the proper natural treatments needed to help correct the abnormal tests scores. At the present time (until you can pass the test) we recommend you seek professional help and would not guarantee any results with our biochemical testing and/or services. You can start the recommended treatments and take our WAT stress test again after several weeks of treatments, to see if you then qualify for our \"Health Assurance Plan\" guarantees.";
		int num = Conversions.ToInteger(((Page)this).Request["s"]);
		if (num < 4)
		{
			Label1.Text = text;
		}
		else if ((num < 7) & (num > 3))
		{
			Label1.Text = text2;
		}
		else if (num >= 7)
		{
			Label1.Text = text3;
		}
		MailMessage mailMessage = new MailMessage();
		MailAddress mailAddress = new MailAddress("Support@HumanOilChange.com");
		string address = "dralaguirre2@aol.com";
		mailMessage.Bcc.Add("sibabi@gmail.com");
		mailMessage.From = mailAddress;
		MailAddress item = new MailAddress(address);
		mailMessage.To.Add(item);
		mailMessage.Bcc.Add("sibabi@gmail.com");
		mailMessage.Subject = "New test has taken by: " + ((Page)this).User.Identity.Name;
		mailMessage.Body = "A new has taken by" + ((Page)this).User.Identity.Name + "<br>Score: " + ((Page)this).Request["s"] + "<br> to see more information go to: http://HumanOilChange.com/admin/WatView.aspx?testid=" + ((Page)this).Request["testid"] + "&un=" + ((Page)this).User.Identity.Name + "&s=" + ((Page)this).Request["s"];
		mailMessage.IsBodyHtml = true;
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Send(mailMessage);
	}
}
