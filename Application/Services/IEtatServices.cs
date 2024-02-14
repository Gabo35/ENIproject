


using Domaine.Entities;

namespace Application.Services
{
    public interface IEtatServices
    {
        int AddEtat(EtatDto Etat);
        Etat GetEtat(int Id);
        Etat DelEtat(int Id);
        void PutEtat(UpdateEtatDto updatedEtat);

    }
}
