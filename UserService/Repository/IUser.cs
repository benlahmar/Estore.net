using UserService.Entities;

namespace UserService.Repository
{
    public interface IUser
    {
        int save(User u);
        User update(User u);
        IEnumerable<User> findall();
        IEnumerable<User> findall(string role);
        User findone(int id);
        Role findrole(int id);
        int saverole(Role role);
        User addRole(Role role, int iduser);
        User removeRole(String role, int iduser);
        User auth(string username,string password); 

    }
}
