namespace ModuloUsuarios
{
    partial class Charcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charcard));
            this.charname = new System.Windows.Forms.Label();
            this.charclass = new System.Windows.Forms.Label();
            this.charrace = new System.Windows.Forms.Label();
            this.charlvl = new System.Windows.Forms.Label();
            this.charenergy = new System.Windows.Forms.Label();
            this.charlife = new System.Windows.Forms.Label();
            this.charxp = new System.Windows.Forms.Label();
            this.chargold = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imagebox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleter_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // charname
            // 
            this.charname.AutoSize = true;
            this.charname.BackColor = System.Drawing.Color.White;
            this.charname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charname.Location = new System.Drawing.Point(4, 6);
            this.charname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charname.Name = "charname";
            this.charname.Size = new System.Drawing.Size(114, 25);
            this.charname.TabIndex = 0;
            this.charname.Text = "CharName";
            this.charname.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // charclass
            // 
            this.charclass.AutoSize = true;
            this.charclass.BackColor = System.Drawing.Color.White;
            this.charclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charclass.Location = new System.Drawing.Point(117, 11);
            this.charclass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charclass.Name = "charclass";
            this.charclass.Size = new System.Drawing.Size(82, 20);
            this.charclass.TabIndex = 1;
            this.charclass.Text = "CharClass";
            this.charclass.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // charrace
            // 
            this.charrace.AutoSize = true;
            this.charrace.BackColor = System.Drawing.Color.White;
            this.charrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charrace.Location = new System.Drawing.Point(207, 11);
            this.charrace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charrace.Name = "charrace";
            this.charrace.Size = new System.Drawing.Size(81, 20);
            this.charrace.TabIndex = 2;
            this.charrace.Text = "CharRace";
            this.charrace.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // charlvl
            // 
            this.charlvl.AutoSize = true;
            this.charlvl.BackColor = System.Drawing.Color.White;
            this.charlvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charlvl.Location = new System.Drawing.Point(296, 6);
            this.charlvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charlvl.Name = "charlvl";
            this.charlvl.Size = new System.Drawing.Size(33, 25);
            this.charlvl.TabIndex = 3;
            this.charlvl.Text = "lvl";
            this.charlvl.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // charenergy
            // 
            this.charenergy.AutoSize = true;
            this.charenergy.BackColor = System.Drawing.Color.White;
            this.charenergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charenergy.Location = new System.Drawing.Point(4, 60);
            this.charenergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charenergy.Name = "charenergy";
            this.charenergy.Size = new System.Drawing.Size(114, 25);
            this.charenergy.TabIndex = 4;
            this.charenergy.Text = "Energy x/x";
            this.charenergy.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // charlife
            // 
            this.charlife.AutoSize = true;
            this.charlife.BackColor = System.Drawing.Color.White;
            this.charlife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charlife.Location = new System.Drawing.Point(4, 36);
            this.charlife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charlife.Name = "charlife";
            this.charlife.Size = new System.Drawing.Size(81, 25);
            this.charlife.TabIndex = 5;
            this.charlife.Text = "Life x/x";
            this.charlife.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // charxp
            // 
            this.charxp.AutoSize = true;
            this.charxp.BackColor = System.Drawing.Color.White;
            this.charxp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charxp.Location = new System.Drawing.Point(4, 85);
            this.charxp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charxp.Name = "charxp";
            this.charxp.Size = new System.Drawing.Size(74, 25);
            this.charxp.TabIndex = 6;
            this.charxp.Text = "XP x/x";
            this.charxp.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // chargold
            // 
            this.chargold.AutoSize = true;
            this.chargold.BackColor = System.Drawing.Color.White;
            this.chargold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargold.Location = new System.Drawing.Point(4, 110);
            this.chargold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chargold.Name = "chargold";
            this.chargold.Size = new System.Drawing.Size(76, 25);
            this.chargold.TabIndex = 7;
            this.chargold.Text = "gold x ";
            this.chargold.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imagebox
            // 
            this.imagebox.BackColor = System.Drawing.Color.White;
            this.imagebox.Location = new System.Drawing.Point(234, 34);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(114, 98);
            this.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox.TabIndex = 8;
            this.imagebox.TabStop = false;
            this.imagebox.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.modify_button);
            this.panel1.Controls.Add(this.deleter_button);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 131);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.Charcard_Load);
            // 
            // deleter_button
            // 
            this.deleter_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleter_button.BackgroundImage")));
            this.deleter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleter_button.Location = new System.Drawing.Point(196, 91);
            this.deleter_button.Name = "deleter_button";
            this.deleter_button.Size = new System.Drawing.Size(28, 28);
            this.deleter_button.TabIndex = 0;
            this.deleter_button.UseVisualStyleBackColor = true;
            // 
            // modify_button
            // 
            this.modify_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modify_button.BackgroundImage")));
            this.modify_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modify_button.Location = new System.Drawing.Point(196, 58);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(28, 27);
            this.modify_button.TabIndex = 1;
            this.modify_button.UseVisualStyleBackColor = true;
            // 
            // Charcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.imagebox);
            this.Controls.Add(this.chargold);
            this.Controls.Add(this.charxp);
            this.Controls.Add(this.charlife);
            this.Controls.Add(this.charenergy);
            this.Controls.Add(this.charlvl);
            this.Controls.Add(this.charrace);
            this.Controls.Add(this.charclass);
            this.Controls.Add(this.charname);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Charcard";
            this.Size = new System.Drawing.Size(354, 140);
            this.Click += new System.EventHandler(this.Charcard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charname;
        private System.Windows.Forms.Label charclass;
        private System.Windows.Forms.Label charrace;
        private System.Windows.Forms.Label charlvl;
        private System.Windows.Forms.Label charenergy;
        private System.Windows.Forms.Label charlife;
        private System.Windows.Forms.Label charxp;
        private System.Windows.Forms.Label chargold;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox imagebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button deleter_button;
    }
}
