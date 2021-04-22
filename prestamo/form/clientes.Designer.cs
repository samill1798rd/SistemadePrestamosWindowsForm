namespace prestamo.form
{
    partial class clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Label();
            this.listadoclientes = new System.Windows.Forms.GroupBox();
            this.dgvbuscar = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet = new prestamo.prestamosDataSet();
            this.clienteTableAdapter = new prestamo.prestamosDataSetTableAdapters.clienteTableAdapter();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listadoclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes";
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.AutoSize = true;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.Black;
            this.btncerrar.Location = new System.Drawing.Point(713, 299);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(0, 20);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // listadoclientes
            // 
            this.listadoclientes.Controls.Add(this.dgvbuscar);
            this.listadoclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoclientes.Location = new System.Drawing.Point(27, 93);
            this.listadoclientes.Name = "listadoclientes";
            this.listadoclientes.Size = new System.Drawing.Size(576, 313);
            this.listadoclientes.TabIndex = 15;
            this.listadoclientes.TabStop = false;
            this.listadoclientes.Text = "Listado de Clientes";
            // 
            // dgvbuscar
            // 
            this.dgvbuscar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvbuscar.Location = new System.Drawing.Point(12, 40);
            this.dgvbuscar.Name = "dgvbuscar";
            this.dgvbuscar.Size = new System.Drawing.Size(543, 246);
            this.dgvbuscar.TabIndex = 17;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.prestamosDataSetBindingSource;
            // 
            // prestamosDataSetBindingSource
            // 
            this.prestamosDataSetBindingSource.DataSource = this.prestamosDataSet;
            this.prestamosDataSetBindingSource.Position = 0;
            // 
            // prestamosDataSet
            // 
            this.prestamosDataSet.DataSetName = "prestamosDataSet";
            this.prestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(655, 47);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(112, 40);
            this.btnInsertar.TabIndex = 36;
            this.btnInsertar.Text = "Nuevo";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(655, 139);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 40);
            this.btndelete.TabIndex = 38;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(655, 93);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(112, 40);
            this.btneditar.TabIndex = 39;
            this.btneditar.Text = "Modificar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txt0
            // 
            this.txt0.Location = new System.Drawing.Point(226, 45);
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(362, 20);
            this.txt0.TabIndex = 62;
            this.txt0.TextChanged += new System.EventHandler(this.txt0_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Buscar Mediante Cliente ID:";
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.listadoclientes);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientes";
            this.Text = "clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            this.listadoclientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btncerrar;
        private System.Windows.Forms.GroupBox listadoclientes;
        private System.Windows.Forms.DataGridView dgvbuscar;
        private System.Windows.Forms.BindingSource prestamosDataSetBindingSource;
        private prestamosDataSet prestamosDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private prestamosDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btneditar;
        public System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.Label label6;
    }
}