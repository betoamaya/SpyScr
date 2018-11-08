namespace SpyScr
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ttpMensajitos = new System.Windows.Forms.ToolTip(this.components);
            this.BtnEstatus = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.IcoNotifica = new System.Windows.Forms.NotifyIcon(this.components);
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BtnEstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEstatus
            // 
            this.BtnEstatus.Image = global::SpyScr.Properties.Resources.imgSwitchOn;
            resources.ApplyResources(this.BtnEstatus, "BtnEstatus");
            this.BtnEstatus.Name = "BtnEstatus";
            this.BtnEstatus.TabStop = false;
            this.BtnEstatus.Click += new System.EventHandler(this.BtnEstatus_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Image = global::SpyScr.Properties.Resources.imgWindows_1;
            resources.ApplyResources(this.BtnMinimizar, "BtnMinimizar");
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = global::SpyScr.Properties.Resources.imgExit;
            resources.ApplyResources(this.BtnCerrar, "BtnCerrar");
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // IcoNotifica
            // 
            resources.ApplyResources(this.IcoNotifica, "IcoNotifica");
            this.IcoNotifica.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IcoNotifica_MouseDoubleClick);
            // 
            // Tiempo
            // 
            this.Tiempo.Interval = 30000;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnEstatus);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.BtnEstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttpMensajitos;
        private System.Windows.Forms.PictureBox BtnEstatus;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.NotifyIcon IcoNotifica;
        private System.Windows.Forms.Timer Tiempo;
    }
}

