using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace amadei.nicola._5H.Aeroporti
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //GLOBAL AREA
        DataTable dtAer, dtVolo;




        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbModalita.SelectedIndex = 0;
            //Questa query seleziona tutti gli elementi dalla tabella Questions, che è il nome del foglio di lavoro Excel.
            string queryAer = "SELECT * FROM [Aeroporti$]";
            string queryVolo = "SELECT * FROM [Voli$]";
            //La stringa di connessione varia a seconda del tipo della connessione stessa, questa va bene per un file .xls classico. http://www.connectionstrings.com/
            string strConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=icao.xls;Extended Properties=Excel 8.0;";

            //METODO COMPLETO
            //In questo modo prima creiamo la connessione esplicitamente, passando come parametro la strinag di connessione.
            OleDbConnection cnn = new OleDbConnection(strConnessione);
            OleDbDataAdapter da = new OleDbDataAdapter(queryAer, cnn);
            dtAer = new DataTable();                          
            da.Fill(dtAer);
            dtVolo = new DataTable();
            da = new OleDbDataAdapter(queryVolo, cnn);
            da.Fill(dtVolo);
        }

        public string GetNomeEsteso(string codICAO)
        {
            foreach(DataRow dr in dtAer.Rows)
            {
                if(codICAO==dr[0].ToString())
                {
                    return dr[4].ToString();
                }
            }
            return "NOPE";
            
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            dgvSchermo.Rows.Clear();
            dgvSchermo.Columns.Clear();
            int cont = 0;
            switch (cmbModalita.SelectedIndex)
            {
                case 0:
                    {
                        //Parte controllo datagrid
                        dgvSchermo.Columns.Add("clmVolo", "Codice Volo");
                        dgvSchermo.Columns.Add("clmPart", "Partenza");
                        dgvSchermo.Columns.Add("clmDest", "Destinazione");
                        foreach (DataGridViewColumn c in dgvSchermo.Columns)
                        {
                            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }

                        foreach (DataRow r in dtVolo.Rows)
                        {
                            if (r[0].ToString() == txtVolo.Text)
                            {
                                dgvSchermo.Rows.Add();
                                dgvSchermo.Rows[cont].Cells[0].Value = txtVolo.Text;
                                dgvSchermo.Rows[cont].Cells[1].Value = GetNomeEsteso(r[1].ToString());
                                dgvSchermo.Rows[cont].Cells[2].Value = GetNomeEsteso(r[2].ToString());
                                //Cont identifica la riga datagrid
                                cont++;
                                break;
                            }
                        }

                        break;
                    }
                case 1:
                    {
                        
                        break;
                    }
                case 2:
                    {
                        
                        break;
                    }
            }
        }

        private void cmbModalita_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbModalita.SelectedIndex)
            {
                case 0:
                    {
                        txtAero1.Enabled = false;
                        txtAero2.Enabled = false;
                        txtVolo.Enabled = true;
                        break;
                    }
                case 1:
                    {
                        txtAero1.Enabled = true;
                        txtAero2.Enabled = false;
                        txtVolo.Enabled = false;
                        break;      
                    }
                case 2:
                    {
                        txtAero1.Enabled = true;
                        txtAero2.Enabled = true;
                        txtVolo.Enabled = false;
                        break;
                    }
            }
        }
    }
}
