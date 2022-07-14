using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class SampleHttpClient
    {
        public static async Task<String> GetAsync( Uri  url)
        {
            using ( HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync(url);
                    return response;
                } catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
    }
}
