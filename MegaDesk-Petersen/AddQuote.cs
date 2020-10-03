using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Petersen
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            // https://www.aspsnippets.com/Articles/Populate-Bind-ComboBox-from-Enum-in-Windows-Forms-WinForms-Application-using-C-and-VBNet.aspx
            List<KeyValuePair<string, string>> listSurfaceMaterials = new List<KeyValuePair<string, string>>();
            Array surfaceMaterials = Enum.GetValues(typeof(SurfaceMaterials));
            foreach (SurfaceMaterials material in surfaceMaterials)
            {
                listSurfaceMaterials.Add(new KeyValuePair<string, string>(material.ToString(), ((int)material).ToString()));
            }
            cmbSurfaceMaterial.DataSource = listSurfaceMaterials;
            cmbSurfaceMaterial.DisplayMember = "Key";
            cmbSurfaceMaterial.ValueMember = "Value";
        }

        private void btnSubmitQuote_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }
    }
}
