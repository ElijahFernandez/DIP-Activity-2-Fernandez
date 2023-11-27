namespace DigitalImageProcessing
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            loadImageButton = new Button();
            saveImageButton = new Button();
            menuStrip1 = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            loadImageToolStripMenuItem = new ToolStripMenuItem();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            imageProcessingToolsToolStripMenuItem = new ToolStripMenuItem();
            basicCopyToolStripMenuItem = new ToolStripMenuItem();
            grayScalingToolStripMenuItem = new ToolStripMenuItem();
            rotateImageToolStripMenuItem = new ToolStripMenuItem();
            rotateXAndYToolStripMenuItem = new ToolStripMenuItem();
            rotateXToolStripMenuItem = new ToolStripMenuItem();
            rotateYToolStripMenuItem = new ToolStripMenuItem();
            invertColorToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            resultSubtractImage = new PictureBox();
            loadImageB = new Button();
            openFileDialog2 = new OpenFileDialog();
            loadBackground = new Button();
            openFileDialog3 = new OpenFileDialog();
            SubtractButton = new Button();
            pictureBox3 = new PictureBox();
            openCamera = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultSubtractImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 334);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(400, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 334);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // loadImageButton
            // 
            loadImageButton.Location = new Point(12, 367);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(149, 50);
            loadImageButton.TabIndex = 2;
            loadImageButton.Text = "Load Image";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // saveImageButton
            // 
            saveImageButton.Location = new Point(167, 367);
            saveImageButton.Name = "saveImageButton";
            saveImageButton.Size = new Size(149, 50);
            saveImageButton.TabIndex = 3;
            saveImageButton.Text = "Save Image";
            saveImageButton.UseVisualStyleBackColor = true;
            saveImageButton.Click += saveImageButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem, imageProcessingToolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1230, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadImageToolStripMenuItem, saveImageToolStripMenuItem });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(52, 24);
            filesToolStripMenuItem.Text = "Files";
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new Size(171, 26);
            loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(171, 26);
            saveImageToolStripMenuItem.Text = "Save Image";
            // 
            // imageProcessingToolsToolStripMenuItem
            // 
            imageProcessingToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicCopyToolStripMenuItem, grayScalingToolStripMenuItem, rotateImageToolStripMenuItem, invertColorToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem });
            imageProcessingToolsToolStripMenuItem.Name = "imageProcessingToolsToolStripMenuItem";
            imageProcessingToolsToolStripMenuItem.Size = new Size(178, 24);
            imageProcessingToolsToolStripMenuItem.Text = "Image Processing Tools";
            // 
            // basicCopyToolStripMenuItem
            // 
            basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            basicCopyToolStripMenuItem.Size = new Size(182, 26);
            basicCopyToolStripMenuItem.Text = "Basic Copy";
            basicCopyToolStripMenuItem.Click += basicCopyToolStripMenuItem_Click;
            // 
            // grayScalingToolStripMenuItem
            // 
            grayScalingToolStripMenuItem.Name = "grayScalingToolStripMenuItem";
            grayScalingToolStripMenuItem.Size = new Size(182, 26);
            grayScalingToolStripMenuItem.Text = "Gray Scaling";
            grayScalingToolStripMenuItem.Click += grayScalingToolStripMenuItem_Click;
            // 
            // rotateImageToolStripMenuItem
            // 
            rotateImageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rotateXAndYToolStripMenuItem, rotateXToolStripMenuItem, rotateYToolStripMenuItem });
            rotateImageToolStripMenuItem.Name = "rotateImageToolStripMenuItem";
            rotateImageToolStripMenuItem.Size = new Size(182, 26);
            rotateImageToolStripMenuItem.Text = "Rotate Image";
            rotateImageToolStripMenuItem.Click += rotateImageToolStripMenuItem_Click;
            // 
            // rotateXAndYToolStripMenuItem
            // 
            rotateXAndYToolStripMenuItem.Name = "rotateXAndYToolStripMenuItem";
            rotateXAndYToolStripMenuItem.Size = new Size(190, 26);
            rotateXAndYToolStripMenuItem.Text = "Rotate X and Y";
            rotateXAndYToolStripMenuItem.Click += rotateXAndYToolStripMenuItem_Click;
            // 
            // rotateXToolStripMenuItem
            // 
            rotateXToolStripMenuItem.Name = "rotateXToolStripMenuItem";
            rotateXToolStripMenuItem.Size = new Size(190, 26);
            rotateXToolStripMenuItem.Text = "Rotate X";
            rotateXToolStripMenuItem.Click += rotateXToolStripMenuItem_Click;
            // 
            // rotateYToolStripMenuItem
            // 
            rotateYToolStripMenuItem.Name = "rotateYToolStripMenuItem";
            rotateYToolStripMenuItem.Size = new Size(190, 26);
            rotateYToolStripMenuItem.Text = "Rotate Y";
            rotateYToolStripMenuItem.Click += rotateYToolStripMenuItem_Click;
            // 
            // invertColorToolStripMenuItem
            // 
            invertColorToolStripMenuItem.Name = "invertColorToolStripMenuItem";
            invertColorToolStripMenuItem.Size = new Size(182, 26);
            invertColorToolStripMenuItem.Text = "Invert Color";
            invertColorToolStripMenuItem.Click += invertColorToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(182, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(182, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // resultSubtractImage
            // 
            resultSubtractImage.Location = new Point(776, 27);
            resultSubtractImage.Name = "resultSubtractImage";
            resultSubtractImage.Size = new Size(354, 334);
            resultSubtractImage.TabIndex = 7;
            resultSubtractImage.TabStop = false;
            resultSubtractImage.Click += resultSubtractImage_Click;
            // 
            // loadImageB
            // 
            loadImageB.Location = new Point(90, 441);
            loadImageB.Name = "loadImageB";
            loadImageB.Size = new Size(149, 50);
            loadImageB.TabIndex = 8;
            loadImageB.Text = "Load Image";
            loadImageB.UseVisualStyleBackColor = true;
            loadImageB.Click += loadImageB_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // loadBackground
            // 
            loadBackground.Location = new Point(492, 441);
            loadBackground.Name = "loadBackground";
            loadBackground.Size = new Size(149, 50);
            loadBackground.TabIndex = 9;
            loadBackground.Text = "Load Background";
            loadBackground.UseVisualStyleBackColor = true;
            loadBackground.Click += loadBackground_Click;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.FileOk += openFileDialog3_FileOk;
            // 
            // SubtractButton
            // 
            SubtractButton.Location = new Point(882, 441);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(149, 50);
            SubtractButton.TabIndex = 10;
            SubtractButton.Text = "Subtract";
            SubtractButton.UseVisualStyleBackColor = true;
            SubtractButton.Click += SubtractButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(400, 516);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(354, 334);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // openCamera
            // 
            openCamera.Location = new Point(492, 870);
            openCamera.Name = "openCamera";
            openCamera.Size = new Size(149, 50);
            openCamera.TabIndex = 12;
            openCamera.Text = "OpenCamera";
            openCamera.UseVisualStyleBackColor = true;
            openCamera.Click += openCamera_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 991);
            Controls.Add(openCamera);
            Controls.Add(pictureBox3);
            Controls.Add(SubtractButton);
            Controls.Add(loadBackground);
            Controls.Add(loadImageB);
            Controls.Add(resultSubtractImage);
            Controls.Add(saveImageButton);
            Controls.Add(loadImageButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultSubtractImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button loadImageButton;
        private Button saveImageButton;
        private MenuStrip menuStrip1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem imageProcessingToolsToolStripMenuItem;
        private ToolStripMenuItem basicCopyToolStripMenuItem;
        private ToolStripMenuItem grayScalingToolStripMenuItem;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem rotateImageToolStripMenuItem;
        private ToolStripMenuItem rotateXAndYToolStripMenuItem;
        private ToolStripMenuItem rotateXToolStripMenuItem;
        private ToolStripMenuItem rotateYToolStripMenuItem;
        private ToolStripMenuItem invertColorToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private PictureBox resultSubtractImage;
        private Button loadImageB;
        private OpenFileDialog openFileDialog2;
        private Button loadBackground;
        private OpenFileDialog openFileDialog3;
        private Button SubtractButton;
        private PictureBox pictureBox3;
        private Button openCamera;
    }
}