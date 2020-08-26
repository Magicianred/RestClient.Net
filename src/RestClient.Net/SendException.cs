﻿using RestClient.Net.Abstractions;
using System;

namespace RestClient.Net
{
    [Serializable]
    public class SendException : Exception
    {
        public Request Request { get; }

        public SendException(string message, Request request, Exception innerException) : base(message, innerException)
        {
            Request = request;
        }
    }

    public class SendException<TRequestBody> : SendException
    {
        public SendException(string message, Request<TRequestBody> request, Exception innerException) : base(message, request, innerException)
        {
        }
    }
}