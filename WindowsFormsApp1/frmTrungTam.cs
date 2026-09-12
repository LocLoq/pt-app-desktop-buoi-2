using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TinhTienBtn_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (cbTAA.Checked)
                s += int.Parse(lbTAA.Text.Split('.')[0]);
            if (cbTAB.Checked)
                s += int.Parse(lbTAB.Text.Split('.')[0]);
            if (cbTHA.Checked)
                s += int.Parse(lbTHA.Text.Split('.')[0]);
            if (cbTHB.Checked)
                s += int.Parse(lbTHB.Text.Split('.')[0]);
            tbTong.Text = s.ToString() + ".000 đồng";
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            comboBHV.Text = "";
            tbTen.Text = "";
            dtDK.Value = DateTime.Now;
            rbNam.Checked = true;
            cbTAA.Checked = false;
            cbTAB.Checked = false;
            cbTHA.Checked = false;
            cbTHB.Checked = false;
            tbTong.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
