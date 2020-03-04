using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using static Domain.Domain;

namespace DAL
{
    public class clsDao : IDAL
    {
        private static SqlConnection conexao()
        {

            
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-6UOMJI2\SQLEXPRESS;Initial Catalog=bdCDP;Integrated Security=True");

            cn.Open();
            return cn;
        }





        public Atleta InsertAtleta(Atleta obj)
        {
            string query = "Insert into Atleta(Nome,Sobrenome,Apelido,Categoria,Vitoria,Derrota,Empate,foto,Modalidade,Equipe,Sexo,Altura,Peso,Idade,Nacionalidade,CidadeNatal,Bandeira) Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,P@15,P@16,P@17)";
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P1", obj.Nome);
                        cmd.Parameters.AddWithValue("@P2", obj.SobreNome);
                        cmd.Parameters.AddWithValue("@P3", obj.Apelido);
                        cmd.Parameters.AddWithValue("@P4", obj.Categoria);
                        cmd.Parameters.AddWithValue("@P5", obj.Vitoria);
                        cmd.Parameters.AddWithValue("@P6", obj.Derrota);
                        cmd.Parameters.AddWithValue("@P7", obj.Empate);
                        cmd.Parameters.AddWithValue("@P8", obj.foto);
                        cmd.Parameters.AddWithValue("@P9", obj.Modalidade);
                        cmd.Parameters.AddWithValue("@P10", obj.Equipe);
                        cmd.Parameters.AddWithValue("@P11", obj.Sexo);
                        cmd.Parameters.AddWithValue("@P12", obj.Altura);
                        cmd.Parameters.AddWithValue("@P13", obj.Peso);
                        cmd.Parameters.AddWithValue("P@14", obj.Idade);
                        cmd.Parameters.AddWithValue("P@15", obj.Nacionalidade);
                        cmd.Parameters.AddWithValue("P@16", obj.BandeiraNacional);
                        cmd.Parameters.AddWithValue("P@17", obj.CidadeNatal);

                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return obj;

        }

        public Atleta UpdateAtleta(Atleta obj)
        {
            try
            {
                string query = "Update Atleta set Nome=@P1,SobreNome=@P2,Apelido=@P3,Categoria=@P4,Vitoria=@P5,Derrota=@P6,Empate=@P7,foto=@P8,Modalidade=@P9,Equipe=@P10,Sexo=@P11,Altura=@P12,Peso=@P13,Idade=@P14,Nacionalidade=@P15,Bandeira=@P16,CidadeNatal=@P17 where Cod =" + obj.Cod;
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P1", obj.Nome);
                        cmd.Parameters.AddWithValue("@P2", obj.SobreNome);
                        cmd.Parameters.AddWithValue("@P3", obj.Apelido);
                        cmd.Parameters.AddWithValue("@P4", obj.Categoria);
                        cmd.Parameters.AddWithValue("@P5", obj.Vitoria);
                        cmd.Parameters.AddWithValue("@P6", obj.Derrota);
                        cmd.Parameters.AddWithValue("@P7", obj.Empate);
                        cmd.Parameters.AddWithValue("@P8", obj.foto);
                        cmd.Parameters.AddWithValue("@P9", obj.Modalidade);
                        cmd.Parameters.AddWithValue("@P10", obj.Equipe);
                        cmd.Parameters.AddWithValue("@P11", obj.Sexo);
                        cmd.Parameters.AddWithValue("@P12", obj.Altura);
                        cmd.Parameters.AddWithValue("@P13", obj.Peso);
                        cmd.Parameters.AddWithValue("@P14", obj.Idade);
                        cmd.Parameters.AddWithValue("@P15", obj.Nacionalidade);
                        cmd.Parameters.AddWithValue("@P16", obj.BandeiraNacional);
                        cmd.Parameters.AddWithValue("@P17", obj.CidadeNatal);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }

            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }

            return obj;

        }

        public void Delete(int Id)
        {
            string query = "delete from Atleta where Cod =" + Id;
            try
            {

                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {

                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }

            }
            catch
            {

            }

        }

        public DataTable GetAllAtleta()
        {
            DataTable dt = new DataTable();
            List<Atleta> listAtleta = new List<Atleta>();
            string query = "select * from Atleta";
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);
                    }
                }
            }
            catch
            {


            }
            return dt;
        }
        






        public Atleta GetAtletabyID(int Id)
        {
            SqlDataReader dr;
            Atleta a = new Atleta();
            string query = "select * from Atleta where Cod=" + Id;
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        dr = cmd.ExecuteReader();



                        dr.Read();


                        a.Cod = int.Parse(dr["Cod"].ToString());
                        a.Nome = dr["Nome"].ToString();
                        a.SobreNome = dr["Sobrenome"].ToString();
                        a.Apelido = dr["Apelido"].ToString();
                        a.Categoria = int.Parse(dr["Categoria"].ToString());
                        a.Equipe = int.Parse(dr["Equipe"].ToString());
                        a.Sexo = dr["Sexo"].ToString();
                        a.Modalidade = dr["Modalidade"].ToString();
                        a.Vitoria = int.Parse(dr["Vitoria"].ToString());
                        a.Derrota = int.Parse(dr["Derrota"].ToString());
                        a.Empate = int.Parse(dr["Empate"].ToString());
                        a.foto =(Byte[])dr["foto"];
                        a.Altura = (double)dr["Altura"];
                        a.Peso = (double)dr["Peso"];
                        a.Idade = (int)dr["Idade"];
                        a.Nacionalidade = dr["Nacionalidade"].ToString();
                        a.BandeiraNacional = (Byte[])dr["Bandeira"];
                        a.CidadeNatal = dr["CidadeNatal"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();

            }
            return a;
        }

       
        
       


        public void AddVitoria(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void AddDerrota(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public Atleta_Organizacao GetAtletaOrganizacaoById(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public DataTable GetAtletaByOrganizacao()
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void InsertCategoria(Categoria obj)
        {
            string query = "Insert into Categoria(Nome) Values(@P1)";
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P1", obj.Nome);


                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        public void UpdateCategoria(Categoria obj)
        {
            string query = "update Categoria set Nome=@P1 where cod=" + obj.Cod;
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P1", obj.Nome);


                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public void DeleteCategoria(int Id)
        {
            string query = "delete from Categoria where cod=" + Id;
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {

                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public Categoria GetById(int Id)
        {
            SqlDataReader dr;
            Categoria c = new Categoria();
            string query = "select * from Categoria where cod =" + Id;
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        dr = cmd.ExecuteReader();






                        c.Cod = int.Parse(dr["cod"].ToString());
                        c.Nome = dr["Nome"].ToString();



                    }
                }
            }
            catch
            {


            }
            return c;
        }

        public DataTable GetAllCategoria()
        {
            DataTable dt = new DataTable();
            List<Categoria> listCat = new List<Categoria>();
            string query = "select * from Categoria";
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);

                    }
                }
            }
            catch
            {


            }
            return dt;
        }

        public void InserirConfronto(Confronto obj)
        {
            string query = "Insert into Confronto (TipoConfronto,CodEvento,Categoria,cVermelho,cAzul,Vencedor,DescriResultado,Status) Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)";
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P2", obj.CodEvento);
                        cmd.Parameters.AddWithValue("@P1", obj.TipoConfronto);
                        cmd.Parameters.AddWithValue("@P3", obj.Categoria);
                        cmd.Parameters.AddWithValue("@P4", obj.cVermelho);
                        cmd.Parameters.AddWithValue("@P5", obj.cAzul);
                        cmd.Parameters.AddWithValue("@P6", obj.Vencedor);
                        cmd.Parameters.AddWithValue("@P7", obj.DescriResultado);
                        cmd.Parameters.AddWithValue("@P8", obj.Status);

                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

        }

        public void UpdateConfronto(Confronto obj)
        {
            string query = "Update Confronto set TipoConfronto=@P1,CodEvento=@P2,Categoria=@P3,cVermelho=@P4,cAzul=@P5,Vencedor=@P6,DescriResultado=@P7 where CodConfronto=" + obj.CodConfronto;
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P1", obj.TipoConfronto);
                        cmd.Parameters.AddWithValue("@P2", obj.CodEvento);
                        cmd.Parameters.AddWithValue("@P3", obj.Categoria);
                        cmd.Parameters.AddWithValue("@P4", obj.cVermelho);
                        cmd.Parameters.AddWithValue("@P5", obj.cAzul);
                        cmd.Parameters.AddWithValue("@P6", obj.Vencedor);
                        cmd.Parameters.AddWithValue("@P7", obj.DescriResultado);

                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public void DeleteConfronto(int Id)
        {
            string query = "delete from Confronto  where CodConfronto=" + Id;
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {


                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public DataTable GetConfrontos()
        {
            DataTable dt = new DataTable();
            List<dynamic> listCat = new List<dynamic>();
            string query = "select * from Categoria";
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);

                    }
                }
            }
            catch
            {


            }
            return dt;
        }

        public DataTable GetConfrontosByEvento(int CodEvento)
        {

            DataTable dt = new DataTable();

            








            StringBuilder sb = new StringBuilder();
            sb.Append("select e.Cod 'Cod Evento',  e.Nome 'Evento',cat.Nome 'Categoria',a.SobreNome 'corner Vermelho', ");
            sb.Append("a1.SobreNome 'corner Azul', c.CodConfronto'Cod Confronto' ,c.Status from Confronto c ");
            sb.Append("inner join Atleta a on c.cVermelho = a.Cod inner join Atleta a1 on c.cAzul = a1.Cod ");
            sb.Append("inner join Categoria cat on cat.cod = c.Categoria ");
            sb.Append("inner join Evento e  on e.Cod = c.CodEvento  where c.CodEvento = "+ CodEvento + " and c.Status = 'Agendado' " );

            string query = sb.ToString();
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);
                             

                    }
                }
            }
            catch
            {


            }
            return dt;
        }

        public DataTable GetConfrontosByAtleta(int CodAtleta)
        {

            DataTable dt = new DataTable();
            List<dynamic> listCat = new List<dynamic>();
            string query = "select e.Nome 'Evento',cat.Nome 'Categoria',a.SobreNome 'corner Vermelho',a1.SobreNome 'corner Azul',a2.SobreNome'Vencedor' from Confronto c inner join Atleta a on c.cVermelho = a.Cod inner join Atleta a1 on c.cAzul = a1.Cod inner join Atleta a2 on c.Vencedor = a2.Cod inner join Categoria cat on cat.cod = c.Categoria inner join Evento e  on e.Cod = c.CodEvento where  a.Cod =@codAtleta or a1.Cod=@codAtleta or a2.Cod =@codAtleta";
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        
                        cmd.Parameters.AddWithValue("@codAtleta", CodAtleta);
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);


                    }
                }
            }
            catch(Exception ex)
            {
                ex.Message.ToString();

            }
            return dt;
        }

        public string GetConfrontoById(int CodConfronto)
        {
            dynamic confronto = new ExpandoObject();
            SqlDataReader dr;
            List<dynamic> listCat = new List<dynamic>();
            string query = "select e.Nome 'Evento',cat.Nome 'Categoria',a.Nome 'corner Vermelho',a.foto ,a1.Nome 'corner Azul' a1.foto,a2.Nome'Vencedor' from Confronto c inner join Atleta a on c.cVermelho = a.Cod inner join Atleta a1 on c.cAzul = a1.Cod inner join Atleta a2 on c.Vencedor = a2.Cod  inner join Categoria cat on cat.cod = c.Categoria inner join Evento e  on e.Cod = c.CodEvento where  c.CodConfronto =" + CodConfronto;
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {


                            confronto.Evento = dr["Evento"].ToString();
                            confronto.categoria = dr["Categoria"].ToString();
                            confronto.cornerVermelho = dr["corner Vermelho"].ToString();
                            confronto.cornerAzul = dr["corner Azul"].ToString();
                            confronto.Vencedor = dr["Vencedor"].ToString();
                            
                        }

                    }
                }
            }
            catch
            {


            }
            return confronto;
        }
        public Confronto GetObjConfrontoById(int CodConfronto)
        {
            dynamic confronto = new ExpandoObject();
            SqlDataReader dr;
            Confronto c = new Confronto();
            string query = "select * from Confronto where CodConfronto =" + CodConfronto;
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        dr = cmd.ExecuteReader();
                        dr.Read();
                       

                            c.CodConfronto = (int)dr["CodConfronto"];
                            c.CodEvento = (int)dr["CodEvento"];
                            c.Categoria = (int)dr["Categoria"];
                            c.cVermelho = (int)dr["cVermelho"];
                            c.cAzul = (int)dr["cAzul"];
                            c.Vencedor = (int)dr["Vencedor"];
                            c.DescriResultado = dr["DescriResultado"].ToString();
                        

                    }
                }
            }
            catch(Exception ex)
            {


            }
            return c;
        }
        public Confronto GetConfrontoPicAtleta(int CodConfronto)
        {
           
            SqlDataReader dr;
            Confronto c = new Confronto();
            string query = "select a.Nome'NomeV', a.SobreNome'SobreNomeV',a.Idade'IdadeV',a.Peso'PesoV',a.Altura'AlturaV',a.Bandeira'BandeiraV', a.Vitoria 'VitoriaV',a.Derrota 'DerrotaV',a.Empate'EmpateV' ,eqV.Nome 'Nome EquipeV' , EqV.Logo 'Logo EquipeV', a.foto'Vermelho' , a1.Nome'NomeA', a1.SobreNome'SobreNomeA',a1.Idade'IdadeA',a1.Peso'PesoA',a1.Altura'AlturaA',a1.Bandeira'BandeiraA',a1.Vitoria 'VitoriaA',a1.Derrota 'DerrotaA',a1.Empate'EmpateA',Eqa.Nome 'Nome EquipeA' , Eqa.Logo 'Logo EquipeA' ,a1.foto'Azul',cat.Nome'Categoria' from Confronto c inner join Atleta a on c.cVermelho = a.Cod inner join Atleta a1 on c.cAzul = a1.Cod  inner join Categoria cat on cat.cod = c.Categoria inner join Equipe Eqa on eqa.Cod= a1.Equipe inner join Equipe EqV on EqV.Cod =a.Equipe inner join Evento e  on e.Cod = c.CodEvento where  c.CodConfronto =" + CodConfronto;
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        dr = cmd.ExecuteReader();
                        dr.Read();

                        c.FotoVermelho = (Byte[])dr["Vermelho"];
                        c.FotoAzul = (Byte[])dr["Azul"];
                        string NomeVermelho = dr["NomeV"].ToString();
                        string SobreNomeVermelho = dr["SobreNomeV"].ToString();
                        string NomeAzul = dr["NomeA"].ToString();
                        string SobreNomeAzul = dr["SobreNomeA"].ToString();
                        
                        c.NomeVermelho = NomeVermelho + " " + SobreNomeVermelho;
                        c.NomeAzul = NomeAzul + " " + SobreNomeAzul;
                        c.VitoriaA = (int)dr["VitoriaA"];
                        c.DerrotaA = (int)dr["DerrotaA"];
                        c.EmpateA = (int)dr["EmpateA"];
                        c.EquipeA = dr["Nome EquipeA"].ToString();
                        c.LogoEquipeA = (Byte[])dr["Logo EquipeA"];
                        c.AlturaA = (double)dr["AlturaA"];
                        c.IdadeA =(int)dr["IdadeA"];
                        c.PesoA = (double)dr["PesoA"];
                        c.VitoriaV = (int)dr["VitoriaV"];
                        c.DerrotaV = (int)dr["DerrotaV"];
                        c.EmpateV = (int)dr["EmpateV"];
                        c.EquipeV = dr["Nome EquipeV"].ToString();
                        c.LogoEquipeV = (Byte[])dr["Logo EquipeV"];
                        c.AlturaV =(double)dr["AlturaV"];
                        c.IdadeV =(int)dr["IdadeV"];
                        c.PesoV = (double)dr["PesoV"];
                        c.NomeCategoriadepeso = dr["Categoria"].ToString();
                        c.BandeiraAzul = (Byte[])dr["BandeiraA"];
                        c.BandeiraVermelho = (Byte[])dr["BandeiraV"];
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return c;
        }

        public void AlterarResultadoConfronto(int Id_Confronto, int IdVencedor)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void InsertEquipe(Equipe obj)
        {
            string query = "Insert into Equipe (Nome,Logo) Values(@P1,@P2)";
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P1", obj.Nome);
                        cmd.Parameters.AddWithValue("@P2", obj.Logo);


                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public void UpdateEquipe(Equipe obj)
        {
            string query = "Update Equipe  set  Nome=@P1,Logo=@P2 where Cod="+obj.Cod;
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P1", obj.Nome);
                        cmd.Parameters.AddWithValue("@P2", obj.Logo);


                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public void DeleteEquipe(int Id)
        {
            string query = "delete from  Equipe  where Cod =" + Id;
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public Equipe GetEquipeById(int Id)
        {
            SqlDataReader dr;
            Equipe e = new Equipe();
            string query = "select * from Equipe where Cod=" + Id;
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        e.Cod = int.Parse(dr["Cod"].ToString());
                        e.Nome = dr["Nome"].ToString();
                        e.Logo = (Byte[])dr["Logo"];

                    }

                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return e;
        }


        public DataTable GetAllEquipe()
        {
            DataTable dt = new DataTable();
            
            string query = "select * from Equipe";
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);
                        

                    }
                }
            }
            catch
            {


            }
            return dt;
        }

        public void InsertEvento(Evento obj)
        {
            string query = "Insert into Evento (Organizacao,Nome,DtEvento,Local_Evento) Values(@P1,@P2,@P3,@P4)";
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P1", obj.Organizacao);
                        cmd.Parameters.AddWithValue("@P2", obj.Nome);
                        cmd.Parameters.AddWithValue("@P3", obj.DtEvento);
                        cmd.Parameters.AddWithValue("@P4", obj.Local_Evento);


                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public void UpdateEvento(Evento obj)
        {
            string query = "Update  Evento  set Organizacao=@P1,Nome=@P2,DtEvento=@P3,Local_Evento=@P4) where Cod =" + obj.Cod;
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@P1", obj.Organizacao);
                        cmd.Parameters.AddWithValue("@P2", obj.Nome);
                        cmd.Parameters.AddWithValue("@P3", obj.DtEvento);
                        cmd.Parameters.AddWithValue("@P4", obj.Local_Evento);


                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public void DeleteEvento(int Id)
        {
            string query = "delete from  Evento where Cod =" + Id;
            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {

                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public DataTable GetEventos()
        {
            DataTable dt = new DataTable();
            List<Evento> listEvento = new List<Evento>();
            string query = "select * from Evento";
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);

                    }
                }
            }
            catch
            {


            }
            return dt;
        }

        public Evento GetEventoById(int Id)
        {
            SqlDataReader dr;
            Evento e = new Evento();
            string query = "select * from Evento where Cod=" + Id;
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        dr = cmd.ExecuteReader();

                        dr.Read();
                        e.Cod = int.Parse(dr["Cod"].ToString());
                        e.Nome = dr["Nome"].ToString();
                        e.Local_Evento = dr["Local_Evento"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {


            }
            return e;
        }
        public int GetLastEvento()
        {
            SqlDataReader dr;
            Evento e = new Evento();
            string query = "select max(Cod)'Cod' from Evento ";
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        e.Cod = int.Parse(dr["Cod"].ToString());

                    }
                }
            }
            catch(Exception ex )
            {

                ex.Message.ToString();
            }
            return e.Cod;
        }

        public void InsertGrupoUsuario(GrupoUsuario obj)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void UpdateGrupoUsuario(GrupoUsuario obj)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void DeleteGrupoUsuario(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public DataTable GetAllGrupoUsuario()
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public GrupoUsuario GetGrupoUsuariobyID(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void InsertOrganizacao(Organizacao obj)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void UpdateOrganizacao(Organizacao obj)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void DeleteOrganizacao(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public Organizacao GetOrganizacaoById(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public DataTable GetAllOrganizacao()
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void InsertPatrocinador(Patrocinador obj)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void UpdatePatrocinador(Patrocinador obj)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public void DeletePatrocinador(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public Patrocinador GetByIdPatrocinador(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public DataTable GetAllPatrocinador()
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public Patrocinador_Evento GetPatrocinador_EventoById(int Id)
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public DataTable GetPatrocinadorByEvento()
        {
            try
            {

            }
            catch
            {

            }
            throw new NotImplementedException();
        }

        public DataTable GetAllAtletabyCategoria(int Id)
        {
            DataTable dt = new DataTable();
            List<Atleta> la = new List<Atleta>();
            Atleta a = new Atleta();
            string query = "select * from Atleta where Categoria=" + Id;
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);



                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();

            }
            return dt;
        }

        public void UpdateRanking( Ranking obj)
        {
            string query = "Update Ranking set atleta=@Campeao where Posicao = 1 Update Ranking set atleta=@Primeiro where Posicao = 2 Update Ranking set atleta=@Segundo where Posicao = 3 Update Ranking set atleta=@Terceiro where Posicao = 4 Update Ranking set atleta=@Quarto where Posicao = 5";

            try
            {
                using (SqlConnection cn = conexao())
                {

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@Campeao", obj.Campeao);
                        cmd.Parameters.AddWithValue("@Primeiro", obj.primeiro);
                        cmd.Parameters.AddWithValue("@Segundo", obj.segundo);
                        cmd.Parameters.AddWithValue("@Terceiro", obj.terceiro);
                        cmd.Parameters.AddWithValue("@Quarto", obj.quarto);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public Ranking getRanking()
        {
            SqlDataReader dr;
            Ranking r = new Ranking();
            List<Ranking> lr = new List<Ranking>();
            string query = "select * from Ranking";
            try
            {
                using (SqlConnection cn = conexao())
                {
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            if (Convert.ToInt16(dr["Posicao"]) == 1)
                            {
                                r.Campeao = (int)dr["Atleta"];
                                lr.Add(r);
                            }
                            if (Convert.ToInt16(dr["Posicao"]) == 2)
                            {
                                r.primeiro = (int)dr["Atleta"];
                                lr.Add(r);
                            }
                            if (Convert.ToInt16(dr["Posicao"]) == 3)
                            {
                                r.segundo = (int)dr["Atleta"];
                                lr.Add(r);
                            }
                            if (Convert.ToInt16(dr["Posicao"]) == 4)
                            {
                                r.terceiro = (int)dr["Atleta"];
                                lr.Add(r);
                            }
                            if (Convert.ToInt16(dr["Posicao"]) == 5)
                            {
                                r.quarto = (int)dr["Atleta"];
                                lr.Add(r);
                            }




                        }
                        
                    }
                }
            }
            catch
            {


            }
            return r;
        }
    }
}
