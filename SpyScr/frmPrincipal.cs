﻿using SpyScr.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpyScr
{
    public partial class frmPrincipal : Form
    {
        public bool IsActivo { get; set; }
        public string Pass { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
            InicializandoAplicacion();
        }

        /* P R O C E S O S */

        private void InicializandoAplicacion()
        {
            this.Icon = SpyScr.Properties.Resources.settings;
            this.IcoNotifica.Icon = SpyScr.Properties.Resources.settings;
            IsActivo = true;
            BtnEstatus.MouseHover += new EventHandler(BtnEstatus_MouseHover);
            BtnEstatus.MouseLeave += new EventHandler(BtnEstatus_MouseLeave);
            BtnMinimizar.MouseHover += new EventHandler(BtnMinimizar_MouseHover);
            BtnMinimizar.MouseLeave += new EventHandler(BtnMinimizar_MouseLeave);
            BtnCerrar.MouseHover += new EventHandler(BtnCerrar_MouseHover);
            BtnCerrar.MouseLeave += new EventHandler(BtnCerrar_MouseLeave);
            Pass = "P@55w0rd";
            Tiempo.Interval = 15000;
            Tiempo.Enabled = true;
            Tiempo.Start();
        }

        private void CapturaPantalla()
        {
            Rectangle bounds = Screen.GetBounds(Screen.GetBounds(Point.Empty));
            string fi = ".png";
            Size curSize = default(Size);
            Point curPos = default(Point);

            DateTime Hoy = DateTime.Now;
            string archivo = Hoy.ToString("yyyyMMddHHmmss") + "-SS";
            string ScreenPath = $@"C:\Temp\SpyScr\{archivo}.png";

            ScreenShot.CaptureImage(true, curSize, curPos,
                Point.Empty, Point.Empty, bounds, ScreenPath, fi);
        }

        /* A C C I O N E S*/

        #region BtnEstatus

        private void BtnEstatus_Click(object sender, EventArgs e)
        {
            string respuesta = Prompt.ShowDialog(text: "Indique Contraseña", caption: "Contraseña");

            if (respuesta == Pass)
            {
                IsActivo = !IsActivo;
                if (IsActivo)
                {
                    Tiempo.Start();
                    this.BtnEstatus.Image = SpyScr.Properties.Resources.imgSwitchOn;
                }
                else
                {
                    Tiempo.Stop();
                    this.BtnEstatus.Image = SpyScr.Properties.Resources.imgSwitchOff;
                }
            }
            else
            {
                MessageBox.Show("Contaseña Incorrecta", "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void BtnEstatus_MouseHover(object sender, EventArgs e)
        {
            if (IsActivo)
            {
                this.BtnEstatus.Image = SpyScr.Properties.Resources.imgSwitchOff;
            }
            else
            {
                this.BtnEstatus.Image = SpyScr.Properties.Resources.imgSwitchOn;
            }
        }

        private void BtnEstatus_MouseLeave(object sender, EventArgs e)
        {
            if (IsActivo)
            {
                this.BtnEstatus.Image = SpyScr.Properties.Resources.imgSwitchOn;
            }
            else
            {
                this.BtnEstatus.Image = SpyScr.Properties.Resources.imgSwitchOff;
            }
        }

        #endregion

        #region BtnMinimizar

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void BtnMinimizar_MouseHover(object sender, EventArgs e)
        {
            this.BtnMinimizar.Image = SpyScr.Properties.Resources.imgWindows_2;
        }

        private void BtnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnMinimizar.Image = SpyScr.Properties.Resources.imgWindows_1;
        }

        #endregion

        #region BtnCerrar

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            string respuesta = Prompt.ShowDialog(text: "Indique Contraseña", caption: "Contraseña");

            if (respuesta == Pass)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Contaseña Incorrecta", "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtnCerrar_MouseHover(object sender, EventArgs e)
        {
            this.BtnCerrar.Image = SpyScr.Properties.Resources.imgExitOn;
        }

        private void BtnCerrar_MouseLeave(object sender, EventArgs e)
        {
            this.BtnCerrar.Image = SpyScr.Properties.Resources.imgExit;
        }



        #endregion

        private void IcoNotifica_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            CapturaPantalla();
        }
    }
}
