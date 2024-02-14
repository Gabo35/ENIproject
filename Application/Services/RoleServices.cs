using AutoMapper;
using Domaine.Entities;
using Infrastructure.Reporitories;


namespace Application.Services
{
    public class RoleServices : IRoleServices
    {
        public IRoleRepository _rroleRepository { get; set; }
        public IMapper _mapper { get; set; }

        public RoleServices(IRoleRepository rroleRepository, IMapper mapper)
        {
            _rroleRepository = rroleRepository;
            _mapper = mapper;
        }
        public int AddRole(RoleDto Role)
        {
            var role = _mapper.Map<Role>(Role);
            return _rroleRepository.AddRole(role);
        }
        public Role GetRole(int id)
        {
            var role = _rroleRepository.GetById(id);
            if (role != null)
            {
                var dtoPourAvoirIdRole = _mapper.Map<Role>(role);
                return dtoPourAvoirIdRole;
            }
            return null;
        }
        public Role DelRole(int id)
        {
            var role = _rroleRepository.GetById(id);
            if (role != null)
            {
                _rroleRepository.DelById(id);
                return role;
            }
            return null;
        }
        public void PutRole(UpdateRoleDto updatedRole)
        {
            var role = _rroleRepository.GetById(updatedRole.Id);
            if (role != null)
            {
                role.Libelle = updatedRole.Libelle;
                _rroleRepository.Put(role);
            }
        }
    }
}
