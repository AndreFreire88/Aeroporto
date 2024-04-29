using Aeroporto.Interfaces;
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
    public partial class BookFlight : Form, IRegisterClientRequest, IRegisterBagRequest
    {
        private List<ClientModel> clients = GlobalConfig.Connection.GetClients_All();

        private FlightModel flight;
        IBookFlightRequest callingForm;

        public BookFlight(IBookFlightRequest caller, FlightModel model)
        {
            InitializeComponent();
            flight = model;
            flightNameLabel.Text = flight.FlightName;
            callingForm = caller;
            WireUpList();
            WireUpBags();
            WireUpInfo();

        }


        private void WireUpList()
        {
            List<ClientModel> selectedClients = flight.Passengers.ToList();

            clientDropDown.DataSource = null;
            clientDropDown.DataSource = clients;
            clientDropDown.DisplayMember = nameof(ClientModel.FullName);
        }

        private void createClientLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterClient frm = new RegisterClient(this);
            frm.Show();
        }

        private void CreateBagBtn_Click(object sender, EventArgs e)
        {
            ClientModel passenger = clientDropDown.SelectedItem as ClientModel;
            RegisterBag frm = new RegisterBag(this,passenger);
            frm.Show();
        }

        private void WireUpBags()
        {
            ClientModel clientModel = clientDropDown.SelectedItem as ClientModel;
            if (clientModel != null)
            {
                bagsListBox.DataSource = null;
                bagsListBox.DataSource = clientModel.Baggages.ToList();
                bagsListBox.DisplayMember = nameof(BaggageModel.Info);
            }
        }
        private void clientDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpBags();
            WireUpInfo();
        }
        private void WireUpInfo()
        {
            ClientModel model = clientDropDown.SelectedItem as ClientModel;

            if ( model != null)
            {
                nomeValueLabel.Text = model.FullName;
                enderecoValueLabel.Text = model.Endereco;
                emailValueLabel.Text = model.Email;
                telefoneValueLabel.Text = model.Telefone;
            }
        }
        private void bookbutton_Click(object sender, EventArgs e)
        {
            ClientModel client = clientDropDown.SelectedItem as ClientModel;
            GlobalConfig.Connection.BookFlight(flight, client);
            callingForm.ReservationComplete();
            Close();
        }
        private void deleteBagBtn_Click(object sender, EventArgs e)
        {
            BaggageModel bag = bagsListBox.SelectedItem as BaggageModel;

            GlobalConfig.Connection.DeleteBag(bag);

            UpdateInfo(0);
        }
        public void RegisterClientComplete()
        {
            UpdateInfo(1);
        }
        public void BagComplete()
        {
            UpdateInfo(0);
        }
        private void UpdateInfo(byte type)
        {
            clients = GlobalConfig.Connection.GetClients_All();
            WireUpList();
            if (type == 1)
            {
                clientDropDown.SelectedIndex = clientDropDown.Items.Count - 1;
            }
            WireUpBags();

        }
    }
}
