namespace algoritmo_asterisco
{
    partial class FormMatriz
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
            this.datamatriz = new System.Windows.Forms.DataGridView();
            this.txtcolumnas = new System.Windows.Forms.TextBox();
            this.txtfilas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaplicar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datamatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // datamatriz
            // 
            this.datamatriz.AllowUserToAddRows = false;
            this.datamatriz.AllowUserToDeleteRows = false;
            this.datamatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datamatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamatriz.ColumnHeadersVisible = false;
            this.datamatriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datamatriz.EnableHeadersVisualStyles = false;
            this.datamatriz.Location = new System.Drawing.Point(117, 67);
            this.datamatriz.Name = "datamatriz";
            this.datamatriz.ReadOnly = true;
            this.datamatriz.RowHeadersVisible = false;
            this.datamatriz.Size = new System.Drawing.Size(487, 322);
            this.datamatriz.TabIndex = 0;
            this.datamatriz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamatriz_CellClick);
            this.datamatriz.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamatriz_CellDoubleClick);
            // 
            // txtcolumnas
            // 
            this.txtcolumnas.Location = new System.Drawing.Point(196, 27);
            this.txtcolumnas.Name = "txtcolumnas";
            this.txtcolumnas.Size = new System.Drawing.Size(105, 20);
            this.txtcolumnas.TabIndex = 1;
            // 
            // txtfilas
            // 
            this.txtfilas.Location = new System.Drawing.Point(454, 27);
            this.txtfilas.Name = "txtfilas";
            this.txtfilas.Size = new System.Drawing.Size(105, 20);
            this.txtfilas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COLUMNAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filas";
            // 
            // btnaplicar
            // 
            this.btnaplicar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaplicar.Location = new System.Drawing.Point(666, 298);
            this.btnaplicar.Name = "btnaplicar";
            this.btnaplicar.Size = new System.Drawing.Size(87, 23);
            this.btnaplicar.TabIndex = 5;
            this.btnaplicar.Text = "APLICAR";
            this.btnaplicar.UseVisualStyleBackColor = true;
            this.btnaplicar.Click += new System.EventHandler(this.btnaplicar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(654, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "inicio";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(654, 140);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(43, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "FIN";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.Location = new System.Drawing.Point(666, 366);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(87, 23);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // FormMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnaplicar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilas);
            this.Controls.Add(this.txtcolumnas);
            this.Controls.Add(this.datamatriz);
            this.Name = "FormMatriz";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datamatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datamatriz;
        private System.Windows.Forms.TextBox txtcolumnas;
        private System.Windows.Forms.TextBox txtfilas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaplicar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnbuscar;
    }
}

