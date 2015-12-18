using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace ChopApp.Infrastructure
{
    public class BLLServiceGateway<T> where T : class
    {
        public T GetItems(string responsePath)
        {

            HttpResponseMessage response = GetClient().GetAsync(responsePath).Result;
            T item = response.Content.ReadAsAsync<T>().Result;

            return item;
        }

        public T PostItems(string responsePath, T t)
        {
            HttpResponseMessage response = GetClient().PostAsJsonAsync(responsePath, t).Result;
           // response.EnsureSuccessStatusCode();
            T item = response.Content.ReadAsAsync<T>().Result;

            return item;
        }

        public void PutItems(string responsePath, T t)
        {
            HttpResponseMessage response = GetClient().PutAsJsonAsync(responsePath, t).Result;

        }

        public void DeleteItems(string responsePath)
        {
            HttpResponseMessage response = GetClient().DeleteAsync(responsePath).Result;

        }

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:40761/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
            return client;

        }
    }
}