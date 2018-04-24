using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.DataAccess.Data
{
    public interface IDao<T>
    {
        interface Add(T t);
            Sqlconnection GetConnection();
    }
}
