namespace Dominioo
{
    partial class FormularioGestionarUsusarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.PANTALLATABLA = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PANTALLATABLA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el codigo del usuario";
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Location = new System.Drawing.Point(12, 50);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(157, 23);
            this.BTNBUSCAR.TabIndex = 1;
            this.BTNBUSCAR.Text = "BUSCAR";
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            this.BTNBUSCAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(175, 50);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(157, 23);
            this.BTNELIMINAR.TabIndex = 2;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // PANTALLATABLA
            // 
            this.PANTALLATABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PANTALLATABLA.Location = new System.Drawing.Point(12, 79);
            this.PANTALLATABLA.Name = "PANTALLATABLA";
            this.PANTALLATABLA.Size = new System.Drawing.Size(320, 150);
            this.PANTALLATABLA.TabIndex = 3;
            // 
            // CODIGO
            // 
            this.CODIGO.Location = new System.Drawing.Point(12, 25);
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Size = new System.Drawing.Size(157, 20);
            this.CODIGO.TabIndex = 4;
            // 
            // FormularioGestionarUsusarios
            // 
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.CODIGO);
            this.Controls.Add(this.PANTALLATABLA);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.label1);
            this.Name = "FormularioGestionarUsusarios";
            this.Load += new System.EventHandler(this.FormularioGestionarUsusarios_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PANTALLATABLA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.DataGridView PANTALLATABLA;
        private System.Windows.Forms.TextBox CODIGO;
    }
}

