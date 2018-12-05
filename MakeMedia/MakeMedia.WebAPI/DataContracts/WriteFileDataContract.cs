using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MakeMedia.WebAPI.DataContracts
{
    public class WriteFileDataContract: BaseDataContract
    {
        [JsonProperty ("filename")]
        public string Filename { get; set; }

        [JsonProperty ("filecontent")]
        public string FileContent { get; set; }
    }
}