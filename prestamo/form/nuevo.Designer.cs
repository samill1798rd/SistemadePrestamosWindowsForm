namespace prestamo.form
{
    partial class nuevo
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
            this.btnclose = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet = new prestamo.prestamosDataSet();
            this.clienteTableAdapter = new prestamo.prestamosDataSetTableAdapters.clienteTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKprestamoclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoTableAdapter = new prestamo.prestamosDataSetTableAdapters.prestamoTableAdapter();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKprestamoclienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.fKprestamoclienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet1 = new prestamo.prestamosDataSet1();
            this.clienteBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter1 = new prestamo.prestamosDataSet1TableAdapters.clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprestamoclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprestamoclienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprestamoclienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(415, 9);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(16, 18);
            this.btnclose.TabIndex = 70;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "INGRESAR DATOS DE NUEVO PRESTAMO";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(26, 120);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 17);
            this.lbl1.TabIndex = 72;
            this.lbl1.Text = "Cliente :";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // cbox1
            // 
            this.cbox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "Idcliente", true));
            this.cbox1.DataSource = this.clienteBindingSource6;
            this.cbox1.DisplayMember = "fullname";
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Location = new System.Drawing.Point(137, 120);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(294, 21);
            this.cbox1.TabIndex = 73;
            this.cbox1.ValueMember = "Idcliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.prestamosDataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "Monto :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Meses :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Interes :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Cuotas :";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(137, 154);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(294, 20);
            this.txt1.TabIndex = 78;
            this.txt1.Text = " ";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(137, 181);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(294, 20);
            this.txt2.TabIndex = 79;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(137, 207);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(294, 20);
            this.txt3.TabIndex = 80;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(137, 233);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(294, 20);
            this.txt4.TabIndex = 81;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(12, 72);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 82;
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
            this.btnnuevo.Location = new System.Drawing.Point(28, 292);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(112, 40);
            this.btnnuevo.TabIndex = 83;
            this.btnnuevo.Text = "Registrar";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "cliente";
            this.clienteBindingSource1.DataSource = this.prestamosDataSet;
            // 
            // fKprestamoclienteBindingSource
            // 
            this.fKprestamoclienteBindingSource.DataMember = "FK_prestamo_cliente";
            this.fKprestamoclienteBindingSource.DataSource = this.clienteBindingSource1;
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "cliente";
            this.clienteBindingSource2.DataSource = this.prestamosDataSet;
            // 
            // fKprestamoclienteBindingSource1
            // 
            this.fKprestamoclienteBindingSource1.DataMember = "FK_prestamo_cliente";
            this.fKprestamoclienteBindingSource1.DataSource = this.clienteBindingSource;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "prestamo";
            this.prestamoBindingSource.DataSource = this.prestamosDataSet;
            // 
            // clienteBindingSource3
            // 
            this.clienteBindingSource3.DataMember = "cliente";
            this.clienteBindingSource3.DataSource = this.prestamosDataSet;
            // 
            // clienteBindingSource4
            // 
            this.clienteBindingSource4.DataMember = "cliente";
            this.clienteBindingSource4.DataSource = this.prestamosDataSet;
            // 
            // clienteBindingSource5
            // 
            this.clienteBindingSource5.DataMember = "cliente";
            this.clienteBindingSource5.DataSource = this.prestamosDataSet;
            // 
            // fKprestamoclienteBindingSource2
            // 
            this.fKprestamoclienteBindingSource2.DataMember = "FK_prestamo_cliente";
            this.fKprestamoclienteBindingSource2.DataSource = this.clienteBindingSource2;
            // 
            // prestamosDataSet1
            // 
            this.prestamosDataSet1.DataSetName = "prestamosDataSet1";
            this.prestamosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource6
            // 
            this.clienteBindingSource6.DataMember = "cliente";
            this.clienteBindingSource6.DataSource = this.prestamosDataSet1;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 360);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nuevo";
            this.Text = "nuevo";
            this.Load += new System.EventHandler(this.nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprestamoclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprestamoclienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKprestamoclienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cbox1;
        private prestamosDataSet prestamosDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private prestamosDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource fKprestamoclienteBindingSource;
        private prestamosDataSetTableAdapters.prestamoTableAdapter prestamoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
        private System.Windows.Forms.BindingSource fKprestamoclienteBindingSource1;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource4;
        private System.Windows.Forms.BindingSource clienteBindingSource5;
        private System.Windows.Forms.BindingSource fKprestamoclienteBindingSource2;
        private prestamosDataSet1 prestamosDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource6;
        private prestamosDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter1;
    }
}