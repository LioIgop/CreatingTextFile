using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmFileName : Form
    {
        public FrmFileName()
        {
            InitializeComponent();
        }
        public string SetFileName { get; private set; }
        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            Close();

            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();
        }
    }
}
