﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
//// in order to use webapiclient add the above namespace
using System.Web;

namespace Mvc
{
    public static class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

         static GlobalVariables()
        {
            WebApiClient.BaseAddress = new Uri("https://localhost:44353/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}