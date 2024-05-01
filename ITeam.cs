

namespace PlayerAndTeam
{
    /// <summary>
    /// Defines the essential functionalities of team
    /// </summary>
    public interface ITeam
    {
        // All methods in inerface are implicitly abstract
        void Add(Player player);

        void Remove(int playerId);

        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playerName);

        List<Player> GetAllPlayers();


    }
}
