
namespace TrabajoPractico1
{
    partial class Ejercicio1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnPasar = new System.Windows.Forms.Button();
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbAgregados = new System.Windows.Forms.ListBox();
            this.lbPasados = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(632, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPasar
            // 
            this.btnPasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasar.Location = new System.Drawing.Point(362, 182);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(79, 37);
            this.btnPasar.TabIndex = 1;
            this.btnPasar.Text = ">";
            this.btnPasar.UseVisualStyleBackColor = true;
            this.btnPasar.Click += new System.EventHandler(this.btnPasar_Click);
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodos.Location = new System.Drawing.Point(362, 294);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(79, 37);
            this.btnPasarTodos.TabIndex = 2;
            this.btnPasarTodos.Text = ">>";
            this.btnPasarTodos.UseVisualStyleBackColor = true;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(454, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(54, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Ingrese su nombre:";
            // 
            // lbAgregados
            // 
            this.lbAgregados.FormattingEnabled = true;
            this.lbAgregados.Location = new System.Drawing.Point(57, 120);
            this.lbAgregados.Name = "lbAgregados";
            this.lbAgregados.Size = new System.Drawing.Size(278, 290);
            this.lbAgregados.TabIndex = 5;
            // 
            // lbPasados
            // 
            this.lbPasados.FormattingEnabled = true;
            this.lbPasados.Location = new System.Drawing.Point(466, 120);
            this.lbPasados.Name = "lbPasados";
            this.lbPasados.Size = new System.Drawing.Size(278, 290);
            this.lbPasados.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(362, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbPasados);
            this.Controls.Add(this.lbAgregados);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.btnPasar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnPasar;
        private System.Windows.Forms.Button btnPasarTodos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lbAgregados;
        private System.Windows.Forms.ListBox lbPasados;
        private System.Windows.Forms.Button btnCancelar;
    }
}