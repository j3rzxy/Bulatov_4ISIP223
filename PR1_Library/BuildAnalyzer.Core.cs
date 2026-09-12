namespace BuildAnalyzer.Core
{
    public class Core
    {
        public string CharName { get; set; } = string.Empty;
        public double BaseAttack { get; set; }
        public double WeaponAttack { get; set; }
        public double CritChance { get; set; }
        public double CritDamageProc { get; set; }
        public Core(string charName, double baseAttack, double weaponAttack, double critChance, double critDamageProc)
        {
            CharName = charName;
            BaseAttack = baseAttack;
            WeaponAttack = weaponAttack;
            CritChance = critChance;
            CritDamageProc = critDamageProc;            
        }

        public Core()
        {
        }
        public double ResultDMG => BaseAttack + WeaponAttack;

        public double ResultCritDMG => ResultDMG * (1 + (CritDamageProc / 100));

        public double AvgDmg => ResultDMG * (1 - (CritChance / 100)) + (ResultCritDMG * (CritChance / 100));

        public double ResultAttckC() => ResultDMG;
        public double CritDamageC() => ResultCritDMG;
        public double AvgDmgC() => AvgDmg;

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
