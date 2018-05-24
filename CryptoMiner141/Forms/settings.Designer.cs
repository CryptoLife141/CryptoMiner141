namespace CryptoMiner141
{
    partial class settings
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
            this.btn_CPU = new System.Windows.Forms.Button();
            this.btn_GPU = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CPU
            // 
            this.btn_CPU.Location = new System.Drawing.Point(82, 42);
            this.btn_CPU.Name = "btn_CPU";
            this.btn_CPU.Size = new System.Drawing.Size(104, 78);
            this.btn_CPU.TabIndex = 0;
            this.btn_CPU.Text = "CPU";
            this.btn_CPU.UseVisualStyleBackColor = true;
            this.btn_CPU.Click += new System.EventHandler(this.btn_CPU_Click);
            // 
            // btn_GPU
            // 
            this.btn_GPU.Location = new System.Drawing.Point(234, 42);
            this.btn_GPU.Name = "btn_GPU";
            this.btn_GPU.Size = new System.Drawing.Size(104, 78);
            this.btn_GPU.TabIndex = 1;
            this.btn_GPU.Text = "GPU";
            this.btn_GPU.UseVisualStyleBackColor = true;
            this.btn_GPU.Click += new System.EventHandler(this.btn_GPU_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(375, 149);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 184);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_GPU);
            this.Controls.Add(this.btn_CPU);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CPU;
        private System.Windows.Forms.Button btn_GPU;
        private System.Windows.Forms.Button btn_close;
    }
}