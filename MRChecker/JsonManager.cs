using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace JsonFileIO.Jsons
{
    [JsonObject("MRJson")]
    public sealed class MRJson
    {
        [JsonProperty("Url")]
        public string Url { get; set; }
        
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Latest")]
        public string Latest { get; set; }

        [JsonProperty("Current")]
        public string Current { get; set; }

    }

    public static class JsonManager
    {
        
        static List<MRJson> m_mrJsonData = new List<MRJson>();
        const string JSON_PATH = "MangaJson.json";

        public static void Init()
		{
            ReadMRJson(m_mrJsonData);
		}

        public static List<string> GetUrlList()
		{
            List<string> ret = new List<string>();

            foreach(var item in m_mrJsonData)
			{
                ret.Add(item.Url);
			}

            return ret;
		}

        public static List<MRJson> GetJsonInfo()
        {
            return m_mrJsonData;
        }

        public static void AddManga(string url)
		{
            //追加するURLから得られる情報
            MRJson addData = new MRJson();
            addData.Url = url;

            //追加済みかを確認
            bool isAdded = false;
            foreach(var data in m_mrJsonData)
			{
				if (addData.Url == data.Url)
				{
                    isAdded = true;
                    data.Latest = addData.Latest;
				}
			}
			if (!isAdded)
			{
                m_mrJsonData.Add(addData);
            }

            WriteMRJson(m_mrJsonData);
        }

        public static void UpdateJson(MRJson mrJson)
		{
            ReadMRJson(m_mrJsonData);
            for(int i = 0; i < m_mrJsonData.Count; i++)
			{
				if (m_mrJsonData[i].Url == mrJson.Url)
				{
                    //NULLは入れないように
                    if (mrJson.Current == null) mrJson.Current = m_mrJsonData[i].Current;
                    m_mrJsonData[i] = mrJson;
                    break;
				}
			}
            WriteMRJson(m_mrJsonData);
        }

		public static void UpdateCurrent(string mangaName)
		{
            ReadMRJson(m_mrJsonData);
            for (int i = 0; i < m_mrJsonData.Count; i++)
            {
                if (m_mrJsonData[i].Name == mangaName)
                {
                    m_mrJsonData[i].Current = m_mrJsonData[i].Latest;
                    break;
                }
            }
            WriteMRJson(m_mrJsonData);
        }
        public static void DeleteManga(string mangaName)
        {
            ReadMRJson(m_mrJsonData);
            for (int i = 0; i < m_mrJsonData.Count; i++)
            {
                if (m_mrJsonData[i].Name == mangaName)
                {
                    m_mrJsonData.RemoveAt(i);
                    break;
                }
            }
            WriteMRJson(m_mrJsonData);
        }


        public static void ReadMRJson(List<MRJson> mrJsons)
		{
			if (!File.Exists(JSON_PATH))
			{
                WriteMRJson(m_mrJsonData);
			}
            using(var sr = new StreamReader(JSON_PATH, System.Text.Encoding.UTF8))
			{
                var readData = sr.ReadToEnd();
                var jsonData = JsonConvert.DeserializeObject<List<MRJson>>(readData);

                m_mrJsonData = jsonData ?? new List<MRJson>();
            }
		}
        static void WriteMRJson(List<MRJson> mrJsons)
		{
            var jsonData = JsonConvert.SerializeObject(mrJsons, Formatting.Indented);

            //bin/Debug/net5.0~以下にJsonファイルを出力
            using (var sw = new StreamWriter(JSON_PATH, false, System.Text.Encoding.UTF8))
            {
                sw.Write(jsonData);
            }
        }


    }
}
