using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class LinguagemDB
    {

        private DB db;

        public Boolean insert(Linguagem linguagem)
        {
            try
            {
                string sql = "INSERT INTO TB_LINGUAGEM (nome, pontuacao)" +
                             " VALUES ('" + linguagem.Nome + linguagem.Pontuacao +"')";
                using (db = new DB())
                {
                    db.ExecutaComando(sql);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

            public List<Linguagem> ListarLinguagem()
        {
            using (db = new DB())
            {
                var sql = "SELECT id, nome, pontuacao FROM TB_LINGUAGEM";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Linguagem> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listLinguagem = new List<Linguagem>();

            while (retorno.Read())
            {
                var item = new Linguagem()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Nome = retorno["nome"].ToString(),
                    Pontuacao = Convert.ToInt32(retorno["pontuacao"]),
                };

                listLinguagem.Add(item);
            }
            return listLinguagem;
        }
    }
}

