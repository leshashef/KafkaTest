using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaTest.Producer
{
    public class ProducerBuilder
    {
        private readonly ProducerConfig config = new ProducerConfig { BootstrapServers = "localhost:9092" };
        private readonly string topic = "simpletalk_topic";

        public async Task SendMessageProducer(string message)
        {
            using (var producer =
                 new ProducerBuilder<Null, string>(config).Build())
            {
                try
                {
                    var res = await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Oops, something went wrong: {e}");
                }
            }

        }
    }
}
