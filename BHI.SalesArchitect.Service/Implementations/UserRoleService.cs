﻿using BHI.SalesArchitect.Infrastructure.Repositories;
using BHI.SalesArchitect.Model.DB;

namespace BHI.SalesArchitect.Service.Implementations
{
    public class UserRoleService : IUserRoleService
    {
        private IUserRoleRepository _userRoleRepository;
        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
        }

        public Task<bool> AddUserRole(int userId, int roleId)
        {
            UserRole ur = new()
            {
                UserId = userId,
                RoleId = roleId
            };
            return _userRoleRepository.AddUserRole(ur);
        }

        public async Task<bool> DeleteUserRole(int userId)
        {
            var userRole = GetByUserId(userId);
            return await _userRoleRepository.DeleteUserRole(userRole);
        }

        public UserRole GetByUserId(int userId)
        {
            return _userRoleRepository.GetByUserId(userId);
        }

        public IEnumerable<UserRole> GetByUserIds(List<int> userIds)
        {
            return _userRoleRepository.GetByUserIds(userIds).ToList();
        }

        public async Task<bool> UpdateUserRole(int userId, int roleId)
        {
            var userRole = GetByUserId(userId);
            if (userRole.RoleId != roleId)
            {
                userRole.RoleId = roleId;
                return await _userRoleRepository.UpdateUserRole(userRole);
            }
            return true;
        }
    }
}
