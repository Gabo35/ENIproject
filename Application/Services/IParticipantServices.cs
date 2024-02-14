

using Domaine.Entities;

namespace Application.Services
{
    public interface IParticipantServices
    {
        int AddParticipant(ParticipantDto Participant);
        Participant GetParticipant(int Id);
        Participant DelParticipant(int Id);
        void PutParticipant(UpdateParticipantDto updatedParticipant);
    }
}
