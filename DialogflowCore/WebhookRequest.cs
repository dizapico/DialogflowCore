using System;

namespace DialogflowCore
{
    public class WebhookRequest
    {
        public String responseId { get; set; }
        public QueryResult queryResult { get; set; }
        //TODO: Implement originalDetectIntentRequest for each platform
        public Object originalDetectIntentRequest { get; set; }
        public String session { get; set; }


    }
}
