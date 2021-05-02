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

        public CustomRichPresence()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void DiscordRichPresence(object sender, EventArgs e)
        {
            client = new DiscordRpcClient(textBoxAppId.Text);

            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = textBoxDetails.Text,
                State = textBoxState.Text,
                Assets = new Assets()
                {
                    LargeImageKey = textBoxLImageKey.Text,
                    LargeImageText = textBoxLImageText.Text,
                    SmallImageKey = textBoxSImageKey.Text,
                    SmallImageText = textBoxSImageText.Text,
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiscordRichPresence(sender, e);
        }

        private void linkDevPortal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkDevPortal.LinkVisited = true;
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start https://discord.com/developers/applications") { CreateNoWindow = true });
        }

        private void linkTuto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkTuto.LinkVisited = true;
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start https://github.com/Cu-chi/CustomDiscordRichPresence/wiki/Tutorial") { CreateNoWindow = true });
        }
    }
}