namespace Vrachi
{
    partial class EditSotrudnikForm
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
            this.btnEditSotrudnik = new System.Windows.Forms.Button();
            this.txtEndWork = new System.Windows.Forms.MaskedTextBox();
            this.txtStartWork = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCabNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditSotrudnik
            // 
            this.btnEditSotrudnik.Location = new System.Drawing.Point(36, 129);
            this.btnEditSotrudnik.Name = "btnEditSotrudnik";
            this.btnEditSotrudnik.Size = new System.Drawing.Size(164, 29);
            this.btnEditSotrudnik.TabIndex = 23;
            this.btnEditSotrudnik.Text = "Сохранить";
            this.btnEditSotrudnik.UseVisualStyleBackColor = true;
            this.btnEditSotrudnik.Click += new System.EventHandler(this.btnEditSotrudnik_Click);
            // 
            // txtEndWork
            // 
            this.txtEndWork.Location = new System.Drawing.Point(525, 50);
            this.txtEndWork.Mask = "00:00";
            this.txtEndWork.Name = "txtEndWork";
            this.txtEndWork.Size = new System.Drawing.Size(34, 20);
            this.txtEndWork.TabIndex = 22;
            // 
            // txtStartWork
            // 
            this.txtStartWork.Location = new System.Drawing.Point(416, 50);
            this.txtStartWork.Mask = "00:00";
            this.txtStartWork.Name = "txtStartWork";
            this.txtStartWork.Size = new System.Drawing.Size(35, 20);
            this.txtStartWork.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Конец работы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Начало работы:";
            // 
            // txtCabNumber
            // 
            this.txtCabNumber.Location = new System.Drawing.Point(261, 50);
            this.txtCabNumber.Name = "txtCabNumber";
            this.txtCabNumber.Size = new System.Drawing.Size(111, 20);
            this.txtCabNumber.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Номер кабинета:";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(144, 50);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(111, 20);
            this.txtSpec.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Специальность:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(27, 50);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(111, 20);
            this.txtFullName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ФИО:";
            // 
            // EditSotrudnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 183);
            this.Controls.Add(this.btnEditSotrudnik);
            this.Controls.Add(this.txtEndWork);
            this.Controls.Add(this.txtStartWork);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCabNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Name = "EditSotrudnikForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование сотрудника";
            this.Load += new System.EventHandler(this.EditSotrudnikForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditSotrudnik;
        private System.Windows.Forms.MaskedTextBox txtEndWork;
        private System.Windows.Forms.MaskedTextBox txtStartWork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCabNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
    }
}