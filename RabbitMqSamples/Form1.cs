using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace RabbitMqSamples
{
    public partial class Form1 : Form
    {
        private IConnection _rabbitMQConnection;
        private IModel _Mobile;
        private IModel _Web;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectRabbitMQ_Click(object sender, EventArgs e)
        {

            if (_rabbitMQConnection != null)
            {
                _rabbitMQConnection.Close();
            }

            var connectionString = ConfigurationManager.ConnectionStrings["RabbitMQconnection"].ConnectionString;
            var connectionFactory = new ConnectionFactory();
            connectionFactory.Uri = new Uri(connectionString);
            connectionFactory.AutomaticRecoveryEnabled = true;
            connectionFactory.DispatchConsumersAsync = true;
            _rabbitMQConnection = connectionFactory.CreateConnection("DemoApp");
        }

        private void btnCreateExchange_Click(object sender, EventArgs e)
        {
            if (_rabbitMQConnection != null)
            {
                using (var channel = _rabbitMQConnection.CreateModel())
                {
                    channel.ExchangeDeclare("CustomerNotification", ExchangeType.Direct, false);
                }
            }
            else
            {
                MessageBox.Show("you need to connect first", "Alert");
            }
        }

        private void btnCreatteQueues_Click(object sender, EventArgs e)
        {
            if (_rabbitMQConnection != null)
            {
                using (var channel = _rabbitMQConnection.CreateModel())
                {
                    channel.QueueDeclare("Mobile", true, false, false);
                    channel.QueueDeclare("WebApp", true, false, false);
                }
            }
            else
            {
                MessageBox.Show("you need to connect first", "Alert");
            }
        }

        private void btnBindQueues_Click(object sender, EventArgs e)
        {
            if (_rabbitMQConnection != null)
            {
                using (var channel = _rabbitMQConnection.CreateModel())
                {
                    channel.QueueBind("Mobile", "CustomerNotification", "Mobile");
                    channel.QueueBind("WebApp", "CustomerNotification", "Web");
                }
            }
            else
            {
                MessageBox.Show("you need to connect first", "Alert");
            }
        }

        private void btnPublishMobileMessage_Click(object sender, EventArgs e)
        {
            if (_rabbitMQConnection != null)
            {
                using (var channel = _rabbitMQConnection.CreateModel())
                {
                    string message = txtMobileMessage.Text;
                    var properties = channel.CreateBasicProperties();
                    properties.DeliveryMode = 2;
                    channel.BasicPublish("CustomerNotification", "Mobile", properties, Encoding.UTF8.GetBytes(message));
                }
            }
            else
            {
                MessageBox.Show("you need to connect first", "Alert");
            }
        }

        private void btnPublishWebMessage_Click(object sender, EventArgs e)
        {
            if (_rabbitMQConnection != null)
            {
                using (var channel = _rabbitMQConnection.CreateModel())
                {
                    string message = txtWebMessage.Text;
                    var properties = channel.CreateBasicProperties();
                    properties.DeliveryMode = 2;
                    //Messages marked as 'persistent' that are delivered to 'durable' queues will be logged to disk. Durable queues are recovered in the event of a crash, along with any persistent messages they stored prior to the crash.
                    channel.BasicPublish("CustomerNotification", "Web", properties, Encoding.UTF8.GetBytes(message));
                }
            }
            else
            {
                MessageBox.Show("you need to connect first", "Alert");
            }
        }

        private void btnsubMobile_Click(object sender, EventArgs e)
        {
            if (_Mobile != null)
                _Mobile.Close();

            if (_rabbitMQConnection != null)
            {
                _Mobile = _rabbitMQConnection.CreateModel();
                _Mobile.BasicQos(0, 1, false);

                var consumer = new AsyncEventingBasicConsumer(_Mobile);
                consumer.Received += Consumer_Received;
                _Mobile.BasicConsume("Mobile", false, consumer);
            }
            else
            {
                MessageBox.Show("you need to connect first", "Alert");
            }
        }

        private async Task Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var messgae = Encoding.UTF8.GetString(e.Body.ToArray());
            lsbMobile.Invoke((MethodInvoker)(() => lsbMobile.Items.Add(messgae)));
            _Mobile.BasicAck(e.DeliveryTag, false);
        }

        private void btnsubWeb_Click(object sender, EventArgs e)
        {
            if (_Web != null)
                _Web.Close();

            if (_rabbitMQConnection != null)
            {
                _Web = _rabbitMQConnection.CreateModel();
                _Web.BasicQos(0, 1, false);
                var consumer = new AsyncEventingBasicConsumer(_Web);
                consumer.Received += Consumer_ReceivedWeb;
                _Web.BasicConsume("WebApp", false, consumer);
            }
            else
            {
                MessageBox.Show("you need to connect first", "Alert");
            }
        }
        private async Task Consumer_ReceivedWeb(object sender, BasicDeliverEventArgs e)
        {
            var messgae = Encoding.UTF8.GetString(e.Body.ToArray());
            lsbWebMessages.Invoke((MethodInvoker)(() => lsbWebMessages.Items.Add(messgae)));
            _Web.BasicAck(e.DeliveryTag, false);
        }
    }
}
