namespace ComputerGameLibray
{
   
        public class ComputerGame
        {
            private string name;
            private PegiAgeRating pegiAgeRating;
            private double budgetInMillionsOfDollars;
            private int minimumGpuMemoryInMegabytes;
            private int diskSpaceNeededInGB;
            private int ramNeededInGb;
            private int coresNeeded;
            private double coreSpeedInGhz;

            public ComputerGame(string name,
                                PegiAgeRating pegiAgeRating,
                                double budgetInMillionsOfDollars,
                                int minimumGpuMemoryInMegabytes,
                                int diskSpaceNeededInGB,
                                int ramNeededInGb,
                                int coresNeeded,
                                double coreSpeedInGhz)
            {
                this.name = name;
                this.pegiAgeRating = pegiAgeRating;
                this.budgetInMillionsOfDollars = budgetInMillionsOfDollars;
                this.minimumGpuMemoryInMegabytes = minimumGpuMemoryInMegabytes;
                this.diskSpaceNeededInGB = diskSpaceNeededInGB;
                this.ramNeededInGb = ramNeededInGb;
                this.coresNeeded = coresNeeded;
                this.coreSpeedInGhz = coreSpeedInGhz;
            }

            public string GetName()
            {
                return name;
            }

            public PegiAgeRating GetPegiAgeRating()
            {
                return pegiAgeRating;
            }

            public double GetBudgetInMillionsOfDollars()
            {
                return budgetInMillionsOfDollars;
            }

            public int GetMinimumGpuMemoryInMegabytes()
            {
                return minimumGpuMemoryInMegabytes;
            }

            public int GetDiskSpaceNeededInGB()
            {
                return diskSpaceNeededInGB;
            }

            public int GetRamNeededInGb()
            {
                return ramNeededInGb;
            }

            public int GetCoresNeeded()
            {
                return coresNeeded;
            }

            public double GetCoreSpeedInGhz()
            {
                return coreSpeedInGhz;
            }
        }
}