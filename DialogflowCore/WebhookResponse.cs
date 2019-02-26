
using DialogflowCore.HelperIntents;
using DialogflowCore.HelperIntents.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogflowCore
{
    public class WebhookResponse
    {
        public String fulfillmentText { get; set; }
        public IList<dynamic> fulfillmentMessages{get;set;}
        public String source { get; set; }
        public IDictionary<String, Object> payload { get; set; }
        public IList<WebhookContext> outputContext { get; set; }
        public EventInput followupEventInput { get; set; }

        public WebhookResponse()
        {
 //           fulfillmentMessages = new List<dynamic>();
   //         outputContext = new List<WebhookContext>();
            payload = new Dictionary<String, object>();
   //         source = "";
        }

        public void AddHelperIntent(IHelperIntent Intent, String TextToSpeech, String DisplayText, bool ExpectUserResponse = true)
        {
            GoogleHelperResponse google = new GoogleHelperResponse(Intent, TextToSpeech, DisplayText, ExpectUserResponse);
            
            payload.Add("google", google);
        }
    }
}
