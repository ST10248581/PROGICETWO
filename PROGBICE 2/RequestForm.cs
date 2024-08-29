using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGBICE_2
{
    public partial class RequestForm : Form
    {

        public RequestForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            try
            {
                var amount = decimal.Parse(txtAmount.Text);
                var description = txtDescription.Text;
                var requestDate = DateTime.Now;

                PaymentRequestManager.CreateRequest(Guid.NewGuid(), amount, description, requestDate);
                MessageBox.Show("Request submitted successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtAmount.Clear();
                txtDescription.Clear();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
