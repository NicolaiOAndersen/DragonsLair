﻿using System;
using System.Collections.Generic;

namespace DragonsLair_1
{
    public class Tournament
    {
        public string Name { get; set; }

        public bool StatusFinish { get; set; }

        public Tournament(string tournamentName)
        {
            Name = tournamentName;
            StatusFinish = false;
        }

        public List<Team> GetTeams()
        {
            
            return new List<Team>(new Team[] {
                new Team("The Valyrians"),
                new Team("The Spartans"),
                new Team("The Cretans"),
                new Team("The Thereans"),
                new Team("The Coans"),
                new Team("The Cnideans"),
                new Team("The Megareans"),
                new Team("The Corinthians")
            });
        }
        public Team GetTeam(string winner)
        {

            Team resultat = null;
            foreach(var team in GetTeams())
            {
                if (team.Name == winner)
                {
                    resultat = team;
                }
                
            }

            return resultat;
        }
        

        private List<Round> Rounds = new List<Round>();

        public int GetNumberOfRounds()
        {
            
            return Rounds.Count;
        }
        public void Addround(Round round)
        {
            Rounds.Add(round);
        }
        public void SetStatusFinished()
        {
            //Lav en attribute, mangler status attribute.
            //Måske skal det håndteres i controller.
            //Der bliver tilføjet en property
            StatusFinish = true;

        }
        
        public Round GetRound(int idx)
        {
            //return Rounds[idx];
            Round r = new Round();
            if(idx == 0)
            {


                Match match1 = new Match();
                match1.FirstOpponent = new Team("The Valyrians");
                match1.SecondOpponent = new Team("The Spartans");
                match1.Winner = new Team("The Valyrians");

                r.AddMatch(match1);

                Match match2 = new Match();
                match2.FirstOpponent = new Team("The Cretans");
                match2.SecondOpponent = new Team("The Thereans");
                //match2.Winner = new Team("The Thereans");

                r.AddMatch(match2);

                Match match3 = new Match();
                match3.FirstOpponent = new Team("The Coans");
                match3.SecondOpponent = new Team("The Cnideans");
                //match3.Winner = new Team("The Coans");

                r.AddMatch(match3);

                Match match4 = new Match();
                match4.FirstOpponent = new Team("The Megareans");
                match4.SecondOpponent = new Team("The Corinthians");
                //match4.Winner = new Team("The Corinthians");

                r.AddMatch(match4);

                Addround(r);

            }
            
            //else if (idx == 1)
            //{
            //    Match match1 = new Match();
            //    match1.FirstOpponent = new Team("The Valyrians");
            //    match1.SecondOpponent = new Team("The Thereans");
            //    match1.Winner = new Team("The Valyrians");

            //    r.AddMatch(match1);

            //    Match match2 = new Match();
            //    match2.FirstOpponent = new Team("The Coans");
            //    match2.SecondOpponent = new Team("The Corinthians");
            //    match2.Winner = new Team("The Coans");

            //    r.AddMatch(match2);
            //    Addround(r);
            //}
            //else if (idx == 2)
            //{
            //    Match match1 = new Match();
            //    match1.FirstOpponent = new Team("The Valyrians");
            //    match1.SecondOpponent = new Team("The Coans");
            //    match1.Winner = new Team("The Coans");

            //    r.AddMatch(match1);
            //    Addround(r);
            //}
            return r;
        }
    }
}
