using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace TestProject2
{
    public static class TestFactory
    {
        public static HttpRequest HttpRequestFactory(string key, string value)
        {
            return new DefaultHttpContext { Request = { Query = new QueryCollection(new Dictionary<string, StringValues> { { key, value } }) } }.Request;
        }
    }

  
}