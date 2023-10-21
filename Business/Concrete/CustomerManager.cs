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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUserDal _userDal;

        public CustomerManager(ICustomerDal customerDal, IUserDal userDal)
        {
            _customerDal = customerDal;
            _userDal = userDal;
        }

        public IResult AddCustomer(Customer customer)
        {
            var user = _userDal.Get(u => u.UserId == customer.UserId);
            if(user==null)
            {
                return new ErrorResult("kullanıcı bulunamadı."); 
            }
            _customerDal.Add(customer);
            return new SuccessResult("müşteri eklendi.");

        }

        public IResult DeleteCustomer(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAllCustomers()
        {
            var customerss = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(customerss);
        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            var cut = _customerDal.Get(p => p.UserId == customerId);
            return new SuccessDataResult<Customer>(cut);
        }

        public IResult UpdateCustomer(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
