using System.Collections.Generic;

namespace DragonsLair_1
{
    public class Round
    {
        public List<Match> matches = new List<Match>();

        private Team FreeRider = new Team("");

        public void AddMatch(Match m)
        {
            matches.Add(m);
        }
        //overload
        public Match GetMatch(string teamName1, string teamName2)
        {
            //man kunne lave en foreach hvor man breaker når man finder den,
            //det er ikke det kønneste men det virker.
            Match resultat = null;

            foreach(Match match in matches)
            {
                if((match.FirstOpponent.Name == teamName1 && match.SecondOpponent.Name == teamName2) || (match.FirstOpponent.Name == teamName2 && match.SecondOpponent.Name == teamName1))
                {
                    resultat = match;
                    break;
                }
            }

            return resultat;
        }
        public Match GetMatch(string team)
        {
            Match resultat = null;

            foreach (Match match in matches)
            {
                if (match.FirstOpponent.Name == team || match.SecondOpponent.Name == team)
                {
                    resultat = match;
                    break;
                }
            }
            return resultat;
           
        }
        public bool IsMatchesFinished()
        {
            bool isFinished = false;

            foreach (Match match in matches)
            {
                if (matches != null)
                {
                    isFinished = true;
                }
            }
            return isFinished;
        }
            
        public List<Team> GetWinningTeams()
        {
            List<Team> winner = new List<Team>();

            foreach (Match match in matches)
            {
                    winner.Add(match.Winner);
            }

            
            return winner;
        }

        public List<Team> GetLosingTeams()
        {
            //Compare if one team did not win
            List<Team> loser = new List<Team>();

            foreach(Match match in matches)
            {
                //Instansering.
                if(match.FirstOpponent.Name != match.Winner.Name)
                {
                    loser.Add(match.FirstOpponent);
                }
                else
                {
                    loser.Add(match.SecondOpponent);
                }
                
            }

            return loser;
        }
        public Team GetFreeRider()
        {
            //TODO skriv metoden

           


            return this.FreeRider;
        }

        public void AddFreeRider(Team FreeRider)
        {
            
           this.FreeRider = FreeRider;
            

        }

    }
}
