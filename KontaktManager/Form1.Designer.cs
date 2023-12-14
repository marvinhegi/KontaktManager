namespace KontaktManager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonListeLoschen = new System.Windows.Forms.Button();
            this.buttonImportcsv = new System.Windows.Forms.Button();
            this.buttonExportcsv = new System.Windows.Forms.Button();
            this.dataGridViewKontakte = new System.Windows.Forms.DataGridView();
            this.labelneuerKontakt = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.buttonhinzufugen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListeLoschen
            // 
            this.buttonListeLoschen.Location = new System.Drawing.Point(12, 12);
            this.buttonListeLoschen.Name = "buttonListeLoschen";
            this.buttonListeLoschen.Size = new System.Drawing.Size(122, 42);
            this.buttonListeLoschen.TabIndex = 0;
            this.buttonListeLoschen.Text = "Liste Löschen";
            this.buttonListeLoschen.UseVisualStyleBackColor = true;
            this.buttonListeLoschen.Click += new System.EventHandler(this.buttonListeLoschen_Click);
            // 
            // buttonImportcsv
            // 
            this.buttonImportcsv.Location = new System.Drawing.Point(505, 12);
            this.buttonImportcsv.Name = "buttonImportcsv";
            this.buttonImportcsv.Size = new System.Drawing.Size(122, 42);
            this.buttonImportcsv.TabIndex = 1;
            this.buttonImportcsv.Text = "Import csv";
            this.buttonImportcsv.UseVisualStyleBackColor = true;
            this.buttonImportcsv.Click += new System.EventHandler(this.buttonImportcsv_Click);
            // 
            // buttonExportcsv
            // 
            this.buttonExportcsv.Location = new System.Drawing.Point(633, 12);
            this.buttonExportcsv.Name = "buttonExportcsv";
            this.buttonExportcsv.Size = new System.Drawing.Size(122, 42);
            this.buttonExportcsv.TabIndex = 2;
            this.buttonExportcsv.Text = "Export csv";
            this.buttonExportcsv.UseVisualStyleBackColor = true;
            this.buttonExportcsv.Click += new System.EventHandler(this.buttonExportcsv_Click);
            // 
            // dataGridViewKontakte
            // 
            this.dataGridViewKontakte.AllowUserToAddRows = false;
            this.dataGridViewKontakte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKontakte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontakte.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewKontakte.Name = "dataGridViewKontakte";
            this.dataGridViewKontakte.ReadOnly = true;
            this.dataGridViewKontakte.RowHeadersWidth = 51;
            this.dataGridViewKontakte.RowTemplate.Height = 24;
            this.dataGridViewKontakte.Size = new System.Drawing.Size(743, 360);
            this.dataGridViewKontakte.TabIndex = 3;
            // 
            // labelneuerKontakt
            // 
            this.labelneuerKontakt.AutoSize = true;
            this.labelneuerKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelneuerKontakt.Location = new System.Drawing.Point(12, 451);
            this.labelneuerKontakt.Name = "labelneuerKontakt";
            this.labelneuerKontakt.Size = new System.Drawing.Size(115, 20);
            this.labelneuerKontakt.TabIndex = 4;
            this.labelneuerKontakt.Text = "Neuer Kontakt";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(151, 488);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(604, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(75, 491);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 16);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(151, 543);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(604, 22);
            this.textBoxEmail.TabIndex = 7;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(75, 543);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(45, 16);
            this.labelemail.TabIndex = 8;
            this.labelemail.Text = "E-Mail";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(151, 586);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(604, 22);
            this.textBoxPhone.TabIndex = 9;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(75, 586);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(46, 16);
            this.labelPhone.TabIndex = 10;
            this.labelPhone.Text = "Phone";
            // 
            // buttonhinzufugen
            // 
            this.buttonhinzufugen.Location = new System.Drawing.Point(587, 626);
            this.buttonhinzufugen.Name = "buttonhinzufugen";
            this.buttonhinzufugen.Size = new System.Drawing.Size(168, 42);
            this.buttonhinzufugen.TabIndex = 11;
            this.buttonhinzufugen.Text = "Hinzufügen";
            this.buttonhinzufugen.UseVisualStyleBackColor = true;
            this.buttonhinzufugen.Click += new System.EventHandler(this.buttonhinzufugen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 712);
            this.Controls.Add(this.buttonhinzufugen);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelneuerKontakt);
            this.Controls.Add(this.dataGridViewKontakte);
            this.Controls.Add(this.buttonExportcsv);
            this.Controls.Add(this.buttonImportcsv);
            this.Controls.Add(this.buttonListeLoschen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListeLoschen;
        private System.Windows.Forms.Button buttonImportcsv;
        private System.Windows.Forms.Button buttonExportcsv;
        private System.Windows.Forms.DataGridView dataGridViewKontakte;
        private System.Windows.Forms.Label labelneuerKontakt;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button buttonhinzufugen;
    }
}

