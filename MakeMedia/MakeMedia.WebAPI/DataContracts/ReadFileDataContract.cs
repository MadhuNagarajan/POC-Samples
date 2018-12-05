using Newtonsoft.Json;

namespace MakeMedia.WebAPI.DataContracts
{
    public class ReadFileDataContract: BaseDataContract
    {
        [JsonProperty ("filename")]
        public string Filename { get; set; }
    }
}