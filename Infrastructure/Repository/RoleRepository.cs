using Domaine.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Reporitories;

public class RoleRepository : IRoleRepository
{
    public readonly RoleContext _context;

    public RoleRepository(RoleContext context)
    {
        _context = context;
    }

    public int AddRole(Role Role)
    {
        try
        {
            var r = _context.Role.Add(Role);
            _context.SaveChanges();
            return r.Entity.Id;
        } catch (Exception ex)
        {
            throw;
        }
    }
    public Role? GetById(int Id)
    {
        try
        {
            var idRole = _context.Role.Find(Id);

            return idRole;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public Role? DelById(int Id)
    {
        try
        {
            var idRole = _context.Role.Find(Id);

            _context.Role.Remove(idRole);
            _context.SaveChanges();

            return idRole;
        }
        catch (Exception e)
        {
            //return -1;
            throw;
        }
    }
    public void Put(Role updatedRole)
    {
        try
        {
            _context.Role.Update(updatedRole);
            _context.SaveChanges();

        }
        catch (Exception e)
        {
            throw;
        }
    }

}
