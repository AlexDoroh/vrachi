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
using MainLibrary;

namespace Vrachi
{
    public partial class SotrudniksForm : Form
    {
        Library DataLayer = new Library();
        
        public SotrudniksForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            dgSotrudniks.Rows.Clear();

            var sotrudniks = DataLayer.GetAllSotrudniks();
            if (sotrudniks != null)
            {
                foreach(Sotrudnik sotr in sotrudniks)
                {
                    dgSotrudniks.Rows.Add(sotr.Id,sotr.FullName,sotr.Specialization,sotr.CabNumber,sotr.WorkStart.ToString("HH:mm"),sotr.WorkEnd.ToString("HH:mm"));
                }
            }
        }

        private void dgSotrudniks_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddSotrudnikForm addSotrudnikForm = new AddSotrudnikForm();
                addSotrudnikForm.ShowDialog();
                FillDataGrid();
            }
            if(e.KeyCode == Keys.Delete)
            {
                if(dgSotrudniks.SelectedRows.Count >0)
                {
                    DataLayer.DeleteSotrudnik(int.Parse(dgSotrudniks[0, dgSotrudniks.SelectedRows[0].Index].Value.ToString()));
                    FillDataGrid();
                }
            }
        }

        private void dgSotrudniks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgSotrudniks.SelectedRows.Count > 0)
            {
                EditSotrudnikForm editSotrudnikForm = new EditSotrudnikForm(int.Parse(dgSotrudniks[0, dgSotrudniks.SelectedRows[0].Index].Value.ToString()));
                editSotrudnikForm.ShowDialog();
                FillDataGrid();
            }
        }

        private void dgSotrudniks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
