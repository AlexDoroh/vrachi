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
    public partial class NotesForm : Form
    {
        MainLibrary.Library DataLayer = new MainLibrary.Library();

        public NotesForm()
        {
            InitializeComponent();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
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

        public void FillDataGrid()
        {
            dgNotes.Rows.Clear();

            var notes = DataLayer.GetAllNotes();
            if (notes != null)
            {
                foreach (Note note in notes)
                    dgNotes.Rows.Add(note.Id,DataLayer.GetPacientById(note.PacientId).ToList()[0].FullName,DataLayer.GetSotrudnikById(note.SotrudnikId).ToList()[0].FullName, note.NoteTime.ToString("dd:MM:yyyy HH:mm"));
            }
        }

        private void dgNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddNoteForm addNoteForm = new AddNoteForm();
                addNoteForm.ShowDialog();
                FillDataGrid();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbPacients.SelectedIndex = -1;
            cbSotrudniks.SelectedIndex = -1;
            txtDate.Text = "";
        }

        public void DoOperationsFilter()
        {
            var notes = DataLayer.GetAllNotes();

            dgNotes.Rows.Clear();

            if (cbPacients.SelectedIndex >= 0)
            {
                var filter =
                from d in notes
                where DataLayer.GetPacientById(d.PacientId).ToList()[0].FullName == cbPacients.Text
                select d;
                notes = filter;
            }
            if (cbSotrudniks.SelectedIndex >= 0)
            {
                var filter =
                from d in notes
                where DataLayer.GetSotrudnikById(d.SotrudnikId).ToList()[0].FullName == cbSotrudniks.Text
                select d;
                notes = filter;
            }
            if (txtDate.Text.Length == 16)
            {
                var filter =
                from d in notes
                where d.NoteTime.ToString("dd.MM.yyyy HH:mm") == txtDate.Text
                select d;
                notes = filter;
            }

            foreach (Note note in notes)
            {
                dgNotes.Rows.Add(note.Id, DataLayer.GetPacientById(note.PacientId).ToList()[0].FullName, DataLayer.GetSotrudnikById(note.SotrudnikId).ToList()[0].FullName, note.NoteTime.ToString("dd:MM:yyyy HH:mm"));
            }
        }

        private void cbSotrudniks_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoOperationsFilter();
        }

        private void cbPacients_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoOperationsFilter();
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            DoOperationsFilter();
        }
    }
}
