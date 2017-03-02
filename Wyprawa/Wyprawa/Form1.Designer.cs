namespace Wyprawa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sword = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.potionRed = new System.Windows.Forms.PictureBox();
            this.potionBlue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(71, 309);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(50, 50);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sword.TabIndex = 0;
            this.sword.TabStop = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(127, 309);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(50, 50);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bow.TabIndex = 1;
            this.bow.TabStop = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
            this.mace.Location = new System.Drawing.Point(183, 309);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(50, 50);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mace.TabIndex = 2;
            this.mace.TabStop = false;
            // 
            // potionRed
            // 
            this.potionRed.BackColor = System.Drawing.Color.Transparent;
            this.potionRed.Image = ((System.Drawing.Image)(resources.GetObject("potionRed.Image")));
            this.potionRed.Location = new System.Drawing.Point(239, 309);
            this.potionRed.Name = "potionRed";
            this.potionRed.Size = new System.Drawing.Size(50, 50);
            this.potionRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.potionRed.TabIndex = 3;
            this.potionRed.TabStop = false;
            // 
            // potionBlue
            // 
            this.potionBlue.BackColor = System.Drawing.Color.Transparent;
            this.potionBlue.Image = ((System.Drawing.Image)(resources.GetObject("potionBlue.Image")));
            this.potionBlue.Location = new System.Drawing.Point(295, 309);
            this.potionBlue.Name = "potionBlue";
            this.potionBlue.Size = new System.Drawing.Size(50, 50);
            this.potionBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.potionBlue.TabIndex = 4;
            this.potionBlue.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 401);
            this.Controls.Add(this.potionBlue);
            this.Controls.Add(this.potionRed);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.sword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Wyprawa";
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox potionRed;
        private System.Windows.Forms.PictureBox potionBlue;
    }
}

