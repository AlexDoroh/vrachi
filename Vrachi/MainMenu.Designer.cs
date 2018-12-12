namespace Vrachi
{
    partial class MainMenu
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
            this.btnSotrudniks = new System.Windows.Forms.Button();
            this.btnPacients = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSotrudniks
            // 
            this.btnSotrudniks.Location = new System.Drawing.Point(12, 12);
            this.btnSotrudniks.Name = "btnSotrudniks";
            this.btnSotrudniks.Size = new System.Drawing.Size(417, 36);
            this.btnSotrudniks.TabIndex = 0;
            this.btnSotrudniks.Text = "Сотрудники";
            this.btnSotrudniks.UseVisualStyleBackColor = true;
            this.btnSotrudniks.Click += new System.EventHandler(this.btnSotrudniks_Click);
            // 
            // btnPacients
            // 
            this.btnPacients.Location = new System.Drawing.Point(12, 54);
            this.btnPacients.Name = "btnPacients";
            this.btnPacients.Size = new System.Drawing.Size(417, 36);
            this.btnPacients.TabIndex = 1;
            this.btnPacients.Text = "Пациенты";
            this.btnPacients.UseVisualStyleBackColor = true;
            this.btnPacients.Click += new System.EventHandler(this.btnPacients_Click);
            // 
            // btnNote
            // 
            this.btnNote.Location = new System.Drawing.Point(12, 96);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(417, 36);
            this.btnNote.TabIndex = 2;
            this.btnNote.Text = "Запись";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 144);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnPacients);
            this.Controls.Add(this.btnSotrudniks);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSotrudniks;
        private System.Windows.Forms.Button btnPacients;
        private System.Windows.Forms.Button btnNote;
    }
}