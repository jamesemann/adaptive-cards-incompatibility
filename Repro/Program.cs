using AdaptiveCards.Templating;

namespace Repro;

public class DoesItWork
{
    public static async Task Main()
    {
        var template = new AdaptiveCardTemplate(@"{
            ""type"": ""AdaptiveCard"",
    ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
    ""version"": ""1.5"",
    ""body"": [
        {
            ""type"": ""TextBlock"",
            ""text"": ""this doesnt work"",
            ""wrap"": true
        }
        ]
        }");
            
        var card = template.Expand(new {});
    }
} 