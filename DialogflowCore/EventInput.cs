using System;
using System.Collections.Generic;
using System.Text;

namespace DialogflowCore
{
    public class EventInput
    {
        public String name { get; set; }
        public IDictionary<string, object> parameters { get; set; }
        public String languageCode { get; set; }
    }
}
