using System;
using System.Net.Http;

namespace CoderNextDoor.WebApp.Helper
{
    public class Helper
    {
        public HttpClient UrlInitial()
        {
            var Client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:50092")
            };
            return Client;
        }
    }
}