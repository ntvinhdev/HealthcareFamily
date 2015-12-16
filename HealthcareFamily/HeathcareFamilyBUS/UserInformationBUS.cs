﻿using HealthcareFamilyDTO;
using HealthcareFamilyDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyBUS
{
    public class UserInformationBUS
    {
        public UserInformation LoadUserInformation(String username)
        { 
            UserInformationDAL user = new UserInformationDAL();
            return user.LoadUserInformation(username);
        }
    }
}