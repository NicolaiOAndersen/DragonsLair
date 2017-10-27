using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonsLair_1
{
    public class Controller
    {
        private TournamentRepo tournamentRepository = new TournamentRepo();

        public void ShowScore(string tournamentName)
        {   
            /*
             * TODO: Calculate for each team how many times they have won
             * Sort based on number of matches won (descending)
             */
            Console.WriteLine("Implement this method!");
        }

        public void ScheduleNewRound(string tournamentName, bool printNewMatches = true)
        {

         Tournament tournament = tournamentRepository.GetTournament(tournamentName);
            

           
           int RoundTotal = tournament.GetNumberOfRounds();
            
            //definer variabel
            List<Team> teams;

            

            if (RoundTotal == 0)
            {
                teams = tournament.GetTeams();
            }
            else
            {
                //LastRound = runden som lige er blevet spillet.
                Round LastRound = tournament.GetRound(tournament.GetNumberOfRounds() - 1);

                bool IsRoundFinished = LastRound.IsMatchesFinished();


                if (IsRoundFinished)
                {
                    teams = LastRound.GetWinningTeams();

                    if (teams.Count >= 2)
                    {

                        //spooks, tjek
                        var rnd = new Random();
                        var RandomTeams = teams.OrderBy(item => rnd.Next());

                        Round newRound = new Round();

                        if (teams.Count % 2 == 0)
                        {
                            OldFreeRider = LastRound.

                        }


                    }
                    else
                    {

                        //finished
                    }

                }
                else
                {

                    //exception

                }
            }

        }

        public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
            // Do not implement this method
        }
    }
}
