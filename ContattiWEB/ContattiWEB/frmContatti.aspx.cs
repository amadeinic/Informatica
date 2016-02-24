using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContattiWEB
{
    public partial class frmContatti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEsegui_Click(object sender, EventArgs e)
        {
            string query = ""; 
            if (txtQuery.Text=="")
            {
                switch(ddlScelta.SelectedIndex)
                {
                    case 0:
                        {
                            query = "SELECT DataOra, Nome, Cognome, Simpatia, Motivo "+
                                    "FROM Contatti INNER JOIN Chiamate ON Contatti.IdContatto = Chiamate.IdContatto "+
                                    "ORDER BY DataOra";
                            break;
                        }
                    case 1:
                        {
                            query = "SELECT TOP 15 DataOra, Nome, Cognome, Simpatia, Motivo " +
                                    "FROM Contatti INNER JOIN Chiamate ON Contatti.IdContatto = Chiamate.IdContatto " +
                                    "ORDER BY DataOra";
                            break;
                        }
                    case 2:
                        {
                            query = "SELECT TOP 5 DataOra, Nome, Cognome, Simpatia, Motivo " +
                                    "FROM Contatti INNER JOIN Chiamate ON Contatti.IdContatto = Chiamate.IdContatto " +
                                    "WHERE Simpatia>=3 "+
                                    "ORDER BY DataOra";
                            break;
                        }
                    case 3:
                        {
                            query = "SELECT TOP 5 DataOra, Nome, Cognome, Simpatia, Motivo " +
                                    "FROM Contatti INNER JOIN Chiamate ON Contatti.IdContatto = Chiamate.IdContatto " +
                                    "WHERE Simpatia<3 " +
                                    "ORDER BY DataOra";
                            break;
                        }
                }
            }
            else
            {
                query = txtQuery.Text;
            }
            
            
            try
            {
                //Connetto al DB !!!!!!PERCORSO ASSOLUTO!!!!!!      
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                    @"Data source=" + Server.MapPath("~") +
                    @"\Appdata\contatti.mdb";
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
            catch (Exception exc)
            {

                //Visualizzo un alert
                string script = "alert("+exc.Message+");";
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