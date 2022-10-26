using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

namespace GnatMQ_Broker
{
    public partial class Service1 : ServiceBase
    {
        MqttBroker broker = new MqttBroker();

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            broker.Start();
            
        }

        protected override void OnStop()
        {
            broker.Stop();
        }
    }
}
