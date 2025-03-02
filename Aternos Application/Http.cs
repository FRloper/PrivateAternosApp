﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aternos_Application
{
    class Http
    {
        public class dWebHook : IDisposable
        {
            private readonly WebClient dWebClient;
            private static NameValueCollection discordValues = new NameValueCollection();
            public string WebHook { get; set; }
            public string UserName { get; set; }
            public string ProfilePicture { get; set; }

            public dWebHook()
            {
                dWebClient = new WebClient();
            }


            public void SendMsg(string msgSend)
            {
                discordValues.Add("username", UserName);
                discordValues.Add("content", msgSend);

                dWebClient.UploadValues(WebHook, discordValues);
            }

            public void Dispose()
            {
                dWebClient.Dispose();
            }
            
        }
    }
}
