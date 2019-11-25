namespace ModuloUsuarios
{
    partial class Refresher
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
            this.loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Location = new System.Drawing.Point(456, 251);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(77, 13);
            this.loading.TabIndex = 0;
            this.loading.Text = "CARGANDO...";
            this.loading.Click += new System.EventHandler(this.label1_Click);
            // 
            // Refresher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 592);
            this.ControlBox = false;
            this.Controls.Add(this.loading);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1008, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1008, 608);
            this.Name = "Refresher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loading;
    }
}