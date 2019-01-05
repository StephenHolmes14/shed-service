using ShedWebService.Domain.Entity;

namespace ShedWebService.Domain.Extenders
{
    public static class GameExtender
    {
        public static void BurnCards(this Game game)
        {
            game.BurnPile.AddRange(game.PlayPile);
            game.PlayPile.Clear();
        }

        public static void PickUpPile(this Game game, Player player)
        {
            player.Hand.AddRange(game.PlayPile);
            game.PlayPile.Clear();
        }
    }
}
