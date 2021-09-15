﻿using System;
using System.Net.Http;
using System.Net;

namespace TestProject.MSTest.Sample.Helpers.Facade
{
    public partial class Facade
    {
        protected readonly HttpClient client;

        public Facade(HttpClient client)
        {
            this.client = client;
        }

        public virtual HttpResponseMessage GetRequest(string? requestUri)
        {
            var httpResult = client.GetAsync(requestUri).GetAwaiter().GetResult();

            if (httpResult.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new ApplicationException("Internal Server Error");
            }
            else if (httpResult.StatusCode == HttpStatusCode.NotFound)
            {
                throw new ApplicationException("Not Found");
            }

            return httpResult;
        }

        public virtual HttpResponseMessage DeleteRequest(string? requestUri)
        {
            var httpResult = client.DeleteAsync(requestUri).GetAwaiter().GetResult();

            if (httpResult.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new ApplicationException("Internal Server Error");
            }
            else if (httpResult.StatusCode == HttpStatusCode.NotFound)
            {
                throw new ApplicationException("Not Found");
            }

            return httpResult;
        }

        public virtual HttpResponseMessage PostRequest(string? requestUri, HttpContent httpContent)
        {
            var httpResult = client.PostAsync(requestUri, httpContent).GetAwaiter().GetResult();

            if (httpResult.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new ApplicationException("Internal Server Error");
            }
            else if (httpResult.StatusCode == HttpStatusCode.NotFound)
            {
                throw new ApplicationException("Not Found");
            }

            return httpResult;
        }

        public virtual HttpResponseMessage PutRequest(string? requestUri, HttpContent httpContent)
        {
            var httpResult = client.PutAsync(requestUri, httpContent).GetAwaiter().GetResult();

            if (httpResult.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new ApplicationException("Internal Server Error");
            }
            else if (httpResult.StatusCode == HttpStatusCode.NotFound)
            {
                throw new ApplicationException("Not Found");
            }

            return httpResult;
        }
    }
}
