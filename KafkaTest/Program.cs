using KafkaTest.Consumer;
using KafkaTest.Producer;

ConsumerBuilder builder = new ConsumerBuilder();

builder.ConnectTopic();

ProducerBuilder producerBuilder = new ProducerBuilder();

await producerBuilder.SendMessageProducer("hello");

await producerBuilder.SendMessageProducer("world");

Console.ReadLine();