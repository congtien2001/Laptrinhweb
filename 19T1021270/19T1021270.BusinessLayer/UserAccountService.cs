﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19T1021270.DataLayers;
using _19T1021270.DomainModels;

namespace _19T1021270.BusinessLayers
{
    /// <summary>
    /// Các chức năng tác nghiệp liên quan đến tài khoản
    /// </summary>
    public static class UserAccountService
    {
        private static IUserAccountDAL employeeAccountDB;
        private static IUserAccountDAL customerAccountDB;

        static UserAccountService()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            employeeAccountDB = new _19T1021270.DataLayers.SQLServer.EmployeeAccountDAL(connectionString);
            customerAccountDB = new _19T1021270.DataLayers.SQLServer.CustomerAccountDAL(connectionString);
        }

        public static UserAccount Authorize(AccountTypes accountType, string userName, string password)
        {
            if (accountType == AccountTypes.Employee)
                return (UserAccount)employeeAccountDB.Authorize(userName, password);
            else
                return (UserAccount)customerAccountDB.Authorize(userName, password);
        }

        public static bool ChangePassword(AccountTypes accountType, string userName, string oldPassword, string newPassword)
        {
            if (accountType == AccountTypes.Employee)
                return employeeAccountDB.ChangePassword(userName, oldPassword, newPassword);
            else
                return customerAccountDB.ChangePassword(userName, oldPassword, newPassword);
        }

    }

    public class AccountTypes
    {
        public static AccountTypes Employee { get; internal set; }
    }
}