namespace NotasExcelencia
{
    partial class FrmDeterminarExcelencia
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
            components = new System.ComponentModel.Container();
            Mensaje = new System.Windows.Forms.ToolTip(components);
            btnCalcular = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtcondicion = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtpromedio = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtnombre = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            lstEstudiantes = new System.Windows.Forms.ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = System.Drawing.SystemColors.WindowFrame;
            btnCalcular.BackgroundImage = Properties.Resources._1486348528_forward_arrows_arrow_front_go_80452;
            btnCalcular.Location = new System.Drawing.Point(341, 20);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new System.Drawing.Size(48, 48);
            btnCalcular.TabIndex = 1;
            Mensaje.SetToolTip(btnCalcular, "Clic para determinar la condición del estudiante");
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(499, 70);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 28);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "&Agregar";
            Mensaje.SetToolTip(btnAgregar, "Clic o Alt+A para agregar el estudiante a la lista");
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(436, 396);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 31);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "&Limpiar";
            Mensaje.SetToolTip(btnLimpiar, "Clic o Alt+L para limpiar los datos");
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(517, 396);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 31);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "&Salir";
            Mensaje.SetToolTip(btnSalir, "Clic o Alt+S para salir");
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(txtcondicion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtpromedio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(580, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Estudiante";
            // 
            // txtcondicion
            // 
            txtcondicion.BackColor = System.Drawing.SystemColors.Info;
            txtcondicion.Location = new System.Drawing.Point(412, 40);
            txtcondicion.Name = "txtcondicion";
            txtcondicion.Size = new System.Drawing.Size(162, 24);
            txtcondicion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(412, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 17);
            label3.TabIndex = 4;
            label3.Text = "Condicion";
            // 
            // txtpromedio
            // 
            txtpromedio.Location = new System.Drawing.Point(218, 40);
            txtpromedio.Name = "txtpromedio";
            txtpromedio.Size = new System.Drawing.Size(104, 24);
            txtpromedio.TabIndex = 3;
            txtpromedio.KeyPress += txtpromedio_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(218, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 17);
            label2.TabIndex = 2;
            label2.Text = "Promedio";
            // 
            // txtnombre
            // 
            txtnombre.Location = new System.Drawing.Point(6, 40);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new System.Drawing.Size(193, 24);
            txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstEstudiantes);
            groupBox2.Location = new System.Drawing.Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(580, 200);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Estudiantes";
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.ItemHeight = 16;
            lstEstudiantes.Location = new System.Drawing.Point(19, 33);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new System.Drawing.Size(542, 148);
            lstEstudiantes.TabIndex = 0;
            // 
            // FrmDeterminarExcelencia
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(609, 451);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDeterminarExcelencia";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Determinar Excelencia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolTip Mensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcondicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstEstudiantes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}