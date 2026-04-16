namespace GraphicsExample
{
    partial class GraphicsExampleForm
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
            components = new System.ComponentModel.Container();
            DisplayPictureBox = new PictureBox();
            DisplayContextMenuStrip = new ContextMenuStrip(components);
            DrawContextpMenuItem = new ToolStripMenuItem();
            ClearContextMenuItem = new ToolStripMenuItem();
            ColorContextMenuItem = new ToolStripMenuItem();
            PenContextMenuItem = new ToolStripMenuItem();
            BackGroundContextMenuItem = new ToolStripMenuItem();
            PenSizeContextMenuItem = new ToolStripMenuItem();
            PenSizeComboBox = new ToolStripComboBox();
            DrawButton = new Button();
            ExitButton = new Button();
            PenColorDialog = new ColorDialog();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            DrawTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutTopMenuItem = new ToolStripMenuItem();
            ClearButton = new Button();
            BottomStatusStrip = new StatusStrip();
            DrawingStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            DisplayContextMenuStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            BottomStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ActiveCaption;
            DisplayPictureBox.ContextMenuStrip = DisplayContextMenuStrip;
            DisplayPictureBox.Location = new Point(13, 54);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(1724, 588);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // DisplayContextMenuStrip
            // 
            DisplayContextMenuStrip.ImageScalingSize = new Size(24, 24);
            DisplayContextMenuStrip.Items.AddRange(new ToolStripItem[] { DrawContextpMenuItem, ClearContextMenuItem, ColorContextMenuItem, PenSizeContextMenuItem });
            DisplayContextMenuStrip.Name = "contextMenuStrip1";
            DisplayContextMenuStrip.Size = new Size(149, 132);
            // 
            // DrawContextpMenuItem
            // 
            DrawContextpMenuItem.Name = "DrawContextpMenuItem";
            DrawContextpMenuItem.Size = new Size(148, 32);
            DrawContextpMenuItem.Text = "Draw";
            // 
            // ClearContextMenuItem
            // 
            ClearContextMenuItem.Name = "ClearContextMenuItem";
            ClearContextMenuItem.Size = new Size(148, 32);
            ClearContextMenuItem.Text = "Clear";
            ClearContextMenuItem.Click += ClearButton_Click;
            // 
            // ColorContextMenuItem
            // 
            ColorContextMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PenContextMenuItem, BackGroundContextMenuItem });
            ColorContextMenuItem.Name = "ColorContextMenuItem";
            ColorContextMenuItem.Size = new Size(148, 32);
            ColorContextMenuItem.Text = "Color";
            // 
            // PenContextMenuItem
            // 
            PenContextMenuItem.Name = "PenContextMenuItem";
            PenContextMenuItem.Size = new Size(210, 34);
            PenContextMenuItem.Text = "Pen";
            // 
            // BackGroundContextMenuItem
            // 
            BackGroundContextMenuItem.Name = "BackGroundContextMenuItem";
            BackGroundContextMenuItem.Size = new Size(210, 34);
            BackGroundContextMenuItem.Text = "BackGround";
            // 
            // PenSizeContextMenuItem
            // 
            PenSizeContextMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PenSizeComboBox });
            PenSizeContextMenuItem.Name = "PenSizeContextMenuItem";
            PenSizeContextMenuItem.Size = new Size(148, 32);
            PenSizeContextMenuItem.Text = "Pen Size";
            // 
            // PenSizeComboBox
            // 
            PenSizeComboBox.Name = "PenSizeComboBox";
            PenSizeComboBox.Size = new Size(121, 33);
            // 
            // DrawButton
            // 
            DrawButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DrawButton.Location = new Point(1323, 667);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(132, 57);
            DrawButton.TabIndex = 1;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.Location = new Point(1600, 667);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(136, 57);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, HelpTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Padding = new Padding(7, 2, 0, 2);
            TopMenuStrip.Size = new Size(1750, 35);
            TopMenuStrip.TabIndex = 3;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DrawTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuItem.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(72, 31);
            FileTopMenuItem.Text = "&File";
            // 
            // DrawTopMenuItem
            // 
            DrawTopMenuItem.Name = "DrawTopMenuItem";
            DrawTopMenuItem.Size = new Size(169, 36);
            DrawTopMenuItem.Text = "&Draw";
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(169, 36);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearButton_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(169, 36);
            ExitTopMenuItem.Text = "E&xit";
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopMenuItem });
            HelpTopMenuItem.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(72, 31);
            HelpTopMenuItem.Text = "&Help";
            // 
            // AboutTopMenuItem
            // 
            AboutTopMenuItem.Name = "AboutTopMenuItem";
            AboutTopMenuItem.Size = new Size(270, 36);
            AboutTopMenuItem.Text = "&About";
            AboutTopMenuItem.Click += AboutTopMenuItem_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(1462, 667);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(132, 57);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // BottomStatusStrip
            // 
            BottomStatusStrip.ImageScalingSize = new Size(24, 24);
            BottomStatusStrip.Items.AddRange(new ToolStripItem[] { DrawingStatusLabel });
            BottomStatusStrip.Location = new Point(0, 731);
            BottomStatusStrip.Name = "BottomStatusStrip";
            BottomStatusStrip.Padding = new Padding(1, 0, 15, 0);
            BottomStatusStrip.Size = new Size(1750, 34);
            BottomStatusStrip.TabIndex = 5;
            // 
            // DrawingStatusLabel
            // 
            DrawingStatusLabel.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DrawingStatusLabel.Name = "DrawingStatusLabel";
            DrawingStatusLabel.Size = new Size(122, 27);
            DrawingStatusLabel.Text = "Loading...";
            // 
            // GraphicsExampleForm
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 765);
            Controls.Add(BottomStatusStrip);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(DrawButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(TopMenuStrip);
            Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = TopMenuStrip;
            MinimumSize = new Size(548, 536);
            Name = "GraphicsExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphics Example Form";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            DisplayContextMenuStrip.ResumeLayout(false);
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            BottomStatusStrip.ResumeLayout(false);
            BottomStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private Button DrawButton;
        private Button ExitButton;
        private ColorDialog PenColorDialog;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem DrawTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem AboutTopMenuItem;
        private ContextMenuStrip DisplayContextMenuStrip;
        private ToolStripMenuItem DrawContextpMenuItem;
        private ToolStripMenuItem ClearContextMenuItem;
        private ToolStripMenuItem ColorContextMenuItem;
        private ToolStripMenuItem PenSizeContextMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private Button ClearButton;
        private ToolStripMenuItem PenContextMenuItem;
        private ToolStripMenuItem BackGroundContextMenuItem;
        private ToolStripComboBox PenSizeComboBox;
        private StatusStrip BottomStatusStrip;
        private ToolStripStatusLabel DrawingStatusLabel;
    }
}
