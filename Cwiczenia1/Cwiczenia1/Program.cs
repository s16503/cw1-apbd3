using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cwiczenia1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(args[0]);

           // Console.Write(response);

   
            Regex reg1 = new Regex(@"\b[a-z][a-z0-9_]*@[a-z0-9]*\.[a-z]{2,3}\b");
            Regex reg2 = new Regex(@"\b[a-z][a-z0-9_]*@[a-z0-9]*\.[a-z0-9]*\.[a-z]{2,3}\b");


        


            foreach( Match m in reg1.Matches(response) )
            {
                Console.WriteLine(m.Value);
            }

            foreach (Match m in reg2.Matches(response))
            {
                Console.WriteLine(m.Value);
            }

            //while(reg1.IsMatch(response))
            //{
            //    Console.Write(reg1.Match(response));
            //    reg1.
            //}

            
        }
    }
}