// REALIZZATO DA FILIPPO GRAZIANO
namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.txtInizio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.Ora = new System.Windows.Forms.ColumnHeader();
            this.Evento = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.Orologio = new System.Windows.Forms.Timer(this.components);
            this.Date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labcounter = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFine2 = new System.Windows.Forms.TextBox();
            this.txtInizio2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(534, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "La tua agenda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.txtFine);
            this.panel1.Controls.Add(this.txtInizio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEvento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 550);
            this.panel1.TabIndex = 1;
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(203, 406);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(69, 23);
            this.txtFine.TabIndex = 12;
            this.txtFine.Text = "00:00";
            this.txtFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInizio
            // 
            this.txtInizio.Location = new System.Drawing.Point(70, 406);
            this.txtInizio.Name = "txtInizio";
            this.txtInizio.Size = new System.Drawing.Size(69, 23);
            this.txtInizio.TabIndex = 11;
            this.txtInizio.Text = "00:00";
            this.txtInizio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Seleziona la data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inserisci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Crea_Appuntamento);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(120, 459);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Tutto il giorno";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.TuttoIlGiorno);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inizio";
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(57, 330);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(227, 23);
            this.txtEvento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evento";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(57, 115);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inserisci nuovo appuntamento";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.Ora,
            this.Evento});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(362, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(890, 478);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 220;
            // 
            // Ora
            // 
            this.Ora.Text = "Ora";
            this.Ora.Width = 220;
            // 
            // Evento
            // 
            this.Evento.Text = "Evento";
            this.Evento.Width = 446;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 657);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data e ora:";
            // 
            // Orologio
            // 
            this.Orologio.Enabled = true;
            this.Orologio.Tick += new System.EventHandler(this.Orologio_Tick);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(78, 657);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(59, 15);
            this.Date.TabIndex = 4;
            this.Date.Text = "data e ora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1089, 657);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Realizzato da Filippo Graziano";
            // 
            // labcounter
            // 
            this.labcounter.Location = new System.Drawing.Point(511, 61);
            this.labcounter.Name = "labcounter";
            this.labcounter.Size = new System.Drawing.Size(243, 15);
            this.labcounter.TabIndex = 6;
            this.labcounter.Text = "Benvenuto. Al momento hai 0 appuntamenti";
            this.labcounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Rimuovi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Rimuovi_Appuntamento);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(362, 583);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 66);
            this.panel2.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 16);
            this.button5.Margin = new System.Windows.Forms.Padding(10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 35);
            this.button5.TabIndex = 10;
            this.button5.Text = "Sposta di una settimana";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Sposta7g_Appuntamento);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(284, 16);
            this.button4.Margin = new System.Windows.Forms.Padding(10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "Sposta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Sposta_Panel);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Inserisci";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Inserisci_Panel);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.txtFine2);
            this.panel3.Controls.Add(this.txtInizio2);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.monthCalendar2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(12, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 550);
            this.panel3.TabIndex = 9;
            this.panel3.Visible = false;
            // 
            // txtFine2
            // 
            this.txtFine2.Location = new System.Drawing.Point(202, 356);
            this.txtFine2.Name = "txtFine2";
            this.txtFine2.Size = new System.Drawing.Size(69, 23);
            this.txtFine2.TabIndex = 18;
            this.txtFine2.Text = "00:00";
            this.txtFine2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInizio2
            // 
            this.txtInizio2.Location = new System.Drawing.Point(69, 356);
            this.txtInizio2.Name = "txtInizio2";
            this.txtInizio2.Size = new System.Drawing.Size(69, 23);
            this.txtInizio2.TabIndex = 17;
            this.txtInizio2.Text = "00:00";
            this.txtInizio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(132, 456);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Sposta";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Sposta_Appuntamento);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(119, 409);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 19);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Tutto il giorno";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fine";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Inizio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Seleziona la data";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(57, 115);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(72, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sposta appuntamento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labcounter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Agenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label8;
        private Button button1;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private TextBox txtEvento;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Label label2;
        private ListView listView1;
        private Label label6;
        private System.Windows.Forms.Timer Orologio;
        private Label Date;
        private Label label7;
        private ColumnHeader Data;
        private ColumnHeader Ora;
        private ColumnHeader Evento;
        private Label labcounter;
        private Button button2;
        private TextBox txtFine;
        private TextBox txtInizio;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Panel panel3;
        private Label label9;
        private TextBox txtFine2;
        private TextBox txtInizio2;
        private Button button6;
        private CheckBox checkBox2;
        private Label label11;
        private Label label12;
        private Label label10;
        private MonthCalendar monthCalendar2;
    }
}
