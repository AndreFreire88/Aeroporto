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
        public RegisterClient()
        {
            InitializeComponent();
        }

        private void registerClientBtn_Click(object sender, EventArgs e)
        {
            ClientModel model = new ClientModel(firstNameValue.Text, lastNameValue.Text, addressValue.Text, emailValue.Text, CellphoneNumberValue.Text);

            GlobalConfig.Connection.CreateClient(model);

        }



    }
}
