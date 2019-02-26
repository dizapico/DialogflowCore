using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogflowCore.HelperIntents.Util
{
    public class GoogleHelperResponse
    {
        [JsonProperty]
        private bool expectUserResponse { get; set; }
        [JsonProperty]
        private GoogleRichResponse richResponse { get; set; }
        public IHelperIntent systemIntent { get; set; }


        public GoogleHelperResponse(IHelperIntent HelperIntent, String TextToSpeech, String DisplayText, bool ExpectUserResponse = true)
        {
            richResponse = new GoogleRichResponse(TextToSpeech, DisplayText);
            systemIntent = HelperIntent;
            expectUserResponse = ExpectUserResponse;
        }
    }
}
