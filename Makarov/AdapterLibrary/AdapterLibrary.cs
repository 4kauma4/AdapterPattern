using ComputerGameLibray;

namespace AdapterLibrary
{
        public class ComputerGameAdapter : PCGame
        {
            private readonly ComputerGame computerGame;

            public ComputerGameAdapter(ComputerGame computerGame)
            {
                this.computerGame = computerGame;
            }

            public string GetTitle()
            {
                return computerGame.GetName();
            }

            public int GetPegiAllowedAge()
            {
                string ratingName = computerGame.GetPegiAgeRating().ToString();
                return int.Parse(ratingName.Substring(1));
            }

            public bool IsTripleAGame()
            {
                return computerGame.GetBudgetInMillionsOfDollars() > 50;
            }

            public Requirements GetRequirements()
            {
                return new Requirements(
                    computerGame.GetMinimumGpuMemoryInMegabytes() / 1024,
                    computerGame.GetDiskSpaceNeededInGB(),
                    computerGame.GetRamNeededInGb(),
                    computerGame.GetCoreSpeedInGhz(),
                    computerGame.GetCoresNeeded()
                );
            }
        }
}



