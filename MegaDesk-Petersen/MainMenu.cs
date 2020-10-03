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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the main menu form
            Close();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotesForm = new SearchQuotes();
            viewSearchQuotesForm.Tag = this;
            viewSearchQuotesForm.Show(this);
            this.Hide();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes showViewAllQuotesForm = new ViewAllQuotes();
            showViewAllQuotesForm.Tag = this;
            showViewAllQuotesForm.Show(this);
            this.Hide();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote showAddQuoteForm = new AddQuote();
            showAddQuoteForm.Tag = this;
            showAddQuoteForm.Show(this);
            this.Hide();
        }
    }
}
