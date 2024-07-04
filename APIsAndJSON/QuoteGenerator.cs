
namespace APIsAndJSON
{
    internal class QuoteGenerator
    {
        private HttpClient client;

        public QuoteGenerator(HttpClient client)
        {
            this.client = client;
        }
    }
}