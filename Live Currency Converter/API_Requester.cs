using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Live_Currency_Converter
{
    class API_Requester
    {
        private string url;
        private WebClient client;

        public API_Requester(string url)
        {
            this.url = url;
            client = new WebClient();
        }
        public string Response_Sender_Getter()
        {
        return client.DownloadString(url);
        }

    }
}
