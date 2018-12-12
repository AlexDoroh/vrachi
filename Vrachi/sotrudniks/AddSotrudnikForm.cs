using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Vrachi
{
    public partial class AddSotrudnikForm : Form
    {
        MainLibrary.Library DataLayer = new MainLibrary.Library();

        public AddSotrudnikForm()
        {
            InitializeComponent();
        }

        private void btnAddSotrudnik_Click(object sender, EventArgs e)
        {
            Sotrudnik addSotrudnik = new Sotrudnik();
            addSotrudnik.FullName = txtFullName.Text;
            addSotrudnik.Specialization = txtSpec.Text;
            addSotrudnik.WorkEnd = Convert.ToDateTime(txtEndWork.Text);
            addSotrudnik.WorkStart = Convert.ToDateTime(txtStartWork.Text);
            addSotrudnik.CabNumber = txtCabNumber.Text;

            DataLayer.AddSotrudnik(addSotrudnik);
            this.Close();
        }

        private void txtEndWork_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtStartWork_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCabNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSpec_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
