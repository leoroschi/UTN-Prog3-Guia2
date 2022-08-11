
namespace GuiaTeoricayPractica2
{
    partial class listView
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listView));
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblActualdir = new System.Windows.Forms.Label();
            this.gbVistas = new System.Windows.Forms.GroupBox();
            this.rbTitle = new System.Windows.Forms.RadioButton();
            this.rbDitail = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.lvCarpetas = new System.Windows.Forms.ListView();
            this.imageListaLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.gbVistas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnAtras.Location = new System.Drawing.Point(221, 405);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblActualdir
            // 
            this.lblActualdir.Location = new System.Drawing.Point(27, 23);
            this.lblActualdir.Name = "lblActualdir";
            this.lblActualdir.Size = new System.Drawing.Size(491, 23);
            this.lblActualdir.TabIndex = 1;
            this.lblActualdir.Text = "Directorio Actual";
            // 
            // gbVistas
            // 
            this.gbVistas.Controls.Add(this.rbTitle);
            this.gbVistas.Controls.Add(this.rbDitail);
            this.gbVistas.Controls.Add(this.rbList);
            this.gbVistas.Controls.Add(this.rbSmall);
            this.gbVistas.Controls.Add(this.rbLarge);
            this.gbVistas.Location = new System.Drawing.Point(533, 51);
            this.gbVistas.Name = "gbVistas";
            this.gbVistas.Size = new System.Drawing.Size(238, 336);
            this.gbVistas.TabIndex = 2;
            this.gbVistas.TabStop = false;
            this.gbVistas.Text = "Modo de vista";
            // 
            // rbTitle
            // 
            this.rbTitle.AutoSize = true;
            this.rbTitle.Location = new System.Drawing.Point(22, 229);
            this.rbTitle.Name = "rbTitle";
            this.rbTitle.Size = new System.Drawing.Size(51, 17);
            this.rbTitle.TabIndex = 4;
            this.rbTitle.Text = "Titulo";
            this.rbTitle.UseVisualStyleBackColor = true;
            this.rbTitle.CheckedChanged += new System.EventHandler(this.rbTitle_CheckedChanged);
            // 
            // rbDitail
            // 
            this.rbDitail.AutoSize = true;
            this.rbDitail.Checked = true;
            this.rbDitail.Location = new System.Drawing.Point(22, 182);
            this.rbDitail.Name = "rbDitail";
            this.rbDitail.Size = new System.Drawing.Size(58, 17);
            this.rbDitail.TabIndex = 3;
            this.rbDitail.TabStop = true;
            this.rbDitail.Text = "Detalle";
            this.rbDitail.UseVisualStyleBackColor = true;
            this.rbDitail.CheckedChanged += new System.EventHandler(this.rbDitail_CheckedChanged);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(22, 133);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(47, 17);
            this.rbList.TabIndex = 2;
            this.rbList.Text = "Lista";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.rbList_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(22, 87);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(108, 17);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.Text = "Iconos Pequeños";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(22, 41);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(100, 17);
            this.rbLarge.TabIndex = 0;
            this.rbLarge.Text = "Iconos Grandes";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // lvCarpetas
            // 
            this.lvCarpetas.HideSelection = false;
            this.lvCarpetas.LargeImageList = this.imageListaLarge;
            this.lvCarpetas.Location = new System.Drawing.Point(27, 51);
            this.lvCarpetas.Name = "lvCarpetas";
            this.lvCarpetas.Size = new System.Drawing.Size(491, 336);
            this.lvCarpetas.SmallImageList = this.imageListSmall;
            this.lvCarpetas.TabIndex = 3;
            this.lvCarpetas.UseCompatibleStateImageBehavior = false;
            this.lvCarpetas.View = System.Windows.Forms.View.Details;
            this.lvCarpetas.ItemActivate += new System.EventHandler(this.lvCarpetas_ItemActivate);
            // 
            // imageListaLarge
            // 
            this.imageListaLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListaLarge.ImageStream")));
            this.imageListaLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListaLarge.Images.SetKeyName(0, "folder.jpg");
            this.imageListaLarge.Images.SetKeyName(1, "icon.jpg");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "folder.jpg");
            this.imageListSmall.Images.SetKeyName(1, "icon.jpg");
            // 
            // listView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvCarpetas);
            this.Controls.Add(this.gbVistas);
            this.Controls.Add(this.lblActualdir);
            this.Controls.Add(this.btnAtras);
            this.Name = "listView";
            this.Text = "ListView";
            this.gbVistas.ResumeLayout(false);
            this.gbVistas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblActualdir;
        private System.Windows.Forms.GroupBox gbVistas;
        private System.Windows.Forms.RadioButton rbDitail;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.ListView lvCarpetas;
        private System.Windows.Forms.RadioButton rbTitle;
        private System.Windows.Forms.ImageList imageListaLarge;
        private System.Windows.Forms.ImageList imageListSmall;
    }
}

