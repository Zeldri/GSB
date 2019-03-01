namespace GSBApp
{
    partial class redigerRapport
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
            this.labelNumRap = new System.Windows.Forms.Label();
            this.labelPraticien = new System.Windows.Forms.Label();
            this.labelDateRap = new System.Windows.Forms.Label();
            this.labelMotif = new System.Windows.Forms.Label();
            this.labelBilan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxPraticien = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRapport = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.labelOffreEchant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(288, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapports de visite";
            // 
            // labelNumRap
            // 
            this.labelNumRap.AutoSize = true;
            this.labelNumRap.Location = new System.Drawing.Point(58, 94);
            this.labelNumRap.Name = "labelNumRap";
            this.labelNumRap.Size = new System.Drawing.Size(80, 13);
            this.labelNumRap.TabIndex = 1;
            this.labelNumRap.Text = "Numéro rapport";
            // 
            // labelPraticien
            // 
            this.labelPraticien.AutoSize = true;
            this.labelPraticien.Location = new System.Drawing.Point(58, 123);
            this.labelPraticien.Name = "labelPraticien";
            this.labelPraticien.Size = new System.Drawing.Size(48, 13);
            this.labelPraticien.TabIndex = 2;
            this.labelPraticien.Text = "Praticien";
            // 
            // labelDateRap
            // 
            this.labelDateRap.AutoSize = true;
            this.labelDateRap.Location = new System.Drawing.Point(58, 153);
            this.labelDateRap.Name = "labelDateRap";
            this.labelDateRap.Size = new System.Drawing.Size(71, 13);
            this.labelDateRap.TabIndex = 3;
            this.labelDateRap.Text = "Date Rapport";
            // 
            // labelMotif
            // 
            this.labelMotif.AutoSize = true;
            this.labelMotif.Location = new System.Drawing.Point(58, 185);
            this.labelMotif.Name = "labelMotif";
            this.labelMotif.Size = new System.Drawing.Size(58, 13);
            this.labelMotif.TabIndex = 4;
            this.labelMotif.Text = "Motif Visite";
            // 
            // labelBilan
            // 
            this.labelBilan.AutoSize = true;
            this.labelBilan.Location = new System.Drawing.Point(58, 212);
            this.labelBilan.Name = "labelBilan";
            this.labelBilan.Size = new System.Drawing.Size(38, 13);
            this.labelBilan.TabIndex = 5;
            this.labelBilan.Text = "BILAN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(221, 212);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(286, 159);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // comboBoxPraticien
            // 
            this.comboBoxPraticien.FormattingEnabled = true;
            this.comboBoxPraticien.Location = new System.Drawing.Point(221, 123);
            this.comboBoxPraticien.Name = "comboBoxPraticien";
            this.comboBoxPraticien.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPraticien.TabIndex = 8;
            // 
            // dateTimePickerRapport
            // 
            this.dateTimePickerRapport.Location = new System.Drawing.Point(221, 153);
            this.dateTimePickerRapport.Name = "dateTimePickerRapport";
            this.dateTimePickerRapport.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRapport.TabIndex = 9;
            this.dateTimePickerRapport.ValueChanged += new System.EventHandler(this.dateTimePickerRapport_ValueChanged);
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(221, 185);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMotif.TabIndex = 10;
            // 
            // labelOffreEchant
            // 
            this.labelOffreEchant.AutoSize = true;
            this.labelOffreEchant.Location = new System.Drawing.Point(532, 93);
            this.labelOffreEchant.Name = "labelOffreEchant";
            this.labelOffreEchant.Size = new System.Drawing.Size(97, 13);
            this.labelOffreEchant.TabIndex = 11;
            this.labelOffreEchant.Text = "Offre d\'échantillons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // redigerRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOffreEchant);
            this.Controls.Add(this.comboBoxMotif);
            this.Controls.Add(this.dateTimePickerRapport);
            this.Controls.Add(this.comboBoxPraticien);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBilan);
            this.Controls.Add(this.labelMotif);
            this.Controls.Add(this.labelDateRap);
            this.Controls.Add(this.labelPraticien);
            this.Controls.Add(this.labelNumRap);
            this.Controls.Add(this.label1);
            this.Name = "redigerRapport";
            this.Text = " ";
            this.Load += new System.EventHandler(this.redigerRapport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumRap;
        private System.Windows.Forms.Label labelPraticien;
        private System.Windows.Forms.Label labelDateRap;
        private System.Windows.Forms.Label labelMotif;
        private System.Windows.Forms.Label labelBilan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxPraticien;
        private System.Windows.Forms.DateTimePicker dateTimePickerRapport;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.Label labelOffreEchant;
        private System.Windows.Forms.Label label2;
    }
}