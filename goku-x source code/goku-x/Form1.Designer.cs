namespace goku_x
{
    partial class gokux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gokux));
            this.executeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBoxScript = new System.Windows.Forms.RichTextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // executeButton
            // 
            this.executeButton.Image = global::goku_x.Properties.Resources.R__1_;
            this.executeButton.Location = new System.Drawing.Point(13, 152);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 32);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "execuate!1";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // button2
            // 
            this.button2.Image = global::goku_x.Properties.Resources.R__2___1_;
            this.button2.Location = new System.Drawing.Point(94, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "clere";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::goku_x.Properties.Resources.R__2___3_;
            this.button3.Location = new System.Drawing.Point(181, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "injjject";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBoxScript
            // 
            this.richTextBoxScript.Location = new System.Drawing.Point(13, 36);
            this.richTextBoxScript.Name = "richTextBoxScript";
            this.richTextBoxScript.Size = new System.Drawing.Size(249, 96);
            this.richTextBoxScript.TabIndex = 5;
            this.richTextBoxScript.Text = "";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "label1";
            // 
            // gokux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::goku_x.Properties.Resources.e4f7d249_61ce_49e4_9d3c_79af70530b54;
            this.ClientSize = new System.Drawing.Size(439, 196);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.richTextBoxScript);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.executeButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gokux";
            this.Text = "goku-x";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBoxScript;
        private System.Windows.Forms.Label statusLabel;
    }
}

