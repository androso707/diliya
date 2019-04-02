namespace Dominioo
{
    partial class FormularioGestionarReportes
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

        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CODTRAMITE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NEWSTATE = new System.Windows.Forms.TextBox();
            this.BTNCAMBIO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CODTRAMITE
            // 
            this.CODTRAMITE.Location = new System.Drawing.Point(60, 51);
            this.CODTRAMITE.Name = "CODTRAMITE";
            this.CODTRAMITE.Size = new System.Drawing.Size(182, 20);
            this.CODTRAMITE.TabIndex = 0;
            this.CODTRAMITE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CAMBIA EL ESTADO DE TRAMITE!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CODIGO DEL TRAMITE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NUEVO ESTADO";
            // 
            // NEWSTATE
            // 
            this.NEWSTATE.Location = new System.Drawing.Point(60, 95);
            this.NEWSTATE.Name = "NEWSTATE";
            this.NEWSTATE.Size = new System.Drawing.Size(182, 20);
            this.NEWSTATE.TabIndex = 4;
            // 
            // BTNCAMBIO
            // 
            this.BTNCAMBIO.Location = new System.Drawing.Point(86, 121);
            this.BTNCAMBIO.Name = "BTNCAMBIO";
            this.BTNCAMBIO.Size = new System.Drawing.Size(114, 23);
            this.BTNCAMBIO.TabIndex = 5;
            this.BTNCAMBIO.Text = "CAMBIAR";
            this.BTNCAMBIO.UseVisualStyleBackColor = true;
            this.BTNCAMBIO.Click += new System.EventHandler(this.BTNCAMBIO_Click);
            // 
            // FormularioGestionarReportes
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTNCAMBIO);
            this.Controls.Add(this.NEWSTATE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CODTRAMITE);
            this.Name = "FormularioGestionarReportes";
            this.Load += new System.EventHandler(this.FormularioGestionarReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox CODTRAMITE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NEWSTATE;
        private System.Windows.Forms.Button BTNCAMBIO;
    }
        #endregion

    }

