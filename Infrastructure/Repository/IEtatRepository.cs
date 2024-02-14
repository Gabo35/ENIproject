using Domaine.Entities;

namespace Infrastructure.Reporitories;

public interface IEtatRepository
{
    int AddEtat(Etat Etat);
    Etat? GetById(int Id);
    Etat? DelById(int Id);
    void Put(Etat updatedEtat);

}
