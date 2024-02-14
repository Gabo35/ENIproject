using Domaine.Entities;

namespace Infrastructure.Reporitories;

public interface IRoleRepository
{
    int AddRole(Role Role);
    Role? GetById(int Id);
    Role? DelById(int Id);
    void Put(Role updatedRole);

}
