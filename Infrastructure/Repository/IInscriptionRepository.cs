using Domaine.Entities;

namespace Infrastructure.Reporitories;

public interface IInscriptionRepository
{
    int AddInscription(Inscription Inscription);
    Inscription? GetById(int Id);
    Inscription? DelById(int Id);
    void Put(Inscription updatedInscription);
}
