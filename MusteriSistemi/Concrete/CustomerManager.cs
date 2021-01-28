using MusteriSistemi.Abstract;
using MusteriSistemi.Message;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriSistemi.Concrete
{
    class CustomerManager : ICustomerService
    {
        Messages _messages;
        ICustomerValidation _customerValidation;
        public CustomerManager(Messages messages,ICustomerValidation customerValidation)
        {
            _messages = messages;
            _customerValidation=customerValidation;
        }
        public void Add(Customer customer)
        {
            _customerValidation.NameValidation(customer);
            _customerValidation.LastNameValidation(customer);
            Console.WriteLine(_messages.Added);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(_messages.Deleted);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(_messages.Updated);
        }
    }
}
