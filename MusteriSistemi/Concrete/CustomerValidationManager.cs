using MusteriSistemi.Abstract;
using MusteriSistemi.Message;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriSistemi.Concrete
{
    class CustomerValidationManager : ICustomerValidation
    {
        Messages _messages;
        public CustomerValidationManager(Messages messages)
        {
             _messages= messages;
        }
        public bool LastNameValidation(Customer customer)
        {
            if (customer.LastName.Length<4|| customer.LastName.Length>15)
            {
                Console.WriteLine(_messages.LastNameLength);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool NameValidation(Customer customer)
        {
            if (customer.Name.Length < 2 || customer.Name.Length > 12)
            {
                Console.WriteLine(_messages.NameLength);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
