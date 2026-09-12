namespace BuildAnalyzer.Core
{
    public class Core
    {
        public string CharName { get; set; }
        public double BaseAttack { get; set; }
        public double WeaponAttack { get; set; }
        public double CritChance { get; set; }
        public double CritDamageProc { get; set; }
        private double ResultDMG;
        private double ResultCritDMG;
        private double AvgDmg;
        public Core(string charName, double baseAttack, double weaponAttack, double critChance, double critDamageProc)
        {
            CharName = charName;
            BaseAttack = baseAttack;
            WeaponAttack = weaponAttack;
            CritChance = critChance;
            CritDamageProc = critDamageProc;
            ResultDMG = BaseAttack + WeaponAttack;
            ResultCritDMG = ResultDMG * (1 + (CritDamageProc / 100));
            AvgDmg = ResultDMG * (1 + (CritChance / 100) * (ResultCritDMG / 100));
        }

        public Core()
        {
        }

        public double ResultAttckC()
        {
            return ResultDMG;
        }
        public double CritDamageC()
        {
            return ResultCritDMG;
        }
        public double AvgDmgC()
        {
            return AvgDmg;
        }
        public string Rating()
        {
            if (AvgDmgC() < 1500)
            {
                return "Weak";
            }
            else if (AvgDmgC() >= 1500 && AvgDmgC() < 2499)
            {
                return "Normal";
            }
            else if (AvgDmgC() >= 2500 && AvgDmgC() < 3499)
            {
                return "Good";
            }
            else
            {
                return "Great";
            }
        } 
    }
}
