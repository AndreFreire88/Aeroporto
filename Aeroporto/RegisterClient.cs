using Aeroporto.Interfaces;
using Libary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroporto
{
    public partial class RegisterClient : Form
    {
        IRegisterClientRequest callingForm;
        public RegisterClient(IRegisterClientRequest caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void registerClientBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ClientModel model = new ClientModel(firstNameValue.Text, lastNameValue.Text, addressValue.Text, emailValue.Text, CellphoneNumberValue.Text);

                GlobalConfig.Connection.CreateClient(model);
                callingForm.RegisterClientComplete(model);

                Close();
            }
            else
                MessageBox.Show("Error", "Error");
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
                return false;

            if (lastNameValue.Text.Length == 0)
                return false;

            if (addressValue.Text.Length == 0)
                return false;

            if (emailValue.Text.Length == 0)
                return false;

            if (CellphoneNumberValue.Text.Length == 0)
                return false;

            return true;

        }



    }
}
