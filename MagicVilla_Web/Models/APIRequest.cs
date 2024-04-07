using MagicVilla_Utility;

namespace MagicVilla_Web.Models

{
    
    public class APIRequest
    {
        public APIRequest()
        {
            ApiType = SD.ApiType.GET;
        }

        public SD.ApiType ApiType { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
    }
    
}

