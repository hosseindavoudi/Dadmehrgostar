﻿using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Domain.BoardType
{
    public class BoardType
    {
        public BoardType(string title)
        {
            Title = title;
            BoardsList = new List<Board.Board>();
            PetitionsList = new List<Petition.Petition>();
        }

        public int Id { get; set; }
        public string Title { get; private set; }
        public List<Board.Board> BoardsList { get; set; }
        public List<Petition.Petition> PetitionsList { get; set; }

        public void Edit(string title)
        {
            Title = title;
        }
    }
}
