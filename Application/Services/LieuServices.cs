using Infrastructure.Reporitories;
using Domaine.Entities;
using AutoMapper;

namespace Application.Services
{
    public class LieuServices : ILieuServices
    {
        public ILieuRepository _rlieuRepository { get; set; }
        public IMapper _mapper { get; set; }

        public LieuServices(ILieuRepository rlieuRepository, IMapper mapper)
        {
            _rlieuRepository = rlieuRepository;
            _mapper = mapper;
        }
        public int AddLieu(LieuDto Lieu)
        {
            var lieu = _mapper.Map<Lieu>(Lieu);
            return _rlieuRepository.AddLieu(lieu);
        }
        public Lieu GetLieu(int id)
        {
            var lieu = _rlieuRepository.GetById(id);
            if (lieu != null)
            {
                var dtoPourAvoirIdLieu = _mapper.Map<Lieu>(lieu);
                return dtoPourAvoirIdLieu;
            }
            return null;
        }
        public Lieu DelLieu(int id)
        {
            var lieu = _rlieuRepository.GetById(id);
            if (lieu != null)
            {
                _rlieuRepository.DelById(id);
                return lieu;
            }
            return null;
        }
        public void PutLieu(UpdateLieuDto updatedLieu)
        {
            var lieu = _rlieuRepository.GetById(updatedLieu.Id);
            if (lieu != null)
            {
                lieu.Etablissement = updatedLieu.Etablissement;
                lieu.Ville = updatedLieu.Ville;
                lieu.Adresse = updatedLieu.Adresse;
                lieu.CodePostal = updatedLieu.CodePostal;
                lieu.CoordonneesGPS = updatedLieu.CoordonneesGPS;
                _rlieuRepository.Put(lieu);
            }
        }
    }
}
