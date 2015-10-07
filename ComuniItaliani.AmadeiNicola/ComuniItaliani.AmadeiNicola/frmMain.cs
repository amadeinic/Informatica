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

        //GLOBAL AREA
        List<Comune> comuni = new List<Comune>();
        List<Regione> regioni = new List<Regione>();
        bool comuniCaricati = false, regioniCaricate = false;

        private void frmMain_Load(object sender, EventArgs e)
        {
            //preparo la form
            btnInterroga.Enabled = false;
            cmbSceltaQuery.SelectedIndex = 0;
        }

        private void btnCaricaComuni_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("comuni.csv");
            try
            {
                //finchè non finisce il file
                while (sr.EndOfStream != true)
                {
                    comuni.Add(new Comune(sr.ReadLine()));
                }
                //interfaccia interattiva
                comuniCaricati = true;
                btnCaricaComuni.Text = "Comuni OK";
                btnCaricaComuni.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Non è stato possibile caricare il file dei comuni\nControlla e riprova!", "Errore di caricamento");
            }
            finally
            {
                //chiudo in ogni caso
                sr.Close();
            }

            if (comuniCaricati && regioniCaricate)
            {
                btnInterroga.Enabled = true;
            }

        }

        private void btnCaricaRegioni_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("regioni.csv");
            try
            {
                //fino alla fine dello stream
                while (sr.EndOfStream != true)
                {
                    regioni.Add(new Regione(sr.ReadLine()));
                }
                //interfaccia interattiva
                regioniCaricate = true;
                btnCaricaRegioni.Text = "Regioni OK";
                btnCaricaRegioni.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Non è stato possibile caricare il file delle regioni\nControlla e riprova!", "Errore di caricamento");
            }
            finally
            {
                sr.Close();
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
                        foreach (Comune c in comuni)
                        {
                            if (c.Nome.ToUpper().Contains(txtParametro.Text.ToUpper()))
                            {
                                lstSchermo.Items.Add(c.Visualizzati());
                            }
                        }
                        break;

                    }
                case 2: //per regione
                    {
                        int codDaCercare = 0;
                        foreach (Regione r in regioni)
                        {
                            if (r.Nome.ToUpper() == txtParametro.Text.ToUpper())
                            {
                                codDaCercare = r.CodiceRegione;
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
                        int codDaCercare = 0;
                        string comuneMax = "";
                        double maxPop = 0;
                        foreach (Regione r in regioni)
                        {
                            if (r.Nome.ToUpper() == txtParametro.Text.ToUpper())
                            {
                                codDaCercare = r.CodiceRegione;
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
                                    comuneMax = c.Nome;
                                }
                            }
                        }
                        //visualizzo
                        foreach (Comune c in comuni)
                        {
                            if (c.Nome == comuneMax)
                            {
                                lstSchermo.Items.Add(c.Visualizzati());
                            }
                        }
                        break;
                    }
            }
        }
    }
}
