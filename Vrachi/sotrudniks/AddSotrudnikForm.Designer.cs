namespace Vrachi
{
    partial class AddSotrudnikForm
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCabNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartWork = new System.Windows.Forms.MaskedTextBox();
            this.txtEndWork = new System.Windows.Forms.MaskedTextBox();
            this.btnAddSotrudnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(12, 69);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(111, 20);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(129, 69);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(111, 20);
            this.txtSpec.TabIndex = 3;
            this.txtSpec.TextChanged += new System.EventHandler(this.txtSpec_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Специальность:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCabNumber
            // 
            this.txtCabNumber.Location = new System.Drawing.Point(246, 69);
            this.txtCabNumber.Name = "txtCabNumber";
            this.txtCabNumber.Size = new System.Drawing.Size(111, 20);
            this.txtCabNumber.TabIndex = 5;
            this.txtCabNumber.TextChanged += new System.EventHandler(this.txtCabNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер кабинета:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Начало работы:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Конец работы:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtStartWork
            // 
            this.txtStartWork.Location = new System.Drawing.Point(401, 69);
            this.txtStartWork.Mask = "00:00";
            this.txtStartWork.Name = "txtStartWork";
            this.txtStartWork.Size = new System.Drawing.Size(35, 20);
            this.txtStartWork.TabIndex = 10;
            this.txtStartWork.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtStartWork_MaskInputRejected);
            // 
            // txtEndWork
            // 
            this.txtEndWork.Location = new System.Drawing.Point(510, 69);
            this.txtEndWork.Mask = "00:00";
            this.txtEndWork.Name = "txtEndWork";
            this.txtEndWork.Size = new System.Drawing.Size(34, 20);
            this.txtEndWork.TabIndex = 11;
            this.txtEndWork.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtEndWork_MaskInputRejected);
            // 
            // btnAddSotrudnik
            // 
            this.btnAddSotrudnik.Location = new System.Drawing.Point(76, 149);
            this.btnAddSotrudnik.Name = "btnAddSotrudnik";
            this.btnAddSotrudnik.Size = new System.Drawing.Size(164, 29);
            this.btnAddSotrudnik.TabIndex = 12;
            this.btnAddSotrudnik.Text = "Добавить";
            this.btnAddSotrudnik.UseVisualStyleBackColor = true;
            this.btnAddSotrudnik.Click += new System.EventHandler(this.btnAddSotrudnik_Click);
            // 
            // AddSotrudnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 194);
            this.Controls.Add(this.btnAddSotrudnik);
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
            this.Name = "AddSotrudnikForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCabNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtStartWork;
        private System.Windows.Forms.MaskedTextBox txtEndWork;
        private System.Windows.Forms.Button btnAddSotrudnik;
    }
}