using AutoMapper;
using Domaine.Entities;
using Infrastructure.Reporitories;

namespace Application.Services
{
    public class ParticipantServices : IParticipantServices
    {
        public IParticipantRepository _rparticipantRepository { get; set; }
        public IMapper _mapper { get; set; }

        public ParticipantServices(IParticipantRepository rparticipantRepository, IMapper mapper)
        {
            _rparticipantRepository = rparticipantRepository;
            _mapper = mapper;
        }
        public int AddParticipant(ParticipantDto Participant)
        {
            var participant = _mapper.Map<Participant>(Participant);
            return _rparticipantRepository.AddParticipant(participant);
        }
        public Participant GetParticipant(int id)
        {
            var participant = _rparticipantRepository.GetById(id);
            if (participant != null)
            {
                var dtoPourAvoirIdparticipant = _mapper.Map<Participant>(participant);
                return dtoPourAvoirIdparticipant;
            }
            return null;
        }
        public Participant DelParticipant(int id)
        {
            var participant = _rparticipantRepository.GetById(id);
            if (participant != null)
            {
                _rparticipantRepository.DelById(id);
                return participant;
            }
            return null;
        }
        public void PutParticipant(UpdateParticipantDto updatedParticipant)
        {
            var participant = _rparticipantRepository.GetById(updatedParticipant.Id);
            if (participant != null)
            {
                participant.Nom = updatedParticipant.Nom;
                participant.Prenom = updatedParticipant.Prenom;
                participant.Mail = updatedParticipant.Mail;
                participant.RoleId = updatedParticipant.RoleId;
                _rparticipantRepository.Put(participant);
            }
        }
    }
}
