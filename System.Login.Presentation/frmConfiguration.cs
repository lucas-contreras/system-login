using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Login.Presentation
{
    public partial class frmConfiguration : Form
    {
        private bool _anyChanges = false;
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void chAllowAutoUnlock_CheckedChanged(object sender, EventArgs e)
        {
            this._anyChanges = true;
            this.mkRestartBefore.Enabled = this.chAllowAutoUnlock.Checked;

            if (this.chAllowAutoUnlock.Checked)
            {
                this.mkRestartBefore.Text = "00:00";
                this.mkRestartBefore.Focus();
                this.mkRestartBefore.SelectAll();
            }
            else
            {
                this.mkRestartBefore.Text = "";
            }
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {

        }

        private void frmConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._anyChanges == false)
            {
                e.Cancel = false;
                return;
            }

            DialogResult result = MessageBox.Show("Hubo cambios en el formulario, ¿Desea salir de todas formas?", Application.ProductName, MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void UpdateAnyChanges(bool value)
        {
            this._anyChanges = value;
        }
    }
}
