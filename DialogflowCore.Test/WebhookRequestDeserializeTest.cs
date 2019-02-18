using DialogflowCore;
using Newtonsoft.Json;
using NUnit.Framework;
using System.IO;

namespace Tests
{
    public class WebhookRequestDeserializeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeserializeDemoJson()
        {
            WebhookRequest WebhookRequest = JsonConvert.DeserializeObject<WebhookRequest>(File.ReadAllText("Resources/Json/WebhookRequestSimple.json"));

            Assert.NotNull(WebhookRequest);

            WebhookResponse WebhookResponse = JsonConvert.DeserializeObject<WebhookResponse>(File.ReadAllText("Resources/Json/WebhookResponseSimple.json"));

            Assert.NotNull(WebhookResponse);

            Assert.AreEqual(WebhookRequest.responseId, "ea3d77e8-ae27-41a4-9e1d-174bd461b68c");
            
        }
    }
}