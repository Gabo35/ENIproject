

using Domaine.Entities;

namespace Application.Services
{
    public interface ISortieServices
    {
        int AddSortie(SortieDto Sortie);
        Sortie GetSortie(int Id);
        Sortie DelSortie(int Id);
        void PutSortie(UpdateSortieDto updatedSortie);
    }
}
