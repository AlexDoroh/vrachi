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
    public partial class EditSotrudnikForm : Form
    {

        public int Id { get; set; }
        MainLibrary.Library DataLayer = new MainLibrary.Library();
        Sotrudnik editedSotr = new Sotrudnik();

        public EditSotrudnikForm()
        {
            InitializeComponent();
        }

        public EditSotrudnikForm(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void EditSotrudnikForm_Load(object sender, EventArgs e)
        {
            this.editedSotr = DataLayer.GetSotrudnikById(this.Id).ToList()[0];

            txtCabNumber.Text = editedSotr.CabNumber;
            txtEndWork.Text = editedSotr.WorkEnd.ToString("HH:mm");
            txtFullName.Text = editedSotr.FullName;
            txtSpec.Text = editedSotr.Specialization;
            txtStartWork.Text = editedSotr.WorkStart.ToString("HH:mm") ;
        }

        private void btnEditSotrudnik_Click(object sender, EventArgs e)
        {
            editedSotr.FullName = txtFullName.Text;
            editedSotr.Specialization = txtSpec.Text;
            editedSotr.WorkEnd = Convert.ToDateTime(txtEndWork.Text);
            editedSotr.WorkStart = Convert.ToDateTime(txtStartWork.Text);
            editedSotr.CabNumber = txtCabNumber.Text;

            DataLayer.UpdateSotrudnik(editedSotr);
            this.Close();
        }
    }
}
