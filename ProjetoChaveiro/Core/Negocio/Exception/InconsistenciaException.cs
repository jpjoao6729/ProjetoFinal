using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.Exception
{
    public class InconsistenciaException : SystemException
    {
        InconsistenciaException(string inconsistencia) : base(inconsistencia) { }
    }
}
