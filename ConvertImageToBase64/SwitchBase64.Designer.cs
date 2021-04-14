namespace ConvertImageToBase64
{
    partial class SwitchBase64
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
            this.picImageDisplay = new System.Windows.Forms.PictureBox();
            this.btnConvertToImage = new System.Windows.Forms.Button();
            this.btnConvertToString = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageString = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageDisplay
            // 
            this.picImageDisplay.Location = new System.Drawing.Point(98, 228);
            this.picImageDisplay.Name = "picImageDisplay";
            this.picImageDisplay.Size = new System.Drawing.Size(221, 145);
            this.picImageDisplay.TabIndex = 15;
            this.picImageDisplay.TabStop = false;
            // 
            // btnConvertToImage
            // 
            this.btnConvertToImage.Location = new System.Drawing.Point(98, 186);
            this.btnConvertToImage.Name = "btnConvertToImage";
            this.btnConvertToImage.Size = new System.Drawing.Size(145, 23);
            this.btnConvertToImage.TabIndex = 14;
            this.btnConvertToImage.Text = "Convert StringToImage";
            this.btnConvertToImage.UseVisualStyleBackColor = true;
            this.btnConvertToImage.Click += new System.EventHandler(this.btnConvertToImage_Click);
            // 
            // btnConvertToString
            // 
            this.btnConvertToString.Location = new System.Drawing.Point(98, 64);
            this.btnConvertToString.Name = "btnConvertToString";
            this.btnConvertToString.Size = new System.Drawing.Size(145, 23);
            this.btnConvertToString.TabIndex = 13;
            this.btnConvertToString.Text = "Convert ImageToString";
            this.btnConvertToString.UseVisualStyleBackColor = true;
            this.btnConvertToString.Click += new System.EventHandler(this.btnConvertToString_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Image String :";
            // 
            // txtImageString
            // 
            this.txtImageString.Location = new System.Drawing.Point(98, 93);
            this.txtImageString.Multiline = true;
            this.txtImageString.Name = "txtImageString";
            this.txtImageString.Size = new System.Drawing.Size(274, 87);
            this.txtImageString.TabIndex = 11;
            this.txtImageString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImageString_KeyDown);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(297, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Image Path :";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(98, 24);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(180, 20);
            this.txtImagePath.TabIndex = 8;
            // 
            // SwitchBase64
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 390);
            this.Controls.Add(this.picImageDisplay);
            this.Controls.Add(this.btnConvertToImage);
            this.Controls.Add(this.btnConvertToString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImageString);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImagePath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SwitchBase64";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwitchBase64";
            ((System.ComponentModel.ISupportInitialize)(this.picImageDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageDisplay;
        private System.Windows.Forms.Button btnConvertToImage;
        private System.Windows.Forms.Button btnConvertToString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImageString;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImagePath;
    }
}