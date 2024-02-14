using Domaine.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Reporitories;

public class EtatRepository : IEtatRepository
{
    public readonly EtatContext _context;

    public EtatRepository(EtatContext context)
    {
        _context = context;
    }

    public int AddEtat(Etat Etat)
    {
        try
        {
            var r = _context.Etat.Add(Etat);
            _context.SaveChanges();
            return r.Entity.Id;
        } catch (Exception ex)
        {
            return -1;
            throw;
        }
    }
    public Etat? GetById(int Id)
    {
        try
        {
            var idEtat = _context.Etat.Find(Id);

            return idEtat;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public Etat? DelById(int Id)
    {
        try
        {
            var idEtat = _context.Etat.Find(Id);

            _context.Etat.Remove(idEtat);
            _context.SaveChanges();

            return idEtat;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public void Put(Etat updatedEtat)
    {
        try
        {
            // var idEtat = _context.Etat.Find(Id);

            _context.Etat.Update(updatedEtat);
            _context.SaveChanges();

        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }

}
