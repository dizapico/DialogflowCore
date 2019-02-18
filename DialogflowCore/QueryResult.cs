using System;
using System.Collections.Generic;
using System.Text;

namespace DialogflowCore
{
    public class QueryResult
    {
        public String queryText{get;set;}
        public String action { get; set; }
        public IDictionary<String, String> parameters { get; set; }
        public Boolean allRequiredParamsPresent { get; set; }
        public String fulfillmentText { get; set; }
        public IList<dynamic> fulfillmentMessages { get; set; }
        public IList<WebhookContext> outputContext { get; set; }
        public WebhookIntent intent { get; set; }
        public double intentDetectionConfidence { get; set; }
        public String languageCode { get; set; }
        public IDictionary<String, Object> diagnosticInfo { get; set; }

    }
}
