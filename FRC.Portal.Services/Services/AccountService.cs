using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRC.Portal.Common.Enums;
using FRC.Portal.Data;
using FRC.Portal.Data.Domains;

namespace FRC.Portal.Services.Services
{
    public class AccountService
    {
        // There will be a logging system in the future for our system.
        // Catch part of try-catch statements will be empty until the development of logging system

        // DbContext is our variable to connect to database
        // We defined this in FRC.Portal.Data class library, you may check
        DbContext db = new DbContext();

        public List<Account> GetUsers()
        {
            /*
             * no-params
             *
             * In this method, we will get all the system users
             */
            try
            {
                List<Account> accounts = (from u in db.Accounts
                    where u.IsDeleted == false
                    orderby u.UserName
                    select u).ToList();
                return accounts;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Account Select(int Id)
        {
            /*
             * params: Id = Account Id
             *
             * In this method, we will get the row from Accounts table by its Id
             */
            try
            {
                Account _account = db.Accounts.Find(Id);
                return _account;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Insert(Account _account)
        {
            /*
             * params: _account = an instance of Account class
             *
             * In this method, the instance got as parameter will be saved to database
             */
            try
            {
                _account.IsDeleted = false;
                _account.CreatedOn = DateTime.Now;
                _account.ModifiedOn = DateTime.Now;
                db.Accounts.Add(_account);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(Account _account)
        {
            /*
            * params: _account = an instance of Account class
            *
            * In this method, the instance will be updated by its attributes automatically
            * By using Entry([model]).State, we don't have to call it separately...
            * ...we just need to give the instance instead
            */
            try
            {
                db.Entry(_account).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CheckUser(int Id)
        {
            /*
             * params: Id = Account Id
             *
             * In this method, we will check the user by its Id to return a boolean value
             */
            try
            {
                Account _account = db.Accounts.Find(Id);
                return _account != null ? true : false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Delete(int Id)
        {
            /*
             * params: Id = Account Id
             *
             * In this method, the instance will be found by its Id and removed from Accounts table
             * Removing will be done by changing its IsDeleted attribute :)
             * Nothing will be deleted :)
             */
            try
            {
                Account _account = db.Accounts.Find(Id);
                _account.IsDeleted = true;
                db.Entry(_account).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Account> GetAccounts()
        {
            /*
            * no-params
            *
            * In this method, we will select all the teams from database
            */
            try
            {
                List<Account> accounts = (from u in db.Accounts
                    where u.UserRole == EnumAccountType.Team
                    select u).ToList();
                return accounts;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
