

using Domaine.Entities;

namespace Application.Services
{
    public interface IRoleServices
    {
        int AddRole(RoleDto Role);
        Role GetRole(int Id);
        Role DelRole(int Id);
        void PutRole(UpdateRoleDto updatedRole);
    }
}
