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
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static string GetRandomWord(char c)
        {
            Random random = new Random();
            string questMark = new string('?', random.Next(5, 10));
            string ans = c + questMark;
            var client = new RestClient("https://api.datamuse.com/");
            var request = new RestRequest($"words?sp={ans}", Method.GET);
            IRestResponse response = client.Execute(request);
            JsonArray obj = (JsonArray)SimpleJson.DeserializeObject(response.Content);
            JsonObject word = (JsonObject)obj[random.Next(0, obj.Count()-1)];
            string randomWord = (string)word["word"];
            if (randomWord.Contains(" ") || randomWord.Any(char.IsDigit) || randomWord.Contains("-"))
                randomWord = GetRandomWord(c);

            return randomWord;
        }

        public static string CleanAnswer(string answer)
        {
            answer = answer.Replace(" ", "").Replace(".", "").Replace(",", "");
            answer = answer.ToLower();
            return answer;
        }
    }
}
