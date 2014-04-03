using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherPrototype
{

    public class Player
    {

        private int totalKills;
        private int totalDeaths;
        private int totalPlayTime;
        private int attack;
        private int defense;
        private int speed;
        private int vitality;
        private int exp;
        private char gender;
        private String lastServerUsed;
        private Item item1;
        private Item item2;
        private Item item3;
        private Item item4;
        private Item item5;

        public Player(int kills, int deaths, int time, int att, int def, int spd, int life, int xp, char sex, String lastServer, Item savedItem1, Item savedItem2, Item savedItem3, Item savedItem4, Item savedItem5)
        {

            this.totalKills = kills;
            this.totalDeaths = deaths;
            this.totalPlayTime = time;
            this.attack = att;
            this.defense = def;
            this.speed = spd;
            this.vitality = life;
            this.exp = xp;
            this.gender = sex;
            this.lastServerUsed = lastServer;
            this.item1 = savedItem1;
            this.item2 = savedItem2;
            this.item3 = savedItem3;
            this.item4 = savedItem4;
            this.item5 = savedItem5;

        }

        public Player()
        {

            this.totalKills = 0;
            this.totalDeaths = 0;
            this.totalPlayTime = 0;
            this.attack = 1;
            this.defense = 1;
            this.speed = 1;
            this.vitality = 10;
            this.exp = 0;
            this.gender = 'x';
            this.lastServerUsed = "//localhost";
            this.item1 = null;
            this.item2 = null;
            this.item3 = null;
            this.item4 = null;
            this.item5 = null;

        }

        public void setTotalKills(int kills)
        {

            this.totalKills = kills;

        }

        public void setTotalDeaths(int deaths)
        {

            this.totalDeaths = deaths;

        }

        public void setTotalPlayTime(int time)
        {

            this.totalPlayTime = time;

        }

        public void setLastServerUsed(String lastServer)
        {

            this.lastServerUsed = lastServer;

        }

        public void setGender(char sex)
        {

            this.gender = sex;

        }

        public void setAttack(int att)
        {

            this.attack = att;

        }

        public void setDefense(int def)
        {

            this.defense = def;

        }

        public void setSpeed(int spd)
        {

            this.speed = spd;

        }

        public void setVitality(int life)
        {

            this.vitality = life;

        }

        public void setExp(int xp)
        {

            this.exp = xp;

        }

        public void setItem1(Item savedItem1)
        {

            this.item1 = savedItem1;

        }

        public void setItem2(Item savedItem2)
        {

            this.item2 = savedItem2;

        }

        public void setItem3(Item savedItem3)
        {

            this.item3 = savedItem3;

        }

        public void setItem4(Item savedItem4)
        {

            this.item4 = savedItem4;

        }

        public void setItem5(Item savedItem5)
        {

            this.item5 = savedItem5;

        }

        public int getTotalKills()
        {

            return this.totalKills;

        }

        public int getTotalDeaths()
        {

            return this.totalDeaths;

        }

        public int getPlaytime()
        {

            return this.totalPlayTime;

        }

        public String getLastServer()
        {

            return this.lastServerUsed;

        }

        public int getAttack()
        {

            return this.attack;

        }

        public int getDefense()
        {

            return this.defense;

        }

        public int getSpeed()
        {

            return this.speed;

        }

        public int getVitality()
        {

            return this.vitality;

        }

        public int getExp()
        {

            return this.exp;

        }

        public char getGender()
        {

            return this.gender;

        }

        public Item getItem1()
        {

            return this.item1;

        }

        public Item getItem2()
        {

            return this.item2;

        }

        public Item getItem3()
        {

            return this.item3;

        }

        public Item getItem4()
        {

            return this.item4;

        }

        public Item getItem5()
        {

            return this.item5;

        }

    }

}
