using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lab7_C
{
    internal class Authenticate
    {

        private Student student;
    public bool Login(string username, string userPassword , string userEmail)
        {
            
            return (student.Username== username  && student.UserPassword==userPassword && student.Username==userEmail);
        }

        public bool Login(string username, string userPassword)
        {

            return (student.Username == username && student.UserPassword == userPassword);
        }

        public bool Login(int userID, string userEmail)
        {

            return (student.ID == userID && student.Email == userEmail);

        }

        public string ForgetPassword(string username)
        {
            if (student.Username == username)
            {
                return "User Passed";
            }
            return "User NOT FOUND !!!!";
        }

        public string ForgetPassword(string userEmail,int userID)
        {
            if (student.Email == userEmail&& student.ID==userID)
            {
                return "User Passed";
            }
            return "User NOT FOUND !!!!";
        }
        public string ForgetPassword( int userID)
        {
            if (student.ID == userID)
            {
                return "User Passed";
            }
            return "User NOT FOUND !!!!";
        }

        public bool ResetPassWord(int id , string oldPassword,string newPassword)
        {
            if(student.ID == id && student.UserPassword == oldPassword)
            {
                student.UserPassword = newPassword;
                return true;
            }
            return false;
        }

        public bool ResetPassWord(string Email, string oldPassword, string newPassword)
        {
            if (student.Email == Email && student.UserPassword == oldPassword)
            {
                student.UserPassword = newPassword;
                return true;
            }
            return false;
        }

        public bool ResetPassWord(int id, string userName,string oldPassword, string newPassword)
        {
            if (student.ID == id && student.Username==userName &&student.UserPassword == oldPassword)
            {
                student.UserPassword = newPassword;
                return true;
            }
            return false;
        }



        public void ResetPassword(string username, string newPassword)
        {
            // Implement logic for resetting the password
            Console.WriteLine($"Password for {username} has been reset to {newPassword}");
        }
    }
}
