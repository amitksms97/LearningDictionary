using System;
using System.Collections.Generic;

namespace LearningDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, string> config = new Dictionary<string, string>();

            config.Add("resolution", "1930*1080");
            config.Add("title", "MyWebsite"); 

            Console.WriteLine(config["title"]);

            foreach(var setting in config)
            {
                Console.WriteLine(setting.Value);
            }
        }
    }
}
