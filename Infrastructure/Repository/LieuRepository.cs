using Domaine.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Reporitories;

public class LieuRepository : ILieuRepository
{
    public readonly LieuContext _context;

    public LieuRepository(LieuContext context)
    {
        _context = context;
    }

    public int AddLieu(Lieu Lieu)
    {
        try
        {
            var r = _context.Lieu.Add(Lieu);
            _context.SaveChanges();
            return r.Entity.Id;
        } catch (Exception ex)
        {
            throw;
        }
    }
    public Lieu? GetById(int Id)
    {
        try
        {
            var idLieu = _context.Lieu.Find(Id);

            return idLieu;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public Lieu? DelById(int Id)
    {
        try
        {
            var idLieu = _context.Lieu.Find(Id);

            _context.Lieu.Remove(idLieu);
            _context.SaveChanges();

            return idLieu;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public void Put(Lieu updatedLieu)
    {
        try
        {
            _context.Lieu.Update(updatedLieu);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            throw;
        }
    }

}
