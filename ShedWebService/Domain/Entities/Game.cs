using ShedWebService.Domain.Entity;
using System.Collections.Generic;
using System;

namespace ShedWebService.Domain.Entity
{
    public class Game
    {
        public Guid Id { get; private set; }

        public List<Card> PickUpPile { get; set; }

        public List<Card> BurnPile { get; set; }

        public List<Card> PlayPile { get; set; }

        public List<Player> Players { get; set; }

        public Game()
        {
            Id = Guid.NewGuid();
        }
    }
}
