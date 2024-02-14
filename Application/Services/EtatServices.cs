using AutoMapper;
using Infrastructure.Reporitories;
using Domaine.Entities;


namespace Application.Services
{
    public class EtatServices : IEtatServices
    {
        public IEtatRepository _retatRepository { get; set; }
        public IMapper _mapper {  get; set; }

        public EtatServices(IEtatRepository retatRepository, IMapper mapper)
        {
            _retatRepository = retatRepository;
            _mapper = mapper;
        }
        public int AddEtat(EtatDto Etat)
        {
            var etat = _mapper.Map<Etat>(Etat);
            return _retatRepository.AddEtat(etat);
        }

        public Etat GetEtat(int id)
        {
            var etat = _retatRepository.GetById(id);
            if (etat != null)
            {
                var dtoPourAvoirIdEtat = _mapper.Map<Etat>(etat);
                return dtoPourAvoirIdEtat;
            }
            return null;
        }

        public Etat DelEtat(int id)
        {
            var etat = _retatRepository.GetById(id);
            if (etat != null)
            {
                _retatRepository.DelById(id);
                return etat;
            }
            return null;
        }
        public void PutEtat(UpdateEtatDto updatedEtat)
        {
            var etat = _retatRepository.GetById(updatedEtat.Id);
            if (etat != null)
            {
                etat.Libelle = updatedEtat.Libelle;
                _retatRepository.Put(etat);
            }
        }
    }
}
