

using Domaine.Entities;

namespace Application.Services
{
    public interface IInscriptionServices
    {
        int AddInscription(InscriptionDto Inscription);
        Inscription GetInscription(int Id);
        Inscription DelInscription(int Id);
        void PutInscription(UpdateInscriptionDto updatedInscription);
    }
}
