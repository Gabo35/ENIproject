using Domaine.Entities;

namespace Infrastructure.Reporitories;

public interface ISortieRepository
{
    int AddSortie(Sortie Sortie);
    Sortie? GetById(int Id);
    Sortie? DelById(int Id);
    void Put(Sortie updatedSortie);
}
