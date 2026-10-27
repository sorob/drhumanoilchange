using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using FreeTextBoxControls;

namespace ASP;

[CompilerGlobalScope]
public class admin_ftb_imagegallery_aspx : Page, IRequiresSessionState, IHttpHandler
{
	protected ImageGallery ImageGallery1;

	protected HtmlForm Form1;

	private static bool __initialized;

	private static object __fileDependencies;

	protected DefaultProfile Profile
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected Obj, but got Unknown
			return (DefaultProfile)((Control)this).Context.Profile;
		}
	}

	protected HttpApplication ApplicationInstance => ((Control)this).Context.ApplicationInstance;

	protected void Page_Load(object Src, EventArgs E)
	{
	}

	[DebuggerNonUserCode]
	public admin_ftb_imagegallery_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/ftb.imagegallery.aspx";
		if (!__initialized)
		{
			__fileDependencies = ((Page)this).GetWrappedFileDependencies(new string[1] { "~/Admin/ftb.imagegallery.aspx" });
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private ImageGallery __BuildControlImageGallery1()
	{
		ImageGallery imageGallery = (ImageGallery1 = new ImageGallery());
		((Control)imageGallery).ID = "ImageGallery1";
		imageGallery.AllowImageDelete = false;
		imageGallery.AllowImageUpload = true;
		imageGallery.AllowDirectoryCreate = false;
		imageGallery.AllowDirectoryDelete = false;
		return imageGallery;
	}

	[DebuggerNonUserCode]
	private HtmlForm __BuildControlForm1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		HtmlForm val = (Form1 = new HtmlForm());
		((Control)val).ID = "Form1";
		val.Enctype = "multipart/form-data";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("  \r\n    \r\n\t\t"));
		ImageGallery imageGallery = __BuildControlImageGallery1();
		val2.AddParsedSubObject((object)imageGallery);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n\t\t\r\n\t"));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_ftb_imagegallery_aspx __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		((Page)this).InitializeCulture();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n<html>\r\n<head>\r\n\t<title>Image Gallery</title>\r\n</head>\r\n<body>\r\n\r\n    "));
		HtmlForm val = __BuildControlForm1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n</body>\r\n</html>\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).FrameworkInitialize();
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(__fileDependencies);
		((Page)this).TraceEnabled = false;
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 408106987;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
