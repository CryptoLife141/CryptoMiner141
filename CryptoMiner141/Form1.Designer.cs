namespace CryptoMiner141
{
    partial class Form1
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
            this.btn_startMining = new System.Windows.Forms.Button();
            this.btn_stopMining = new System.Windows.Forms.Button();
            this.checkedListBoxMiner = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_startMining
            // 
            this.btn_startMining.Location = new System.Drawing.Point(633, 72);
            this.btn_startMining.Name = "btn_startMining";
            this.btn_startMining.Size = new System.Drawing.Size(75, 23);
            this.btn_startMining.TabIndex = 0;
            this.btn_startMining.Text = "Start";
            this.btn_startMining.UseVisualStyleBackColor = true;
            this.btn_startMining.Click += new System.EventHandler(this.btn_startMining_Click);
            // 
            // btn_stopMining
            // 
            this.btn_stopMining.Location = new System.Drawing.Point(633, 197);
            this.btn_stopMining.Name = "btn_stopMining";
            this.btn_stopMining.Size = new System.Drawing.Size(75, 23);
            this.btn_stopMining.TabIndex = 1;
            this.btn_stopMining.Text = "Stop";
            this.btn_stopMining.UseVisualStyleBackColor = true;
            this.btn_stopMining.Click += new System.EventHandler(this.btn_stopMining_Click);
            // 
            // checkedListBoxMiner
            // 
            this.checkedListBoxMiner.CheckOnClick = true;
            this.checkedListBoxMiner.FormattingEnabled = true;
            this.checkedListBoxMiner.Items.AddRange(new object[] {
            "CPU Mining",
            "GPU Mining"});
            this.checkedListBoxMiner.Location = new System.Drawing.Point(60, 72);
            this.checkedListBoxMiner.Name = "checkedListBoxMiner";
            this.checkedListBoxMiner.Size = new System.Drawing.Size(412, 244);
            this.checkedListBoxMiner.TabIndex = 2;
            this.checkedListBoxMiner.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxMiner_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxMiner);
            this.Controls.Add(this.btn_stopMining);
            this.Controls.Add(this.btn_startMining);
            this.Name = "Form1";
            this.Text = "FMCryptoMiner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_startMining;
        private System.Windows.Forms.Button btn_stopMining;
        private System.Windows.Forms.CheckedListBox checkedListBoxMiner;
    }
}

