

using Domaine.Entities;

namespace Application.Services
{
    public interface ILieuServices
    {
        int AddLieu(LieuDto Lieu);
        Lieu GetLieu(int Id);
        Lieu DelLieu(int Id);
        void PutLieu(UpdateLieuDto updatedLieu);
    }
}
