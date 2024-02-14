using Domaine.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Reporitories;

public class SortieRepository : ISortieRepository
{
    public readonly SortieContext _context;

    public SortieRepository(SortieContext context)
    {
        _context = context;
    }

    public int AddSortie(Sortie Sortie)
    {
        try
        {
            var r = _context.Sortie.Add(Sortie);
            _context.SaveChanges();
            return r.Entity.Id;
        } catch (Exception ex)
        {
            throw;
        }
    }
    public Sortie? GetById(int Id)
    {
        try
        {
            var idSortie = _context.Sortie.Find(Id);

            return idSortie;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public Sortie? DelById(int Id)
    {
        try
        {
            var idSortie = _context.Sortie.Find(Id);

            _context.Sortie.Remove(idSortie);
            _context.SaveChanges();

            return idSortie;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public void Put(Sortie updatedSortie)
    {
        try
        {
            // var idEtat = _context.Etat.Find(Id);

            _context.Sortie.Update(updatedSortie);
            _context.SaveChanges();

        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }

}
