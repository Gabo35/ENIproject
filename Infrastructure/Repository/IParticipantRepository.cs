using Domaine.Entities;

namespace Infrastructure.Reporitories;

public interface IParticipantRepository
{
    int AddParticipant(Participant Participant);
    Participant? GetById(int Id);
    Participant? DelById(int Id);
    void Put(Participant updatedParticipant);

}
