using mvvm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Models
{
    #region Domain
    //==============================================================================================================================
    //			Domain, Teams, Overloaded Constructors
    //==============================================================================================================================
    public class Teams
    {
        //Variables & Properties
        private string name { get; set; }
        private int rank { get; set; }

        //Constructor
        public Teams(string name, int rank)
        {
            this.name = name;
            this.rank = rank;
        }

        public Teams(string name) : this(name, 0)
        {
            this.name = name;
        }
    }
    #endregion


    #region Repository
    //==============================================================================================================================
    //			Repository, List<Teams>, CRUD
    //==============================================================================================================================
    public class TeamRepo
    {
        //Variables & Properties
        private List<Teams> teams = new List<Teams>();
        private Teams SelTeam { get; }

        #region CRUD
        //================================================================
        //		Create, Read, Update, Delete
        //================================================================
        public void Add(string name, int rank)
        {
            Teams newTeam = new Teams(name, rank);
            teams.Add(newTeam);
        }

        public void Add(string name)
        {
            Teams newTeam = new Teams(name);
            teams.Add(newTeam);
        }

        public void Remove()
        {
            teams.Remove(SelTeam);
        }

        public void UpdateName()
        {

        }

        public void UpdateRank()
        {

        }
        public List<Teams> Retrive()
        {
            return teams;
        }
        #endregion

    }
    #endregion
}
