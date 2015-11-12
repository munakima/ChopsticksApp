using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace ChopApp.Models
{
    public class HomepicClient
    {
        private string BASE_URL = "http://localhost:49079/api/";

        public IEnumerable<Homepic> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                  new  MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("homepics").Result;
                if (response.IsSuccessStatusCode)              
                    return response.Content.ReadAsAsync<IEnumerable<Homepic>>().Result;
                return null;
               
            }
            catch
            {
                return null;
            }
        }

        public Homepic find(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                  new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("homepics/"+id).Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<Homepic>().Result;
                return null;

            }
            catch
            {
                return null;
            }
        }
        public bool Create(Homepic homepic)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                  new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("homepics/",homepic).Result;
                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }
        }
        public bool Edit(Homepic homepic)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                  new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("homepics/" + homepic.Id, homepic).Result;
                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }
        }
        public bool Delelte(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(
                  new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("homepics/"+id).Result;
                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }
        }
    }

}