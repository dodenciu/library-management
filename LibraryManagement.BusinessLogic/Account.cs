using LibraryManagement.BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BusinessLogic
{
    public abstract class Account
    {
        private String id;
        private String password;
        private AccountStatus status;
        private Person person;

        public abstract bool resetPassword();
    }
}
