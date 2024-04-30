using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Hotel_Mod.Class
{
    public class DaoPais<T> : Dao<T>
    {

        public DaoPais() : base()
        {
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            List<T> paises = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM paises" : "SELECT * FROM PAISES WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.pais_id = Convert.ToInt32(reader["pais_ID"]);
                        obj.pais = reader["pais_nome"].ToString();
                        obj.ddi = reader["ddi"].ToString();
                        obj.sigla = reader["sigla"].ToString();
                        paises.Add(obj);
                    }

                }
            }
            return paises;
        }

        public override void Salvar(T obj)
        {
            dynamic pais = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO paises (pais, sigla, ddi, ativo, data_cadastro, dat_ult_alt) values (@pais, @sigla, @ddi, @ativo, @data_cadastro, @dat_ult_alt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@pais_nome", pais.pais);
                command.Parameters.AddWithValue("@sigla", pais.Sigla);
                command.Parameters.AddWithValue("@ddi", pais.ddi);
                command.Parameters.AddWithValue("@ativo", pais.ativo);
                command.Parameters.AddWithValue("@data_cadastro", pais.data_cadastro);
                command.Parameters.AddWithValue("@dat_ult_alt", pais.dat_ult_alt);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public override void excluir(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE  * FROM paises where paises_id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public override void alterar(T obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE pais SET Pais = @pais, Sigla = @sigla, DDI = @DDI, ativo = @ativo, dataCadastro = @dataCadastro, dat_ult_alt = @dataUltAlt WHERE pais_id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pais_id", Pais.pais_id);
                command.Parameters.AddWithValue("@pais", Pais.pais);
                command.Parameters.AddWithValue("@sigla", Pais.sigla);
                command.Parameters.AddWithValue("@ddi", Pais.ddi);
                command.Parameters.AddWithValue("@ativo", Pais.ativo);
                command.Parameters.AddWithValue("@data_cadastro", Pais.data_cadastro);
                command.Parameters.AddWithValue("@dat_ult_alt", Pais.dat_ult_alt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public override T pesquisar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from paises where id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.pais_id = Convert.ToInt32(reader["pais_id"]);
                        obj.Pais = reader["pais"].ToString();
                        obj.Sigla = reader["sigla"].ToString();
                        obj.DDI = reader["ddi"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["data_cadastro"].ToString());
                        obj.dat_ult_alt = DateTime.Parse(reader["dat_ult_alt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T);
                    }


                }


            }

        }
    }
}
