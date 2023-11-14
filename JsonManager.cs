using System;
using Newtonsoft.Json;

namespace JsonFileIO.Jsons
{
    [JsonObject("TestJson")]
    public sealed class TestJson
    {
        [JSonProperty("Url")]
        public string Url { get; set; }

        [JsonProperty("Latest")]
        public int Latest { get; set; }
    }

    public class JsonManger
    {
        TestJson m_listJson = new TestJson();

        public JsonManager()
        {

        }

        void AddManga()
		{

		}
    }
}
