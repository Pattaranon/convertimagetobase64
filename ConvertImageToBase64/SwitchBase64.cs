using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertImageToBase64
{
    public partial class SwitchBase64 : Form
    {
        public SwitchBase64()
        {
            InitializeComponent();
        }

        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width
            int sourceWidth = imgToResize.Width;
            //Get the image current height
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fdlg = new OpenFileDialog())
            {
                fdlg.Title = "Convert ImageToString Open File Dialog";
                fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                fdlg.FilterIndex = 2;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtImagePath.Text = fdlg.FileName;
                }
            }
        }

        private void btnConvertToString_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                using (Image image = Image.FromFile(this.txtImagePath.Text.Trim()))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();

                        // Convert byte[] to Base64 String
                        this.txtImageString.Text = Convert.ToBase64String(imageBytes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnConvertToImage_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!string.IsNullOrEmpty(this.txtImageString.Text.Trim()))
                {
                    // Convert Base64 String to byte[]
                    byte[] imageBytes = Convert.FromBase64String(this.txtImageString.Text.Trim());
                    // Convert byte[] to Image
                    using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                    {
                        Image image = Image.FromStream(ms, true);
                        picImageDisplay.Image = image;
                        picImageDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("ไม่มีไฟล์ให้ Convert");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void txtImageString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtImageString.SelectAll();
            }
        }
    }
}
