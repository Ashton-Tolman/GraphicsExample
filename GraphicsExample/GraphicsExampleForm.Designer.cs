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
            DisplayContextMenuStrip = new ContextMenuStrip(components);
            DrawContextpMenuItem = new ToolStripMenuItem();
            ClearContextMenuItem = new ToolStripMenuItem();
            ColorContextMenuItem = new ToolStripMenuItem();
            PenSizeContextMenuItem = new ToolStripMenuItem();
            ClearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            TopMenuStrip.SuspendLayout();
            DisplayContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ActiveCaption;
            DisplayPictureBox.ContextMenuStrip = DisplayContextMenuStrip;
            DisplayPictureBox.Location = new Point(12, 50);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(1567, 544);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // DrawButton
            // 
            DrawButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DrawButton.Location = new Point(1203, 643);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(120, 53);
            DrawButton.TabIndex = 1;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.Location = new Point(1455, 643);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(124, 53);
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
            TopMenuStrip.Size = new Size(1591, 33);
            TopMenuStrip.TabIndex = 3;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DrawTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(54, 29);
            FileTopMenuItem.Text = "&File";
            // 
            // DrawTopMenuItem
            // 
            DrawTopMenuItem.Name = "DrawTopMenuItem";
            DrawTopMenuItem.Size = new Size(155, 34);
            DrawTopMenuItem.Text = "&Draw";
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(155, 34);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearButton_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(155, 34);
            ExitTopMenuItem.Text = "E&xit";
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopMenuItem });
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(65, 29);
            HelpTopMenuItem.Text = "&Help";
            // 
            // AboutTopMenuItem
            // 
            AboutTopMenuItem.Name = "AboutTopMenuItem";
            AboutTopMenuItem.Size = new Size(164, 34);
            AboutTopMenuItem.Text = "&About";
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
            ColorContextMenuItem.Name = "ColorContextMenuItem";
            ColorContextMenuItem.Size = new Size(148, 32);
            ColorContextMenuItem.Text = "Color";
            // 
            // PenSizeContextMenuItem
            // 
            PenSizeContextMenuItem.Name = "PenSizeContextMenuItem";
            PenSizeContextMenuItem.Size = new Size(148, 32);
            PenSizeContextMenuItem.Text = "Pen Size";
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(1329, 643);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(120, 53);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // GraphicsExampleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 708);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(DrawButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            MinimumSize = new Size(500, 500);
            Name = "GraphicsExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphics Example Form";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            DisplayContextMenuStrip.ResumeLayout(false);
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
    }
}
