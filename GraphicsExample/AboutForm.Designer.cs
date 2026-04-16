namespace GraphicsExample
{
    partial class AboutForm
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
            AboutLabel = new Label();
            OkButton = new Button();
            SuspendLayout();
            // 
            // AboutLabel
            // 
            AboutLabel.Location = new Point(13, 10);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(254, 169);
            AboutLabel.TabIndex = 0;
            AboutLabel.Text = "label1";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(246, 229);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(123, 46);
            OkButton.TabIndex = 1;
            OkButton.Text = "&Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // AboutForm
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = OkButton;
            ClientSize = new Size(381, 287);
            Controls.Add(OkButton);
            Controls.Add(AboutLabel);
            Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AboutForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private Label AboutLabel;
        private Button OkButton;
    }
}