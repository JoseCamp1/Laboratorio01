namespace NotasExcelencia
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            mnuCalcular = new System.Windows.Forms.ToolStripMenuItem();
            mnuExcelencia = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnuAcerca = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuArchivo, ayudaToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(680, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuCalcular, mnuExcelencia, toolStripSeparator1, mnuSalir });
            mnuArchivo.Name = "mnuArchivo";
            mnuArchivo.Size = new System.Drawing.Size(60, 20);
            mnuArchivo.Text = "Archivo";
            // 
            // mnuCalcular
            // 
            mnuCalcular.Image = Properties.Resources.calculate_icon_icons_com_71014;
            mnuCalcular.Name = "mnuCalcular";
            mnuCalcular.Size = new System.Drawing.Size(169, 22);
            mnuCalcular.Text = "CalcularPromedio";
            mnuCalcular.Click += mnuCalcular_Click;
            // 
            // mnuExcelencia
            // 
            mnuExcelencia.Image = Properties.Resources._1486395886_checkmark_80611;
            mnuExcelencia.Name = "mnuExcelencia";
            mnuExcelencia.Size = new System.Drawing.Size(169, 22);
            mnuExcelencia.Text = "Excelencia";
            mnuExcelencia.Click += mnuExcelencia_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // mnuSalir
            // 
            mnuSalir.Image = Properties.Resources.signout_106525;
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new System.Drawing.Size(169, 22);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuAcerca });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // mnuAcerca
            // 
            mnuAcerca.Image = Properties.Resources.about_3697;
            mnuAcerca.Name = "mnuAcerca";
            mnuAcerca.Size = new System.Drawing.Size(135, 22);
            mnuAcerca.Text = "Acerca de...";
            mnuAcerca.Click += mnuAcerca_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(680, 557);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Laboratorio 1";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuCalcular;
        private System.Windows.Forms.ToolStripMenuItem mnuExcelencia;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAcerca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
