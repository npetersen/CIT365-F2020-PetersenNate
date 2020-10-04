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
        private Desk desk = new Desk();
        private DeskQuote deskQuote = new DeskQuote();
        private readonly System.Windows.Forms.ErrorProvider deskWidthErrorProvider;

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
            desk.deskWidth = int.Parse(deskWidth.Text);
            desk.deskDepth = int.Parse(deskDepth.Text);
            desk.surfaceMaterial = cmbSurfaceMaterial.Text;
            desk.numDrawers = int.Parse(cmbNumDrawers.Text);
            deskQuote.customerFullName = customerFullName.Text;
            deskQuote.rushOrderDays = int.Parse(cmbRushOrder.Text);
            deskQuote.desk = desk;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void deskWidth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage;
            if (!ValidateDeskWidth(int.Parse(deskWidth.Text), out errorMessage))
            {
                e.Cancel = true;
                deskWidth.Select(0, deskWidth.Text.Length);

                this.deskWidthErrorProvider.SetError(deskWidth, errorMessage);

            }
        }

        public bool ValidateDeskWidth(int deskWidth, out string errorMessage)
        {
            if (deskWidth == 0)
            {
                errorMessage = "Please provide the width of the desk.";
                return false;
            }
            else if (deskWidth < 100)
            {
                errorMessage = "The desk width must be greater than 100.";
                return false;
            }
            else if (deskWidth > 200)
            {
                errorMessage = "The desk width must be less than 200";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }

    }


}
