namespace TestForm
{
    partial class MultiplePasswordForm
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
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.Location = new System.Drawing.Point(12, 12);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(491, 353);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "";
            // 
            // MultiplePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 377);
            this.Controls.Add(this.mainText);
            this.Name = "MultiplePasswordForm";
            this.Text = "MultiplePasswordForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox mainText;
    }
}