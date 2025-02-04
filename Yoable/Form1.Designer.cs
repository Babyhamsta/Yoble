﻿namespace Yoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            ImportDirectoryToolStrip = new ToolStripMenuItem();
            ImportImageToolStrip = new ToolStripMenuItem();
            YOLOLabelImportToolStrip = new ToolStripMenuItem();
            ExportLabelsToolStrip = new ToolStripMenuItem();
            AIDropdownButton = new ToolStripDropDownButton();
            AutoLabelImagesToolStrip = new ToolStripMenuItem();
            AutoSuggestLabelsToolStrip = new ToolStripMenuItem();
            AISettingsToolStrip = new ToolStripMenuItem();
            UISettingsDropdown = new ToolStripDropDownButton();
            DarkThemeToolStrip = new ToolStripMenuItem();
            AboutUsToolStrip = new ToolStripLabel();
            MainPanel = new Panel();
            LoadedImage = new PictureBox();
            LabelListBox = new ListBox();
            ImageListBox = new ListBox();
            ClearAllToolStrip = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoadedImage).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, AIDropdownButton, UISettingsDropdown, AboutUsToolStrip });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1050, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { ImportDirectoryToolStrip, ImportImageToolStrip, YOLOLabelImportToolStrip, ExportLabelsToolStrip, ClearAllToolStrip });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(38, 22);
            toolStripDropDownButton1.Text = "File";
            toolStripDropDownButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // ImportDirectoryToolStrip
            // 
            ImportDirectoryToolStrip.BackColor = SystemColors.Control;
            ImportDirectoryToolStrip.Name = "ImportDirectoryToolStrip";
            ImportDirectoryToolStrip.Size = new Size(180, 22);
            ImportDirectoryToolStrip.Text = "Import Directory";
            ImportDirectoryToolStrip.Click += ImportDirectoryToolStrip_Click;
            // 
            // ImportImageToolStrip
            // 
            ImportImageToolStrip.Name = "ImportImageToolStrip";
            ImportImageToolStrip.Size = new Size(180, 22);
            ImportImageToolStrip.Text = "Import Image";
            ImportImageToolStrip.Click += ImportImageToolStrip_Click;
            // 
            // YOLOLabelImportToolStrip
            // 
            YOLOLabelImportToolStrip.Name = "YOLOLabelImportToolStrip";
            YOLOLabelImportToolStrip.Size = new Size(180, 22);
            YOLOLabelImportToolStrip.Text = "Import YOLO Labels";
            YOLOLabelImportToolStrip.Click += YOLOLabelImportToolStrip_Click;
            // 
            // ExportLabelsToolStrip
            // 
            ExportLabelsToolStrip.Name = "ExportLabelsToolStrip";
            ExportLabelsToolStrip.Size = new Size(180, 22);
            ExportLabelsToolStrip.Text = "Export Labels";
            ExportLabelsToolStrip.Click += ExportLabelsToolStrip_Click;
            // 
            // AIDropdownButton
            // 
            AIDropdownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AIDropdownButton.DropDownItems.AddRange(new ToolStripItem[] { AutoLabelImagesToolStrip, AutoSuggestLabelsToolStrip, AISettingsToolStrip });
            AIDropdownButton.Image = (Image)resources.GetObject("AIDropdownButton.Image");
            AIDropdownButton.ImageTransparentColor = Color.Magenta;
            AIDropdownButton.Name = "AIDropdownButton";
            AIDropdownButton.Size = new Size(31, 22);
            AIDropdownButton.Text = "AI";
            AIDropdownButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // AutoLabelImagesToolStrip
            // 
            AutoLabelImagesToolStrip.Name = "AutoLabelImagesToolStrip";
            AutoLabelImagesToolStrip.Size = new Size(181, 22);
            AutoLabelImagesToolStrip.Text = "Auto Label Images";
            AutoLabelImagesToolStrip.Click += AutoLabelImagesToolStrip_Click;
            // 
            // AutoSuggestLabelsToolStrip
            // 
            AutoSuggestLabelsToolStrip.Name = "AutoSuggestLabelsToolStrip";
            AutoSuggestLabelsToolStrip.Size = new Size(181, 22);
            AutoSuggestLabelsToolStrip.Text = "Auto Suggest Labels";
            AutoSuggestLabelsToolStrip.Click += AutoSuggestLabelsToolStrip_Click;
            // 
            // AISettingsToolStrip
            // 
            AISettingsToolStrip.Name = "AISettingsToolStrip";
            AISettingsToolStrip.Size = new Size(181, 22);
            AISettingsToolStrip.Text = "AI Settings";
            AISettingsToolStrip.Click += AISettingsToolStrip_Click;
            // 
            // UISettingsDropdown
            // 
            UISettingsDropdown.DisplayStyle = ToolStripItemDisplayStyle.Text;
            UISettingsDropdown.DropDownItems.AddRange(new ToolStripItem[] { DarkThemeToolStrip });
            UISettingsDropdown.Image = (Image)resources.GetObject("UISettingsDropdown.Image");
            UISettingsDropdown.ImageTransparentColor = Color.Magenta;
            UISettingsDropdown.Name = "UISettingsDropdown";
            UISettingsDropdown.Size = new Size(76, 22);
            UISettingsDropdown.Text = "UI Settings";
            // 
            // DarkThemeToolStrip
            // 
            DarkThemeToolStrip.Name = "DarkThemeToolStrip";
            DarkThemeToolStrip.Size = new Size(137, 22);
            DarkThemeToolStrip.Text = "Dark Theme";
            DarkThemeToolStrip.Click += DarkThemeToolStrip_Click;
            // 
            // AboutUsToolStrip
            // 
            AboutUsToolStrip.Name = "AboutUsToolStrip";
            AboutUsToolStrip.Size = new Size(40, 22);
            AboutUsToolStrip.Text = "About";
            AboutUsToolStrip.Click += AboutUsToolStrip_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(LoadedImage);
            MainPanel.Controls.Add(LabelListBox);
            MainPanel.Controls.Add(ImageListBox);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 25);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1050, 650);
            MainPanel.TabIndex = 1;
            // 
            // LoadedImage
            // 
            LoadedImage.Dock = DockStyle.Fill;
            LoadedImage.Location = new Point(205, 0);
            LoadedImage.Name = "LoadedImage";
            LoadedImage.Size = new Size(640, 650);
            LoadedImage.TabIndex = 0;
            LoadedImage.TabStop = false;
            LoadedImage.Paint += PictureBox_Paint;
            LoadedImage.MouseDown += PictureBox_MouseDown;
            LoadedImage.MouseMove += PictureBox_MouseMove;
            LoadedImage.MouseUp += PictureBox_MouseUp;
            // 
            // LabelListBox
            // 
            LabelListBox.Dock = DockStyle.Right;
            LabelListBox.FormattingEnabled = true;
            LabelListBox.ItemHeight = 15;
            LabelListBox.Location = new Point(845, 0);
            LabelListBox.Name = "LabelListBox";
            LabelListBox.Size = new Size(205, 650);
            LabelListBox.TabIndex = 2;
            LabelListBox.SelectedIndexChanged += LabelListBox_SelectedIndexChanged;
            // 
            // ImageListBox
            // 
            ImageListBox.Dock = DockStyle.Left;
            ImageListBox.FormattingEnabled = true;
            ImageListBox.ItemHeight = 15;
            ImageListBox.Location = new Point(0, 0);
            ImageListBox.Name = "ImageListBox";
            ImageListBox.Size = new Size(205, 650);
            ImageListBox.TabIndex = 1;
            ImageListBox.SelectedIndexChanged += ImageListBox_SelectedIndexChanged;
            // 
            // ClearAllToolStrip
            // 
            ClearAllToolStrip.Name = "ClearAllToolStrip";
            ClearAllToolStrip.Size = new Size(180, 22);
            ClearAllToolStrip.Text = "Clear All";
            ClearAllToolStrip.Click += ClearAllToolStrip_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 675);
            Controls.Add(MainPanel);
            Controls.Add(toolStrip1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yoable";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoadedImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private Panel MainPanel;
        private ListBox ImageListBox;
        private PictureBox LoadedImage;
        private ListBox LabelListBox;
        private ToolStripMenuItem ImportDirectoryToolStrip;
        private ToolStripMenuItem ImportImageToolStrip;
        private ToolStripMenuItem ExportLabelsToolStrip;
        private ToolStripDropDownButton AIDropdownButton;
        private ToolStripMenuItem AutoLabelImagesToolStrip;
        private ToolStripMenuItem AutoSuggestLabelsToolStrip;
        private ToolStripLabel AboutUsToolStrip;
        private ToolStripMenuItem AISettingsToolStrip;
        private ToolStripDropDownButton UISettingsDropdown;
        private ToolStripMenuItem DarkThemeToolStrip;
        private ToolStripMenuItem YOLOLabelImportToolStrip;
        private ToolStripMenuItem ClearAllToolStrip;
    }
}
