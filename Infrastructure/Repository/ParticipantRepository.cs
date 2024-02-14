using Domaine.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Reporitories;

public class ParticipantRepository : IParticipantRepository
{
    public readonly ParticipantContext _context;

    public ParticipantRepository(ParticipantContext context)
    {
        _context = context;
    }

    public int AddParticipant(Participant Participant)
    {
        try
        {
            var r = _context.Participant.Add(Participant);
            _context.SaveChanges();
            return r.Entity.id;
        } catch (Exception ex)
        {
            throw;
        }
    }
    public Participant? GetById(int Id)
    {
        try
        {
            var idParticipant = _context.Participant.Find(Id);

            return idParticipant;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public Participant? DelById(int Id)
    {
        try
        {
            var idParticipant = _context.Participant.Find(Id);

            _context.Participant.Remove(idParticipant);
            _context.SaveChanges();

            return idParticipant;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public void Put(Participant updatedParticipant)
    {
        try
        {
            _context.Participant.Update(updatedParticipant);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            throw;
        }
    }

}
