namespace ModeloDual_NET_Framework
{
    partial class Form1
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
            this.btnBuscarAct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarAct = new System.Windows.Forms.Button();
            this.btnEliminarAct = new System.Windows.Forms.Button();
            this.btnActualizarAct = new System.Windows.Forms.Button();
            this.btnGuardarAct = new System.Windows.Forms.Button();
            this.cboxTema = new System.Windows.Forms.ComboBox();
            this.tBoxDescAct = new System.Windows.Forms.TextBox();
            this.tboxHorasAct = new System.Windows.Forms.TextBox();
            this.tboxNombreAct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNoAct = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarAct
            // 
            this.btnBuscarAct.Location = new System.Drawing.Point(405, 57);
            this.btnBuscarAct.Name = "btnBuscarAct";
            this.btnBuscarAct.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAct.TabIndex = 0;
            this.btnBuscarAct.Text = "Buscar";
            this.btnBuscarAct.UseVisualStyleBackColor = true;
            this.btnBuscarAct.Click += new System.EventHandler(this.btnBuscarAct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarAct);
            this.groupBox1.Controls.Add(this.btnEliminarAct);
            this.groupBox1.Controls.Add(this.btnActualizarAct);
            this.groupBox1.Controls.Add(this.btnGuardarAct);
            this.groupBox1.Controls.Add(this.cboxTema);
            this.groupBox1.Controls.Add(this.tBoxDescAct);
            this.groupBox1.Controls.Add(this.tboxHorasAct);
            this.groupBox1.Controls.Add(this.tboxNombreAct);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxNoAct);
            this.groupBox1.Controls.Add(this.btnBuscarAct);
            this.groupBox1.Location = new System.Drawing.Point(130, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actividades";
            // 
            // btnLimpiarAct
            // 
            this.btnLimpiarAct.Location = new System.Drawing.Point(390, 382);
            this.btnLimpiarAct.Name = "btnLimpiarAct";
            this.btnLimpiarAct.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarAct.TabIndex = 14;
            this.btnLimpiarAct.Text = "Limpiar";
            this.btnLimpiarAct.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAct
            // 
            this.btnEliminarAct.Location = new System.Drawing.Point(276, 382);
            this.btnEliminarAct.Name = "btnEliminarAct";
            this.btnEliminarAct.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAct.TabIndex = 13;
            this.btnEliminarAct.Text = "Eliminar";
            this.btnEliminarAct.UseVisualStyleBackColor = true;
            this.btnEliminarAct.Click += new System.EventHandler(this.btnEliminarAct_Click);
            // 
            // btnActualizarAct
            // 
            this.btnActualizarAct.Location = new System.Drawing.Point(159, 382);
            this.btnActualizarAct.Name = "btnActualizarAct";
            this.btnActualizarAct.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarAct.TabIndex = 12;
            this.btnActualizarAct.Text = "Actualizar";
            this.btnActualizarAct.UseVisualStyleBackColor = true;
            // 
            // btnGuardarAct
            // 
            this.btnGuardarAct.Location = new System.Drawing.Point(31, 382);
            this.btnGuardarAct.Name = "btnGuardarAct";
            this.btnGuardarAct.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAct.TabIndex = 11;
            this.btnGuardarAct.Text = "Guardar";
            this.btnGuardarAct.UseVisualStyleBackColor = true;
            this.btnGuardarAct.Click += new System.EventHandler(this.btnGuardarAct_Click);
            // 
            // cboxTema
            // 
            this.cboxTema.FormattingEnabled = true;
            this.cboxTema.Location = new System.Drawing.Point(159, 59);
            this.cboxTema.Name = "cboxTema";
            this.cboxTema.Size = new System.Drawing.Size(146, 21);
            this.cboxTema.TabIndex = 10;
            this.cboxTema.SelectedIndexChanged += new System.EventHandler(this.cboxTema_SelectedIndexChanged);
            // 
            // tBoxDescAct
            // 
            this.tBoxDescAct.Location = new System.Drawing.Point(114, 238);
            this.tBoxDescAct.Multiline = true;
            this.tBoxDescAct.Name = "tBoxDescAct";
            this.tBoxDescAct.Size = new System.Drawing.Size(237, 122);
            this.tBoxDescAct.TabIndex = 9;
            // 
            // tboxHorasAct
            // 
            this.tboxHorasAct.Location = new System.Drawing.Point(208, 178);
            this.tboxHorasAct.Name = "tboxHorasAct";
            this.tboxHorasAct.Size = new System.Drawing.Size(56, 20);
            this.tboxHorasAct.TabIndex = 8;
            // 
            // tboxNombreAct
            // 
            this.tboxNombreAct.Location = new System.Drawing.Point(190, 123);
            this.tboxNombreAct.Name = "tboxNombreAct";
            this.tboxNombreAct.Size = new System.Drawing.Size(142, 20);
            this.tboxNombreAct.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tema";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Actividad";
            // 
            // tboxNoAct
            // 
            this.tboxNoAct.Location = new System.Drawing.Point(144, 123);
            this.tboxNoAct.Name = "tboxNoAct";
            this.tboxNoAct.Size = new System.Drawing.Size(40, 20);
            this.tboxNoAct.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarAct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNoAct;
        private System.Windows.Forms.ComboBox cboxTema;
        private System.Windows.Forms.TextBox tBoxDescAct;
        private System.Windows.Forms.TextBox tboxHorasAct;
        private System.Windows.Forms.TextBox tboxNombreAct;
        private System.Windows.Forms.Button btnLimpiarAct;
        private System.Windows.Forms.Button btnEliminarAct;
        private System.Windows.Forms.Button btnActualizarAct;
        private System.Windows.Forms.Button btnGuardarAct;
    }
}

