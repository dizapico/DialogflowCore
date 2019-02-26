using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogflowCore.HelperIntents
{
    public interface IHelperIntent
    {
        String intent { get; }
        IDictionary<string,object> data { get; }
    }
}
