using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRC.Portal.Data.Domains;
using FRC.Portal.Data;

namespace FRC.Portal.Services.Services
{
    public class TeamService
    {
        // There will be a logging system in the future for our system.
        // Catch part of try-catch statements will be empty until the development of logging system
        DbContext db = new DbContext();

        public Team Select(int Id)
        {
            /*
             * params: Id = Team Id
             *
             * In this method, system just selects the team by its Id from database
             */
            try
            {
                Team _team = db.Teams.Find(Id);
                return _team;
            }
            catch (Exception e)
            {
                return null;
            }
           
        }

        public bool Insert(Team _team)
        {
            /*
             * params: _team = an instance of Team class
             *
             * In this method, the instance gotten as parameter will be saved to database
             */
            try
            {
                db.Teams.Add(_team);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            /*
             * params: Id = Team Id
             *
             * In this method, the instance will be found by its Id and removed from Team table
             */
            try
            {
                Team _team = db.Teams.Find(Id);
                db.Teams.Remove(_team);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Update(Team _team)
        {
            /*
            * params: _team = an instance of Team class
            *
            * In this method, the instance will be updated by its attributes automatically
            * By using Entry([model]).State, we don't have to call it separately...
            * ...we just need to give the instance instead
            */
            try
            {
                db.Entry(_team).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<Team> GetTeams()
        {
            /*
            * no-params
            *
            * In this method, we will select all the teams from database
            */
            try
            {
                List<Team> teams = (from e in db.Teams
                    orderby e.TeamNumber
                    select e).ToList();
                return teams;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
