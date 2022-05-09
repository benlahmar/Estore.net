using UserService.Entities;

namespace UserService.Repository
{
    public class UserRepository : IUser
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public User addRole(Role role, int iduser)
        {
            User? u = _context.users.Find(iduser);
            if (u != null)
            { 
                u.Roles.Add(role);
                _context.users.Update(u);
                _context.SaveChanges();
            }
            return u;
        }

        public  Task<User> auth(string username, string password)
        {
            User? u =  _context.users.FirstOrDefault(x => x.Username == username && x.Password == password);
            return u;
        }

        public IEnumerable<User> findall()
        {
           return  _context.users.ToList();
        }

        public IEnumerable<User> findall(string role)
        {
            Role r = _context.roles.Where(r => r.Name == role).First();
            List<User> us = _context.users.Where<User>(u => u.Roles.Contains(r)).ToList();
            return us;
        }

        public User findone(int id)
        {
            User? u = _context.users.Find(id);
            return u;
        }

        public Role findrole(int id)
        {
            Role? rt = _context.roles.Find(id);
            return rt;
        }

        public User removeRole(string role, int iduser)
        {
            Role r = _context.roles.Where(r => r.Name == role).First();
            User? ut = _context.users.Find(iduser);
            ut.Roles.Remove(r);
            _context.Update<User>(ut);
            _context.SaveChanges();
            return ut;
        }

        public int save(User u)
        {
            _context.users.Add(u);
            return _context.SaveChanges();
        }

        public int saverole(Role role)
        {
            _context.roles.Add(role);
            return _context.SaveChanges();
        }

        public User update(User u)
        {
            User? ut = _context.users.Find(u.Id);
            ut.Username=u.Username;
            ut.FirstName=u.FirstName;
            ut.Password=u.Password;
            _context.Update(ut);
            _context.SaveChanges();
            return ut;
        }
    }
}
