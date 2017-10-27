using System;

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
            Round round = new Round();

            Tournament tournament = new Tournament(tournamentName);

            tournament.GetNumberOfRounds();



            if (tournament.GetNumberOfRounds() == 0)
            {
                tournament.GetTeams();
            }
            else
            {
                tournament.GetRound(tournament.GetNumberOfRounds() - 1);

                round.IsMatchesFinished();
            }
            if (round.IsMatchesFinished())
            {
                round.GetWinningTeams();

                //if()

            }


        }

        public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
            // Do not implement this method
        }
    }
}
