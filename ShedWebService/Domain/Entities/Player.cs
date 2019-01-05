using System;
using System.Collections.Generic;
using System.Text;

namespace ShedWebService.Domain.Entity
{
    public class Player
    {
        public Guid Id { get; private set; }

        public List<Card> Hand { get; set; }

        public Player()
        {
            Id = Guid.NewGuid();
        }
    }
}
