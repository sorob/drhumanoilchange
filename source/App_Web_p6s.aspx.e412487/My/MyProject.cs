using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Web;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic.MyServices.Internal;

namespace My;

[HideModuleName]
[GeneratedCode("MyTemplate", "10.0.0.0")]
[StandardModule]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		private readonly ContextValue<T> m_Context;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				T val = m_Context.Value;
				if (val == null)
				{
					val = new T();
					m_Context.Value = val;
				}
				return val;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
			m_Context = new ContextValue<T>();
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<WebUser> m_UserObjectProvider = new ThreadSafeObjectProvider<WebUser>();

	private static readonly ThreadSafeObjectProvider<AspLog> m_LogObjectProvider = new ThreadSafeObjectProvider<AspLog>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static WebUser User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Request")]
	internal static HttpRequest Request
	{
		[DebuggerHidden]
		get
		{
			HttpContext current = HttpContext.Current;
			if (current != null)
			{
				return current.Request;
			}
			return null;
		}
	}

	[HelpKeyword("My.Response")]
	internal static HttpResponse Response
	{
		[DebuggerHidden]
		get
		{
			HttpContext current = HttpContext.Current;
			if (current != null)
			{
				return current.Response;
			}
			return null;
		}
	}

	[HelpKeyword("My.Application.Log")]
	internal static AspLog Log
	{
		[DebuggerHidden]
		get
		{
			return m_LogObjectProvider.GetInstance;
		}
	}
}
