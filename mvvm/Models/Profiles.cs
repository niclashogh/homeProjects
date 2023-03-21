using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Models
{
    #region Enumerations
    //==============================================================================================================================
    //			Enumerations, Roles & Teams
    //==============================================================================================================================
    public enum Roles
	{
		Role1, Role2, Role3, Role4, Role5, Role6,
	}

    public enum Teams
	{
		Team1, Team2, Team3, Team4, Team5, Team6,
	}
	#endregion

	#region Domain
	//==============================================================================================================================
	//			Domain, Profiles, Overloaded Constructors
	//==============================================================================================================================
    public class Profiles
	{
		//Variables & Properties
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string ingName;
		public string IngName
		{
			get { return ingName; }
			set { ingName = value; }
		}

		internal Roles role { get; set; }
        internal Teams team { get; set; }

        internal bool active { get; set; }

		//Constructors
		public Profiles(string name, string ingName, Roles role, Teams team, bool active)
		{
			this.name = name;
			this.ingName = ingName;
			this.role = role;
			this.team = team;
			this.active = active;
		}

		public Profiles(string ingName, Roles role, Teams team, bool active) : this("", ingName, role, team, active)
		{
			this.ingName = ingName;
			this.role = role;
			this.team = team;
			this.active = active;
		}
	}
    #endregion

    #region Repository
    //==============================================================================================================================
    //			Repository, List<Profiles>, CRUD
    //==============================================================================================================================
    public class ProfileRepo
	{
		//Variables & Properties
		private List<Profiles> profile = new List<Profiles>();
		private string sqlLink = "";
		private Profiles selProfile { get; }

        #region Add & Remove
        //================================================================
		//		Add & Remove
		//================================================================
        public void Add(string name, string ingName, Roles role, Teams team, bool active)
		{
			Profiles newProfile = new Profiles(name, ingName, role, team, active);
			profile.Add(newProfile);
		}

        public void Add(string ingName, Roles role, Teams team, bool active)
        {
            Profiles newProfile = new Profiles(ingName, role, team, active);
            profile.Add(newProfile);
        }

        public void Remove()
        {
			string ingName = selProfile.IngName;
			int index = 0;

			foreach (Profiles item in profile)
			{
				bool findOccaurance = profile[index].IngName == ingName;
				if (findOccaurance)
				{
					profile.RemoveAt(index);
					break;
				}
				else
				{
					index++;
				}
			}
		}
        #endregion

        #region Update
        //================================================================
        //		Update attr.
        //================================================================
        public void UpdateName(string name, int index)
		{
			profile[index].Name = name;
		}

		public void UpdateIngName(string ingName, int index)
		{
			profile[index].IngName = ingName;
		}

		public void UpdateRole(Roles role, int index)
		{
			profile[index].role = role;
		}

		public void UpdateTeam(Teams team, int index)
		{
			profile[index].team = team;
		}

		public void UpdateActive(bool active, int index)
		{
			profile[index].active = active;
		}
        #endregion

        #region Read
        //================================================================
        //		Read & Load Data
        //================================================================
		public List<Profiles> Read()
		{
			return profile;
		}

		public void Load()
		{
			//Load from dataset
		}
        #endregion
    }
    #endregion
}
