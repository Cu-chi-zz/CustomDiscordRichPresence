
namespace CustomDiscordRichPresence
{
    partial class CustomRichPresence
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAppId = new System.Windows.Forms.TextBox();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxLImageKey = new System.Windows.Forms.TextBox();
            this.textBoxLImageText = new System.Windows.Forms.TextBox();
            this.textBoxSImageKey = new System.Windows.Forms.TextBox();
            this.textBoxSImageText = new System.Windows.Forms.TextBox();
            this.linkDevPortal = new System.Windows.Forms.LinkLabel();
            this.linkTuto = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update RPC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAppId
            // 
            this.textBoxAppId.Location = new System.Drawing.Point(13, 31);
            this.textBoxAppId.Name = "textBoxAppId";
            this.textBoxAppId.PlaceholderText = "Application ID";
            this.textBoxAppId.Size = new System.Drawing.Size(250, 23);
            this.textBoxAppId.TabIndex = 2;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(12, 60);
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.PlaceholderText = "Details";
            this.textBoxDetails.Size = new System.Drawing.Size(250, 23);
            this.textBoxDetails.TabIndex = 3;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(12, 89);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.PlaceholderText = "State";
            this.textBoxState.Size = new System.Drawing.Size(250, 23);
            this.textBoxState.TabIndex = 4;
            // 
            // textBoxLImageKey
            // 
            this.textBoxLImageKey.Location = new System.Drawing.Point(12, 118);
            this.textBoxLImageKey.Name = "textBoxLImageKey";
            this.textBoxLImageKey.PlaceholderText = "Large Image Key";
            this.textBoxLImageKey.Size = new System.Drawing.Size(250, 23);
            this.textBoxLImageKey.TabIndex = 5;
            // 
            // textBoxLImageText
            // 
            this.textBoxLImageText.Location = new System.Drawing.Point(12, 147);
            this.textBoxLImageText.Name = "textBoxLImageText";
            this.textBoxLImageText.PlaceholderText = "Large Image Text";
            this.textBoxLImageText.Size = new System.Drawing.Size(250, 23);
            this.textBoxLImageText.TabIndex = 6;
            // 
            // textBoxSImageKey
            // 
            this.textBoxSImageKey.Location = new System.Drawing.Point(12, 176);
            this.textBoxSImageKey.Name = "textBoxSImageKey";
            this.textBoxSImageKey.PlaceholderText = "Small Image Key";
            this.textBoxSImageKey.Size = new System.Drawing.Size(250, 23);
            this.textBoxSImageKey.TabIndex = 7;
            // 
            // textBoxSImageText
            // 
            this.textBoxSImageText.Location = new System.Drawing.Point(12, 205);
            this.textBoxSImageText.Name = "textBoxSImageText";
            this.textBoxSImageText.PlaceholderText = "Small Image Text";
            this.textBoxSImageText.Size = new System.Drawing.Size(250, 23);
            this.textBoxSImageText.TabIndex = 8;
            // 
            // linkDevPortal
            // 
            this.linkDevPortal.AutoSize = true;
            this.linkDevPortal.Location = new System.Drawing.Point(12, 13);
            this.linkDevPortal.Name = "linkDevPortal";
            this.linkDevPortal.Size = new System.Drawing.Size(94, 15);
            this.linkDevPortal.TabIndex = 9;
            this.linkDevPortal.TabStop = true;
            this.linkDevPortal.Text = "Developer Portal";
            this.linkDevPortal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDevPortal_LinkClicked);
            // 
            // linkTuto
            // 
            this.linkTuto.AutoSize = true;
            this.linkTuto.Location = new System.Drawing.Point(215, 13);
            this.linkTuto.Name = "linkTuto";
            this.linkTuto.Size = new System.Drawing.Size(47, 15);
            this.linkTuto.TabIndex = 10;
            this.linkTuto.TabStop = true;
            this.linkTuto.Text = "Tutorial";
            this.linkTuto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTuto_LinkClicked);
            // 
            // CustomRichPresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 273);
            this.Controls.Add(this.linkTuto);
            this.Controls.Add(this.linkDevPortal);
            this.Controls.Add(this.textBoxSImageText);
            this.Controls.Add(this.textBoxSImageKey);
            this.Controls.Add(this.textBoxLImageText);
            this.Controls.Add(this.textBoxLImageKey);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.textBoxAppId);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomRichPresence";
            this.Text = "Custom Rich Presence";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAppId;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxLImageKey;
        private System.Windows.Forms.TextBox textBoxLImageText;
        private System.Windows.Forms.TextBox textBoxSImageKey;
        private System.Windows.Forms.TextBox textBoxSImageText;
        private System.Windows.Forms.LinkLabel linkDevPortal;
        private System.Windows.Forms.LinkLabel linkTuto;
    }
}

