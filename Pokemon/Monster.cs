using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Monster
    {
        protected string m_sNickname = "";
        protected int m_nLevel = 1;
        protected float m_fHP = 10.0f;
        protected float m_fAttack = 1.0f;
        protected float m_fDefense = 1.0f;
        protected string m_sType = "Normal";

        public Monster(string a_sNickname)
        {
            Init(a_sNickname, 1);
        }
        public Monster(string a_sNickname, int a_nLevel) 
        {
            Init(a_sNickname, a_nLevel);
        }
        virtual protected void Init(string a_sNickname, int a_nLevel)
        {
            m_sNickname = a_sNickname;
            m_nLevel = a_nLevel;
            m_fHP += m_nLevel;
            m_fAttack += m_nLevel;
            m_fDefense += m_nLevel;
            m_sType = "Normal";
            this.Print();
        }
        
        public int Level
        {
            get { return m_nLevel; }
        }
        public string Nickname {  get { return m_sNickname; } }
        public float HP { get { return m_fHP; } }
        public float Attack { get { return m_fAttack; } }
        public float Defense { get {  return m_fDefense; } }
        public string Type { get { return m_sType; } }

        public void Fight(Monster a_monster)
        {
            Console.WriteLine("\n" + this.Nickname + " gets in a fight with monster " + a_monster.Nickname);
            this.Fight(a_monster.Attack);
            this.Print();
        }

        protected void Fight(float a_fIncomingDamage)
        {
            float fCombatResult = m_fDefense - a_fIncomingDamage;
            if (fCombatResult < 0)
            {
                m_fHP += fCombatResult;
            }
        }

        public void Print()
        {
            Console.WriteLine("");
            Console.WriteLine("Monster name: " + Nickname);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Attack: " + Attack);
            Console.WriteLine("Defense: " + Defense);
        }
    }
}
