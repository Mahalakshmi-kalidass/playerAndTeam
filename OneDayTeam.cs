



namespace PlayerAndTeam
{
    // implemented Add , remove method of ITeam interface . Balance ,to be implemented 
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>(); 

        public OneDayTeam() 
        { 
            oneDayTeam.Capacity = 11;
        }


        /// <summary>
        /// Adds specified Player to the one day team list
        /// </summary>
        /// <param name="player">object of Player to be added</param>
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }

       /// <summary>
       /// This function creates a new player object with specified properties
       /// </summary>
       /// <param name="playerId">Integer value of player Id</param>
       /// <param name="name">Name of the player</param>
       /// <param name="age">Age of the player</param>
       /// <returns>Player object</returns>
        public Player CreatePlayer(int playerId, string name, int age)
        {
            return new Player { PlayerId = playerId, PlayerName = name, PlayerAge = age };
        }

        
        /// <summary>
        /// this function searches for the player in the oneDayteam list using player Id
        /// </summary>
        /// <param name="playerId">Id of player who needs to be found</param>
        /// <returns>Player object of specified id . if not found returns null</returns>
        public Player FindPlayer(int playerId)
        {
            foreach (var player in oneDayTeam)
            {
                if(player.PlayerId == playerId)
                    return player;
            }
            return null;
        }

        /// <summary>
        /// This function removes the player from the team by passing player Id as parameter
        /// </summary>
        /// <param name="playerId">Player id of player to be removed</param>
        public void Remove(int playerId)
        {
            //searches the given playerId in the list and returns the player object
            Player playerToRemove = FindPlayer(playerId);

            //if found player is removed
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);//remove method of List class is used here
                Console.WriteLine($"Player-{playerId} is removed from One day team Successfully!");
            }
            else
            {
                Console.WriteLine($"Uh Oh! Player-{playerId} not found!");
            }
        }

        //Implement the functionality to get the player details by passing playerId
        public Player GetPlayerById(int playerId)
        {

            // Returning the playerId by using Lambda expression
            return oneDayTeam.Find(player => player.PlayerId==playerId);
            
        }


        //Implement the functionality to get the player details by passing playerName
        public Player GetPlayerByName(string playerName)
        { 

            //StringComparision.OrdinalIgnoreCase provides the CaseInsensitivity.
            //Returning the playerName by using Lambda Expression 

            return oneDayTeam.Find(player => player.PlayerName.Equals(playerName, StringComparison.OrdinalIgnoreCase));
        }

        //Implement the functionality to get all player details list
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
