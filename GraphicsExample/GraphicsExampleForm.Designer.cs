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
            menuStrip1 = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            DrawTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutTopMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            drawToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            penSizeToolStripMenuItem = new ToolStripMenuItem();
            ClearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ActiveCaption;
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, HelpTopMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1591, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { drawToolStripMenuItem, clearToolStripMenuItem, colorToolStripMenuItem, penSizeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(149, 132);
            // 
            // drawToolStripMenuItem
            // 
            drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            drawToolStripMenuItem.Size = new Size(148, 32);
            drawToolStripMenuItem.Text = "Draw";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(148, 32);
            clearToolStripMenuItem.Text = "Clear";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(148, 32);
            colorToolStripMenuItem.Text = "Color";
            // 
            // penSizeToolStripMenuItem
            // 
            penSizeToolStripMenuItem.Name = "penSizeToolStripMenuItem";
            penSizeToolStripMenuItem.Size = new Size(148, 32);
            penSizeToolStripMenuItem.Text = "Pen Size";
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(500, 500);
            Name = "GraphicsExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphics Example Form";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private Button DrawButton;
        private Button ExitButton;
        private ColorDialog PenColorDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem DrawTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem AboutTopMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem drawToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem penSizeToolStripMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private Button ClearButton;
    }
}
