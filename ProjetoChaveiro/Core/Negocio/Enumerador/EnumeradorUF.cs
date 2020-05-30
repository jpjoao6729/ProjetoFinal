using Core.Negocio.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Negocio.Enumerador
{
    public class EnumeradorUF : EnumeradorSeguro<string>
    {
        public static EnumeradorUF RO = new EnumeradorUF("RO","Rondônia");
        public static EnumeradorUF AC = new EnumeradorUF("AC","Acre");
        public static EnumeradorUF AM = new EnumeradorUF("AM","Amazonas");
        public static EnumeradorUF RR = new EnumeradorUF("RR","Roraima");
        public static EnumeradorUF PA = new EnumeradorUF("PA","Pará");
        public static EnumeradorUF AP = new EnumeradorUF("AP","Amapá");
        public static EnumeradorUF TO = new EnumeradorUF("TO","Tocantins");
        public static EnumeradorUF MA = new EnumeradorUF("MA","Maranhão");
        public static EnumeradorUF PI = new EnumeradorUF("PI","Piauí");
        public static EnumeradorUF CE = new EnumeradorUF("CE","Ceará");
        public static EnumeradorUF RN = new EnumeradorUF("RN","Rio Grande do Norte"	);
        public static EnumeradorUF PB = new EnumeradorUF("PB","Paraíba");
        public static EnumeradorUF PE = new EnumeradorUF("PE","Pernambuco");
        public static EnumeradorUF AL = new EnumeradorUF("AL","Alagoas");
        public static EnumeradorUF SE = new EnumeradorUF("SE","Sergipe");
        public static EnumeradorUF BA = new EnumeradorUF("BA","Bahia");
        public static EnumeradorUF MG = new EnumeradorUF("MG","Minas Gerais");
        public static EnumeradorUF ES = new EnumeradorUF("ES","Espírito Santo");
        public static EnumeradorUF RJ = new EnumeradorUF("RJ","Rio de Janeiro");
        public static EnumeradorUF SP = new EnumeradorUF("SP","São Paulo");
        public static EnumeradorUF PR = new EnumeradorUF("PR","Paraná");
        public static EnumeradorUF SC = new EnumeradorUF("SC","Santa Catarina");
        public static EnumeradorUF RS = new EnumeradorUF("RS","Rio Grande do Sul");
        public static EnumeradorUF MS = new EnumeradorUF("MS","Mato Grosso do Sul");
        public static EnumeradorUF MT = new EnumeradorUF("MT","Mato Grosso");
        public static EnumeradorUF GO = new EnumeradorUF("GO","Goiás");
        public static EnumeradorUF DF = new EnumeradorUF("DF", "Distrito Federal");
        public EnumeradorUF(string codigo, string descricao) : base(codigo, descricao) { }

        public override string ToString()
        {
            return base.Codigo;
        }

    }
}
