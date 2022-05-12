using MiniPrs_C37.Models;


namespace MiniPrs_C37.Controllers {
    public class UsersController {

        private AppDbContext _context = new AppDbContext();

        #region GetUsers()
        public List<User> GetUsers() {
            return _context.Users.ToList();
        }
        #endregion

        #region GetUser()
        public User GetUser(int id) {
            return _context.Users.Find(id)!;
        }
        #endregion
        
        #region AddUser()
        public User AddUser(User user) {
            _context.Users.Add(user);
            var rowsAffected = _context.SaveChanges();
            if(rowsAffected != 1) {
                throw new Exception("AddUser failed!");
            }
            return user;
        }
        #endregion
        
        #region UpdateUser()
        public void UpdateUser(User user) {
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("UpdateUser failed!");
            }
        }
        #endregion
        
        #region DeleteUser()
        public void DeleteUser(int id) {
            var user = GetUser(id);
            if(user is null) {
                throw new Exception("User not found!");
            }
            _context.Users.Remove(user);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("DeleteUser failed!");
            }
        }
        #endregion
    }
}
