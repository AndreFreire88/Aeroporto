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
    public partial class RegisterBag : Form
    {
        private ClientModel Passanger;
        public RegisterBag(ClientModel passanger)
        {
            InitializeComponent();
            Passanger = passanger;
        }

        private void registerBagBtn_Click(object sender, EventArgs e)
        {

            BaggageModel model = new BaggageModel(Passanger.ID_Passageiro, pesoValue.Text);
            GlobalConfig.Connection.CreateBag(model);
        }
    }
}
