using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using DTL;

namespace DAL
{
    public class FichasDAL
    {
        public void Insert(Ficha ficha, Vantagens[] vantagens, Desvantagens[] desvantagens, Tecnicas[] tecnicas) 
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = Dados.StringDeConexao;

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO _tb_fichas (nome, descricao, arquetipo, pericias, foto, exp, pontos, poder, habilidade, resistencia, pv, pv_max, pa, pa_max, pm, pm_max, inventario) VALUES (@nome, @descricao, @arquetipo, @pericias, @foto, @exp, @pontos, @poder, @habilidade, @resistencia, @pv, @pv_max, @pa, @pa_max, @pm, @pm_max, @inventario)";
                cmd.Parameters.AddWithValue("@nome", ficha.Nome);
                cmd.Parameters.AddWithValue("@descricao", ficha.Descricao);
                cmd.Parameters.AddWithValue("@pericias", ficha.Pericias);
                cmd.Parameters.AddWithValue("@arquetipo", ficha.Arquetipo);
                cmd.Parameters.AddWithValue("@foto", ficha.Foto);
                cmd.Parameters.AddWithValue("@exp", ficha.Exp);
                cmd.Parameters.AddWithValue("@pontos", ficha.Pontos);
                cmd.Parameters.AddWithValue("@poder", ficha.Poder);
                cmd.Parameters.AddWithValue("@habilidade", ficha.Habilidade);
                cmd.Parameters.AddWithValue("@resistencia", ficha.Resistencia);
                cmd.Parameters.AddWithValue("@pv", ficha.Pv);
                cmd.Parameters.AddWithValue("@pv_max", ficha.MaxPv);
                cmd.Parameters.AddWithValue("@pa", ficha.Pa);
                cmd.Parameters.AddWithValue("@pa_max", ficha.MaxPa);
                cmd.Parameters.AddWithValue("@pm", ficha.Pm);
                cmd.Parameters.AddWithValue("@pm_max", ficha.MaxPm);
                cmd.Parameters.AddWithValue("@inventario", ficha.Inventario);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                if (vantagens != null)
                {
                    foreach (Vantagens vantagem in vantagens)
                    {
                        cmd.CommandText = "INSERT INTO _tb_vantagens (id_ficha, nome, descricao) VALUES (@id_ficha, @nome, @descricao)";
                        cmd.Parameters.AddWithValue("@id_ficha", vantagem.Id_ficha);
                        cmd.Parameters.AddWithValue("@nome", vantagem.Nome);
                        cmd.Parameters.AddWithValue("@descricao", vantagem.Descricao);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                if (desvantagens != null)
                {
                    foreach (Desvantagens desvantagem in desvantagens)
                    {
                        cmd.CommandText = "INSERT INTO _tb_desvantagens (id_ficha, nome, descricao) VALUES (@id_ficha, @nome, @descricao)";
                        cmd.Parameters.AddWithValue("@id_ficha", desvantagem.Id_ficha);
                        cmd.Parameters.AddWithValue("@nome", desvantagem.Nome);
                        cmd.Parameters.AddWithValue("@descricao", desvantagem.Descricao);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                if (tecnicas != null)
                {
                    foreach (Tecnicas tecnica in tecnicas)
                    {
                        cmd.CommandText = "INSERT INTO _tb_tecnicas (id_ficha, nome, descricao) VALUES (@id_ficha, @nome, @descricao)";
                        cmd.Parameters.AddWithValue("@id_ficha", tecnica.Id_ficha);
                        cmd.Parameters.AddWithValue("@nome", tecnica.Nome);
                        cmd.Parameters.AddWithValue("@descricao", tecnica.Descricao);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }

            catch (SQLiteException liteEx)
            {
                throw new Exception("Erro inserir ficha: \n" + liteEx);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public void Update(Ficha ficha, Vantagens[] vantagens, Desvantagens[] desvantagens, Tecnicas[] tecnicas) 
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = Dados.StringDeConexao;

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE _tb_fichas SET nome = @nome, descricao = @descricao, arquetipo = @arquetipo, pericias = @pericias, foto = @foto, exp = @exp, pontos = @pontos, poder = @poder, habilidade = @habilidade, resistencia = @resistencia, pv = @pv, pv_max = @pv_max, pa = @pa, pa_max = @pa_max, pm = @pm, pm_max = @pm_max, inventario = @inventario WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", ficha.Id);
                cmd.Parameters.AddWithValue("@nome", ficha.Nome);
                cmd.Parameters.AddWithValue("@descricao", ficha.Descricao);
                cmd.Parameters.AddWithValue("@arquetipo", ficha.Arquetipo);
                cmd.Parameters.AddWithValue("@pericias", ficha.Pericias);
                cmd.Parameters.AddWithValue("@foto", ficha.Foto);
                cmd.Parameters.AddWithValue("@exp", ficha.Exp);
                cmd.Parameters.AddWithValue("@pontos", ficha.Pontos);
                cmd.Parameters.AddWithValue("@poder", ficha.Poder);
                cmd.Parameters.AddWithValue("@habilidade", ficha.Habilidade);
                cmd.Parameters.AddWithValue("@resistencia", ficha.Resistencia);
                cmd.Parameters.AddWithValue("@pv", ficha.Pv);
                cmd.Parameters.AddWithValue("@pv_max", ficha.MaxPv);
                cmd.Parameters.AddWithValue("@pa", ficha.Pa);
                cmd.Parameters.AddWithValue("@pa_max", ficha.MaxPa);
                cmd.Parameters.AddWithValue("@pm", ficha.Pm);
                cmd.Parameters.AddWithValue("@pm_max", ficha.MaxPm);
                cmd.Parameters.AddWithValue("@inventario", ficha.Inventario);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //Deleta todas as vantagens relacionadas a ficha
                cmd.CommandText = "DELETE FROM _tb_vantagens WHERE id_ficha = @id_ficha";
                cmd.Parameters.AddWithValue("@id_ficha", ficha.Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                if (vantagens != null)
                    foreach(Vantagens vantagem in vantagens) 
                    {
                        cmd.CommandText = "INSERT INTO _tb_vantagens (id_ficha, nome, descricao) VALUES (@id_ficha, @nome, @descricao)";
                        cmd.Parameters.AddWithValue("@id_ficha", ficha.Id);
                        cmd.Parameters.AddWithValue("@nome", vantagem.Nome);
                        cmd.Parameters.AddWithValue("@descricao", vantagem.Descricao);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                //Deleta todas as desvantagens relacionadas a ficha
                cmd.CommandText = "DELETE FROM _tb_desvantagens WHERE id_ficha = @id_ficha";
                cmd.Parameters.AddWithValue("@id_ficha", ficha.Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                if (desvantagens != null)
                    foreach (Desvantagens desvantagem in desvantagens)
                    {
                        cmd.CommandText = "INSERT INTO _tb_desvantagens (id_ficha, nome, descricao) VALUES (@id_ficha, @nome, @descricao)";
                        cmd.Parameters.AddWithValue("@id_ficha", ficha.Id);
                        cmd.Parameters.AddWithValue("@nome", desvantagem.Nome);
                        cmd.Parameters.AddWithValue("@descricao", desvantagem.Descricao);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                //Deleta todas as tecnicas relacionadas a ficha
                cmd.CommandText = "DELETE FROM _tb_tecnicas WHERE id_ficha = @id_ficha";
                cmd.Parameters.AddWithValue("@id_ficha", ficha.Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                if (tecnicas != null)
                    foreach (Tecnicas tecnica in tecnicas)
                    {
                        cmd.CommandText = "INSERT INTO _tb_tecnicas (id_ficha, nome, descricao) VALUES (@id_ficha, @nome, @descricao)";
                        cmd.Parameters.AddWithValue("@id_ficha", ficha.Id);
                        cmd.Parameters.AddWithValue("@nome", tecnica.Nome);
                        cmd.Parameters.AddWithValue("@descricao", tecnica.Descricao);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
            }

            catch (SQLiteException liteEx)
            {
                throw new SQLiteException("Erro ao atualizar ficha: \n" + liteEx);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public void Delete(int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = Dados.StringDeConexao;

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM _tb_fichas WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                cmd.CommandText = "DELETE FROM _tb_vantagens WHERE id_ficha = @id_ficha";
                cmd.Parameters.AddWithValue("@id_ficha", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                cmd.CommandText = "DELETE FROM _tb_desvantagens WHERE id_ficha = @id_ficha";
                cmd.Parameters.AddWithValue("@id_ficha", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                cmd.CommandText = "DELETE FROM _tb_tecnicas WHERE id_ficha = @id_ficha";
                cmd.Parameters.AddWithValue("@id_ficha", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (SQLiteException liteEx)
            {
                throw new Exception("Erro ao tentar deletar ficha: \n" + liteEx);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public DataTable Select(int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = Dados.StringDeConexao;

                DataTable tabela = new DataTable();

                using (var cmd = con.CreateCommand())
                {
                    SQLiteDataAdapter da;

                    if (id == 0)
                        da = new SQLiteDataAdapter("SELECT * FROM _tb_fichas", Dados.StringDeConexao);
                    else
                        da = new SQLiteDataAdapter("SELECT * FROM _tb_fichas WHERE id = " + id, Dados.StringDeConexao);

                    da.Fill(tabela);

                    con.Close();
                    return tabela;
                }
            }

            catch (SQLiteException liteEx)
            {
                throw new Exception("Erro ao tentar encontrar fichas: \n" + liteEx);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public Ficha CarregarFichas(int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = Dados.StringDeConexao;

                Ficha ficha = new Ficha();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM _tb_fichas WHERE id = " + id;
                con.Open();
                SQLiteDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    ficha.Id = Convert.ToInt32(registro["id"]);
                    ficha.Nome = Convert.ToString(registro["nome"]);
                    ficha.Descricao = Convert.ToString(registro["descricao"]);
                    ficha.Arquetipo = Convert.ToString(registro["arquetipo"]);
                    ficha.Pericias = Convert.ToString(registro["pericias"]);
                    ficha.Foto = Convert.ToString(registro["foto"]);
                    ficha.Exp = Convert.ToInt32(registro["exp"]);
                    ficha.Pontos = Convert.ToInt32(registro["pontos"]);
                    ficha.Poder = Convert.ToInt32(registro["poder"]);
                    ficha.Habilidade = Convert.ToInt32(registro["habilidade"]);
                    ficha.Resistencia = Convert.ToInt32(registro["resistencia"]);
                    ficha.Pv = Convert.ToInt32(registro["pv"]);
                    ficha.MaxPv = Convert.ToInt32(registro["pv_max"]);
                    ficha.Pa = Convert.ToInt32(registro["pa"]);
                    ficha.MaxPa = Convert.ToInt32(registro["pa_max"]);
                    ficha.Pm = Convert.ToInt32(registro["pm"]);
                    ficha.MaxPm = Convert.ToInt32(registro["pm_max"]);
                    ficha.Inventario = Convert.ToString(registro["inventario"]);
                }

                con.Close();
                return ficha;
            }

            catch (SQLiteException liteEx)
            {
                throw new Exception("Erro ao tentar carregar ficha: \n" + liteEx);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public Vantagens[] CarregarVantagens(int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = Dados.StringDeConexao;

                Vantagens[] vantagens = null;
                DataTable tabela = new DataTable();

                using (var cmd = con.CreateCommand())
                {
                    SQLiteDataAdapter da;

                    da = new SQLiteDataAdapter("SELECT * FROM _tb_vantagens WHERE id_ficha = " + id, Dados.StringDeConexao);
                    da.Fill(tabela);

                    if (tabela.Rows.Count > 0)
                    {
                        vantagens = new Vantagens[tabela.Rows.Count];

                        for (int i = 0; i < tabela.Rows.Count; i++)
                        {
                            Vantagens vantagem = new Vantagens();

                            vantagem.Nome = Convert.ToString(tabela.Rows[i][1]);
                            vantagem.Descricao = Convert.ToString(tabela.Rows[i][2]);

                            vantagens[i] = vantagem;
                        }
                    }

                    con.Close();
                    return vantagens;
                }
            }

            catch (SQLiteException liteEx)
            {
                throw new Exception("Erro ao tentar carregar vantagens: \n" + liteEx);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public Desvantagens[] CarregarDesvantagens(int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = Dados.StringDeConexao;

                Desvantagens[] desvantagens = null;
                DataTable tabela = new DataTable();

                using (var cmd = con.CreateCommand())
                {
                    SQLiteDataAdapter da;

                    da = new SQLiteDataAdapter("SELECT * FROM _tb_desvantagens WHERE id_ficha = " + id, Dados.StringDeConexao);
                    da.Fill(tabela);

                    if (tabela.Rows.Count > 0)
                    {
                        desvantagens = new Desvantagens[tabela.Rows.Count];

                        for (int i = 0; i < tabela.Rows.Count; i++)
                        {
                            Desvantagens desvantagem = new Desvantagens();

                            desvantagem.Nome = Convert.ToString(tabela.Rows[i][1]);
                            desvantagem.Descricao = Convert.ToString(tabela.Rows[i][2]);

                            desvantagens[i] = desvantagem;
                        }
                    }

                    con.Close();
                    return desvantagens;
                }
            }

            catch (SQLiteException liteEx)
            {
                throw new Exception("Erro ao tentar carregar desvantagens: \n" + liteEx);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public Tecnicas[] CarregarTecnicas(int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = Dados.StringDeConexao;

                Tecnicas[] tecnicas = null;
                DataTable tabela = new DataTable();

                using (var cmd = con.CreateCommand())
                {
                    SQLiteDataAdapter da;

                    da = new SQLiteDataAdapter("SELECT * FROM _tb_tecnicas WHERE id_ficha = " + id, Dados.StringDeConexao);
                    da.Fill(tabela);

                    if (tabela.Rows.Count > 0)
                    {
                        tecnicas = new Tecnicas[tabela.Rows.Count];

                        for (int i = 0; i < tabela.Rows.Count; i++)
                        {
                            Tecnicas tecnica = new Tecnicas();

                            tecnica.Nome = Convert.ToString(tabela.Rows[i][1]);
                            tecnica.Descricao = Convert.ToString(tabela.Rows[i][2]);

                            tecnicas[i] = tecnica;
                        }
                    }

                    con.Close();
                    return tecnicas;
                }
            }

            catch (SQLiteException liteEx)
            {
                throw new Exception("Erro ao tentar carregar técnicas: \n" + liteEx);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public int NextId() 
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection();
                con.ConnectionString = Dados.StringDeConexao;

                DataTable tabela = new DataTable();

                using (var cmd = con.CreateCommand())
                {
                    SQLiteDataAdapter da;

                    da = new SQLiteDataAdapter("SELECT * FROM SQLITE_SEQUENCE WHERE name = '_tb_fichas'", Dados.StringDeConexao);
                    da.Fill(tabela);

                    con.Close();
                    return Convert.ToInt32(tabela.Rows[0][1]) + 1;
                }
            }

            catch (SQLiteException liteEx)
            {
                throw new Exception("Erro ao tentar encontrar o próximo id da ficha: \n" + liteEx);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }
    }
}
