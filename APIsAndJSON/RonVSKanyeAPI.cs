using System;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    public class QuoteGenerator
    {
        private HttpClient _client; //(CLIENT)

        public QuoteGenerator(HttpClient client)
        {
            _client = client;
        }

        public string Kanye()
        {
            //API Url (ENDPOINT)
            var kanyeURL = "https://api.kanye.rest";

            //Stores the JSON repsonse in a variable (RESPONSE BACK FROM GET REQUEST)
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;

            //Parses through the response we received to get the value associated with (PARSE INTO OBJECT)
            //the NAME "quote"
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string RonSwanson()
        {
            //Ron Swanson URL
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = _client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse);

            return ronQuote[0].ToString();
        }
    }
}

