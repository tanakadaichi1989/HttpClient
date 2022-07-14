using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri  url = new Uri("https://zipcloud.ibsnet.co.jp/api/search?zipcode=1000000");
            Task<String> webTask = SampleHttpClient.GetAsync(url);
            webTask.Wait();
            String result = webTask.Result;
            Console.WriteLine(result);
        }
    }
}
