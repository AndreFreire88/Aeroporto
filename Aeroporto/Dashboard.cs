using Aeroporto.Interfaces;
using Libary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroporto
{
    public partial class Dashboard : Form, IRegisterFlightRequest, IBookFlightRequest, IUpdateFlightRequest
    {
        List<FlightModel> flights = GlobalConfig.Connection.GetFlights_All();
        public Dashboard()
        {
            InitializeComponent();
            WireUpLIst();
            WireUpInfo();
        }

        private void WireUpLIst()
        {
            flightDropDown.DataSource = null;
            flightDropDown.DataSource = flights;
            flightDropDown.DisplayMember = nameof(FlightModel.FlightName);
        }

        private void WireUpInfo()
        {
            FlightModel model = flightDropDown.SelectedItem as FlightModel;

            if (model != null)
            {
                numeroVooValueLabel.Text = model.NumeroVoo;
                companhiaValueLabel.Text = model.CompanhiaAerea;
                origemValueLabel.Text = model.Origem;
                destinoValueLabel.Text = model.Destino;

                HoraDePartidadeValueLabel.Text = model.DataHoraPartida.ToString("dd/MM/yyyy HH:mm");
                horaDeChegadaValueLabel.Text = model.DataHoraChegada.ToString("dd/MM/yyyy HH:mm");
                capacidadeValueLabel.Text = model.Capacidade.ToString();

                flightNameLabel.Text = model.FlightName;

                passangerListBox.DataSource = null;
                passangerListBox.DataSource = model.Passengers;
                passangerListBox.DisplayMember = nameof(ClientModel.FullName);
            }
        }

        private void flightDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpInfo();
        }

        private void CreateFlightBtn_Click(object sender, EventArgs e)
        {

            RegisterFlight frm = new RegisterFlight(this);
            frm.Show();
        }

        private void addPassager_Click(object sender, EventArgs e)
        {            
            FlightModel flight = flightDropDown.SelectedItem as FlightModel;
            BookFlight frm = new BookFlight(this, flight);
            frm.Show();
        }

        private void removePassenger_Click(object sender, EventArgs e)
        {
            ClientModel client = passangerListBox.SelectedItem as ClientModel;
            FlightModel flight = flightDropDown.SelectedItem as FlightModel;

            if (client != null)
            {
                GlobalConfig.Connection.DeleteReservation(flight, client);

                Updateinfo(flight.ID_Voo);
                
            }
            else
            {
                MessageBox.Show("Nothing was selected", "Error");
            }

        }

        public void FlightComplete(FlightModel model)
        {
            Updateinfo(model.ID_Voo);
        }

        private void Updateinfo(int id)
        {
            flights = GlobalConfig.Connection.GetFlights_All();

            WireUpLIst();

            int index = 0;

            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].ID_Voo == id)
                {
                    index = i;
                    break;
                }

            }
            flightDropDown.SelectedIndex = index;

            WireUpInfo();
        }

        public void ReservationComplete(ClientModel model)
        {
            FlightModel flightModel = flightDropDown.SelectedItem as FlightModel;
            List<ClientModel> clients = flightModel.Passengers.ToList();
            Updateinfo(flightModel.ID_Voo);
            int index = 0;

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].ID_Passageiro == model.ID_Passageiro)
                {
                    index = i;
                    break;
                }
            }
            passangerListBox.SelectedIndex = index;
        }

        private void UpdateFlightBtn_Click(object sender, EventArgs e)
        {
            FlightModel flightModel = flightDropDown.SelectedItem as FlightModel ;
            UpdateFlight frm = new UpdateFlight(this, flightModel);
            frm.Show();

        }

        public void UpdateFlightComplete(FlightModel model)
        {
            Updateinfo(model.ID_Voo);
        }
    }
}
