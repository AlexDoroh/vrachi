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

namespace Vrachi.pacients
{
    public partial class AddPacientForm : Form
    {
        MainLibrary.Library DataLayer = new MainLibrary.Library();

        public AddPacientForm()
        {
            InitializeComponent();
        }

        private void btnAddPacient_Click(object sender, EventArgs e)
        {
            DataLayer.AddPacient(new Pacient {FullName = txtFullName.Text, Address = txtAddress.Text });
            this.Close();
        }
    }
}
