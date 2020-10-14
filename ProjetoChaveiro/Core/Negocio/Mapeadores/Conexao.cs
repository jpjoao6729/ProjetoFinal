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
        private FbTransaction _transacao;

        public Conexao()
        {
            try
            {
                _conexao = new FbConnection(_stringDeConexao);
                if (_conexao == null)
                {
                    throw new Exception("não foi possível estabelecer conexão com o banco.");
                }
                _conexao.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AdicioneComando(string comando)
        {
            if (comando == null || comando == "")
            {
                return;
            }
            _comando = new FbCommand(comando, this._conexao);
        }

        internal FbDataReader ObtenhaDataReader()
        {
            try
            {
                var dr = _comando.ExecuteReader();
                return dr;
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na conexão" + erro);
            }
        }

        public FbTransaction Transacao()
        {
            if(_transacao == null)
            {
                _transacao = _conexao.BeginTransaction();
            }
                
            return _transacao;
        }

        public FbCommand CrieComando()
        {
            return new FbCommand("", _conexao, _transacao);
        }

        public void ExecuteComand()
        {
            if (_comando != null)
            {
                _comando.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            _conexao.Close();
        }
    }
}
