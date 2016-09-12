namespace Vista
{
    partial class Libro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libro));
            this.modificar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.informacion = new System.Windows.Forms.GroupBox();
            this.precio = new System.Windows.Forms.MaskedTextBox();
            this.paginas = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autores = new System.Windows.Forms.ComboBox();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestar = new System.Windows.Forms.Button();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // modificar
            // 
            this.modificar.Image = ((System.Drawing.Image)(resources.GetObject("modificar.Image")));
            this.modificar.Location = new System.Drawing.Point(147, 12);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(62, 47);
            this.modificar.TabIndex = 3;
            this.modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.Location = new System.Drawing.Point(470, 12);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(62, 47);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Aceptar.Image")));
            this.Aceptar.Location = new System.Drawing.Point(402, 12);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(62, 47);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Location = new System.Drawing.Point(80, 12);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(62, 47);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Agregar.BackgroundImage")));
            this.Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Agregar.Location = new System.Drawing.Point(12, 12);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(62, 47);
            this.Agregar.TabIndex = 1;
            this.Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // informacion
            // 
            this.informacion.Controls.Add(this.precio);
            this.informacion.Controls.Add(this.paginas);
            this.informacion.Controls.Add(this.label5);
            this.informacion.Controls.Add(this.label4);
            this.informacion.Controls.Add(this.isbn);
            this.informacion.Controls.Add(this.label2);
            this.informacion.Controls.Add(this.autores);
            this.informacion.Controls.Add(this.label3);
            this.informacion.Controls.Add(this.Titulo);
            this.informacion.Controls.Add(this.label1);
            this.informacion.Location = new System.Drawing.Point(12, 76);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(520, 138);
            this.informacion.TabIndex = 24;
            this.informacion.TabStop = false;
            this.informacion.Text = "Informacion";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(242, 75);
            this.precio.Mask = "99999";
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(36, 20);
            this.precio.TabIndex = 8;
            this.precio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.precio.ValidatingType = typeof(int);
            // 
            // paginas
            // 
            this.paginas.Location = new System.Drawing.Point(69, 75);
            this.paginas.Mask = "99999";
            this.paginas.Name = "paginas";
            this.paginas.Size = new System.Drawing.Size(36, 20);
            this.paginas.TabIndex = 7;
            this.paginas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.paginas.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Paginas";
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(68, 23);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(279, 20);
            this.isbn.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ISBN";
            // 
            // autores
            // 
            this.autores.DataSource = this.autorBindingSource;
            this.autores.DisplayMember = "Nombre";
            this.autores.FormattingEnabled = true;
            this.autores.Location = new System.Drawing.Point(68, 101);
            this.autores.Name = "autores";
            this.autores.Size = new System.Drawing.Size(121, 21);
            this.autores.TabIndex = 9;
            this.autores.ValueMember = "IdEditorial";
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(Modelo.Autor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor";
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(68, 49);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(279, 20);
            this.Titulo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.Prestamo});
            this.dataGridView1.DataSource = this.libroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 257);
            this.dataGridView1.TabIndex = 6;
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(Modelo.Libro);
            // 
            // prestar
            // 
            this.prestar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prestar.BackgroundImage")));
            this.prestar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prestar.Location = new System.Drawing.Point(215, 12);
            this.prestar.Name = "prestar";
            this.prestar.Size = new System.Drawing.Size(62, 47);
            this.prestar.TabIndex = 25;
            this.prestar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.prestar.UseVisualStyleBackColor = true;
            this.prestar.Click += new System.EventHandler(this.prestar_Click);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 90;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 160;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 55;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 90;
            // 
            // Prestamo
            // 
            this.Prestamo.DataPropertyName = "Prestamo";
            this.Prestamo.HeaderText = "Estado";
            this.Prestamo.Name = "Prestamo";
            this.Prestamo.Width = 80;
            // 
            // Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 489);
            this.Controls.Add(this.prestar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro";
            this.informacion.ResumeLayout(false);
            this.informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.GroupBox informacion;
        private System.Windows.Forms.ComboBox autores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private System.Windows.Forms.MaskedTextBox precio;
        private System.Windows.Forms.MaskedTextBox paginas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button prestar;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
    }
}