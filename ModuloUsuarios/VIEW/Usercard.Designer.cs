namespace ModuloUsuarios
{
    partial class Usercard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usercard));
            this.username = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.abilityimg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userrole = new System.Windows.Forms.Label();
            this.modify_button = new System.Windows.Forms.Button();
            this.deleter_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abilityimg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(4, 6);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(124, 29);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.Usercard_load);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // abilityimg
            // 
            this.abilityimg.BackColor = System.Drawing.Color.White;
            this.abilityimg.Location = new System.Drawing.Point(235, 34);
            this.abilityimg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abilityimg.Name = "abilityimg";
            this.abilityimg.Size = new System.Drawing.Size(115, 98);
            this.abilityimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.abilityimg.TabIndex = 8;
            this.abilityimg.TabStop = false;
            this.abilityimg.Click += new System.EventHandler(this.Usercard_load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.userrole);
            this.panel1.Controls.Add(this.modify_button);
            this.panel1.Controls.Add(this.deleter_button);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 130);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.Usercard_load);
            // 
            // userrole
            // 
            this.userrole.AutoSize = true;
            this.userrole.BackColor = System.Drawing.Color.White;
            this.userrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrole.Location = new System.Drawing.Point(4, 42);
            this.userrole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userrole.Name = "userrole";
            this.userrole.Size = new System.Drawing.Size(81, 24);
            this.userrole.TabIndex = 10;
            this.userrole.Text = "Userrole";
            this.userrole.Click += new System.EventHandler(this.Usercard_load);
            // 
            // modify_button
            // 
            this.modify_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modify_button.BackgroundImage")));
            this.modify_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modify_button.Location = new System.Drawing.Point(196, 58);
            this.modify_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(28, 27);
            this.modify_button.TabIndex = 1;
            this.modify_button.UseVisualStyleBackColor = true;
            // 
            // deleter_button
            // 
            this.deleter_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleter_button.BackgroundImage")));
            this.deleter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleter_button.Location = new System.Drawing.Point(196, 91);
            this.deleter_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleter_button.Name = "deleter_button";
            this.deleter_button.Size = new System.Drawing.Size(28, 28);
            this.deleter_button.TabIndex = 0;
            this.deleter_button.UseVisualStyleBackColor = true;
            // 
            // Usercard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.abilityimg);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Usercard";
            this.Size = new System.Drawing.Size(355, 140);
            ((System.ComponentModel.ISupportInitialize)(this.abilityimg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox abilityimg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button deleter_button;
        private System.Windows.Forms.Label userrole;
    }
}
