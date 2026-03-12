using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_ns
{
    public interface IPlayableCharacter
    {
        int Življenje { get; set; }
        string ImeRazreda { get; set; }
        string DrugoOrožje { get; set; }
        void Heal(int heal);
        void Attack(IEnemy enemy);
    }

    public interface IEnemy
    {
        int Življenje { get; set; }
        int Damage { get; }
        void TakeDamage(int damage);
        void AttackBack(IPlayableCharacter player);
        bool IsDead { get; }
    }
}
