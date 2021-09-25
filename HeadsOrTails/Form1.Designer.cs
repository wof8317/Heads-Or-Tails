
namespace HeadsOrTails
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
            this.picCoins = new System.Windows.Forms.PictureBox();
            this.btnShowHeads = new System.Windows.Forms.Button();
            this.btnShowTails = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // picCoins
            // 
            this.picCoins.Image = global::HeadsOrTails.Properties.Resources._10cents;
            this.picCoins.Location = new System.Drawing.Point(261, 31);
            this.picCoins.Name = "picCoins";
            this.picCoins.Size = new System.Drawing.Size(260, 245);
            this.picCoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoins.TabIndex = 0;
            this.picCoins.TabStop = false;
            // 
            // btnShowHeads
            // 
            this.btnShowHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHeads.Location = new System.Drawing.Point(71, 348);
            this.btnShowHeads.Name = "btnShowHeads";
            this.btnShowHeads.Size = new System.Drawing.Size(126, 46);
            this.btnShowHeads.TabIndex = 1;
            this.btnShowHeads.Text = "Show Heads";
            this.btnShowHeads.UseVisualStyleBackColor = true;
            this.btnShowHeads.Click += new System.EventHandler(this.btnShowHeads_Click);
            // 
            // btnShowTails
            // 
            this.btnShowTails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTails.Location = new System.Drawing.Point(342, 348);
            this.btnShowTails.Name = "btnShowTails";
            this.btnShowTails.Size = new System.Drawing.Size(110, 46);
            this.btnShowTails.TabIndex = 2;
            this.btnShowTails.Text = "Show Tails";
            this.btnShowTails.UseVisualStyleBackColor = true;
            this.btnShowTails.Click += new System.EventHandler(this.btnShowTails_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(605, 348);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 46);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.btnShowTails);
            this.Controls.Add(this.btnShowHeads);
            this.Controls.Add(this.picCoins);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.picCoins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCoins;
        private System.Windows.Forms.Button btnShowHeads;
        private System.Windows.Forms.Button btnShowTails;
        private System.Windows.Forms.Button Reset;
    }
}

