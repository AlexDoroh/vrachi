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

namespace Vrachi.notes
{
    public partial class AddNoteForm : Form
    {
        MainLibrary.Library DataLayer = new MainLibrary.Library();

        public AddNoteForm()
        {
            InitializeComponent();
            FillCombos();
        }

        public void FillCombos()
        {
            var pacients = DataLayer.GetAllPacients();
            var sotrudniks = DataLayer.GetAllSotrudniks();

            cbPacients.Items.Clear();
            cbSotrudniks.Items.Clear();

            foreach (Pacient pacient in pacients)
                cbPacients.Items.Add(pacient.FullName);

            foreach (Sotrudnik sotrudnik in sotrudniks)
                cbSotrudniks.Items.Add(sotrudnik.FullName);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            DataLayer.AddNote(new Note {PacientId = int.Parse(DataLayer.GetPacientByName(cbPacients.Text).ToList()[0].Id.ToString()),
            SotrudnikId = int.Parse(DataLayer.GetSotrudnikByName(cbSotrudniks.Text).ToList()[0].Id.ToString()),
            NoteTime = Convert.ToDateTime(txtDate.Text)
            });
            this.Close();
        }

        private void AddNoteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
