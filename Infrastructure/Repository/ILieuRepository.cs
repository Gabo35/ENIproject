using Domaine.Entities;

namespace Infrastructure.Reporitories;

public interface ILieuRepository
{
    int AddLieu(Lieu Lieu);
    Lieu? GetById(int Id);
    Lieu? DelById(int Id);
    void Put(Lieu updatedLieu);

}
