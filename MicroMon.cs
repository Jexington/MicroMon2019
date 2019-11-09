namespace MicroMon2019
{
    internal class MicroMon
    {
        public MicroMon(string name)
        {
            // Init Parameters
            mMicroMonName = name;
        }

        public string mMicroMonName;
        public string mMicroType;
        public string mMoveOne;
        public string mMoveTwo;
        public string mMoveThree;

        public int mMaxHealth;
        public int mCurHealth;
        public int mDefense;
        public int mAttack;

        public bool mAlive = true;

        public void initStats()
        {
            if (mMicroMonName.ToLower() == "fireboi")
            {
                mMicroType = "fire";
                mMaxHealth = 8;
                mCurHealth = mMaxHealth;
                mDefense = 4;
                mAttack = 5;

                mMoveOne = "Tackle";
                mMoveTwo = "FireBreath";
                mMoveThree = "PhoenixHeal";
            }
            else if (mMicroMonName.ToLower() == "waterboi")
            {
                mMicroType = "water";
                mMaxHealth = 8;
                mDefense = 5;
                mAttack = 4;

                mMoveOne = "ClawStrike";
                mMoveTwo = "WaterShield";
                mMoveThree = "RainOfPain";
            }
            else if (mMicroMonName.ToLower() == "darkboi")
            {
                mMicroType = "dark";
                mMaxHealth = 6;
                mDefense = 3;
                mAttack = 7;

                mMoveOne = "ClawStrike";
                mMoveTwo = "DarkHeal";
                mMoveThree = "BlackMagic";
            }
            else if (mMicroMonName.ToLower() == "lightboi")
            {
                mMicroType = "light";
                mMaxHealth = 9;
                mDefense = 5;
                mAttack = 3;

                mMoveOne = "Tackle";
                mMoveTwo = "HealingSun";
                mMoveThree = "BurningLight";
            }
            else if (mMicroMonName.ToLower() == "earthboi")
            {
                mMicroType = "earth";
                mMaxHealth = 9;
                mDefense = 4;
                mAttack = 4;

                mMoveOne = "ClawStrike";
                mMoveTwo = "RockWall";
                mMoveThree = "MeteoriteSlam";
            }
            else if (mMicroMonName.ToLower() == "windboi")
            {
                mMicroType = "wind";
                mMaxHealth = 8;
                mDefense = 2;
                mAttack = 5;

                mMoveOne = "Tackle";
                mMoveTwo = "hurricaneheal";
                mMoveThree = "TornadoStrike";
            }
            else if (mMicroMonName.ToLower() == "bossboi")
            {
                mMicroType = "boss";
                mMaxHealth = 12;
                mDefense = 4;
                mAttack = 5;

                mMoveOne = "tailswing";
                mMoveTwo = "emberfury";
                mMoveThree = "apocalypse";
            }

            mCurHealth = mMaxHealth;
        }

        public string getMicroMonName()
        {
            return mMicroMonName;
        }

        public string getMicroType()
        {
            return mMicroType;
        }

        public string getMoveOne()
        {
            return mMoveOne;
        }

        public string getMoveTwo()
        {
            return mMoveTwo;
        }

        public string getMoveThree()
        {
            return mMoveThree;
        }

        public int getMaxHealth()
        {
            return mMaxHealth;
        }

        public int getCurHealth()
        {
            return mCurHealth;
        }

        public int getDefense()
        {
            return mDefense;
        }

        public int getAttack()
        {
            return mAttack;
        }

        public bool getAlive()
        {
            return mAlive;
        }

        public void setMaxHealth(int num)
        {
            mMaxHealth = num;
        }

        public void setCurHealth(int num)
        {
            mCurHealth = num;
        }

        public void heal(int num)
        {

            if (mCurHealth + num >= mMaxHealth)
            {
                mCurHealth = mMaxHealth;
            }
            else
            {
                mCurHealth += num;
            }
        }

        public void takeDamage(int num)
        {
            if (mCurHealth - num <= 0)
            {
                mCurHealth = 0;
                mAlive = false;
            }
            else
            {
                mCurHealth -= num;
            }

        }

        public void modAttack(int num)
        {
            mAttack += num;
        }

        public void modDefense(int num)
        {
            if(mDefense < 7)
            {
                mDefense += num;
            }
            
        }

    }
}