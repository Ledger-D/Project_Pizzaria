using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizaria_Registro.Enums
{
    enum OrderStatus : int
    {
        Pago = 0,
        Processando =1 ,
        Enviado = 2,
        Entregue = 3
    }
}
