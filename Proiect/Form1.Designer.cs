
namespace Proiect
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
            this.buttonGrayScale = new System.Windows.Forms.Button();
            this.grayPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxChoose = new System.Windows.Forms.PictureBox();
            this.pictureBoxContrast = new System.Windows.Forms.PictureBox();
            this.Contrast = new System.Windows.Forms.Button();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.textBoxContrast1 = new System.Windows.Forms.TextBox();
            this.pictureBoxGamma = new System.Windows.Forms.PictureBox();
            this.buttonGamma = new System.Windows.Forms.Button();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.buttonRed = new System.Windows.Forms.Button();
            this.pictureBoxScale = new System.Windows.Forms.PictureBox();
            this.buttonScale = new System.Windows.Forms.Button();
            this.pictureBoxRotate = new System.Windows.Forms.PictureBox();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.pictureBoxROI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxROI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGrayScale
            // 
            this.buttonGrayScale.Location = new System.Drawing.Point(173, 129);
            this.buttonGrayScale.Name = "buttonGrayScale";
            this.buttonGrayScale.Size = new System.Drawing.Size(75, 23);
            this.buttonGrayScale.TabIndex = 0;
            this.buttonGrayScale.Text = "Gray Scale";
            this.buttonGrayScale.UseVisualStyleBackColor = true;
            this.buttonGrayScale.Click += new System.EventHandler(this.buttonGrayScale_Click);
            // 
            // grayPictureBox
            // 
            this.grayPictureBox.Location = new System.Drawing.Point(151, 12);
            this.grayPictureBox.Name = "grayPictureBox";
            this.grayPictureBox.Size = new System.Drawing.Size(112, 111);
            this.grayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grayPictureBox.TabIndex = 1;
            this.grayPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ChooseImg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.choosePicture_Click);
            // 
            // pictureBoxChoose
            // 
            this.pictureBoxChoose.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxChoose.Name = "pictureBoxChoose";
            this.pictureBoxChoose.Size = new System.Drawing.Size(112, 111);
            this.pictureBoxChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChoose.TabIndex = 3;
            this.pictureBoxChoose.TabStop = false;
            // 
            // pictureBoxContrast
            // 
            this.pictureBoxContrast.Location = new System.Drawing.Point(290, 12);
            this.pictureBoxContrast.Name = "pictureBoxContrast";
            this.pictureBoxContrast.Size = new System.Drawing.Size(112, 111);
            this.pictureBoxContrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxContrast.TabIndex = 4;
            this.pictureBoxContrast.TabStop = false;
            // 
            // Contrast
            // 
            this.Contrast.Location = new System.Drawing.Point(310, 129);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(75, 23);
            this.Contrast.TabIndex = 5;
            this.Contrast.Text = "Contrast";
            this.Contrast.UseVisualStyleBackColor = true;
            this.Contrast.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Location = new System.Drawing.Point(408, 12);
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrast.TabIndex = 6;
            // 
            // textBoxContrast1
            // 
            this.textBoxContrast1.Location = new System.Drawing.Point(408, 38);
            this.textBoxContrast1.Name = "textBoxContrast1";
            this.textBoxContrast1.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrast1.TabIndex = 7;
            // 
            // pictureBoxGamma
            // 
            this.pictureBoxGamma.Location = new System.Drawing.Point(514, 12);
            this.pictureBoxGamma.Name = "pictureBoxGamma";
            this.pictureBoxGamma.Size = new System.Drawing.Size(112, 111);
            this.pictureBoxGamma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGamma.TabIndex = 8;
            this.pictureBoxGamma.TabStop = false;
            // 
            // buttonGamma
            // 
            this.buttonGamma.Location = new System.Drawing.Point(531, 129);
            this.buttonGamma.Name = "buttonGamma";
            this.buttonGamma.Size = new System.Drawing.Size(75, 23);
            this.buttonGamma.TabIndex = 9;
            this.buttonGamma.Text = "Gamma";
            this.buttonGamma.UseVisualStyleBackColor = true;
            this.buttonGamma.Click += new System.EventHandler(this.buttonGamma_Click);
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(632, 12);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(100, 20);
            this.textBoxGamma.TabIndex = 10;
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.Location = new System.Drawing.Point(12, 158);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(112, 111);
            this.pictureBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRed.TabIndex = 11;
            this.pictureBoxRed.TabStop = false;
            // 
            // buttonRed
            // 
            this.buttonRed.Location = new System.Drawing.Point(30, 275);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(75, 23);
            this.buttonRed.TabIndex = 12;
            this.buttonRed.Text = "Red Filter";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // pictureBoxScale
            // 
            this.pictureBoxScale.Location = new System.Drawing.Point(151, 158);
            this.pictureBoxScale.Name = "pictureBoxScale";
            this.pictureBoxScale.Size = new System.Drawing.Size(112, 111);
            this.pictureBoxScale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxScale.TabIndex = 13;
            this.pictureBoxScale.TabStop = false;
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(173, 275);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(75, 23);
            this.buttonScale.TabIndex = 14;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // pictureBoxRotate
            // 
            this.pictureBoxRotate.Location = new System.Drawing.Point(290, 158);
            this.pictureBoxRotate.Name = "pictureBoxRotate";
            this.pictureBoxRotate.Size = new System.Drawing.Size(112, 111);
            this.pictureBoxRotate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRotate.TabIndex = 15;
            this.pictureBoxRotate.TabStop = false;
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(310, 275);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(75, 23);
            this.buttonRotate.TabIndex = 16;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // pictureBoxROI
            // 
            this.pictureBoxROI.Location = new System.Drawing.Point(408, 158);
            this.pictureBoxROI.Name = "pictureBoxROI";
            this.pictureBoxROI.Size = new System.Drawing.Size(218, 208);
            this.pictureBoxROI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxROI.TabIndex = 17;
            this.pictureBoxROI.TabStop = false;
            this.pictureBoxROI.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxROI_Paint);
            this.pictureBoxROI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxROI_MouseDown);
            this.pictureBoxROI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxROI_MouseMove);
            this.pictureBoxROI.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxROI_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxROI);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.pictureBoxRotate);
            this.Controls.Add(this.buttonScale);
            this.Controls.Add(this.pictureBoxScale);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.pictureBoxRed);
            this.Controls.Add(this.textBoxGamma);
            this.Controls.Add(this.buttonGamma);
            this.Controls.Add(this.pictureBoxGamma);
            this.Controls.Add(this.textBoxContrast1);
            this.Controls.Add(this.textBoxContrast);
            this.Controls.Add(this.Contrast);
            this.Controls.Add(this.pictureBoxContrast);
            this.Controls.Add(this.pictureBoxChoose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grayPictureBox);
            this.Controls.Add(this.buttonGrayScale);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxROI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGrayScale;
        private System.Windows.Forms.PictureBox grayPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxChoose;
        private System.Windows.Forms.PictureBox pictureBoxContrast;
        private System.Windows.Forms.Button Contrast;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.TextBox textBoxContrast1;
        private System.Windows.Forms.PictureBox pictureBoxGamma;
        private System.Windows.Forms.Button buttonGamma;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.PictureBox pictureBoxScale;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.PictureBox pictureBoxRotate;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.PictureBox pictureBoxROI;
    }
}

