
namespace _2_task
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            FlipnSave = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            listBox1 = new ListBox();
            Flip = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.MidnightBlue;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += SelectImg;
            // 
            // FlipnSave
            // 
            FlipnSave.BackColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(FlipnSave, "FlipnSave");
            FlipnSave.ForeColor = SystemColors.MenuText;
            FlipnSave.Name = "FlipnSave";
            FlipnSave.UseVisualStyleBackColor = false;
            FlipnSave.Click += SaveImg;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.FormattingEnabled = true;
            listBox1.Name = "listBox1";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Flip
            // 
            Flip.BackColor = SystemColors.WindowText;
            resources.ApplyResources(Flip, "Flip");
            Flip.ForeColor = SystemColors.ButtonHighlight;
            Flip.Name = "Flip";
            Flip.UseVisualStyleBackColor = false;
            Flip.Click += FlipImg;
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            Controls.Add(Flip);
            Controls.Add(listBox1);
            Controls.Add(FlipnSave);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Help;
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }


        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button FlipnSave;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox listBox1;
        private Button Flip;
    }
}
