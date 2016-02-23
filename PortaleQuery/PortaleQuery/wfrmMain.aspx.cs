using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace PortaleQuery
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //NICOLA AMADEI 2016
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEsegui_Click(object sender, EventArgs e)
        {
            //Preparo la Query sostituendo i parametri
            string query = txtQuery.Text;
            query = query.Replace("@1@", txtP1.Text).Replace("@2@", txtP2.Text).Replace("@3@", txtP3.Text).Replace("@4@", txtP4.Text).Replace("@5@", txtP5.Text).Replace("@6@", txtP6.Text);
            try
            {          
                //Connetto al DB !!!!!!PERCORSO ASSOLUTO!!!!!!      
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                    @"Data source= C:\Users\nicol\Desktop\PortaleQuery\PortaleQuery\bin\" +
                    @"dbazienda.mdb";
                cnn.Open();
                //Creiamo una DataTable per contenere i nostri dati.
                DataTable dt = new DataTable();
                //Creiamo il DataAdapter che sfrutterà la nostra connessione per eseguire la query e prelevare i dati.
                OleDbDataAdapter da = new OleDbDataAdapter(query, cnn);
                //Riempiamo la DataTable            
                da.Fill(dt);
                //Aggancio il datatable alla gridview
                gvTabella.DataSource = dt;
                gvTabella.DataBind();
                imgStato.ImageUrl = @".\Images\ok.png";
            }
            catch (Exception)
            {
                //Visualizzo un alert
                string script = "alert(\"Nessun risultato, controlla la query!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                //Segnalo all'utente che la query non è andata a buon fine pulendo la tabella e impostando l'immagine rossa
                imgStato.ImageUrl = @".\Images\wait.png";
                gvTabella.DataSource = null;
                gvTabella.DataBind();
            }

        }

    }
}