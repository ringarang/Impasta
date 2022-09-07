namespace Cheat
{
    partial class Impasta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit_Btn = new FlatUI.FlatClose();
            this.Output_Box = new FlatUI.FlatTextBox();
            this.Cheat_Ghost = new FlatUI.FlatCheckBox();
            this.Cheat_Noclip = new FlatUI.FlatCheckBox();
            this.Cheat_Xray = new FlatUI.FlatCheckBox();
            this.Cheat_SuperSpeed = new FlatUI.FlatCheckBox();
            this.Cheat_UnlockCosmetics = new FlatUI.FlatButton();
            this.Role_Information = new FlatUI.FlatLabel();
            this.Cheat_DbgMode = new FlatUI.FlatCheckBox();
            this.Skin = new FlatUI.FormSkin();
            this.Skin.SuspendLayout();
            this.Load += Impasta_Load;
            this.SuspendLayout();
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_Btn.BackColor = System.Drawing.Color.White;
            this.Exit_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Exit_Btn.Font = new System.Drawing.Font("Marlett", 10F);
            this.Exit_Btn.Location = new System.Drawing.Point(370, 12);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(18, 18);
            this.Exit_Btn.TabIndex = 0;
            this.Exit_Btn.Text = "Close";
            this.Exit_Btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Output_Box
            // 
            this.Output_Box.BackColor = System.Drawing.Color.Transparent;
            this.Output_Box.Enabled = false;
            this.Output_Box.FocusOnHover = false;
            this.Output_Box.Location = new System.Drawing.Point(12, 196);
            this.Output_Box.MaxLength = 32767;
            this.Output_Box.Multiline = true;
            this.Output_Box.Name = "Output_Box";
            this.Output_Box.ReadOnly = false;
            this.Output_Box.Size = new System.Drawing.Size(376, 52);
            this.Output_Box.TabIndex = 1;
            this.Output_Box.Text = "Waiting for Among Us to open...";
            this.Output_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Output_Box.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Output_Box.UseSystemPasswordChar = false;
            // 
            // Cheat_Ghost
            // 
            this.Cheat_Ghost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Cheat_Ghost.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Cheat_Ghost.BorderColor = System.Drawing.Color.Blue;
            this.Cheat_Ghost.Checked = false;
            this.Cheat_Ghost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cheat_Ghost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cheat_Ghost.Location = new System.Drawing.Point(12, 85);
            this.Cheat_Ghost.Name = "Cheat_Ghost";
            this.Cheat_Ghost.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.Cheat_Ghost.Size = new System.Drawing.Size(112, 22);
            this.Cheat_Ghost.TabIndex = 2;
            this.Cheat_Ghost.Text = "Ghost";
            this.Cheat_Ghost.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.Cheat_Ghost_CheckedChanged);
            // 
            // Cheat_Noclip
            // 
            this.Cheat_Noclip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Cheat_Noclip.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Cheat_Noclip.BorderColor = System.Drawing.Color.Blue;
            this.Cheat_Noclip.Checked = false;
            this.Cheat_Noclip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cheat_Noclip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cheat_Noclip.Location = new System.Drawing.Point(12, 57);
            this.Cheat_Noclip.Name = "Cheat_Noclip";
            this.Cheat_Noclip.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.Cheat_Noclip.Size = new System.Drawing.Size(112, 22);
            this.Cheat_Noclip.TabIndex = 2;
            this.Cheat_Noclip.Text = "No Clip";
            this.Cheat_Noclip.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.Cheat_Noclip_CheckedChanged);
            // 
            // Cheat_Xray
            // 
            this.Cheat_Xray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Cheat_Xray.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Cheat_Xray.BorderColor = System.Drawing.Color.Blue;
            this.Cheat_Xray.Checked = false;
            this.Cheat_Xray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cheat_Xray.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cheat_Xray.Location = new System.Drawing.Point(12, 113);
            this.Cheat_Xray.Name = "Cheat_Xray";
            this.Cheat_Xray.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.Cheat_Xray.Size = new System.Drawing.Size(112, 22);
            this.Cheat_Xray.TabIndex = 3;
            this.Cheat_Xray.Text = "Xray";
            this.Cheat_Xray.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.Cheat_Xray_CheckedChanged);
            // 
            // Cheat_SuperSpeed
            // 
            this.Cheat_SuperSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Cheat_SuperSpeed.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Cheat_SuperSpeed.BorderColor = System.Drawing.Color.Blue;
            this.Cheat_SuperSpeed.Checked = false;
            this.Cheat_SuperSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cheat_SuperSpeed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cheat_SuperSpeed.Location = new System.Drawing.Point(12, 141);
            this.Cheat_SuperSpeed.Name = "Cheat_SuperSpeed";
            this.Cheat_SuperSpeed.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.Cheat_SuperSpeed.Size = new System.Drawing.Size(112, 22);
            this.Cheat_SuperSpeed.TabIndex = 4;
            this.Cheat_SuperSpeed.Text = "Super Speed";
            this.Cheat_SuperSpeed.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.Cheat_SuperSpeed_CheckedChanged);
            // 
            // Cheat_UnlockCosmetics
            // 
            this.Cheat_UnlockCosmetics.BackColor = System.Drawing.Color.Transparent;
            this.Cheat_UnlockCosmetics.BaseColor = System.Drawing.Color.Blue;
            this.Cheat_UnlockCosmetics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cheat_UnlockCosmetics.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Cheat_UnlockCosmetics.Location = new System.Drawing.Point(130, 57);
            this.Cheat_UnlockCosmetics.Name = "Cheat_UnlockCosmetics";
            this.Cheat_UnlockCosmetics.Rounded = false;
            this.Cheat_UnlockCosmetics.Size = new System.Drawing.Size(258, 32);
            this.Cheat_UnlockCosmetics.TabIndex = 6;
            this.Cheat_UnlockCosmetics.Text = "Unlock all Cosmetics";
            this.Cheat_UnlockCosmetics.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Cheat_UnlockCosmetics.Click += new System.EventHandler(this.Cheat_UnlockCosmetics_Click);
            // 
            // Role_Information
            // 
            this.Role_Information.AutoSize = true;
            this.Role_Information.BackColor = System.Drawing.Color.Transparent;
            this.Role_Information.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Role_Information.ForeColor = System.Drawing.Color.White;
            this.Role_Information.Location = new System.Drawing.Point(130, 92);
            this.Role_Information.Name = "Role_Information";
            this.Role_Information.Size = new System.Drawing.Size(257, 52);
            this.Role_Information.TabIndex = 8;
            this.Role_Information.Text = "Role information will appear here on game start!\r\nOnly non-crewmate roles will be" +
    " shown!\r\nIf a player is not listed on there then they\r\nare a crewmate!";
            // 
            // Cheat_DbgMode
            // 
            this.Cheat_DbgMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Cheat_DbgMode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Cheat_DbgMode.BorderColor = System.Drawing.Color.Blue;
            this.Cheat_DbgMode.Checked = false;
            this.Cheat_DbgMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cheat_DbgMode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cheat_DbgMode.Location = new System.Drawing.Point(12, 168);
            this.Cheat_DbgMode.Name = "Cheat_DbgMode";
            this.Cheat_DbgMode.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.Cheat_DbgMode.Size = new System.Drawing.Size(112, 22);
            this.Cheat_DbgMode.TabIndex = 9;
            this.Cheat_DbgMode.Text = "Debug Mode";
            this.Cheat_DbgMode.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.Cheat_DbgMode_CheckedChanged);
            // 
            // Skin
            // 
            this.Skin.BackColor = System.Drawing.Color.Black;
            this.Skin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Skin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.Skin.Controls.Add(this.Cheat_DbgMode);
            this.Skin.Controls.Add(this.Role_Information);
            this.Skin.Controls.Add(this.Cheat_UnlockCosmetics);
            this.Skin.Controls.Add(this.Cheat_SuperSpeed);
            this.Skin.Controls.Add(this.Cheat_Xray);
            this.Skin.Controls.Add(this.Cheat_Noclip);
            this.Skin.Controls.Add(this.Cheat_Ghost);
            this.Skin.Controls.Add(this.Output_Box);
            this.Skin.Controls.Add(this.Exit_Btn);
            this.Skin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skin.FlatColor = System.Drawing.Color.Blue;
            this.Skin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Skin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Skin.HeaderMaximize = false;
            this.Skin.Location = new System.Drawing.Point(0, 0);
            this.Skin.Name = "Skin";
            this.Skin.Size = new System.Drawing.Size(400, 260);
            this.Skin.TabIndex = 0;
            this.Skin.Text = "Impasta";
            // 
            // Impasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.Skin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Impasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impasta";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Skin.ResumeLayout(false);
            this.Skin.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Impasta_Load1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private FlatUI.FlatClose Exit_Btn;
        private FlatUI.FlatTextBox Output_Box;
        private FlatUI.FlatCheckBox Cheat_Ghost;
        private FlatUI.FlatCheckBox Cheat_Noclip;
        private FlatUI.FlatCheckBox Cheat_Xray;
        private FlatUI.FlatCheckBox Cheat_SuperSpeed;
        private FlatUI.FlatButton Cheat_UnlockCosmetics;
        private FlatUI.FlatLabel Role_Information;
        private FlatUI.FlatCheckBox Cheat_DbgMode;
        private FlatUI.FormSkin Skin;
    }
}

