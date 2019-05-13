using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WordGame
{
    class Word
    {

        public static Boolean WordCheck(string ans)
        {
            var client = new RestClient("https://api.datamuse.com/");
            var request = new RestRequest($"words?ml={ans}&max=1", Method.GET);
            IRestResponse response = client.Execute(request);
            JsonArray obj = (JsonArray) SimpleJson.DeserializeObject(response.Content);
            try
            {
                JsonObject word = (JsonObject)obj[0];
                if (word != null)
                    return true;
                else
                    return false;
            } catch (Exception e)
            {
                return false;
            }
        }
    }
}
