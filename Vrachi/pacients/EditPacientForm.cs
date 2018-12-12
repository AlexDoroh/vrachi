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
    public partial class EditPacientForm : Form
    {
        public int Id { get; set; }
        MainLibrary.Library DataLayer = new MainLibrary.Library();
        Pacient editedPacient = new Pacient();

        public EditPacientForm()
        {
            InitializeComponent();
        }
        public EditPacientForm(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnEditPacient_Click(object sender, EventArgs e)
        {
            editedPacient.FullName = txtFullName.Text;
            editedPacient.Address = txtAddress.Text;

            DataLayer.UpdatePacient(editedPacient);
            this.Close();
        }

        private void EditPacientForm_Load(object sender, EventArgs e)
        {
            this.editedPacient = DataLayer.GetPacientById(this.Id).ToList()[0];

            txtAddress.Text = editedPacient.Address;
            txtFullName.Text = editedPacient.FullName;
        }
    }
}
