using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vrachi
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnSotrudniks_Click(object sender, EventArgs e)
        {
            SotrudniksForm sotrudniksForm = new SotrudniksForm();
            sotrudniksForm.ShowDialog();
        }

        private void btnPacients_Click(object sender, EventArgs e)
        {
            PacientsForm pacientsForm = new PacientsForm();
            pacientsForm.ShowDialog();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            notes.NotesForm notesForm = new notes.NotesForm();
            notesForm.ShowDialog();
        }
    }
}
