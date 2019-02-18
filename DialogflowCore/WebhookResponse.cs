
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
    }
}
