using AutoMapper;
using Domaine.Entities;
using Infrastructure.Reporitories;

namespace Application.Services
{
    public class SortieServices : ISortieServices
    {
        public ISortieRepository _rsortieRepository { get; set; }
        public IMapper _mapper { get; set; }

        public SortieServices(ISortieRepository rsortieRepository, IMapper mapper)
        {
            _rsortieRepository = rsortieRepository;
            _mapper = mapper;
        }
        public int AddSortie(SortieDto Sortie)
        {
            var sortie = _mapper.Map<Sortie>(Sortie);
            return _rsortieRepository.AddSortie(sortie);
        }
        public Sortie GetSortie(int id)
        {
            var sortie = _rsortieRepository.GetById(id);
            if (sortie != null)
            {
                var dtoPourAvoirIdSortie = _mapper.Map<Sortie>(sortie);
                return dtoPourAvoirIdSortie;
            }
            return null;
        }
        public Sortie DelSortie(int id)
        {
            var sortie = _rsortieRepository.GetById(id);
            if (sortie != null)
            {
                _rsortieRepository.DelById(id);
                return sortie;
            }
            return null;
        }
        public void PutSortie(UpdateSortieDto updatedSortie)
        {
            var sortie = _rsortieRepository.GetById(updatedSortie.Id);
            if (sortie != null)
            {
                sortie.Nom = updatedSortie.Nom;
                sortie.DateDebut = updatedSortie.DateDebut;
                sortie.DateFin = updatedSortie.DateFin;
                sortie.OrganisateurId = updatedSortie.OrganisateurId;
                sortie.LieuId = updatedSortie.LieuId;
                sortie.EtatId = updatedSortie.EtatId;
                _rsortieRepository.Put(sortie);
            }
        }

    }
}
