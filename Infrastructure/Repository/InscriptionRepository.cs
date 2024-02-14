using Domaine.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Reporitories;

public class InscriptionRepository : IInscriptionRepository
{
    public readonly InscriptionContext _context;

    public InscriptionRepository(InscriptionContext context)
    {
        _context = context;
    }

    public int AddInscription(Inscription Inscription)
    {
        try
        {
            var r = _context.Inscription.Add(Inscription);
            _context.SaveChanges();
            return r.Entity.Id;
        } catch (Exception ex)
        {
            throw;
        }
    }
    public Inscription? GetById(int Id)
    {
        try
        {
            var idInscription = _context.Inscription.Find(Id);

            return idInscription;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public Inscription? DelById(int Id)
    {
        try
        {
            var idInscription = _context.Inscription.Find(Id);

            _context.Inscription.Remove(idInscription);
            _context.SaveChanges();

            return idInscription;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public void Put(Inscription updatedInscription)
    {
        try
        {
            _context.Inscription.Update(updatedInscription);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            throw;
        }
    }

}
