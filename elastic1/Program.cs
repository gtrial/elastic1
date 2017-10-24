using System;
using Elasticsearch.Net;

namespace elastic1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var settings = new ConnectionConfiguration(new Uri("http://127.0.0.1:9200")).RequestTimeout(TimeSpan.FromMinutes(2));
            var lowlevelClient = new ElasticLowLevelClient(settings);
        }
    }
}