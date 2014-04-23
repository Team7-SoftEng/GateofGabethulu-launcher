using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherPrototype
{
    class Client
    {

        private String serverName;
        private String clientName;
        private Int32 gamePort;
        private TcpClient client;
        private NetworkStream netStream;
        private SslStream ssl;
        private StreamReader reader;
        private StreamWriter writer;
        private X509Certificate2 cert;

        public Client(String host, Int32 port)
        {

            try
            {

                clientName = Dns.GetHostName();


            }
            catch (SocketException se)
            {

                MessageBox.Show("ERROR: Could not retrieve client's DNS hostname.  Please try again." + se.Message + ".", "Client Socket Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            serverName = host;
            gamePort = port;
            client = new TcpClient(host, port);
            netStream = client.GetStream();
            reader = new StreamReader(netStream);
            writer = new StreamWriter(netStream);
            ssl = new SslStream(netStream, false, new RemoteCertificateValidationCallback(ValidateCert));
            cert = new X509Certificate2("server.crt");
            ssl.AuthenticateAsClient(serverName);
            writer.AutoFlush = true;

        }

        private static bool ValidateCert(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {

            return true; // Allow untrusted certificates.
        
        }

        public String getServerName()
        {

            return this.serverName;

        }

        public String getClientName()
        {

            return this.clientName;

        }

        public Int32 getGamePort()
        {

            return this.gamePort;

        }

        public TcpClient getGameClient()
        {

            return this.client;

        }

        public Stream getNetworkStream()
        {

            return this.netStream;

        }

        public StreamReader getStreamReader()
        {

            return this.reader;

        }

        public StreamWriter getStreamWriter()
        {

            return this.writer;

        }

    }

}
