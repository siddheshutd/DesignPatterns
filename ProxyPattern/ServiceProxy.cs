using System;
using System.Collections.Generic;

namespace ProxyPattern
{
    public class ServiceProxy : IService
    {
        private readonly IService _service;
        private readonly Dictionary<string, string> _cache = new Dictionary<string, string>();

        public ServiceProxy(IService service)
        {
            _service = service;
        }

        public string GetData(string key)
        {
            if (_cache.ContainsKey(key))
            {
                Console.WriteLine($"Returning cached data for key: {key}");
                return _cache[key];
            }

            var data = _service.GetData(key);
            _cache.Add(key, data);
            return data;
        }
    }
}
