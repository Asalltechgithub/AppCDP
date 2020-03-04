using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Domain
    {
        public class Atleta
        {
            [Key]
            public int Cod { get; set; }
            public string Nome { get; set; }
            public string SobreNome { get; set; }
            public string Apelido { get; set; }
            public int Categoria { get; set; }
            public int Vitoria { get; set; }
            public int Derrota { get; set; }
            public int Empate { get; set; }
            public Byte[] foto { get; set; }
            public string Modalidade { get; set; }
            public int Equipe { get; set; }
            public string Sexo { get; set; }
            public double Peso { get; set; }
            public double Altura { get; set; }
            public int Idade { get; set; }
            public string CidadeNatal { get; set; }
            public string Nacionalidade { get; set; }
            public Byte[] BandeiraNacional { get; set; }






        }
        public class Atleta_Organizacao
        {
            [Key]
            public int Cod_Atleta { get; set; }
            public int Cod_Organizacao { get; set; }


        }
        public class Categoria
        {
            [Key]
            public int Cod { get; set; }
            public string Nome { get; set; }
        }
        public class Confronto
        {
            public int TipoConfronto { get; set; }
            [Key]
            public int CodConfronto { get; set; }
            public string NomeCategoriadepeso { get; set; }
            public int CodEvento { get; set; }

            public int Categoria { get; set; }
            public string NacionalidadeVermelho { get; set; }
            public Byte[] BandeiraVermelho { get; set; }
            public string NomeVermelho { get; set; }
            public string EquipeV  { get; set; }
            public Byte[] LogoEquipeV { get; set; }
            public double PesoV { get; set; }
            public double AlturaV { get; set; }
            public int IdadeV { get; set; }
            public int VitoriaV { get; set; }
            public int DerrotaV { get; set; }
            public int EmpateV { get; set; }
            public int cVermelho { get; set; }
            public Byte[] FotoVermelho { get; set; }

            public string NacionalidadeAzul { get; set; }
            public Byte[] BandeiraAzul { get; set; }
            public string NomeAzul { get; set; }
            public string EquipeA { get; set; }
            public Byte[] LogoEquipeA { get; set; }
            public double PesoA { get; set; }
            public double AlturaA { get; set; }
            public int IdadeA { get; set; }
            public int VitoriaA { get; set; }
            public int DerrotaA { get; set; }
            public int EmpateA { get; set; }
            public int cAzul { get; set; }
            public Byte[] FotoAzul { get; set; }
            public int Vencedor { get; set; }
            public string DescriResultado { get; set; }
            public string Status { get; set; }




        }
        public class Equipe
        {
            [Key]
            public int Cod { get; set; }
            public string Nome { get; set; }
            public Byte[] Logo { get; set; }
        }
        public class Evento
        {
            public int Organizacao { get; set; }
            [Key]
            public int Cod { get; set; }
            public string Nome { get; set; }

            public DateTime DtEvento { get; set; }
            public string Local_Evento { get; set; }


        }
        public class GrupoUsuario
        {
            [Key]
            public int Id { get; set; }
            public string Nome { get; set; }
        }
        public class Organizacao
        {
            [Key]
            public int Cod { get; set; }
            public string Nome { get; set; }
            public string Logo { get; set; }
        }
        public class Patrocinador
        {
            [Key]
            public int cod { get; set; }
            public string Nome { get; set; }
            public string Logo { get; set; }
        }
        public class Patrocinador_Evento
        {
            [Key]
            public int codEvento { get; set; }
            public int patrocinador { get; set; }

        }
        public class clsView
        {
            public dynamic Item1 { get;set;}
            public dynamic Item2 { get; set; }
            public dynamic Item3 { get; set; }
            public dynamic Item4 { get; set; }
            public dynamic Item5 { get; set; }
            public dynamic Item6 { get; set; }
            public dynamic Item7 { get; set; }
            public dynamic Item8 { get; set; }
            public dynamic Item9 { get; set; }


        }

        public class Ranking
        {
            public int Campeao { get; set; }
            public int primeiro { get; set; }
            public int segundo { get; set; }
            public int terceiro { get; set; }
            public int quarto { get; set; }

        }
    }
}
