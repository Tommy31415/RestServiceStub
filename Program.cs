using System;
using System.Net;

/**
    Based on 
    https://codehosting.net/blog/BlogEngine/post/Simple-C-Web-Server
*/

namespace RestServiceTestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServer ws = new WebServer(SendResponse, "http://localhost:8080/");
            ws.Run();
            Console.WriteLine("A simple webserver. Press a key to quit.");
            Console.ReadKey();
            ws.Stop();
        }

        public static string SendResponse(HttpListenerRequest request)
        {
            Console.WriteLine(request.Url);
            string text = System.IO.File.ReadAllText(@"c:\temp\response.json");
            return text;
        }
    }
}
