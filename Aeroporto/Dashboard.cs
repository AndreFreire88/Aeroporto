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
    public partial class Dashboard : Form, IRegisterFlightRequest, IBookFlightRequest
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
                HoraDePartidadeValueLabel.Text = model.DataHoraPartida.Substring(0, model.DataHoraPartida.Length - 3);
                horaDeChegadaValueLabel.Text = model.DataHoraChegada.Substring(0, model.DataHoraChegada.Length - 3);
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

                Updateinfo(0);
            }
            else
            {
                MessageBox.Show("Nothing was selected", "Error");
            }

        }

        public void FlightComplete()
        {
            Updateinfo(1);
        }

        private void Updateinfo(byte type)
        {
            flights = GlobalConfig.Connection.GetFlights_All();

            WireUpLIst();

            if (type == 1)
            {
                flightDropDown.SelectedIndex = flightDropDown.Items.Count - 1;
            }

            WireUpInfo();
        }

        public void ReservationComplete()
        {
            Updateinfo(0);
        }
    }
}
