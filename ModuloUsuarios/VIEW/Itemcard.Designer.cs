namespace ModuloUsuarios
{
    partial class Itemcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Itemcard));
            this.itemname = new System.Windows.Forms.Label();
            this.itemlevel = new System.Windows.Forms.Label();
            this.itemweight = new System.Windows.Forms.Label();
            this.itemspace = new System.Windows.Forms.Label();
            this.itemarmor = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.creatureimage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemvalue = new System.Windows.Forms.Label();
            this.itemdamage = new System.Windows.Forms.Label();
            this.itemtype = new System.Windows.Forms.Label();
            this.modify_button = new System.Windows.Forms.Button();
            this.deleter_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.creatureimage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.BackColor = System.Drawing.Color.White;
            this.itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.Location = new System.Drawing.Point(3, 5);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(82, 20);
            this.itemname.TabIndex = 0;
            this.itemname.Text = "Itemname";
            this.itemname.Click += new System.EventHandler(this.Item_load);
            // 
            // itemlevel
            // 
            this.itemlevel.AutoSize = true;
            this.itemlevel.BackColor = System.Drawing.Color.White;
            this.itemlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemlevel.Location = new System.Drawing.Point(222, 5);
            this.itemlevel.Name = "itemlevel";
            this.itemlevel.Size = new System.Drawing.Size(25, 20);
            this.itemlevel.TabIndex = 3;
            this.itemlevel.Text = "lvl";
            // 
            // itemweight
            // 
            this.itemweight.AutoSize = true;
            this.itemweight.BackColor = System.Drawing.Color.White;
            this.itemweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.itemweight.Location = new System.Drawing.Point(0, 65);
            this.itemweight.Name = "itemweight";
            this.itemweight.Size = new System.Drawing.Size(48, 17);
            this.itemweight.TabIndex = 4;
            this.itemweight.Text = "weight";
            // 
            // itemspace
            // 
            this.itemspace.AutoSize = true;
            this.itemspace.BackColor = System.Drawing.Color.White;
            this.itemspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.itemspace.Location = new System.Drawing.Point(63, 65);
            this.itemspace.Name = "itemspace";
            this.itemspace.Size = new System.Drawing.Size(47, 17);
            this.itemspace.TabIndex = 5;
            this.itemspace.Text = "x slots";
            // 
            // itemarmor
            // 
            this.itemarmor.AutoSize = true;
            this.itemarmor.BackColor = System.Drawing.Color.White;
            this.itemarmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemarmor.Location = new System.Drawing.Point(0, 27);
            this.itemarmor.Name = "itemarmor";
            this.itemarmor.Size = new System.Drawing.Size(53, 20);
            this.itemarmor.TabIndex = 6;
            this.itemarmor.Text = "armor";
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
            this.creatureimage.Location = new System.Drawing.Point(175, 28);
            this.creatureimage.Margin = new System.Windows.Forms.Padding(2);
            this.creatureimage.Name = "creatureimage";
            this.creatureimage.Size = new System.Drawing.Size(87, 79);
            this.creatureimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creatureimage.TabIndex = 8;
            this.creatureimage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.itemvalue);
            this.panel1.Controls.Add(this.itemdamage);
            this.panel1.Controls.Add(this.itemarmor);
            this.panel1.Controls.Add(this.itemtype);
            this.panel1.Controls.Add(this.itemweight);
            this.panel1.Controls.Add(this.itemspace);
            this.panel1.Controls.Add(this.modify_button);
            this.panel1.Controls.Add(this.deleter_button);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 106);
            this.panel1.TabIndex = 9;
            // 
            // itemvalue
            // 
            this.itemvalue.AutoSize = true;
            this.itemvalue.BackColor = System.Drawing.Color.White;
            this.itemvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemvalue.Location = new System.Drawing.Point(0, 85);
            this.itemvalue.Name = "itemvalue";
            this.itemvalue.Size = new System.Drawing.Size(53, 20);
            this.itemvalue.TabIndex = 11;
            this.itemvalue.Text = "x gold";
            // 
            // itemdamage
            // 
            this.itemdamage.AutoSize = true;
            this.itemdamage.BackColor = System.Drawing.Color.White;
            this.itemdamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.itemdamage.Location = new System.Drawing.Point(0, 47);
            this.itemdamage.Name = "itemdamage";
            this.itemdamage.Size = new System.Drawing.Size(142, 18);
            this.itemdamage.TabIndex = 10;
            this.itemdamage.Text = "damage: x(typedmg)";
            // 
            // itemtype
            // 
            this.itemtype.AutoSize = true;
            this.itemtype.BackColor = System.Drawing.Color.White;
            this.itemtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtype.Location = new System.Drawing.Point(108, 3);
            this.itemtype.Name = "itemtype";
            this.itemtype.Size = new System.Drawing.Size(72, 20);
            this.itemtype.TabIndex = 10;
            this.itemtype.Text = "itemtype";
            // 
            // modify_button
            // 
            this.modify_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modify_button.BackgroundImage")));
            this.modify_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modify_button.Location = new System.Drawing.Point(122, 82);
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
            this.deleter_button.Location = new System.Drawing.Point(147, 81);
            this.deleter_button.Margin = new System.Windows.Forms.Padding(2);
            this.deleter_button.Name = "deleter_button";
            this.deleter_button.Size = new System.Drawing.Size(21, 23);
            this.deleter_button.TabIndex = 0;
            this.deleter_button.UseVisualStyleBackColor = true;
            // 
            // Itemcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.creatureimage);
            this.Controls.Add(this.itemlevel);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.panel1);
            this.Name = "Itemcard";
            this.Size = new System.Drawing.Size(266, 114);
            ((System.ComponentModel.ISupportInitialize)(this.creatureimage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.Label itemlevel;
        private System.Windows.Forms.Label itemweight;
        private System.Windows.Forms.Label itemspace;
        private System.Windows.Forms.Label itemarmor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox creatureimage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button deleter_button;
        private System.Windows.Forms.Label itemtype;
        private System.Windows.Forms.Label itemdamage;
        private System.Windows.Forms.Label itemvalue;
    }
}
