using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vrachi.pacients;
using Models;

namespace Vrachi
{
    public partial class PacientsForm : Form
    {
        MainLibrary.Library DataLayer = new MainLibrary.Library();

        public PacientsForm()
        {
            InitializeComponent();
        }

        private void dgPacients_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddPacientForm addPacientForm = new AddPacientForm();
                addPacientForm.ShowDialog();
                FillDataGrid();
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (dgPacients.SelectedRows.Count > 0)
                {
                    DataLayer.DeletePacient(int.Parse(dgPacients[0, dgPacients.SelectedRows[0].Index].Value.ToString()));
                    FillDataGrid();
                }
            }
        }

        private void PacientsForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            dgPacients.Rows.Clear();

            var pacients = DataLayer.GetAllPacients();
            if (pacients != null)
            {
                foreach(Pacient pacient in pacients)
                    dgPacients.Rows.Add(pacient.Id,pacient.FullName,pacient.Address);
            }
        }

        private void dgPacients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgPacients.SelectedRows.Count > 0)
            {
                EditPacientForm editPacientForm = new EditPacientForm(int.Parse(dgPacients[0, dgPacients.SelectedRows[0].Index].Value.ToString()));
                editPacientForm.ShowDialog();
                FillDataGrid();
            }
        }
    }
}
