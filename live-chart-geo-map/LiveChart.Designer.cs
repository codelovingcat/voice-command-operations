namespace live_chart_geo_map
{
    partial class LiveChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiveChart));
            this.btnTurkey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTurkey
            // 
            this.btnTurkey.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTurkey.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurkey.ForeColor = System.Drawing.Color.White;
            this.btnTurkey.Location = new System.Drawing.Point(12, 460);
            this.btnTurkey.Name = "btnTurkey";
            this.btnTurkey.Size = new System.Drawing.Size(155, 49);
            this.btnTurkey.TabIndex = 0;
            this.btnTurkey.Text = "Türkiye Haritası";
            this.btnTurkey.UseVisualStyleBackColor = false;
            this.btnTurkey.Click += new System.EventHandler(this.btnTurkey_Click);
            // 
            // LiveChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 521);
            this.Controls.Add(this.btnTurkey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LiveChart";
            this.Text = "Live Chart Geo Map ile Dünya Haritas";
            this.Load += new System.EventHandler(this.LiveChart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTurkey;
    }
}

