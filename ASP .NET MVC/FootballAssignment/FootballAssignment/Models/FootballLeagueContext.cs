using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FootballAssignment.Models
{
    public class FootballLeagueContext
    {
        string CS = ConfigurationManager.ConnectionStrings["FootballLeagueContext"].ConnectionString;
        List<FootballLeague> resultList = new List<FootballLeague>();

        public bool AddMatchResult(FootballLeague footballLeagueObject)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand("AddMatchResult", connection);

                command.CommandType = CommandType.StoredProcedure; 

                command.Parameters.AddWithValue("@TeamName1", footballLeagueObject.TeamName1);
                command.Parameters.AddWithValue("@TeamName2", footballLeagueObject.TeamName2);
                command.Parameters.AddWithValue("@WinningTeam", footballLeagueObject.WinningTeam);
                command.Parameters.AddWithValue("@Status", footballLeagueObject.Status);
                command.Parameters.AddWithValue("@Points", footballLeagueObject.Points);
                SqlParameter OutputParameter = new SqlParameter();
                OutputParameter.ParameterName = "@MatchId";
                OutputParameter.SqlDbType = SqlDbType.Int;
                OutputParameter.Direction = ParameterDirection.Output;

                command.Parameters.Add(OutputParameter);

                connection.Open(); 

                int statementinsertedcount = command.ExecuteNonQuery(); 

                string MatchID = OutputParameter.Value.ToString(); 
                footballLeagueObject.MatchId = Convert.ToInt32(MatchID); 
                Console.WriteLine(footballLeagueObject.MatchId);

                if (statementinsertedcount >= 1)
                    return true;
                else
                    return false;
            }
            
        }
        public List<FootballLeague> Details()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand("Select * From FootballLeague", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                connection.Open(); //please create bean instead opf opening connection in eveery func
                dataAdapter.Fill(dataTable);
                foreach ( DataRow dataRow in dataTable.Rows)
                {
                    resultList.Add(new FootballLeague { MatchId = Convert.ToInt32(dataRow["MatchId"]),
                                                TeamName1 = Convert.ToString(dataRow["TeamName1"]),
                                                 TeamName2 = Convert.ToString(dataRow["TeamName2"]),
                                                Status = Convert.ToString(dataRow["Status"]),
                                                WinningTeam = Convert.ToString(dataRow["WinningTeam"]),
                                               Points = Convert.ToInt32(dataRow["Points"])
                    });
                }
                return resultList;
            }
        }

        public List<FootballLeague> DisplayWinningTeamNames()
        {
            List<FootballLeague> resultList = new List<FootballLeague>();
            using(SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand("WinningTeamDetails",connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    resultList.Add(new FootballLeague
                    {
                        MatchId = Convert.ToInt32(dataRow["MatchId"]),
                        TeamName1 = Convert.ToString(dataRow["TeamName1"]),
                        TeamName2 = Convert.ToString(dataRow["TeamName2"]),
                        Status = Convert.ToString(dataRow["Status"]),
                        WinningTeam = Convert.ToString(dataRow["WinningTeam"]),
                        Points = Convert.ToInt32(dataRow["Points"])
                    });
                }

            }
            return resultList;
        }

        public List<FootballLeague> TeamNameisJapan()
        {
            using (SqlConnection connection = new SqlConnection(CS)) {

                SqlCommand command = new SqlCommand("TeamNameisJapan", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    resultList.Add(new FootballLeague
                    {
                        MatchId = Convert.ToInt32(dataRow["MatchId"]),
                        TeamName1 = Convert.ToString(dataRow["TeamName1"]),
                        TeamName2 = Convert.ToString(dataRow["TeamName2"]),
                        Status = Convert.ToString(dataRow["Status"]),
                        WinningTeam = Convert.ToString(dataRow["WinningTeam"]),
                        Points = Convert.ToInt32(dataRow["Points"])
                    });
                }
                
            }
            return resultList;
        }
    }
}