using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComuniItaliani.AmadeiNicola
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //Nicola Amadei 2015 - Comuni Italiani

        //GLOBAL AREA_____________________________//
        List<Comune> comuni = new List<Comune>();
        List<Regione> regioni = new List<Regione>();
        bool comuniCaricati = false, regioniCaricate = false;
        string intestazioneListB = "Nome".PadRight(30) + "Popolaz.".PadRight(12) + "Cod.Reg.".PadRight(10);
        //________________________________________//
        private void frmMain_Load(object sender, EventArgs e)
        {
            //preparo la form
            btnInterroga.Enabled = false;
            cmbSceltaQuery.SelectedIndex = 0;
        }

        private void btnCaricaComuni_Click(object sender, EventArgs e)
        {
            //Utilizzare due bottoni per i due file è ripetitivo, ma rende meglio l'idea ;)  
            try
            {
                StreamReader sr = new StreamReader("comuni.csv");
                //finchè non finisce il file, nessun header nel csv quindi leggo subito comuni
                while (sr.EndOfStream != true)
                {
                    comuni.Add(new Comune(sr.ReadLine()));
                }
                sr.Close();
                //interfaccia interattiva
                comuniCaricati = true;
                btnCaricaComuni.Text = "Comuni OK";
                btnCaricaComuni.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Non è stato possibile caricare il file dei comuni\nControlla e riprova!", "Errore di caricamento");
            }

            //abilito il bottone per eseguire query solo se tutti e due i file sono stati caricati.
            if (comuniCaricati && regioniCaricate)
            {
                btnInterroga.Enabled = true;
            }

        }

        private void btnCaricaRegioni_Click(object sender, EventArgs e)
        {

            try
            {
                StreamReader sr = new StreamReader("regioni.csv");
                //fino alla fine dello stream
                while (sr.EndOfStream != true)
                {
                    regioni.Add(new Regione(sr.ReadLine()));
                }
                sr.Close();
                //interfaccia interattiva
                regioniCaricate = true;
                btnCaricaRegioni.Text = "Regioni OK";
                btnCaricaRegioni.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Non è stato possibile caricare il file delle regioni\nControlla e riprova!", "Errore di caricamento");
            }

            if (comuniCaricati && regioniCaricate)
            {
                btnInterroga.Enabled = true;
            }
        }

        private void btnInterroga_Click(object sender, EventArgs e)
        {
            lstSchermo.Items.Clear();
            switch (cmbSceltaQuery.SelectedIndex)
            {
                case 0: //per nome completo
                    {
                        lstSchermo.Items.Add(intestazioneListB);
                        foreach (Comune c in comuni)
                        {
                            if (c.Nome.ToUpper() == txtParametro.Text.ToUpper())
                            {
                                lstSchermo.Items.Add(c.Visualizzati());
                            }
                        }
                        break;
                    }
                case 1: //per nome paraziale
                    {
                        lstSchermo.Items.Add(intestazioneListB);
                        bool iniziaCon = false, finisceCon = false;
                        string daCercare = "", stringaCompleta = txtParametro.Text;
                        //Prima controllo dove si trova il carattere jolly
                        if (stringaCompleta.Substring(0, 1) == "%")
                        {
                            iniziaCon = true;
                        }
                        if (stringaCompleta.Substring(stringaCompleta.Length - 1, 1) == "%")
                        {
                            finisceCon = true;
                        }
                        //poi valuto i vari casi
                        if (iniziaCon && !finisceCon)
                        {
                            daCercare = stringaCompleta.Substring(1, stringaCompleta.Length - 1);

                            foreach (Comune c in comuni)
                            {
                                if (c.Nome.ToUpper().EndsWith(daCercare.ToUpper()))
                                {
                                    lstSchermo.Items.Add(c.Visualizzati());
                                }
                            }
                        }
                        if (finisceCon && !iniziaCon)
                        {
                            daCercare = stringaCompleta.Substring(0, stringaCompleta.Length - 1);
                            //usiamo un endswith
                            foreach (Comune c in comuni)
                            {
                                if (c.Nome.ToUpper().StartsWith(daCercare.ToUpper()))
                                {
                                    lstSchermo.Items.Add(c.Visualizzati());
                                }
                            }
                        }
                        if (iniziaCon && finisceCon)
                        {
                            daCercare = stringaCompleta.Substring(1, stringaCompleta.Length - 2);
                            //usiamo un contains
                            foreach (Comune c in comuni)
                            {
                                if (c.Nome.ToUpper().Contains(daCercare.ToUpper()))
                                {
                                    lstSchermo.Items.Add(c.Visualizzati());
                                }
                            }
                        }
                        break;
                    }
                case 2: //per regione
                    {
                        lstSchermo.Items.Add(intestazioneListB);
                        int codDaCercare = 0;
                        foreach (Regione r in regioni)
                        {
                            if (r.Nome.ToUpper() == txtParametro.Text.ToUpper())
                            {
                                codDaCercare = r.CodiceRegione;
                                break;
                            }
                        }
                        foreach (Comune c in comuni)
                        {
                            if (c.CodiceRegione == codDaCercare)
                            {
                                lstSchermo.Items.Add(c.Visualizzati());
                            }
                        }
                        break;
                    }
                case 3: //somma popolazione
                    {
                        int codDaCercare = 0;
                        double sommaPopolazione = 0;
                        foreach (Regione r in regioni)
                        {
                            if (r.Nome.ToUpper() == txtParametro.Text.ToUpper())
                            {
                                codDaCercare = r.CodiceRegione;
                                break;
                            }
                        }
                        foreach (Comune c in comuni)
                        {
                            if (c.CodiceRegione == codDaCercare)
                            {
                                sommaPopolazione += c.Popolazione;
                            }
                        }
                        lstSchermo.Items.Add("Popolazione " + sommaPopolazione.ToString());
                        break;
                    }
                case 4: //comune popoloso
                    {
                        lstSchermo.Items.Add(intestazioneListB);
                        int codDaCercare = 0;
                        string comuneMax = "Not found";
                        double maxPop = 0;
                        foreach (Regione r in regioni)
                        {
                            if (r.Nome.ToUpper() == txtParametro.Text.ToUpper())
                            {
                                codDaCercare = r.CodiceRegione;
                                break;
                            }
                        }
                        foreach (Comune c in comuni)
                        {
                            if (c.CodiceRegione == codDaCercare)
                            {
                                //aggiorno sempre il comune più popoloso
                                if (c.Popolazione > maxPop)
                                {
                                    maxPop = c.Popolazione;
                                    comuneMax = c.Visualizzati();
                                }
                            }
                        }
                        lstSchermo.Items.Add(comuneMax);
                        break;
                    }
            }
        }
    }
}
