using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.DataAccess
{
    public interface IDataConnection
    {
        void CreateClient(ClientModel model); 
    }
}
