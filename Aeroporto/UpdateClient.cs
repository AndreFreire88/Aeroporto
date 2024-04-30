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
    public partial class UpdateClient : Form
    {
        IUpdateClientRequest callingForm;
        ClientModel passenger;

        public UpdateClient(IUpdateClientRequest caller, ClientModel model)
        {
            InitializeComponent();
            callingForm = caller;
            passenger = model;
            WireUpInfo();
        }



        private void updateClientBtn_Click(object sender, EventArgs e)
        {
            ClientModel model = new ClientModel(passenger.ID_Passageiro, addressValue.Text, emailValue.Text, CellphoneNumberValue.Text);
            GlobalConfig.Connection.UpdateClient(model);

            callingForm.UpdateClientComplete(model);

            Close();
        }

        private void WireUpInfo()
        {
            firstNameValueLabel.Text = passenger.Nome;
            lastNameValueLabel.Text = passenger.Sobrenome;
            addressValue.Text = passenger.Endereco;
            emailValue.Text = passenger.Email;
            CellphoneNumberValue.Text = passenger.Telefone;
        }
    }
}
