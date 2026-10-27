using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class Utilities
{
	public bool DeleteFile(string path)
	{
		bool result;
		try
		{
			File.Delete(path);
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = true;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool Makethumb(string img, string savepath, ImageFormat Imgtype)
	{
		if (File.Exists(img))
		{
			Image val = Image.FromFile(img);
			short num = default;
			short num2 = default;
			checked
			{
				if (val.Height > val.Width)
				{
					if (val.Height > 100)
					{
						num = (short)unchecked(val.Width / (val.Height / 100));
						num2 = 100;
					}
				}
				else if (val.Width > 100)
				{
					num2 = (short)unchecked(val.Height / (val.Width / 100));
					num = 100;
				}
			}
			Image thumbnailImage = val.GetThumbnailImage((int)num, (int)num2, (GetThumbnailImageAbort)null, IntPtr.Zero);
			val.Dispose();
			thumbnailImage.Save(savepath, Imgtype);
			val.Dispose();
			thumbnailImage.Dispose();
			return true;
		}
		bool result = default;
		return result;
	}

	public static string RemoveHTML(string strTxt)
	{
		string value = strTxt;
		Regex regex = new Regex("<[^>]*>", RegexOptions.RightToLeft);
		value = Strings.Replace(Strings.LCase(value), "<br>", "\n");
		if (Operators.CompareString(value, "", TextCompare: false) != 0)
		{
			value = regex.Replace(value, "");
		}
		return value;
	}
}
