using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

public class txtimport : Page, IRequiresSessionState
{
	[AccessedThroughProperty("FileUpload1")]
	private FileUpload _FileUpload1;

	[AccessedThroughProperty("LinkButton1")]
	private LinkButton _LinkButton1;

	[AccessedThroughProperty("form1")]
	private HtmlForm _form1;

	protected virtual FileUpload FileUpload1
	{
		get
		{
			return _FileUpload1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FileUpload1 = value;
		}
	}

	protected virtual LinkButton LinkButton1
	{
		get
		{
			return _LinkButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LinkButton1_Click;
			if (_LinkButton1 != null)
			{
				_LinkButton1.Click -= eventHandler;
			}
			_LinkButton1 = value;
			if (_LinkButton1 != null)
			{
				_LinkButton1.Click += eventHandler;
			}
		}
	}

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

	protected void LinkButton1_Click(object sender, EventArgs e)
	{
		FileInfo fileInfo = new FileInfo(FileUpload1.PostedFile.FileName);
		if (Operators.CompareString(fileInfo.Extension, ".pdf", TextCompare: false) == 0)
		{
			string text = ReadPdfFile(FileUpload1.PostedFile.InputStream);
			string[] array = text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = array;
			foreach (string data in array2)
			{
				process(data);
			}
		}
		else
		{
			StreamReader streamReader = new StreamReader(FileUpload1.PostedFile.InputStream);
			while (streamReader.Peek() != -1)
			{
				process(streamReader.ReadLine());
			}
		}
	}

	public string ReadPdfFile(Stream fileName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		PdfReader pdfReader = new PdfReader(fileName);
		int numberOfPages = pdfReader.NumberOfPages;
		for (int i = 1; i <= numberOfPages; i = checked(i + 1))
		{
			ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
			string textFromPage = PdfTextExtractor.GetTextFromPage(pdfReader, i, strategy);
			textFromPage = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(textFromPage)));
			stringBuilder.Append(textFromPage);
			pdfReader.Close();
		}
		return stringBuilder.ToString();
	}

	private void process(string data)
	{
		int try0000_dispatch = -1;
		checked
		{
			int num2 = default;
			bool flag = default;
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
						data = data.TrimStart(new char[0]);
						Regex regex = new Regex("\\d");
						if (Operators.CompareString(Strings.Mid(data, 1, 13), "Patient Code:", TextCompare: false) != 0 && ((data.IndexOf("  ") > -1) & regex.IsMatch(data)))
						{
							if (data.IndexOf("Not Estab") > -1)
							{
								flag = true;
							}
							data = data.TrimStart(new char[0]);
							if (Operators.CompareString(Strings.Mid(data, 1, 2), "**", TextCompare: false) == 0 || data.IndexOf("  ") < 1)
							{
								break;
							}
							Regex regex2 = new Regex("\\d");
							Regex regex3 = new Regex("\\d");
							Regex regex4 = new Regex("\\s");
							Regex regex5 = new Regex("\\s");
							Regex regex6 = new Regex("\\w");
							((Page)this).Response.Write("<br>Name:" + Strings.Mid(data, 1, regex2.Matches(data)[0].Index));
							string text = Strings.Mid(data, regex2.Matches(data)[0].Index + 1).TrimStart(new char[0]);
							((Page)this).Response.Write(" value:" + Conversions.ToString(Conversion.Val(Strings.Mid(text, 1, regex4.Matches(text)[0].Index + 1).TrimStart(new char[0]))));
							string text2 = Strings.Mid(text, regex4.Matches(text)[0].Index + 1).TrimStart(new char[0]);
							int i = 0;
							if (!flag)
							{
								for (; regex3.Matches(text2)[0].Index > regex5.Matches(text2)[i].Index; i++)
								{
								}
								((Page)this).Response.Write(" minmax:" + Strings.Mid(text2, regex3.Matches(text2)[0].Index + 1, regex5.Matches(text2)[i].Index + 1));
							}
							else
							{
								for (; regex6.Matches(text2)[0].Index > regex5.Matches(text2)[i].Index; i++)
								{
								}
								((Page)this).Response.Write("<font color=\"red\"> minmax:" + Strings.Mid(text2, regex6.Matches(text2)[0].Index + 1, regex5.Matches(text2)[i].Index + 1) + "</font>");
							}
						}
						else if (Information.IsDate(data.Trim()))
						{
							((Page)this).Response.Write("date=" + data.Trim());
						}
						else if (Operators.CompareString(Strings.Mid(data, 1, 13), "Patient Code:", TextCompare: false) == 0)
						{
							((Page)this).Response.Write("Patient Code is " + Strings.Mid(data, 14).Trim());
						}
						break;
					}
					case 793:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_0353;
						}
						break;
					}
				}
				catch (Exception ex) when ((num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0000_dispatch = 793;
					continue;
				}
				break;
				IL_0353:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}
}
