using Business.Abstract;
using Core.Ultities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult AddUser(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("Kullanıcı eklendi");
        }

        public IResult DeleteUser(User user)
        {
            _userDal.Delete(user); 
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAllUsers()
        {
            var userList = _userDal.GetAll();
            return new SuccessDataResult<List<User>>(userList);
        }

        public IDataResult<User> GetUserById(int userId)
        {
            var user = _userDal.Get(u => u.UserId == userId);
            return new SuccessDataResult<User>(user);
        }

        public IResult UpdateUser(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
