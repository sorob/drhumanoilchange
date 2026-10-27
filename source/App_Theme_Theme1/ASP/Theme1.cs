using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI;

namespace ASP;

[CompilerGlobalScope]
public class Theme1 : PageTheme
{
	private HybridDictionary __controlSkins;

	private string[] __linkedStyleSheets;

	private static bool __initialized;

	protected override string AppRelativeTemplateSourceDirectory => "/DrHumanOilChange/App_Themes/Theme1/";

	protected override IDictionary ControlSkins => __controlSkins;

	protected override string[] LinkedStyleSheets => __linkedStyleSheets;

	[DebuggerNonUserCode]
	public Theme1()
	{
		__controlSkins = new HybridDictionary(0);
		__linkedStyleSheets = new string[1] { "~/App_Themes/Theme1/StyleSheet.css" };
		if (!__initialized)
		{
			__initialized = true;
		}
	}
}
