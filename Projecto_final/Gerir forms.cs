using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_aulaSQL
{
    internal class Gerir_forms
    {

        public static void TrocarForms(Form formAtual, Form formNovo)
        {
            formAtual.Hide();
            formNovo.ShowDialog();
            formAtual.Close();
        }



    }
}
