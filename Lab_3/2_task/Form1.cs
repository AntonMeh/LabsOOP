using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace _2_task
{
    public partial class Form : System.Windows.Forms.Form
    {
        Bitmap img ;
        string imgPath;
        public Form() => InitializeComponent();

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void SelectImg(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            Regex regexExtForImage = new Regex(@"\.(bmp|gif|tiff?|jpe?g|png)$", RegexOptions.IgnoreCase);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
                string[] files = Directory.GetFiles(folder);

                foreach (string file in files)
                {
                    if (regexExtForImage.IsMatch(file))
                    {
                        listBox1.Items.Add(file);
                    }
                }
            }

        }
        private void FlipImg(object sender, EventArgs e)
        {

            try
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Image = img;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Image wasn't selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }


        private void SaveImg(object sender, EventArgs e)
        {

            try
            {
                string directory = Path.GetDirectoryName(imgPath);
                string fileName = Path.GetFileNameWithoutExtension(imgPath);
                string saveImgPath = Path.Combine(directory, fileName);

                img.Save($"{saveImgPath} - mirrored.gif");

                MessageBox.Show("File saved","Succes",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Image wasn't selected or the file path is corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ExternalException)
            {
                MessageBox.Show($"Image couldn`t be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            imgPath = listBox1.SelectedItem.ToString();

            try
            {
                img = new Bitmap(imgPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = img;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No item selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't open image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
