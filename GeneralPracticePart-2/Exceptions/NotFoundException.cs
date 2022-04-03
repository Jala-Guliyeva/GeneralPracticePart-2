using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralPracticePart_2.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {
           
        }
    }
}
