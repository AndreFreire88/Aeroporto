using Aeroporto.Interfaces;
using Libary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroporto
{
    public partial class BookFlight : Form, IRegisterClientRequest, IRegisterBagRequest, IUpdateClientRequest
    {
        private List<ClientModel> clients = GlobalConfig.Connection.GetClients_All();
        private List<ClientModel> available = new List<ClientModel>();

        private FlightModel flight;
        IBookFlightRequest callingForm;

        public BookFlight(IBookFlightRequest caller, FlightModel model)
        {
            InitializeComponent();

            flight = model;
            flightNameLabel.Text = flight.FlightName;
            callingForm = caller;
            ShowOnlyNotBooked();
            WireUpList();
            WireUpBags();
            WireUpInfo();

        }

        private void ShowOnlyNotBooked()
        {
            List<ClientModel> selectedClients = flight.Passengers.ToList();

            available = clients;

            for (int i = 0; i < available.Count; i++)
            {
                if (selectedClients.Any(m => m.ID_Passageiro == available[i].ID_Passageiro))
                {
                    available.RemoveAt(i);
                    i--;
                }
            }

        }

        private void WireUpList()
        {

            clientDropDown.DataSource = null;
            clientDropDown.DataSource = available;
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
            callingForm.ReservationComplete( client);
            Close();
        }
        private void deleteBagBtn_Click(object sender, EventArgs e)
        {
            BaggageModel bag = bagsListBox.SelectedItem as BaggageModel;

            GlobalConfig.Connection.DeleteBag(bag);

            UpdateInfo(bag.ID_Passageiro);
        }
        public void RegisterClientComplete(ClientModel model)
        {
            UpdateInfo(model.ID_Passageiro);
        }
        public void BagComplete(BaggageModel model)
        {
            UpdateInfo(model.ID_Passageiro);

        }
        private void UpdateInfo(int id)
        {
            clients = GlobalConfig.Connection.GetClients_All();
            ShowOnlyNotBooked();
            WireUpList();
            int index = 0;

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].ID_Passageiro == id)
                {
                    index = i;
                    break;
                }

            }
            clientDropDown.SelectedIndex = index;


            WireUpBags();

        }

        private void updateClientInfo_Click(object sender, EventArgs e)
        {
            ClientModel passenger = clientDropDown.SelectedItem as ClientModel;
            UpdateClient frm = new UpdateClient(this, passenger);
            frm.Show();

        }

        public void UpdateClientComplete(ClientModel model)
        {
            UpdateInfo(model.ID_Passageiro);

        }
    }
}
