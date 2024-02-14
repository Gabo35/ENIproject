using Infrastructure.Reporitories;
using Domaine.Entities;
using AutoMapper;

namespace Application.Services
{
    public class InscriptionServices : IInscriptionServices
    {
        public IInscriptionRepository _rinscriptionRepository { get; set; }
        public IMapper _mapper { get; set; }

        public InscriptionServices(IInscriptionRepository rinscriptionRepository, IMapper mapper)
        {
            _rinscriptionRepository = rinscriptionRepository;
            _mapper = mapper;
        }
        public int AddInscription(InscriptionDto Inscription)
        {
            var inscription = _mapper.Map<Inscription>(Inscription);
            return _rinscriptionRepository.AddInscription(inscription);
        }
        public Inscription GetInscription(int id)
        {
            var inscription = _rinscriptionRepository.GetById(id);
            if (inscription != null)
            {
                var dtoPourAvoirIdInscription = _mapper.Map<Inscription>(inscription);
                return dtoPourAvoirIdInscription;
            }
            return null;
        }
        public Inscription DelInscription(int id)
        {
            var inscription = _rinscriptionRepository.GetById(id);
            if (inscription != null)
            {
                _rinscriptionRepository.DelById(id);
                return inscription;
            }
            return null;
        }
        public void PutInscription(UpdateInscriptionDto updatedInscription)
        {
            var inscription = _rinscriptionRepository.GetById(updatedInscription.Id);
            if (inscription != null)
            {
                inscription.SortieId = updatedInscription.SortieId;
                inscription.ParticipantId = updatedInscription.ParticipantId;
                _rinscriptionRepository.Put(inscription);
            }
        }
    }
}
