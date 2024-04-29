using Libary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroporto
{
    public partial class BookFlight : Form
    {
        List<ClientModel> clients = GlobalConfig.Connection.GetClients_All();

        public BookFlight()
        {
            InitializeComponent();
            WireUpList();
            WireUpBags();
            WireUpInfo();

        }

        private void WireUpList()
        {
            clientDropDown.DataSource = null;
            clientDropDown.DataSource = clients;
            clientDropDown.DisplayMember = nameof(ClientModel.FullName);
        }

        private void createClientLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterClient frm = new RegisterClient();
            frm.Show();
        }

        private void CreateBagBtn_Click(object sender, EventArgs e)
        {
            ClientModel passenger = clientDropDown.SelectedItem as ClientModel;
            RegisterBag frm = new RegisterBag(passenger);
            frm.Show();
        }

        private void WireUpBags()
        {
            ClientModel passager = clientDropDown.SelectedItem as ClientModel;
            List<BaggageModel> bags = passager.Baggages;
            bagsListBox.DataSource = null;
            bagsListBox.DataSource = bags;
            bagsListBox.DisplayMember = nameof(BaggageModel.Info);
        }

        private void clientDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpBags();
            WireUpInfo();
        }

        private void WireUpInfo()
        {
            ClientModel model = clientDropDown.SelectedItem as ClientModel;
            nomeValueLabel.Text = model.FullName;
            enderecoValueLabel.Text = model.Endereco;
            emailValueLabel.Text= model.Email;
            telefoneValueLabel.Text = model.Telefone;

        }

        private void bookbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
