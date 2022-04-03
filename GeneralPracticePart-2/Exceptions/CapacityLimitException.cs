using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralPracticePart_2.Exceptions
{
    internal class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message) 
        {
         

        }
    }
}
