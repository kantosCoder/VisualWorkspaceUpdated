namespace ModuloUsuarios
{
    partial class Creaturecard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creaturecard));
            this.creaturename = new System.Windows.Forms.Label();
            this.creaturelevel = new System.Windows.Forms.Label();
            this.creatureaversion = new System.Windows.Forms.Label();
            this.creaturelife = new System.Windows.Forms.Label();
            this.creaturebasedamage = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.creatureimage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.modify_button = new System.Windows.Forms.Button();
            this.deleter_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.creatureimage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // creaturename
            // 
            this.creaturename.AutoSize = true;
            this.creaturename.BackColor = System.Drawing.Color.White;
            this.creaturename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaturename.Location = new System.Drawing.Point(3, 5);
            this.creaturename.Name = "creaturename";
            this.creaturename.Size = new System.Drawing.Size(89, 20);
            this.creaturename.TabIndex = 0;
            this.creaturename.Text = "CharName";
            this.creaturename.Click += new System.EventHandler(this.Creaturecard_Load);
            // 
            // creaturelevel
            // 
            this.creaturelevel.AutoSize = true;
            this.creaturelevel.BackColor = System.Drawing.Color.White;
            this.creaturelevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaturelevel.Location = new System.Drawing.Point(222, 5);
            this.creaturelevel.Name = "creaturelevel";
            this.creaturelevel.Size = new System.Drawing.Size(25, 20);
            this.creaturelevel.TabIndex = 3;
            this.creaturelevel.Text = "lvl";
            this.creaturelevel.Click += new System.EventHandler(this.Creaturecard_Load);
            // 
            // creatureaversion
            // 
            this.creatureaversion.AutoSize = true;
            this.creatureaversion.BackColor = System.Drawing.Color.White;
            this.creatureaversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureaversion.Location = new System.Drawing.Point(3, 49);
            this.creatureaversion.Name = "creatureaversion";
            this.creatureaversion.Size = new System.Drawing.Size(62, 20);
            this.creatureaversion.TabIndex = 4;
            this.creatureaversion.Text = "Versus";
            this.creatureaversion.Click += new System.EventHandler(this.Creaturecard_Load);
            // 
            // creaturelife
            // 
            this.creaturelife.AutoSize = true;
            this.creaturelife.BackColor = System.Drawing.Color.White;
            this.creaturelife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaturelife.Location = new System.Drawing.Point(3, 29);
            this.creaturelife.Name = "creaturelife";
            this.creaturelife.Size = new System.Drawing.Size(63, 20);
            this.creaturelife.TabIndex = 5;
            this.creaturelife.Text = "Life x/x";
            this.creaturelife.Click += new System.EventHandler(this.Creaturecard_Load);
            // 
            // creaturebasedamage
            // 
            this.creaturebasedamage.AutoSize = true;
            this.creaturebasedamage.BackColor = System.Drawing.Color.White;
            this.creaturebasedamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaturebasedamage.Location = new System.Drawing.Point(3, 69);
            this.creaturebasedamage.Name = "creaturebasedamage";
            this.creaturebasedamage.Size = new System.Drawing.Size(49, 20);
            this.creaturebasedamage.TabIndex = 6;
            this.creaturebasedamage.Text = "DMG";
            this.creaturebasedamage.Click += new System.EventHandler(this.Creaturecard_Load);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // creatureimage
            // 
            this.creatureimage.BackColor = System.Drawing.Color.White;
            this.creatureimage.Location = new System.Drawing.Point(176, 28);
            this.creatureimage.Margin = new System.Windows.Forms.Padding(2);
            this.creatureimage.Name = "creatureimage";
            this.creatureimage.Size = new System.Drawing.Size(86, 80);
            this.creatureimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creatureimage.TabIndex = 8;
            this.creatureimage.TabStop = false;
            this.creatureimage.Click += new System.EventHandler(this.Creaturecard_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.modify_button);
            this.panel1.Controls.Add(this.deleter_button);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 106);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.Creaturecard_Load);
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
            // 
            // Creaturecard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.creatureimage);
            this.Controls.Add(this.creaturebasedamage);
            this.Controls.Add(this.creaturelife);
            this.Controls.Add(this.creatureaversion);
            this.Controls.Add(this.creaturelevel);
            this.Controls.Add(this.creaturename);
            this.Controls.Add(this.panel1);
            this.Name = "Creaturecard";
            this.Size = new System.Drawing.Size(266, 114);
            ((System.ComponentModel.ISupportInitialize)(this.creatureimage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creaturename;
        private System.Windows.Forms.Label creaturelevel;
        private System.Windows.Forms.Label creatureaversion;
        private System.Windows.Forms.Label creaturelife;
        private System.Windows.Forms.Label creaturebasedamage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox creatureimage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button deleter_button;
    }
}
