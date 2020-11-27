using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_core_mvc.Helpers
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string Key, object value)
        {
            session.SetString(Key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectAsJson<T>(this ISession session, string Key)
        {
            var value = session.GetString(Key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
