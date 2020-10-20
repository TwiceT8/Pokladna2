namespace Pokladna
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxMesic = new System.Windows.Forms.ComboBox();
            this.cBoxRok = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPopis = new System.Windows.Forms.TextBox();
            this.txtDoklad = new System.Windows.Forms.TextBox();
            this.numericCastka = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPoznamka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUloz = new System.Windows.Forms.Button();
            this.btnNovy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCastka)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(851, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Číslo dokladu";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Popis";
            this.columnHeader3.Width = 163;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Příjmy";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Výdaje";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zůstatek";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Poznámka";
            this.columnHeader7.Width = 87;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(571, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 450);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBoxMesic);
            this.groupBox1.Controls.Add(this.cBoxRok);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Účetní období";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Měsíc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rok";
            // 
            // cBoxMesic
            // 
            this.cBoxMesic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMesic.FormattingEnabled = true;
            this.cBoxMesic.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen",
            "Červenec",
            "Spren",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
            this.cBoxMesic.Location = new System.Drawing.Point(152, 46);
            this.cBoxMesic.Name = "cBoxMesic";
            this.cBoxMesic.Size = new System.Drawing.Size(95, 21);
            this.cBoxMesic.TabIndex = 1;
            this.cBoxMesic.SelectedIndexChanged += new System.EventHandler(this.cBoxRok_SelectedIndexChanged);
            // 
            // cBoxRok
            // 
            this.cBoxRok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRok.FormattingEnabled = true;
            this.cBoxRok.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cBoxRok.Location = new System.Drawing.Point(152, 19);
            this.cBoxRok.Name = "cBoxRok";
            this.cBoxRok.Size = new System.Drawing.Size(95, 21);
            this.cBoxRok.TabIndex = 0;
            this.cBoxRok.SelectedIndexChanged += new System.EventHandler(this.cBoxRok_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovy);
            this.groupBox2.Controls.Add(this.btnUloz);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPoznamka);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericCastka);
            this.groupBox2.Controls.Add(this.txtDoklad);
            this.groupBox2.Controls.Add(this.txtPopis);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtp);
            this.groupBox2.Location = new System.Drawing.Point(4, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Položka";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(83, 19);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(164, 20);
            this.dtp.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Č. dokladu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Popis";
            // 
            // txtPopis
            // 
            this.txtPopis.Location = new System.Drawing.Point(83, 71);
            this.txtPopis.Name = "txtPopis";
            this.txtPopis.Size = new System.Drawing.Size(164, 20);
            this.txtPopis.TabIndex = 5;
            this.txtPopis.TextChanged += new System.EventHandler(this.txtPopis_TextChanged);
            // 
            // txtDoklad
            // 
            this.txtDoklad.Location = new System.Drawing.Point(83, 45);
            this.txtDoklad.Name = "txtDoklad";
            this.txtDoklad.ReadOnly = true;
            this.txtDoklad.Size = new System.Drawing.Size(164, 20);
            this.txtDoklad.TabIndex = 6;
            this.txtDoklad.TextChanged += new System.EventHandler(this.txtDoklad_TextChanged);
            // 
            // numericCastka
            // 
            this.numericCastka.Location = new System.Drawing.Point(84, 97);
            this.numericCastka.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericCastka.Minimum = new decimal(new int[] {
            200000,
            0,
            0,
            -2147483648});
            this.numericCastka.Name = "numericCastka";
            this.numericCastka.Size = new System.Drawing.Size(163, 20);
            this.numericCastka.TabIndex = 7;
            this.numericCastka.ValueChanged += new System.EventHandler(this.numericCastka_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Částka";
            // 
            // txtPoznamka
            // 
            this.txtPoznamka.Location = new System.Drawing.Point(83, 123);
            this.txtPoznamka.Name = "txtPoznamka";
            this.txtPoznamka.Size = new System.Drawing.Size(164, 20);
            this.txtPoznamka.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Poznámka";
            // 
            // btnUloz
            // 
            this.btnUloz.Enabled = false;
            this.btnUloz.Location = new System.Drawing.Point(164, 149);
            this.btnUloz.Name = "btnUloz";
            this.btnUloz.Size = new System.Drawing.Size(83, 37);
            this.btnUloz.TabIndex = 11;
            this.btnUloz.Text = "Uložit";
            this.btnUloz.UseVisualStyleBackColor = true;
            // 
            // btnNovy
            // 
            this.btnNovy.Enabled = false;
            this.btnNovy.Location = new System.Drawing.Point(83, 149);
            this.btnNovy.Name = "btnNovy";
            this.btnNovy.Size = new System.Drawing.Size(83, 37);
            this.btnNovy.TabIndex = 11;
            this.btnNovy.Text = "Nový";
            this.btnNovy.UseVisualStyleBackColor = true;
            this.btnNovy.Click += new System.EventHandler(this.btnNovy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCastka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxMesic;
        private System.Windows.Forms.ComboBox cBoxRok;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovy;
        private System.Windows.Forms.Button btnUloz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPoznamka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericCastka;
        private System.Windows.Forms.TextBox txtDoklad;
        private System.Windows.Forms.TextBox txtPopis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}

