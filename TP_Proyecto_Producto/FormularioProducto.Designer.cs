namespace TP_Proyecto_Producto
{
    partial class FormularioProducto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btCargar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStockModif = new System.Windows.Forms.Label();
            this.lblDescModif = new System.Windows.Forms.Label();
            this.txtCodModif = new System.Windows.Forms.TextBox();
            this.sinuso2 = new System.Windows.Forms.Label();
            this.btSelectProd = new System.Windows.Forms.Button();
            this.rbEgreso = new System.Windows.Forms.RadioButton();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.sinuso = new System.Windows.Forms.Label();
            this.txtCantidadAModif = new System.Windows.Forms.TextBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.lblSelectProdCod = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btBorrarDatos = new System.Windows.Forms.Button();
            this.btMostrarDatos = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(193, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 218);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btCargar);
            this.tabPage1.Controls.Add(this.txtStock);
            this.tabPage1.Controls.Add(this.txtDesc);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.lblStock);
            this.tabPage1.Controls.Add(this.lblDesc);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carga de productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(305, 111);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(83, 36);
            this.btCargar.TabIndex = 6;
            this.btCargar.Text = "Cargar producto";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(87, 120);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(136, 20);
            this.txtStock.TabIndex = 5;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(87, 70);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(301, 20);
            this.txtDesc.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(136, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(18, 127);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(18, 77);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btEliminar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblStockModif);
            this.tabPage2.Controls.Add(this.lblDescModif);
            this.tabPage2.Controls.Add(this.txtCodModif);
            this.tabPage2.Controls.Add(this.sinuso2);
            this.tabPage2.Controls.Add(this.btSelectProd);
            this.tabPage2.Controls.Add(this.rbEgreso);
            this.tabPage2.Controls.Add(this.rbIngreso);
            this.tabPage2.Controls.Add(this.lblCantidad);
            this.tabPage2.Controls.Add(this.sinuso);
            this.tabPage2.Controls.Add(this.txtCantidadAModif);
            this.tabPage2.Controls.Add(this.btModificar);
            this.tabPage2.Controls.Add(this.lblSelectProdCod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar´productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modificar el Stock del producto";
            // 
            // lblStockModif
            // 
            this.lblStockModif.AutoSize = true;
            this.lblStockModif.Location = new System.Drawing.Point(87, 78);
            this.lblStockModif.Name = "lblStockModif";
            this.lblStockModif.Size = new System.Drawing.Size(0, 13);
            this.lblStockModif.TabIndex = 11;
            // 
            // lblDescModif
            // 
            this.lblDescModif.AutoSize = true;
            this.lblDescModif.Location = new System.Drawing.Point(87, 53);
            this.lblDescModif.Name = "lblDescModif";
            this.lblDescModif.Size = new System.Drawing.Size(0, 13);
            this.lblDescModif.TabIndex = 10;
            // 
            // txtCodModif
            // 
            this.txtCodModif.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCodModif.Location = new System.Drawing.Point(90, 18);
            this.txtCodModif.Name = "txtCodModif";
            this.txtCodModif.Size = new System.Drawing.Size(196, 20);
            this.txtCodModif.TabIndex = 9;
            this.txtCodModif.Text = "Ingrese código de producto a modificar";
            this.txtCodModif.Enter += new System.EventHandler(this.txtCodModif_Enter);
            this.txtCodModif.Leave += new System.EventHandler(this.txtCodModif_Leave);
            // 
            // sinuso2
            // 
            this.sinuso2.AutoSize = true;
            this.sinuso2.Location = new System.Drawing.Point(19, 78);
            this.sinuso2.Name = "sinuso2";
            this.sinuso2.Size = new System.Drawing.Size(35, 13);
            this.sinuso2.TabIndex = 8;
            this.sinuso2.Text = "Stock";
            // 
            // btSelectProd
            // 
            this.btSelectProd.Location = new System.Drawing.Point(365, 20);
            this.btSelectProd.Name = "btSelectProd";
            this.btSelectProd.Size = new System.Drawing.Size(75, 46);
            this.btSelectProd.TabIndex = 7;
            this.btSelectProd.Text = "Seleccionar producto";
            this.btSelectProd.UseVisualStyleBackColor = true;
            this.btSelectProd.Click += new System.EventHandler(this.btSelectProd_Click);
            // 
            // rbEgreso
            // 
            this.rbEgreso.AutoSize = true;
            this.rbEgreso.Location = new System.Drawing.Point(196, 159);
            this.rbEgreso.Name = "rbEgreso";
            this.rbEgreso.Size = new System.Drawing.Size(58, 17);
            this.rbEgreso.TabIndex = 6;
            this.rbEgreso.TabStop = true;
            this.rbEgreso.Text = "Egreso";
            this.rbEgreso.UseVisualStyleBackColor = true;
            // 
            // rbIngreso
            // 
            this.rbIngreso.AutoSize = true;
            this.rbIngreso.Location = new System.Drawing.Point(196, 136);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(60, 17);
            this.rbIngreso.TabIndex = 5;
            this.rbIngreso.TabStop = true;
            this.rbIngreso.Text = "Ingreso";
            this.rbIngreso.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(19, 144);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // sinuso
            // 
            this.sinuso.AutoSize = true;
            this.sinuso.Location = new System.Drawing.Point(19, 53);
            this.sinuso.Name = "sinuso";
            this.sinuso.Size = new System.Drawing.Size(63, 13);
            this.sinuso.TabIndex = 3;
            this.sinuso.Text = "Descripción";
            // 
            // txtCantidadAModif
            // 
            this.txtCantidadAModif.Location = new System.Drawing.Point(90, 141);
            this.txtCantidadAModif.Name = "txtCantidadAModif";
            this.txtCantidadAModif.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAModif.TabIndex = 2;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(365, 139);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 1;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // lblSelectProdCod
            // 
            this.lblSelectProdCod.AutoSize = true;
            this.lblSelectProdCod.Location = new System.Drawing.Point(19, 25);
            this.lblSelectProdCod.Name = "lblSelectProdCod";
            this.lblSelectProdCod.Size = new System.Drawing.Size(40, 13);
            this.lblSelectProdCod.TabIndex = 0;
            this.lblSelectProdCod.Text = "Codigo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 129);
            this.dataGridView1.TabIndex = 1;
            // 
            // btBorrarDatos
            // 
            this.btBorrarDatos.Location = new System.Drawing.Point(564, 385);
            this.btBorrarDatos.Name = "btBorrarDatos";
            this.btBorrarDatos.Size = new System.Drawing.Size(83, 22);
            this.btBorrarDatos.TabIndex = 7;
            this.btBorrarDatos.Text = "Borrar";
            this.btBorrarDatos.UseVisualStyleBackColor = true;
            this.btBorrarDatos.Click += new System.EventHandler(this.btBorrarDatos_Click);
            // 
            // btMostrarDatos
            // 
            this.btMostrarDatos.Location = new System.Drawing.Point(475, 385);
            this.btMostrarDatos.Name = "btMostrarDatos";
            this.btMostrarDatos.Size = new System.Drawing.Size(83, 22);
            this.btMostrarDatos.TabIndex = 8;
            this.btMostrarDatos.Text = "Mostrar datos";
            this.btMostrarDatos.UseVisualStyleBackColor = true;
            this.btMostrarDatos.Click += new System.EventHandler(this.btMostrarDatos_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(365, 163);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 9;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // FormularioProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMostrarDatos);
            this.Controls.Add(this.btBorrarDatos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormularioProducto";
            this.Text = "FormularioProducto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.TextBox txtCantidadAModif;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label lblSelectProdCod;
        private System.Windows.Forms.RadioButton rbEgreso;
        private System.Windows.Forms.RadioButton rbIngreso;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label sinuso;
        private System.Windows.Forms.Button btSelectProd;
        private System.Windows.Forms.Label sinuso2;
        private System.Windows.Forms.TextBox txtCodModif;
        private System.Windows.Forms.Label lblDescModif;
        private System.Windows.Forms.Label lblStockModif;
        private System.Windows.Forms.Button btBorrarDatos;
        private System.Windows.Forms.Button btMostrarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminar;
    }
}