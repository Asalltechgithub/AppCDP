using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Domain;

namespace DAL
{
    public interface IDAL
    {

        Atleta InsertAtleta(Atleta obj);
        Atleta UpdateAtleta(Atleta obj);
        void Delete(int Id);
        DataTable GetAllAtleta();
        Atleta GetAtletabyID(int Id);
        DataTable GetAllAtletabyCategoria(int Id);
        void AddVitoria(int Id);
        void AddDerrota(int Id);
        Atleta_Organizacao GetAtletaOrganizacaoById(int Id);
        DataTable GetAtletaByOrganizacao();
        void InsertCategoria(Categoria obj);
        void UpdateCategoria(Categoria obj);
        void DeleteCategoria(int Id);
        Categoria GetById(int Id);
        DataTable GetAllCategoria();
        void InserirConfronto(Confronto obj);
        void UpdateConfronto(Confronto obj);
        void DeleteConfronto(int Id);
        DataTable GetConfrontos();
        DataTable GetConfrontosByEvento(int CodEvento);
        DataTable GetConfrontosByAtleta(int CodAtleta);
        Confronto GetConfrontoPicAtleta(int CodConfronto);
        Confronto GetObjConfrontoById(int CodConfronto);
        string GetConfrontoById(int CodConfronto);

        void AlterarResultadoConfronto(int Id_Confronto, int IdVencedor);
        void InsertEquipe(Equipe obj);
        void UpdateEquipe(Equipe obj);
        void DeleteEquipe(int Id);
        Equipe GetEquipeById(int Id);
        DataTable GetAllEquipe();


        void InsertEvento(Evento obj);
        void UpdateEvento(Evento obj);
        void DeleteEvento(int Id);
        DataTable GetEventos();
        Evento GetEventoById(int Id);
        int GetLastEvento();

        void InsertGrupoUsuario(GrupoUsuario obj);
        void UpdateGrupoUsuario(GrupoUsuario obj);
        void DeleteGrupoUsuario(int Id);
        DataTable GetAllGrupoUsuario();
        GrupoUsuario GetGrupoUsuariobyID(int Id);


        void InsertOrganizacao(Organizacao obj);
        void UpdateOrganizacao(Organizacao obj);
        void DeleteOrganizacao(int Id);

        Organizacao GetOrganizacaoById(int Id);
        DataTable GetAllOrganizacao();
        void InsertPatrocinador(Patrocinador obj);
        void UpdatePatrocinador(Patrocinador obj);
        void DeletePatrocinador(int Id);
        Patrocinador GetByIdPatrocinador(int Id);
        DataTable GetAllPatrocinador();
        Patrocinador_Evento GetPatrocinador_EventoById(int Id);
        DataTable GetPatrocinadorByEvento();

        void UpdateRanking(Ranking obj);
        Ranking getRanking();
    }
    
}
