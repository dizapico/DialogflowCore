using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogflowCore.HelperIntents.Util
{
    public class GoogleRichResponse
    {
        [JsonProperty]
        private IList<JProperty> items { get; set; }

        public GoogleRichResponse(String TextToSpeech, String DisplayText)
        {
            items = new List<JProperty>();
            RichSimpleResponse simpleResponse = new RichSimpleResponse()
            {
                textToSpeech = TextToSpeech,
                displayText = DisplayText
            };

            items.Add(new JProperty("simpleResponse", simpleResponse));
        }


    }
}
