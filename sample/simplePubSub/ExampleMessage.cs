using Softplan.Common.Messaging;
using Softplan.Common.Messaging.Abstractions;

namespace simplePubSub
{
    public class ExampleMessage : Message, IMessage
    {
        public string Text { get; set; }
    }
}