using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;

namespace CustomDiscordRichPresence
{
    public partial class CustomRichPresence : Form
    {
        public DiscordRpcClient client;
        public string applicationID = "";

        public CustomRichPresence()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void DiscordRichPresence()
        {
            client = new DiscordRpcClient(applicationID);

            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "Debugging RichPresence",
                State = "Working...",
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "RPC",
                }
            });
        }
    }
}