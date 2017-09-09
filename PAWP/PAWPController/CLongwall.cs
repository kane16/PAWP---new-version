using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWPController
{
    public class CLongwall
    {
        public static double SWDB;
        public static double LDr;
        public static bool DPSN;
        public static bool SCzP;
        public static double LDWP;
        public static double LSAO;
        public static double LKAO;

        public int wallID;
        public string wallName;
        public string mineAssigment;
        public double Td;
        public bool WSCzP;
        public double Wpp;
        public double Wwkpt;
        public double PrKsr;
        public double PDmax;
        public double PD0;
        public double LZPDR0;
        public double LZKDR0;
        public double LZPSN0;
        public double LZKSN0;
        public double LZPDRmin;
        public double LZPSNmax;
        public double OZP0;
        public double OZK0;
        public double WA0w;
        public double WDB0;

        private double Eef;
        private double TPKdmax;
        private double WDBZNmax_dr;
        private double LZPDRZNmax;
        private double LZPDRmax;
        private double LZKDRmax;
        private double TPKzmmax;
        private double WDBmax_dr;
        private double WDBmax_sn;
        private double WDBmax;
        private double WDBi;
        private double WDBmin;

        public double RWmax;
        public double LZPDRk;
        public double LZKDRk;
        public double LZPSNk;
        public double LZKSNk;
        public double WDBk;
        public double ΔWDBk;
        public double ΔODDR;
        public double ΔZpp;

        public CLongwall(int wallID=0, string wallName="", string mineAssigment="", double Td=0,
            bool WSCzP=false, double Wpp=0, double Wwkpt=0 , double PrKsr=0, double PDmax=0 ,
            double PD0=0, double LZPDR0=0, double LZKDR0=0, double LZPSN0=0, double LZKSN0=0,
            double LZPDRmin=0, double LZPSNmax=0, double OZP0=0, double OZK0=0, double WA0w=0, 
            double WDB0=0)
        {
            this.wallName = wallName;
            this.mineAssigment = mineAssigment;
            this.Td = Td;
            this.WSCzP = WSCzP;
            this.Wpp = Wpp;
            this.Wwkpt = Wwkpt;
            this.PrKsr = PrKsr;
            this.PDmax = PDmax;
            this.PD0 = PD0;
            this.LZPDR0 = LZPDR0;
            this.LZKDR0 = LZKDR0;
            this.LZPSN0 = LZPSN0;
            this.LZKSN0 = LZKSN0;
            this.LZPDRmin = LZPDRmin;
            this.LZPSNmax = LZPSNmax;
            this.OZP0 = OZP0;
            this.OZK0 = OZK0;
            this.WA0w = WA0w;
            this.WDB0 = WDB0;
            LZPDRk = LZPDRmin;
            LZKDRk = LZPDRk * LZKDR0 / LZPDR0;
            makeCalculations();
        }

        public void makeCalculations()
        {
            Eef = CalculateEef();
            TPKdmax = CalculateTPKdmax();
            WDBZNmax_dr = CalculateWDBZNmax_dr();
            LZPDRZNmax = CalculateLZPDRZNmax();
            LZPDRmax = CalculateLZPDRmax();
            LZKDRmax = CalculateLZKDRmax();
            TPKzmmax = CalculateTPKzmmax();
            WDBmax_dr = CalculateWDBmax_dr();
            WDBmax_sn = CalculateWDBmax_sn();
            WDBmax = CalculateWDBmax();
            RWmax = CalculateRWmax();
            WDBi = CalculateWDBi();
            LZKDRk = CalculateLZKDRk();
            WDBmin = CalculateWDBmin();
        }

        public double CalculateEef()
        {
            if (WSCzP == false)
            {
                return 450 - 2 * Td;
            }else
            {
                return 360 - 2 * Td;
            }
        }

        public double CalculateTPKdmax()
        {
            return 1440 * Wwkpt/100 * (1 - Wpp/100);
        }

        public double CalculateWDBZNmax_dr()
        {
            return PDmax / PD0 * WDB0;
        }

        public double CalculateLZPDRZNmax()
        {
            return 1440 / Eef * LZPDR0 / LZKDR0 / (1 + LZPDR0 / LZKDR0) * WDBZNmax_dr / TPKdmax * 60 / PrKsr;
        }

        public double CalculateLZPDRmax()
        {
            double resultLZPDRmax = 1440 / Eef * LZPDR0 / LZKDR0 / (1 + LZPDR0 / LZKDR0);
            if (LZPDRZNmax < resultLZPDRmax)
            {
                return LZPDRZNmax;
            }
            else return resultLZPDRmax;
        }

        public double CalculateLZKDRmax()
        {
            return CalculateLZPDRmax() / LZPDR0 * LZKDR0;
        }

        public double CalculateTPKzmmax()
        {
            double resultTPKzmmax = TPKdmax / LZPDR0;
            double Eef = CalculateEef();
            if (CalculateLZPDRmax() < LZPDR0)
            {
                resultTPKzmmax = TPKdmax / LZPDRmax;
            }
            if (resultTPKzmmax > Eef * Wwkpt / 100 )
            {
                resultTPKzmmax = Eef * Wwkpt / 100 ;
            }
            return resultTPKzmmax;
        }

        public double CalculateWDBmax_dr()
        {
            return LZPDRmax * TPKzmmax / 60 * PrKsr;
        }

        public double CalculateWDBmax_sn()
        {
            if (LZPSNmax < 2 * LZPDRmax)
            {
                return LZPSNmax * TPKzmmax / 60 * PrKsr;
            } else return 2 * LZPSNmax * TPKzmmax / 60 * PrKsr;
        }

        public double CalculateWDBmax()
        {
            return WDBmax_dr + WDBmax_sn * LDWP / LDr;
        }

        public double CalculateRWmax()
        {
            return WDBmax - WDB0;
        }

        public double CalculateWDBi()
        {
            return LZPDRk * PrKsr * TPKzmmax / 60;
        }

        public double CalculateLZKDRk()
        {
            return LZPDRk * LZKDR0 / LZPDR0;
        }

        public double CalculateWDBmin()
        {
            return LZPDRmin * PrKsr * TPKzmmax / 60;
        }

    }
}