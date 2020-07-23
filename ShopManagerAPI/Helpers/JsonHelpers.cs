using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopManagerAPI.Helpers
{
    public class JsonHelpers
    {
        public static string stringify(object o)
        {
            string parsedData = JsonConvert.SerializeObject(o, Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );

            return parsedData;
        }
    }
}