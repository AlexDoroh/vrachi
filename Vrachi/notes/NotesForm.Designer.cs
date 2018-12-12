namespace Vrachi.notes
{
    partial class NotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgNotes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSotrudniks = new System.Windows.Forms.ComboBox();
            this.cbPacients = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNotes
            // 
            this.dgNotes.AllowUserToAddRows = false;
            this.dgNotes.AllowUserToDeleteRows = false;
            this.dgNotes.AllowUserToResizeColumns = false;
            this.dgNotes.AllowUserToResizeRows = false;
            this.dgNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgNotes.Location = new System.Drawing.Point(0, 116);
            this.dgNotes.MultiSelect = false;
            this.dgNotes.Name = "dgNotes";
            this.dgNotes.ReadOnly = true;
            this.dgNotes.RowHeadersVisible = false;
            this.dgNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNotes.Size = new System.Drawing.Size(800, 334);
            this.dgNotes.TabIndex = 0;
            this.dgNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgNotes_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Пациент";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сотрудник";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Время";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cbSotrudniks
            // 
            this.cbSotrudniks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSotrudniks.FormattingEnabled = true;
            this.cbSotrudniks.Location = new System.Drawing.Point(49, 42);
            this.cbSotrudniks.Name = "cbSotrudniks";
            this.cbSotrudniks.Size = new System.Drawing.Size(121, 21);
            this.cbSotrudniks.TabIndex = 1;
            this.cbSotrudniks.SelectedIndexChanged += new System.EventHandler(this.cbSotrudniks_SelectedIndexChanged);
            // 
            // cbPacients
            // 
            this.cbPacients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacients.FormattingEnabled = true;
            this.cbPacients.Location = new System.Drawing.Point(176, 41);
            this.cbPacients.Name = "cbPacients";
            this.cbPacients.Size = new System.Drawing.Size(121, 21);
            this.cbPacients.TabIndex = 2;
            this.cbPacients.SelectedIndexChanged += new System.EventHandler(this.cbPacients_SelectedIndexChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(303, 42);
            this.txtDate.Mask = "00.00.0000 00:00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(93, 20);
            this.txtDate.TabIndex = 3;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сотрудник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пациент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(427, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Сбросить";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cbPacients);
            this.Controls.Add(this.cbSotrudniks);
            this.Controls.Add(this.dgNotes);
            this.Name = "NotesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запись";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbSotrudniks;
        private System.Windows.Forms.ComboBox cbPacients;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}