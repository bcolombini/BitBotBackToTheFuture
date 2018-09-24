using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBotBackToTheFuture.Models
{
    class JsonParse<T>
    {
        public T objectParsed { get; private set; }

        public JsonParse(string fileDir)
        {
            string json = File.ReadAllText(fileDir);
            objectParsed = JsonConvert.DeserializeObject<T>(json);
        }

    }
}
