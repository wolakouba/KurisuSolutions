﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using LeagueSharp;

namespace Oracle
{
    internal class GameBuff
    {
        public string ChampionName { get; set; }
        public bool Dangerous { get; set; }
        public string BuffName { get; set; }
        public SpellSlot Slot { get; set; }
        public string SpellName { get; set; }
        public int Delay { get; set; }

        public static readonly List<GameBuff> Buffs = new List<GameBuff>();

        static GameBuff()
        {
            Buffs.Add(new GameBuff
            {
                ChampionName = "Zed",
                BuffName = "zedulttargetmark",
                SpellName = "zedult",
                Slot = SpellSlot.R,
                Delay = 1800,
                Dangerous = true
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Darius",
                BuffName = "dariusnoxiantacticsonh",
                SpellName = "dariusnoxiantacticsonh",
                Slot = SpellSlot.W,
                Delay = 0
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Fizz",
                BuffName = "fizzmarinerdoombomb",
                SpellName = "fizzmarinerdoom",
                Slot = SpellSlot.R,
                Delay = 2000,
                Dangerous = true
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Leblanc",
                BuffName = "leblancsoulshackle",
                SpellName = "leblancsoulshackle",
                Slot = SpellSlot.E,
                Delay = 1800,
                Dangerous = true,
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Leblanc",
                BuffName = "leblancsoulshacklem",
                SpellName = "leblancsoulshacklem",
                Slot = SpellSlot.R,
                Delay = 0,
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Mordekaiser",
                BuffName = "mordekaiserchildrenofthegrave",
                SpellName = "mordekaiserchildrenofthegrave",
                Slot = SpellSlot.R,
                Delay = 0,
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Poppy",
                BuffName = "poppydiplomaticimmunity",
                SpellName = "poppydiplomaticimmunity",
                Slot = SpellSlot.R,
                Delay = 0,
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Skarner",
                BuffName = "skarnerimpale",
                SpellName = "skarnerimpale",
                Slot = SpellSlot.R,
                Delay = 0
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Urgot",
                BuffName = "urgotswap2",
                SpellName = "urgotswap2",
                Slot = SpellSlot.R,
                Delay = 0
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Vladimir",
                BuffName = "vladimirhemoplague",
                SpellName = "vladimirhemoplague",
                Slot = SpellSlot.R,
                Delay = 4000,
                Dangerous = true
            });

            Buffs.Add(new GameBuff
            {
                ChampionName = "Morgana",
                BuffName = "soulshackles",
                SpellName = "soulshackles",
                Slot = SpellSlot.R,
                Delay = 2000,
                Dangerous = true
            });
                        
        }
    }
}