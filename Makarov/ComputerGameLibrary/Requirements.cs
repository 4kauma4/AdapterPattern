using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGameLibray
{
    public class Requirements
    {
        private int gpuGb;
        private int hddGb;
        private int ramGb;
        private double cpuGhz;
        private int coresNum;

        public Requirements(int gpuGb,
                            int hddGb,
                            int ramGb,
                            double cpuGhz,
                            int coresNum)
        {
            this.gpuGb = gpuGb;
            this.hddGb = hddGb;
            this.ramGb = ramGb;
            this.cpuGhz = cpuGhz;
            this.coresNum = coresNum;
        }

        public int GetGpuGb()
        {
            return gpuGb;
        }

        public int GetHddGb()
        {
            return hddGb;
        }

        public int GetRamGb()
        {
            return ramGb;
        }

        public double GetCpuGhz()
        {
            return cpuGhz;
        }

        public int GetCoresNum()
        {
            return coresNum;
        }
    }
}

