using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.XPath;

using JsonFileIO.Jsons;

namespace MRChecker
{
	class ScrapingManager
	{
		IBrowsingContext context = BrowsingContext.New(Configuration.Default.WithDefaultLoader());

		public async Task UpdateMRInfo(string url, bool isFirst = false)
		{
			WebClient wc = new WebClient();
			try
			{
				string htmldocs = wc.DownloadString(url);
				
				var config = Configuration.Default;
				var context = BrowsingContext.New(config);
				var document = await context.OpenAsync(req => req.Content(htmldocs));

				MRJson mrJson =new MRJson();
				mrJson.Url = url;
				mrJson.Name = document.QuerySelectorAll("h1")[0].TextContent.Trim();
				mrJson.Latest = document.QuerySelectorAll("th")[0].TextContent.Trim();
				if (isFirst)
				{
					mrJson.Current = mrJson.Latest;
				}

				JsonManager.UpdateJson(mrJson);
			}
			catch (System.Exception)
			{
				throw;
			}
			//一応0.1秒ディレイ
			await Task.Delay(100);
		}
	}
}
