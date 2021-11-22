
namespace WindowsForms_Auto_Nyilv
{
    partial class Form1
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
            this.label_cim = new System.Windows.Forms.Label();
            this.label_Rendszam = new System.Windows.Forms.Label();
            this.label_Gyartmany = new System.Windows.Forms.Label();
            this.label_Tipus = new System.Windows.Forms.Label();
            this.label_Uz_Datum = new System.Windows.Forms.Label();
            this.label_Szin = new System.Windows.Forms.Label();
            this.label_Muszaki = new System.Windows.Forms.Label();
            this.textBox_Rendszam = new System.Windows.Forms.TextBox();
            this.comboBox_Gyartmany = new System.Windows.Forms.ComboBox();
            this.comboBox_Tipus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Uz_Datum = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Szin = new System.Windows.Forms.ComboBox();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.checkBox_Muszaki = new System.Windows.Forms.CheckBox();
            this.button_vosszatolt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_cim
            // 
            this.label_cim.AutoSize = true;
            this.label_cim.Location = new System.Drawing.Point(383, 45);
            this.label_cim.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_cim.Name = "label_cim";
            this.label_cim.Size = new System.Drawing.Size(216, 29);
            this.label_cim.TabIndex = 0;
            this.label_cim.Text = "Autó nyilvántartás";
            // 
            // label_Rendszam
            // 
            this.label_Rendszam.AutoSize = true;
            this.label_Rendszam.Location = new System.Drawing.Point(134, 133);
            this.label_Rendszam.Name = "label_Rendszam";
            this.label_Rendszam.Size = new System.Drawing.Size(135, 29);
            this.label_Rendszam.TabIndex = 1;
            this.label_Rendszam.Text = "Rendszám";
            // 
            // label_Gyartmany
            // 
            this.label_Gyartmany.AutoSize = true;
            this.label_Gyartmany.Location = new System.Drawing.Point(134, 190);
            this.label_Gyartmany.Name = "label_Gyartmany";
            this.label_Gyartmany.Size = new System.Drawing.Size(135, 29);
            this.label_Gyartmany.TabIndex = 2;
            this.label_Gyartmany.Text = "Gyártmány";
            // 
            // label_Tipus
            // 
            this.label_Tipus.AutoSize = true;
            this.label_Tipus.Location = new System.Drawing.Point(134, 241);
            this.label_Tipus.Name = "label_Tipus";
            this.label_Tipus.Size = new System.Drawing.Size(79, 29);
            this.label_Tipus.TabIndex = 3;
            this.label_Tipus.Text = "Típus";
            // 
            // label_Uz_Datum
            // 
            this.label_Uz_Datum.AutoSize = true;
            this.label_Uz_Datum.Location = new System.Drawing.Point(134, 289);
            this.label_Uz_Datum.Name = "label_Uz_Datum";
            this.label_Uz_Datum.Size = new System.Drawing.Size(304, 29);
            this.label_Uz_Datum.TabIndex = 4;
            this.label_Uz_Datum.Text = "Üzembehelyezés dátuma";
            // 
            // label_Szin
            // 
            this.label_Szin.AutoSize = true;
            this.label_Szin.Location = new System.Drawing.Point(134, 338);
            this.label_Szin.Name = "label_Szin";
            this.label_Szin.Size = new System.Drawing.Size(63, 29);
            this.label_Szin.TabIndex = 5;
            this.label_Szin.Text = "Szín";
            // 
            // label_Muszaki
            // 
            this.label_Muszaki.AutoSize = true;
            this.label_Muszaki.Location = new System.Drawing.Point(134, 390);
            this.label_Muszaki.Name = "label_Muszaki";
            this.label_Muszaki.Size = new System.Drawing.Size(403, 29);
            this.label_Muszaki.TabIndex = 6;
            this.label_Muszaki.Text = "Érvényes műszakival rendelkezik:";
            // 
            // textBox_Rendszam
            // 
            this.textBox_Rendszam.Location = new System.Drawing.Point(565, 130);
            this.textBox_Rendszam.Name = "textBox_Rendszam";
            this.textBox_Rendszam.Size = new System.Drawing.Size(159, 34);
            this.textBox_Rendszam.TabIndex = 7;
            // 
            // comboBox_Gyartmany
            // 
            this.comboBox_Gyartmany.FormattingEnabled = true;
            this.comboBox_Gyartmany.Items.AddRange(new object[] {
            "Suzuki",
            "Toyota",
            "Opel"});
            this.comboBox_Gyartmany.Location = new System.Drawing.Point(565, 187);
            this.comboBox_Gyartmany.Name = "comboBox_Gyartmany";
            this.comboBox_Gyartmany.Size = new System.Drawing.Size(159, 37);
            this.comboBox_Gyartmany.TabIndex = 9;
            // 
            // comboBox_Tipus
            // 
            this.comboBox_Tipus.FormattingEnabled = true;
            this.comboBox_Tipus.Items.AddRange(new object[] {
            "Swift",
            "Ignis",
            "Yaris",
            "Corolla",
            "Corsa",
            "Vectra"});
            this.comboBox_Tipus.Location = new System.Drawing.Point(565, 238);
            this.comboBox_Tipus.Name = "comboBox_Tipus";
            this.comboBox_Tipus.Size = new System.Drawing.Size(159, 37);
            this.comboBox_Tipus.TabIndex = 10;
            // 
            // dateTimePicker_Uz_Datum
            // 
            this.dateTimePicker_Uz_Datum.Location = new System.Drawing.Point(565, 284);
            this.dateTimePicker_Uz_Datum.Name = "dateTimePicker_Uz_Datum";
            this.dateTimePicker_Uz_Datum.Size = new System.Drawing.Size(275, 34);
            this.dateTimePicker_Uz_Datum.TabIndex = 11;
            // 
            // comboBox_Szin
            // 
            this.comboBox_Szin.FormattingEnabled = true;
            this.comboBox_Szin.Items.AddRange(new object[] {
            "Piros",
            "Fekete",
            "Fehér",
            "Szürke",
            "Kék"});
            this.comboBox_Szin.Location = new System.Drawing.Point(565, 335);
            this.comboBox_Szin.Name = "comboBox_Szin";
            this.comboBox_Szin.Size = new System.Drawing.Size(159, 37);
            this.comboBox_Szin.TabIndex = 12;
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(184, 509);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(147, 51);
            this.button_Mentes.TabIndex = 15;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // checkBox_Muszaki
            // 
            this.checkBox_Muszaki.AutoSize = true;
            this.checkBox_Muszaki.Location = new System.Drawing.Point(565, 397);
            this.checkBox_Muszaki.Name = "checkBox_Muszaki";
            this.checkBox_Muszaki.Size = new System.Drawing.Size(18, 17);
            this.checkBox_Muszaki.TabIndex = 16;
            this.checkBox_Muszaki.UseVisualStyleBackColor = true;
            // 
            // button_vosszatolt
            // 
            this.button_vosszatolt.Location = new System.Drawing.Point(471, 509);
            this.button_vosszatolt.Name = "button_vosszatolt";
            this.button_vosszatolt.Size = new System.Drawing.Size(178, 51);
            this.button_vosszatolt.TabIndex = 17;
            this.button_vosszatolt.Text = "Visszatöltés";
            this.button_vosszatolt.UseVisualStyleBackColor = true;
            this.button_vosszatolt.Click += new System.EventHandler(this.button_vosszatolt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 617);
            this.Controls.Add(this.button_vosszatolt);
            this.Controls.Add(this.checkBox_Muszaki);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.comboBox_Szin);
            this.Controls.Add(this.dateTimePicker_Uz_Datum);
            this.Controls.Add(this.comboBox_Tipus);
            this.Controls.Add(this.comboBox_Gyartmany);
            this.Controls.Add(this.textBox_Rendszam);
            this.Controls.Add(this.label_Muszaki);
            this.Controls.Add(this.label_Szin);
            this.Controls.Add(this.label_Uz_Datum);
            this.Controls.Add(this.label_Tipus);
            this.Controls.Add(this.label_Gyartmany);
            this.Controls.Add(this.label_Rendszam);
            this.Controls.Add(this.label_cim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cim;
        private System.Windows.Forms.Label label_Rendszam;
        private System.Windows.Forms.Label label_Gyartmany;
        private System.Windows.Forms.Label label_Tipus;
        private System.Windows.Forms.Label label_Uz_Datum;
        private System.Windows.Forms.Label label_Szin;
        private System.Windows.Forms.Label label_Muszaki;
        private System.Windows.Forms.TextBox textBox_Rendszam;
        private System.Windows.Forms.ComboBox comboBox_Gyartmany;
        private System.Windows.Forms.ComboBox comboBox_Tipus;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Uz_Datum;
        private System.Windows.Forms.ComboBox comboBox_Szin;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.CheckBox checkBox_Muszaki;
        private System.Windows.Forms.Button button_vosszatolt;
    }
}

