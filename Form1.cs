// REALIZZATO DA FILIPPO GRAZIANO
using System;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Mostra il numero di appuntamenti in agenda
        private void Counter_Appuntamenti()
        {
            if (listView1.Items.Count != 1)
            {
                labcounter.Text = "Al momento hai " + listView1.Items.Count.ToString() + " appuntamenti";
            }
            else
            {
                labcounter.Text = "Al momento hai 1 appuntamento";
            }
        }

        // Fa durare un appuntamento tutto il giorno
        private void TuttoIlGiorno(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Visible = false;
                label5.Visible = false;
                txtInizio.Visible = false;
                txtFine.Visible = false;
            }
            else
            {
                label4.Visible = true;
                label5.Visible = true;
                txtInizio.Text = "00:00";
                txtFine.Text = "00:00";
                txtInizio.Visible = true;
                txtFine.Visible = true;
            }
        }

        // Crea nuovo appuntamento
        private void Crea_Appuntamento(object sender, EventArgs e)
        {
            string data = monthCalendar1.SelectionRange.Start.ToShortDateString();

            if (string.IsNullOrWhiteSpace(txtEvento.Text))
            {
                MessageBox.Show("Riempire il campo Evento");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInizio.Text))
            {
                MessageBox.Show("Riempire il campo Inizio");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFine.Text))
            {
                MessageBox.Show("Riempire il campo Fine");
                return;
            }

            ListViewItem appuntamento = new ListViewItem(data);
            if (checkBox1.Checked)
            {
                appuntamento.SubItems.Add("Tutto il giorno");
            }
            else
            {
                appuntamento.SubItems.Add("Dalle ore " + txtInizio.Text + " alle " + txtFine.Text);
            }
            appuntamento.SubItems.Add(txtEvento.Text);
            listView1.Items.Add(appuntamento);

            // Pulisce i campi
            txtEvento.Clear();
            txtInizio.Text = "00:00";
            txtFine.Text = "00:00";

            // Aggiorna counter appuntamenti
            Counter_Appuntamenti();
        }

        // Pulsante Inserisci apre il panel per inserire un nuovo appuntamento
        private void Inserisci_Panel(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
        }

        // Pulsante Sposta apre il panel per spostare un appuntamento
        private void Sposta_Panel(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
        }

        // Sposta l'appuntamento selezionato alla data scelta
        private void Sposta_Appuntamento(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                string data = monthCalendar2.SelectionRange.Start.ToShortDateString();

                listView1.SelectedItems[0].Text = data;
                if (checkBox2.Checked)
                {
                    listView1.SelectedItems[0].SubItems[1].Text = "Tutto il giorno";
                }
                else
                {
                    listView1.SelectedItems[0].SubItems[1].Text =
                        "Dalle ore " + txtInizio2.Text + " alle " + txtFine2.Text;
                }
            }
            // Pulisce i campi
            txtInizio2.Text = "00:00";
            txtFine2.Text = "00:00";
        }

        // Sposta di una settimana l'appuntamento selezionato
        private void Sposta7g_Appuntamento(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                DateTime day = Convert.ToDateTime(listView1.SelectedItems[0].Text);

                DateTime giorniAggiunti = day.AddDays(7);
                var giorni = giorniAggiunti.ToString("dd/MM/yyyy");

                listView1.SelectedItems[0].Text = giorni.ToString();
            }
        }

        // Rimuove l'appuntamento selezionato dalla lista
        private void Rimuovi_Appuntamento(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

            // Aggiorna counter appuntamenti
            Counter_Appuntamenti();
        }

        // Gestisce l'ora
        private void Orologio_Tick(object sender, EventArgs e)
        { AggiornaOra(); }

        private void AggiornaOra()
        { Date.Text = DateTime.Now.ToString("G"); }
    }
}


// CLASSI

// CLASSE CALENDARIO
public class Calendario
{
    private int _giorno;
    public int Giorno
    {
        get { return _giorno; }
        set
        {
            if (value < 1 || value > 31)
                throw new Exception("ERRORE: giorno");
            this._giorno = value;
        }
    }

    private int _mese;
    public int Mese
    {
        get { return _mese; }
        set
        {
            if (value < 1 || value > 12)
                throw new Exception("ERRORE: mese");
            this._mese = value;
        }
    }

    private int _anno;
    public int Anno
    {
        get { return _anno; }
        set
        {
            if (value < 2000)
                throw new Exception("ERRORE: anno");
            this._anno = value;
        }
    }

    private int _oraInizio;
    public int Ora
    {
        get { return _oraInizio; }
        set
        {
            if (value < 0 || value > 23)
                throw new Exception("ERRORE: ora mancante");
            this._oraInizio = value;
        }
    }

    private int _oraFine;
    public int Minuti
    {
        get { return _oraFine; }
        set
        {
            if (value < 0 || value > 59)
                throw new Exception("ERRORE: minuti mancante");
            this._oraFine = value;
        }
    }
}

//CLASSE APPUNTAMENTO
public class Appuntamento
{
    public Calendario Data { get; set; }

    private string _descrizione;
    public string Descrizione
    {
        get { return _descrizione; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("ERRORE: descrizione mancante");
            this._descrizione = value;
        }
    }
}

//CLASSE AGENDA
public class Agendaa
{
    private List<Appuntamento> _appuntamenti;
    public List<Appuntamento> Appuntamenti
    {
        get { return _appuntamenti; }
        set { this._appuntamenti = value; }
    }
}