﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.ClasseDeNegocio
{
    public abstract class ICliente : IObjeto
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }
        public Email Email { get; set; }
        public string String()
        {
            throw new NotImplementedException();
        }
    }
}
