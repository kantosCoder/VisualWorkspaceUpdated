namespace ModuloUsuarios
{
    partial class Abilitycard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abilitycard));
            this.abilityname = new System.Windows.Forms.Label();
            this.abilitylevel = new System.Windows.Forms.Label();
            this.abilitydescr = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.abilityimg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.abilitytype = new System.Windows.Forms.Label();
            this.modify_button = new System.Windows.Forms.Button();
            this.deleter_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abilityimg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abilityname
            // 
            this.abilityname.AutoSize = true;
            this.abilityname.BackColor = System.Drawing.Color.White;
            this.abilityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilityname.Location = new System.Drawing.Point(3, 5);
            this.abilityname.Name = "abilityname";
            this.abilityname.Size = new System.Drawing.Size(70, 20);
            this.abilityname.TabIndex = 0;
            this.abilityname.Text = "Abname";
            this.abilityname.Click += new System.EventHandler(this.Abilitycard_load);
            // 
            // abilitylevel
            // 
            this.abilitylevel.AutoSize = true;
            this.abilitylevel.BackColor = System.Drawing.Color.White;
            this.abilitylevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilitylevel.Location = new System.Drawing.Point(222, 5);
            this.abilitylevel.Name = "abilitylevel";
            this.abilitylevel.Size = new System.Drawing.Size(25, 20);
            this.abilitylevel.TabIndex = 3;
            this.abilitylevel.Text = "lvl";
            this.abilitylevel.Click += new System.EventHandler(this.Abilitycard_load);
            // 
            // abilitydescr
            // 
            this.abilitydescr.BackColor = System.Drawing.Color.White;
            this.abilitydescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilitydescr.Location = new System.Drawing.Point(3, 25);
            this.abilitydescr.Name = "abilitydescr";
            this.abilitydescr.Size = new System.Drawing.Size(139, 72);
            this.abilitydescr.TabIndex = 6;
            this.abilitydescr.Text = "Desc";
            this.abilitydescr.Click += new System.EventHandler(this.Abilitycard_load);
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
            this.abilityimg.Location = new System.Drawing.Point(176, 28);
            this.abilityimg.Margin = new System.Windows.Forms.Padding(2);
            this.abilityimg.Name = "abilityimg";
            this.abilityimg.Size = new System.Drawing.Size(86, 80);
            this.abilityimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.abilityimg.TabIndex = 8;
            this.abilityimg.TabStop = false;
            this.abilityimg.Click += new System.EventHandler(this.Abilitycard_load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.abilitytype);
            this.panel1.Controls.Add(this.modify_button);
            this.panel1.Controls.Add(this.abilitydescr);
            this.panel1.Controls.Add(this.deleter_button);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 106);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.Abilitycard_load);
            // 
            // abilitytype
            // 
            this.abilitytype.AutoSize = true;
            this.abilitytype.BackColor = System.Drawing.Color.White;
            this.abilitytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilitytype.Location = new System.Drawing.Point(121, 2);
            this.abilitytype.Name = "abilitytype";
            this.abilitytype.Size = new System.Drawing.Size(52, 18);
            this.abilitytype.TabIndex = 10;
            this.abilitytype.Text = "Abtype";
            this.abilitytype.Click += new System.EventHandler(this.Abilitycard_load);
            // 
            // modify_button
            // 
            this.modify_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modify_button.BackgroundImage")));
            this.modify_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modify_button.Location = new System.Drawing.Point(147, 47);
            this.modify_button.Margin = new System.Windows.Forms.Padding(2);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(21, 22);
            this.modify_button.TabIndex = 1;
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // deleter_button
            // 
            this.deleter_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleter_button.BackgroundImage")));
            this.deleter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleter_button.Location = new System.Drawing.Point(147, 74);
            this.deleter_button.Margin = new System.Windows.Forms.Padding(2);
            this.deleter_button.Name = "deleter_button";
            this.deleter_button.Size = new System.Drawing.Size(21, 23);
            this.deleter_button.TabIndex = 0;
            this.deleter_button.UseVisualStyleBackColor = true;
            this.deleter_button.Click += new System.EventHandler(this.deleter_button_Click);
            // 
            // Abilitycard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.abilityimg);
            this.Controls.Add(this.abilitylevel);
            this.Controls.Add(this.abilityname);
            this.Controls.Add(this.panel1);
            this.Name = "Abilitycard";
            this.Size = new System.Drawing.Size(266, 114);
            ((System.ComponentModel.ISupportInitialize)(this.abilityimg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abilityname;
        private System.Windows.Forms.Label abilitylevel;
        private System.Windows.Forms.Label abilitydescr;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox abilityimg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button deleter_button;
        private System.Windows.Forms.Label abilitytype;
    }
}
