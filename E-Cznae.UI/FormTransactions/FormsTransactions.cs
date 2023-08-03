using E_Czane.Data.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace E_Cznae.UI.FormTransactions
{
    public class FormsTransactions<T> where T : new()
    {
        public void ShowTable(DataGridView dataGrid, List<T> list, ArrayList columnName = null)
        {
            dataGrid.DataSource = list;
            for(var i = 0; i< columnName.Count; i++)
            {
                dataGrid.Columns[i].HeaderText = $"{columnName[i]}";
            }
            dataGrid.Columns[0].Visible = false;
            
        }
        public void ShowTable(DataGridView dataGrid, List<T> list)
        {
            dataGrid.DataSource = list;
            
        }
    }
}
