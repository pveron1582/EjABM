namespace Altas_Clientes_Productos
{
    partial class AltaProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.cbo_prod = new System.Windows.Forms.ComboBox();
            this.btn_salida = new System.Windows.Forms.Button();
            this.btn_altap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de producto";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(188, 22);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(142, 20);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(188, 51);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(142, 20);
            this.txt_precio.TabIndex = 4;
            // 
            // cbo_prod
            // 
            this.cbo_prod.FormattingEnabled = true;
            this.cbo_prod.Location = new System.Drawing.Point(188, 80);
            this.cbo_prod.Name = "cbo_prod";
            this.cbo_prod.Size = new System.Drawing.Size(140, 21);
            this.cbo_prod.TabIndex = 5;
            // 
            // btn_salida
            // 
            this.btn_salida.Location = new System.Drawing.Point(188, 122);
            this.btn_salida.Name = "btn_salida";
            this.btn_salida.Size = new System.Drawing.Size(164, 43);
            this.btn_salida.TabIndex = 6;
            this.btn_salida.Text = "Salir";
            this.btn_salida.UseVisualStyleBackColor = true;
            this.btn_salida.Click += new System.EventHandler(this.btn_salida_Click);
            // 
            // btn_altap
            // 
            this.btn_altap.Location = new System.Drawing.Point(12, 122);
            this.btn_altap.Name = "btn_altap";
            this.btn_altap.Size = new System.Drawing.Size(164, 43);
            this.btn_altap.TabIndex = 7;
            this.btn_altap.Text = "Generar nuevo producto";
            this.btn_altap.UseVisualStyleBackColor = true;
            this.btn_altap.Click += new System.EventHandler(this.btn_altap_Click);
            // 
            // AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 177);
            this.Controls.Add(this.btn_altap);
            this.Controls.Add(this.btn_salida);
            this.Controls.Add(this.cbo_prod);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaProductos";
            this.Text = "AltaProductos";
            this.Load += new System.EventHandler(this.AltaProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precio;
        //private System.Windows.Forms.Button btn_nuevoproducto;
       // private System.Windows.Forms.Button btn_salir;
        //private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.ComboBox cbo_prod;
        private System.Windows.Forms.Button btn_salida;
        private System.Windows.Forms.Button btn_altap;
    }
}