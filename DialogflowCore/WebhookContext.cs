using System;
using System.Collections.Generic;
using System.Text;

namespace DialogflowCore
{
    public class WebhookContext
    {
        public String name { get; set; }
        public int lifespanCount { get; set; }
        public IDictionary<String, String> parameters { get; set; }

    }
}
