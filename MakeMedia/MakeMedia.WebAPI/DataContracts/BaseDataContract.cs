using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MakeMedia.WebAPI.DataContracts
{
    public class BaseDataContract
    {
        [JsonProperty ("ErrorCode")]
        public int ErrorCode { get; set; }

        [JsonProperty("ErrorMessage")]
        public string ErrorMessage { get; set; }
    }
}