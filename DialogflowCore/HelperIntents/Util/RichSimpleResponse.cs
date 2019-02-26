using System;
using System.Collections.Generic;
using System.Text;

namespace DialogflowCore.HelperIntents.Util
{
    public class RichSimpleResponse : IRichResponse
    {
        public String textToSpeech { get; set; }
        public String displayText { get; set; }
    }
}
