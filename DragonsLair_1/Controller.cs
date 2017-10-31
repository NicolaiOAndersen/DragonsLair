using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonsLair_1
{
    public class Controller
    {
        private TournamentRepo tournamentRepository = new TournamentRepo();

        //pascal case public metode samme for public properties.
        public void ShowScore(string tournamentName)
        {
            //Prøver at indhente

            Tournament tournament = tournamentRepository.GetTournament(tournamentName);
            List<Team> teams = tournament.GetTeams();
            List<Team> teamsSorted = new List<Team>();

            for (int i = 0; i < tournament.GetNumberOfRounds(); i++)
            {
                Round currentRound = tournament.GetRound(i);
                List<Team> winningTeams = currentRound.GetWinningTeams();
            }




            //man kunne return string
        }

        public void ScheduleNewRound(string tournamentName, bool printNewMatches = true)
        {

            //GetTournament
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
                        //den skal castes. da vi havde en orderet list.
                        teams = (List<Team>) RandomTeams;

                        Round newRound = new Round();

                        if (teams.Count % 2 != 0)
                        {
                            //NewRound FreeRider bliver brugt.
                            Team OldFreeRider = newRound.GetFreeRider();
                          

                               Team NewFreeRider = teams[0];

                            int x = 0;

                            while (OldFreeRider == NewFreeRider)
                            {

                                x++;
                                NewFreeRider = teams[x];
                            }

                            teams.Remove(NewFreeRider);

                            newRound.AddFreeRider(NewFreeRider);
                        }

                        for (int i = 0; i <= teams.Count; i = i + 2)
                        {

                            Match match = new Match();

                            Team First = teams[i];
                            Team Second = teams[i + 1];

                            match.FirstOpponent = First;
                            match.SecondOpponent = Second;

                            newRound.AddMatch(match);
                        }
                        //
                        tournament.Addround(newRound);

                    }
                    else
                    {
                        tournament.SetStatusFinished();
                        //finished
                    }

                }
                else
                {

                    //throw new System.IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
                    //exception

                    throw new Exception("ERROR Round Not Finished");

                }
            }



        }

        public void SaveMatch(string tournamentName, int roundNumber, string team1, string team2, string winningTeam)
        {
            // Do not implement this method
        }
    }
}
