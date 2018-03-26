namespace ImageProcessingInit
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.grayImage = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gray Scale";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // originalImage
            // 
            this.originalImage.Location = new System.Drawing.Point(45, 61);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(334, 189);
            this.originalImage.TabIndex = 2;
            this.originalImage.TabStop = false;
            // 
            // grayImage
            // 
            this.grayImage.Location = new System.Drawing.Point(432, 61);
            this.grayImage.Name = "grayImage";
            this.grayImage.Size = new System.Drawing.Size(334, 189);
            this.grayImage.TabIndex = 3;
            this.grayImage.TabStop = false;
            this.grayImage.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(906, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 77);
            this.button3.TabIndex = 4;
            this.button3.Text = "Hex Conversion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grayImage);
            this.Controls.Add(this.originalImage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.PictureBox grayImage;
        private System.Windows.Forms.Button button3;
    }
}

