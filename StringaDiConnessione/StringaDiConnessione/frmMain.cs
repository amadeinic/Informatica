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

namespace StringaDiConnessione
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //ESEMPIO CONNESSIONE - Nicola Amadei 2015
        //    Questo programma è un semplice esempio di connessione, in questo caso utilizziamo un file excel come prova.

        private void btnFaiQualcosa_Click(object sender, EventArgs e)
        {
            //Questa query seleziona tutti gli elementi dalla tabella Questions, che è il nome del foglio di lavoro Excel.
            string query = "SELECT * FROM [Questions$]";
            //La stringa di connessione varia a seconda del tipo della connessione stessa, questa va bene per un file .xls classico. http://www.connectionstrings.com/
            string strConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=dati.xls;Extended Properties=Excel 8.0;";
            
            //METODO COMPLETO
            //In questo modo prima creiamo la connessione esplicitamente, passando come parametro la strinag di connessione.
            OleDbConnection cnn = new OleDbConnection(strConnessione);
            //Creiamo una DataTable per contenere i nostri dati.
            DataTable dt = new DataTable();
            //Creiamo il DataAdapter che sfrutterà la nostra connessione per eseguire la query e prelevare i dati.
            OleDbDataAdapter da = new OleDbDataAdapter(query, cnn);
            //Riempiamo la DataTable
            da.Fill(dt);
            //Impostiamo il DataSource della DataGridView collegandolo alla DataTable, la visualizzazione è così automatica.
            dgvSchermo.DataSource = dt;
        }
    }
}
