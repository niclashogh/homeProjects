using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Models
{
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

        internal bool active { get; set; }

		//Constructors
		public Profiles(string name, string ingName, Roles role, bool active)
		{
			this.name = name;
			this.ingName = ingName;
			this.role = role;
			this.active = active;
		}

		public Profiles(string ingName, Roles role, bool active) : this("", ingName, role, active)
		{
			this.ingName = ingName;
			this.role = role;
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
		private static List<Profiles> profile = new List<Profiles>();
		private Profiles selProfile { get; }

        #region Add & Remove
        //================================================================
		//		Add & Remove
		//================================================================
        public void Add(string name, string ingName, Roles role, bool active)
		{
			Profiles newProfile = new Profiles(name, ingName, role, active);
			profile.Add(newProfile);
		}

        public void Add(string ingName, Roles role, bool active)
        {
            Profiles newProfile = new Profiles(ingName, role, active);
            profile.Add(newProfile);
        }

        public void Remove()
        {
			profile.Remove(selProfile);

			/*
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
			*/
		}
        #endregion

        #region Update
        //================================================================
        //		Update attr.
        //================================================================
        public void UpdateName(string name, int index) //Updates in list (only needs to update in sql)
		{
			profile[index].Name = name;
		}

		public void UpdateIngName(string ingName, int index) //Updates in list (only needs to update in sql)
        {
			profile[index].IngName = ingName;
		}

		public void UpdateRole(Roles role, int index) //Updates in list (only needs to update in sql)
        {
			profile[index].role = role;
		}

		public void UpdateActive(bool active, int index) //Updates in list (only needs to update in sql)
        {
			profile[index].active = active;
		}
        #endregion

        #region Read
        //================================================================
        //		List & Load Data
        //================================================================
        public static List<Profiles> Retrive()
		{
			Load();
			return profile;
		}

		public static void Load()
		{
			sql_controller.Connect();
			SqlCommand cmd = new SqlCommand("SELECT Name, IngName, Role, Active FROM PROFILES", sql_controller.db_conn);

			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				while (reader.Read())
				{
					Profiles loadProfile = new Profiles((string)reader["Name"], (string)reader["IngName"], (Roles)Enum.Parse(typeof(Roles), reader["Role"].ToString()), (bool)reader["Active"]);

					profile.Add(loadProfile);
				}
			}
			sql_controller.Disconnect();
		}
        #endregion
    }
    #endregion
}
