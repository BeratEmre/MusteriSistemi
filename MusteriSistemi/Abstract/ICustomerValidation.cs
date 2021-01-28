using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriSistemi.Abstract
{
    interface ICustomerValidation
    {
        bool LastNameValidation(Customer customer);
        bool NameValidation(Customer customer);
    }
}
