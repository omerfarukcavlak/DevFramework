﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Utilities.Common
{
    public class WcfProxy<T>
    {
        public static T CreateChannel()
        {
            string baseAdress = ConfigurationManager.AppSettings["ServiceAddress"];
            string address = string.Format(baseAdress,typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();
            var channel = new ChannelFactory<T>(binding, address);

            return channel.CreateChannel();
        }
    }
}
