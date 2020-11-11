namespace voice_command
{
    partial class Audio
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
            this.btnSpeak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswear = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSpeak.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpeak.Location = new System.Drawing.Point(76, 48);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(556, 109);
            this.btnSpeak.TabIndex = 0;
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.TextChanged += new System.EventHandler(this.btnSpeak_TextChanged);
            this.btnSpeak.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Önce butona tıklayın sonra konuşun";
            // 
            // lblAnswear
            // 
            this.lblAnswear.AutoSize = true;
            this.lblAnswear.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnswear.Location = new System.Drawing.Point(295, 171);
            this.lblAnswear.Name = "lblAnswear";
            this.lblAnswear.Size = new System.Drawing.Size(119, 26);
            this.lblAnswear.TabIndex = 2;
            this.lblAnswear.Text = "Dinliyorum...";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 206);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(689, 313);
            this.webBrowser1.TabIndex = 3;
            // 
            // Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 525);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lblAnswear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpeak);
            this.Name = "Audio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswear;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

