using SevenDev.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SevenDev.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<int> InsertAsync(User user);
        Task<User> GetByLoginAsync(string login);
        Task<User> GetByIdAsync(int id);
        Task UpdateAsync(User user);
        Task<int> InsertInviteAsync(int userIdInvited, int userIdReceive);
        Task<InviteFriends> GetInviteByIds(int userIdInvited, int userIdReceive);
        Task AcceptDeniedInviteAsync(int idInvite, int accept, int denied);
        Task<List<InviteFriends>> GetAllInvitesReceiveAsync(int userIdReceive);

    }
}
