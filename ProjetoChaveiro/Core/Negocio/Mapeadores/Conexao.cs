using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Conexao : IDisposable
    {
        private string _stringDeConexao = @"DataSource = localhost; DataBase=C:\DB\TESTE.fdb; username=SYSDBA; password=masterkey";
        private FbConnection _conexao;
        private FbCommand _comando;

        public Conexao()
        {
            try
            {
                _conexao = new FbConnection(_stringDeConexao);
                if(_conexao == null)
                {
                    throw new Exception("não foi possível estabelecer conexão com o banco.");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public 

        public void Dispose()
        {
            _conexao.Close();
        }
    }
}
