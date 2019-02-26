using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogflowCore.HelperIntents
{
    public class SignInIntent : IHelperIntent
    {
        public string intent { get; }
        public IDictionary<string, object> data { get; }

        public SignInIntent()
        {
            intent = "actions.intent.SIGN_IN";
            data = new Dictionary<string, object>();
            data.Add("@type", "type.googleapis.com/google.actions.v2.SignInValueSpec");
        }

        

    }
}
