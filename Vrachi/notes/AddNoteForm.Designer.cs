namespace Vrachi.notes
{
    partial class AddNoteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.cbPacients = new System.Windows.Forms.ComboBox();
            this.cbSotrudniks = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пациент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сотрудник";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(222, 37);
            this.txtDate.Mask = "00.00.0000 00:00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(92, 20);
            this.txtDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(101, 87);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(144, 33);
            this.btnAddNote.TabIndex = 6;
            this.btnAddNote.Text = "Добавить";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // cbPacients
            // 
            this.cbPacients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacients.FormattingEnabled = true;
            this.cbPacients.Location = new System.Drawing.Point(16, 37);
            this.cbPacients.Name = "cbPacients";
            this.cbPacients.Size = new System.Drawing.Size(97, 21);
            this.cbPacients.TabIndex = 7;
            // 
            // cbSotrudniks
            // 
            this.cbSotrudniks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSotrudniks.FormattingEnabled = true;
            this.cbSotrudniks.Location = new System.Drawing.Point(119, 37);
            this.cbSotrudniks.Name = "cbSotrudniks";
            this.cbSotrudniks.Size = new System.Drawing.Size(97, 21);
            this.cbSotrudniks.TabIndex = 8;
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 149);
            this.Controls.Add(this.cbSotrudniks);
            this.Controls.Add(this.cbPacients);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNoteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.AddNoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.ComboBox cbPacients;
        private System.Windows.Forms.ComboBox cbSotrudniks;
    }
}