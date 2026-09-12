namespace BuildAnalyzer.Core
{
    public class Core
    {
        /// <summary>
        /// Принимает параметры игрока и возвращает расчитанные значения урона, шанса и урона критического удара..
        /// </summary>
        /// <param name="CharName">Имя игрока</param>
        public string CharName { get; set; } = string.Empty;
        /// <param name="BaseAttack">Базовая атака</param>
        public double BaseAttack { get; set; }
        /// <param name="WeaponAttack">Атака оружия</param>
        public double WeaponAttack { get; set; }
        /// <param name="CritChance">Шанс крита</param>
        public double CritChance { get; set; }
        /// <param name="CritDamageProc">Критический урон в процентах</param>
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
        /// <summary>
        /// Параметр для расчета итоговой атаки
        /// </summary>
        public double ResultDMG => BaseAttack + WeaponAttack;
        /// <summary>
        /// Параметр для расчёта итогового крит урона
        /// </summary>
        public double ResultCritDMG => ResultDMG * (1 + (CritDamageProc / 100));
        /// <summary>
        /// Параметр для расчтеа среднего урона
        /// </summary>
        public double AvgDmg => ResultDMG * (1 - (CritChance / 100)) + (ResultCritDMG * (CritChance / 100));
        /// <summary>
        /// Возвращает итоговую атаку
        /// </summary>
        /// <returns>ResultDMG</returns>
        public double ResultAttckC() => ResultDMG;
        /// <summary>
        /// Возвращает итоговый крит урон
        /// </summary>
        /// <returns>ResultCritDMG</returns>
        public double CritDamageC() => ResultCritDMG;
        /// <summary>
        /// Возвращает средний урон
        /// </summary>
        /// <returns>AvgDmg</returns>
        public double AvgDmgC() => AvgDmg;
        /// <summary>
        /// Возвращает рейтинг сборки
        /// </summary>
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
