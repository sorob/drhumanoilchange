using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class imager
{
	public static bool makethumb(string imgpath, string thumbpath, int maxwidthorhight)
	{
		int try0000_dispatch = -1;
		int num2 = default;
		int num = default;
		bool flag;
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
					if (!File.Exists(imgpath))
					{
						break;
					}
					Image val = Image.FromFile(imgpath);
					short num3;
					short num4;
					checked
					{
						if (val.Height > val.Width)
						{
							num3 = (short)unchecked(val.Width / (val.Height / maxwidthorhight));
							num4 = (short)maxwidthorhight;
						}
						else if (val.Height < val.Width)
						{
							num4 = (short)unchecked(val.Height / (val.Width / maxwidthorhight));
							num3 = (short)maxwidthorhight;
						}
						else
						{
							num4 = (short)maxwidthorhight;
							num3 = (short)maxwidthorhight;
						}
					}
					Image thumbnailImage = val.GetThumbnailImage((int)num3, (int)num4, (GetThumbnailImageAbort)null, IntPtr.Zero);
					thumbnailImage.Save(thumbpath, ImageFormat.Jpeg);
					val.Dispose();
					thumbnailImage.Dispose();
					flag = true;
					goto end_IL_0000;
				}
				case 163:
					num = -1;
					switch (num2)
					{
					case 2:
						flag = false;
						break;
					default:
						goto end_IL_0000_2;
					}
					break;
				}
				flag = true;
				break;
				end_IL_0000_2:;
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0000_dispatch = 163;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000:
			break;
		}
		bool result = flag;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string EncryptText(string strText)
	{
		return Encrypt(strText, "&%#@?,:*");
	}

	public static string DecryptText(string strText)
	{
		return Decrypt(strText, "&%#@?,:*");
	}

	private static string Encrypt(string strText, string strEncrKey)
	{
		byte[] array = new byte[0];
		byte[] rgbIV = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };
		string result;
		try
		{
			array = Encoding.UTF8.GetBytes(Strings.Left(strEncrKey, 8));
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] bytes = Encoding.UTF8.GetBytes(strText);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(array, rgbIV), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			result = Convert.ToBase64String(memoryStream.ToArray());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static string Decrypt(string strText, string sDecrKey)
	{
		byte[] array = new byte[0];
		byte[] rgbIV = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };
		byte[] array2 = new byte[checked(strText.Length + 1)];
		string result;
		try
		{
			array = Encoding.UTF8.GetBytes(Strings.Left(sDecrKey, 8));
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			array2 = Convert.FromBase64String(strText);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(array, rgbIV), CryptoStreamMode.Write);
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.FlushFinalBlock();
			Encoding uTF = Encoding.UTF8;
			result = uTF.GetString(memoryStream.ToArray());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
