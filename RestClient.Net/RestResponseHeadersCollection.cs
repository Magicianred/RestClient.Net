﻿using RestClientDotNet.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace RestClientDotNet
{
#pragma warning disable CA1711 // Identifiers should not have incorrect suffix
    public class RestResponseHeadersCollection : IRestHeadersCollection
#pragma warning restore CA1711 // Identifiers should not have incorrect suffix
    {
        #region Public Properties
        public IEnumerable<string> Names => HttpResponseHeaders.ToList().Select(l => l.Key);
        public HttpResponseHeaders HttpResponseHeaders { get; }
        public IEnumerable<string> this[string name] => HttpResponseHeaders.GetValues(name);
        #endregion

        #region Constructor
        public RestResponseHeadersCollection(HttpResponseHeaders httpResponseHeaders)
        {
            HttpResponseHeaders = httpResponseHeaders;
        }
        #endregion

        #region Implementation
        public void Add(string name, string value)
        {
            throw new System.NotImplementedException();
        }

        public void Add(string name, IEnumerable<string> values)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(string name)
        {
            return HttpResponseHeaders.Contains(name);
        }
        #endregion
    }
}
