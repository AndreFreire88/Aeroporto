using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.DataAccess
{
    internal class TextConnector : IDataConnection
    {

        void IDataConnection.CreateClient(ClientModel model)
        {
            throw new NotImplementedException();
        }
    }
}
