namespace Altas_Clientes_Productos
{
    partial class Mostrar
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
            this.btn_mostrarclientes = new System.Windows.Forms.Button();
            this.btn_mostrarproductos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_buscarproducto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreape = new System.Windows.Forms.TextBox();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mostrarclientes
            // 
            this.btn_mostrarclientes.Location = new System.Drawing.Point(710, 29);
            this.btn_mostrarclientes.Name = "btn_mostrarclientes";
            this.btn_mostrarclientes.Size = new System.Drawing.Size(165, 36);
            this.btn_mostrarclientes.TabIndex = 0;
            this.btn_mostrarclientes.Text = "Mostrar Clientes";
            this.btn_mostrarclientes.UseVisualStyleBackColor = true;
            this.btn_mostrarclientes.Click += new System.EventHandler(this.btn_mostrarclientes_Click);
            // 
            // btn_mostrarproductos
            // 
            this.btn_mostrarproductos.Location = new System.Drawing.Point(710, 71);
            this.btn_mostrarproductos.Name = "btn_mostrarproductos";
            this.btn_mostrarproductos.Size = new System.Drawing.Size(165, 36);
            this.btn_mostrarproductos.TabIndex = 1;
            this.btn_mostrarproductos.Text = "Mostrar Productos";
            this.btn_mostrarproductos.UseVisualStyleBackColor = true;
            this.btn_mostrarproductos.Click += new System.EventHandler(this.btn_mostrarproductos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(760, 134);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(132, 20);
            this.txt_descripcion.TabIndex = 4;
            // 
            // btn_buscarproducto
            // 
            this.btn_buscarproducto.Location = new System.Drawing.Point(708, 174);
            this.btn_buscarproducto.Name = "btn_buscarproducto";
            this.btn_buscarproducto.Size = new System.Drawing.Size(166, 42);
            this.btn_buscarproducto.TabIndex = 5;
            this.btn_buscarproducto.Text = "Buscar Producto";
            this.btn_buscarproducto.UseVisualStyleBackColor = true;
            this.btn_buscarproducto.Click += new System.EventHandler(this.btn_buscarproducto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscarCliente);
            this.groupBox1.Controls.Add(this.txt_nombreape);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(705, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "buscar clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nombre / apellido";
            // 
            // txt_nombreape
            // 
            this.txt_nombreape.Location = new System.Drawing.Point(38, 59);
            this.txt_nombreape.Name = "txt_nombreape";
            this.txt_nombreape.Size = new System.Drawing.Size(99, 20);
            this.txt_nombreape.TabIndex = 2;
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Location = new System.Drawing.Point(6, 110);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(168, 38);
            this.btn_buscarCliente.TabIndex = 4;
            this.btn_buscarCliente.Text = "Buscar";
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 447);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_buscarproducto);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_mostrarproductos);
            this.Controls.Add(this.btn_mostrarclientes);
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrarclientes;
        private System.Windows.Forms.Button btn_mostrarproductos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_buscarproducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscarCliente;
        private System.Windows.Forms.TextBox txt_nombreape;
        private System.Windows.Forms.Label label2;
    }
}