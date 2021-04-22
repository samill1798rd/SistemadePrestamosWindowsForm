namespace prestamo.form
{
    partial class servicios
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
            this.listadoclientes = new System.Windows.Forms.GroupBox();
            this.dgvbuscar = new System.Windows.Forms.DataGridView();
            this.prestamoBindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet2 = new prestamo.prestamosDataSet2();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet = new prestamo.prestamosDataSet();
            this.prestamoTableAdapter = new prestamo.prestamosDataSetTableAdapters.prestamoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmonto = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnpago = new System.Windows.Forms.Button();
            this.btntiempo = new System.Windows.Forms.Button();
            this.btncuotas = new System.Windows.Forms.Button();
            this.prestamoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet1 = new prestamo.prestamosDataSet1();
            this.prestamosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoTableAdapter1 = new prestamo.prestamosDataSet1TableAdapters.prestamoTableAdapter();
            this.prestamoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoTableAdapter2 = new prestamo.prestamosDataSet2TableAdapters.prestamoTableAdapter();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn1pago = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listadoclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource9)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoclientes
            // 
            this.listadoclientes.Controls.Add(this.dgvbuscar);
            this.listadoclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoclientes.Location = new System.Drawing.Point(21, 100);
            this.listadoclientes.Name = "listadoclientes";
            this.listadoclientes.Size = new System.Drawing.Size(576, 338);
            this.listadoclientes.TabIndex = 16;
            this.listadoclientes.TabStop = false;
            this.listadoclientes.Text = "Listado de Prestamo";
            // 
            // dgvbuscar
            // 
            this.dgvbuscar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscar.Location = new System.Drawing.Point(6, 45);
            this.dgvbuscar.Name = "dgvbuscar";
            this.dgvbuscar.Size = new System.Drawing.Size(538, 264);
            this.dgvbuscar.TabIndex = 0;
            // 
            // prestamoBindingSource10
            // 
            this.prestamoBindingSource10.DataMember = "prestamo";
            this.prestamoBindingSource10.DataSource = this.prestamosDataSet2;
            // 
            // prestamosDataSet2
            // 
            this.prestamosDataSet2.DataSetName = "prestamosDataSet2";
            this.prestamosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "prestamo";
            this.prestamoBindingSource.DataSource = this.prestamosDataSet;
            // 
            // prestamosDataSet
            // 
            this.prestamosDataSet.DataSetName = "prestamosDataSet";
            this.prestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Servicios";
            // 
            // btnmonto
            // 
            this.btnmonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnmonto.FlatAppearance.BorderSize = 0;
            this.btnmonto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnmonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmonto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmonto.ForeColor = System.Drawing.Color.White;
            this.btnmonto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmonto.Location = new System.Drawing.Point(667, 162);
            this.btnmonto.Name = "btnmonto";
            this.btnmonto.Size = new System.Drawing.Size(112, 50);
            this.btnmonto.TabIndex = 43;
            this.btnmonto.Text = "Monto del Prestamo";
            this.btnmonto.UseVisualStyleBackColor = false;
            this.btnmonto.Click += new System.EventHandler(this.btnmonto_Click);
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
            this.btndelete.Location = new System.Drawing.Point(667, 116);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 40);
            this.btndelete.TabIndex = 42;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(667, 9);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(112, 40);
            this.btnnuevo.TabIndex = 41;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnpago
            // 
            this.btnpago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnpago.FlatAppearance.BorderSize = 0;
            this.btnpago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnpago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpago.ForeColor = System.Drawing.Color.White;
            this.btnpago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpago.Location = new System.Drawing.Point(667, 60);
            this.btnpago.Name = "btnpago";
            this.btnpago.Size = new System.Drawing.Size(112, 49);
            this.btnpago.TabIndex = 45;
            this.btnpago.Text = "Modificar Monto";
            this.btnpago.UseVisualStyleBackColor = false;
            this.btnpago.Click += new System.EventHandler(this.btnpago_Click);
            // 
            // btntiempo
            // 
            this.btntiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btntiempo.FlatAppearance.BorderSize = 0;
            this.btntiempo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btntiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntiempo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntiempo.ForeColor = System.Drawing.Color.White;
            this.btntiempo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntiempo.Location = new System.Drawing.Point(667, 218);
            this.btntiempo.Name = "btntiempo";
            this.btntiempo.Size = new System.Drawing.Size(112, 54);
            this.btntiempo.TabIndex = 46;
            this.btntiempo.Text = "Tiempo del Prestamo";
            this.btntiempo.UseVisualStyleBackColor = false;
            this.btntiempo.Click += new System.EventHandler(this.btntiempo_Click);
            // 
            // btncuotas
            // 
            this.btncuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncuotas.FlatAppearance.BorderSize = 0;
            this.btncuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncuotas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuotas.ForeColor = System.Drawing.Color.White;
            this.btncuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncuotas.Location = new System.Drawing.Point(667, 278);
            this.btncuotas.Name = "btncuotas";
            this.btncuotas.Size = new System.Drawing.Size(112, 40);
            this.btncuotas.TabIndex = 47;
            this.btncuotas.Text = "Cuotas";
            this.btncuotas.UseVisualStyleBackColor = false;
            this.btncuotas.Click += new System.EventHandler(this.btncuotas_Click);
            // 
            // prestamoBindingSource1
            // 
            this.prestamoBindingSource1.DataMember = "prestamo";
            this.prestamoBindingSource1.DataSource = this.prestamosDataSet;
            // 
            // prestamosDataSet1
            // 
            this.prestamosDataSet1.DataSetName = "prestamosDataSet1";
            this.prestamosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosDataSet1BindingSource
            // 
            this.prestamosDataSet1BindingSource.DataSource = this.prestamosDataSet1;
            this.prestamosDataSet1BindingSource.Position = 0;
            // 
            // prestamoBindingSource2
            // 
            this.prestamoBindingSource2.DataMember = "prestamo";
            this.prestamoBindingSource2.DataSource = this.prestamosDataSet;
            // 
            // prestamoBindingSource3
            // 
            this.prestamoBindingSource3.DataMember = "prestamo";
            this.prestamoBindingSource3.DataSource = this.prestamosDataSet1BindingSource;
            // 
            // prestamoTableAdapter1
            // 
            this.prestamoTableAdapter1.ClearBeforeFill = true;
            // 
            // prestamoBindingSource4
            // 
            this.prestamoBindingSource4.DataMember = "prestamo";
            this.prestamoBindingSource4.DataSource = this.prestamosDataSet;
            // 
            // prestamoBindingSource5
            // 
            this.prestamoBindingSource5.DataMember = "prestamo";
            this.prestamoBindingSource5.DataSource = this.prestamosDataSet;
            // 
            // prestamoBindingSource6
            // 
            this.prestamoBindingSource6.DataMember = "prestamo";
            this.prestamoBindingSource6.DataSource = this.prestamosDataSet1;
            // 
            // prestamoBindingSource7
            // 
            this.prestamoBindingSource7.DataMember = "prestamo";
            this.prestamoBindingSource7.DataSource = this.prestamosDataSet1BindingSource;
            // 
            // prestamoBindingSource8
            // 
            this.prestamoBindingSource8.DataMember = "prestamo";
            this.prestamoBindingSource8.DataSource = this.prestamosDataSet1BindingSource;
            // 
            // prestamoBindingSource9
            // 
            this.prestamoBindingSource9.DataMember = "prestamo";
            this.prestamoBindingSource9.DataSource = this.prestamosDataSet;
            // 
            // prestamoTableAdapter2
            // 
            this.prestamoTableAdapter2.ClearBeforeFill = true;
            // 
            // txt0
            // 
            this.txt0.Location = new System.Drawing.Point(189, 60);
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(362, 20);
            this.txt0.TabIndex = 60;
            this.txt0.TextChanged += new System.EventHandler(this.txt0_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "Buscar Mediante Cliente ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn1pago
            // 
            this.btn1pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn1pago.FlatAppearance.BorderSize = 0;
            this.btn1pago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn1pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1pago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1pago.ForeColor = System.Drawing.Color.White;
            this.btn1pago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1pago.Location = new System.Drawing.Point(667, 370);
            this.btn1pago.Name = "btn1pago";
            this.btn1pago.Size = new System.Drawing.Size(112, 57);
            this.btn1pago.TabIndex = 61;
            this.btn1pago.Text = "Realizar Pago";
            this.btn1pago.UseVisualStyleBackColor = false;
            this.btn1pago.Click += new System.EventHandler(this.btn1pago_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(667, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 62;
            this.button1.Text = "Balance";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1pago);
            this.Controls.Add(this.txt0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncuotas);
            this.Controls.Add(this.btntiempo);
            this.Controls.Add(this.btnpago);
            this.Controls.Add(this.btnmonto);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "servicios";
            this.Text = "servicios";
            this.Load += new System.EventHandler(this.servicios_Load);
            this.listadoclientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox listadoclientes;
        private prestamosDataSet prestamosDataSet;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private prestamosDataSetTableAdapters.prestamoTableAdapter prestamoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmonto;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnpago;
        private System.Windows.Forms.Button btntiempo;
        private System.Windows.Forms.Button btncuotas;
        private System.Windows.Forms.BindingSource prestamoBindingSource1;
        private System.Windows.Forms.BindingSource prestamoBindingSource2;
        private prestamosDataSet1 prestamosDataSet1;
        private System.Windows.Forms.BindingSource prestamosDataSet1BindingSource;
        private System.Windows.Forms.BindingSource prestamoBindingSource3;
        private prestamosDataSet1TableAdapters.prestamoTableAdapter prestamoTableAdapter1;
        private System.Windows.Forms.DataGridView dgvbuscar;
        private System.Windows.Forms.BindingSource prestamoBindingSource4;
        private System.Windows.Forms.BindingSource prestamoBindingSource5;
        private System.Windows.Forms.BindingSource prestamoBindingSource6;
        private System.Windows.Forms.BindingSource prestamoBindingSource9;
        private System.Windows.Forms.BindingSource prestamoBindingSource7;
        private System.Windows.Forms.BindingSource prestamoBindingSource8;
        private prestamosDataSet2 prestamosDataSet2;
        private System.Windows.Forms.BindingSource prestamoBindingSource10;
        private prestamosDataSet2TableAdapters.prestamoTableAdapter prestamoTableAdapter2;
        public System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn1pago;
        private System.Windows.Forms.Button button1;
    }
}