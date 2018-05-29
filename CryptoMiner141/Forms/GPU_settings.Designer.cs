namespace CryptoMiner141.Forms
{
    partial class GPU_settings
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
            this.btn_saveConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_urlPool = new System.Windows.Forms.TextBox();
            this.cb_crypto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_saveConfig
            // 
            this.btn_saveConfig.Location = new System.Drawing.Point(15, 206);
            this.btn_saveConfig.Name = "btn_saveConfig";
            this.btn_saveConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_saveConfig.TabIndex = 20;
            this.btn_saveConfig.Text = "Save config";
            this.btn_saveConfig.UseVisualStyleBackColor = true;
            this.btn_saveConfig.Click += new System.EventHandler(this.btn_saveConfig_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password for this user, depend of pool.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Username for the pool (worker name or public address for payment) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter pool address with the port, Ex: gulf.moneroocean.stream:10001 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Choose your cryptocurrencie";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(705, 206);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(15, 136);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(765, 20);
            this.tb_password.TabIndex = 14;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(15, 97);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(765, 20);
            this.tb_username.TabIndex = 13;
            // 
            // tb_urlPool
            // 
            this.tb_urlPool.Location = new System.Drawing.Point(248, 32);
            this.tb_urlPool.Name = "tb_urlPool";
            this.tb_urlPool.Size = new System.Drawing.Size(532, 20);
            this.tb_urlPool.TabIndex = 12;
            // 
            // cb_crypto
            // 
            this.cb_crypto.FormattingEnabled = true;
            this.cb_crypto.Items.AddRange(new object[] {
            "VTC (Vertcoin) - lyra2v2",
            "TZC (Trezarcoin) - neoscrypt",
            "BTCP (Bitcoin Private) - equihash"});
            this.cb_crypto.Location = new System.Drawing.Point(15, 31);
            this.cb_crypto.Name = "cb_crypto";
            this.cb_crypto.Size = new System.Drawing.Size(227, 21);
            this.cb_crypto.TabIndex = 11;
            this.cb_crypto.SelectedIndexChanged += new System.EventHandler(this.cb_crypto_SelectedIndexChanged);
            // 
            // GPU_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.btn_saveConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_urlPool);
            this.Controls.Add(this.cb_crypto);
            this.Name = "GPU_settings";
            this.Text = "GPU_settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_urlPool;
        private System.Windows.Forms.ComboBox cb_crypto;
    }
}