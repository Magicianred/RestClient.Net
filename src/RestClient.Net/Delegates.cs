﻿using RestClient.Net.Abstractions;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestClient.Net
{
    public delegate Task<HttpResponseMessage> SendHttpRequestMessage(HttpClient httpClient, GetHttpRequestMessage httpRequestMessageFunc, IRequest request);

}