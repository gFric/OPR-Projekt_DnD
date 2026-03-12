using Interfaces;

namespace Player_ns
{
    public abstract class Player : IPlayableCharacter
    {
        private const int maxŽivljenje = 100;
        private int življenje;
        private string imeRazreda;
        private int štHealov = 1;

        public int ŠtHealov { get { return štHealov; } set {štHealov = value; } }
        public string ImeRazreda { get { return imeRazreda; } set { imeRazreda = value; } }
        public int Življenje
        {
            get { return življenje; }
            set
            {
                if (value <= maxŽivljenje) { življenje = value; }
                else { življenje = maxŽivljenje; }
            }
        }

        public string DrugoOrožje { get; set; }

        public int Coins { get; set; } = 100;
        public int item1_cena { get; set; } = 25;
        public int item2_cena { get; set; } = 25;
        public int item3_cena { get; set; } = 25;

        public Player(string imeRazreda, int začetnoŽivljenje)
        {
            this.imeRazreda = imeRazreda;
            življenje = začetnoŽivljenje;
        }

        public void Heal(int heal)
        {
            if (življenje + heal <= maxŽivljenje)
            {
                Življenje += heal;
                ŠtHealov--;
            }
        }

        public static Player operator +(Player p, int heal)
        {
            p.Heal(heal);
            return p;
        }

        public virtual void Attack(IEnemy enemy)
        {
            int damage = ZračunajDamage();

            enemy.TakeDamage(damage);

            OnAttack?.Invoke(damage);
        }

        public abstract int ZračunajDamage();

        public delegate void AttackDelegat(int damage);
        public event AttackDelegat OnAttack;


    }

    public class Ranger : Player
    {
        private string[] vrstaPuščice = { "Basic arrow", "Poison arrow", "Explosive arrow" };
        private int[] damagePuščice = { 10, 25, 30 };
        private string[] vrstaLoka = { "Barebow", "Longbow", "Recurve" };
        private double[] damageLoka = { 1, 1.5, 2 };
        private string puščica;
        private string lok;

        public int LevelLoka { get; set; } = 0;
        public int LevelPuščice { get; set; } = 0;
        public string[] VrstaLoka => vrstaLoka;
        public string[] VrstaPuščice => vrstaPuščice;

        public Ranger() : base("Ranger", 70)
        {
            puščica = vrstaPuščice[0];
            lok = vrstaLoka[0];
            DrugoOrožje = "Arrow:";
        }

        public override int ZračunajDamage()
        {
            double damage = damagePuščice[LevelPuščice] * damageLoka[LevelLoka];

            return (int)damage;
        }
    }

    public class Fighter : Player
    {
        private string[] vrstaMeča = { "Dagger", "Longsword", "Claymore" };
        private int[] damageMeča = { 20, 30, 40 };
        private string[] vrstaŠčita = { "Wooden shield", "Stone shield", "Iron shield" };
        private double[] zaščitaŠčita = { 0.8, 0.6, 0.4 };
        private string meč;
        private string ščit;

        public int LevelMeča { get; set; } = 0;
        public int LevelŠčita { get; set; } = 0;
        public string[] VrstaMeča => vrstaMeča;
        public string[] VrstaŠčita => vrstaŠčita;
        public double ShieldMultiplier
        {
            get { return zaščitaŠčita[LevelŠčita]; }
        }

        public Fighter() : base("Fighter", 80)
        {
            ščit = vrstaŠčita[0];
            meč = vrstaMeča[0];
            DrugoOrožje = "Shield:";
        }

        public override int ZračunajDamage()
        {
            return damageMeča[LevelMeča];
        }
    }

    public class Wizard : Player
    {
        public string WizardSpell1 { get; set; }
        public string WizardSpell2 { get; set; }
        private string[] vrstaPalice = { "Starter wand", "Fire wand", "Master's wand" };
        private double[] damagePalice = { 1, 1.5, 2 };
        private string[] vrstaDamageSpells = { "Chill touch", "Fire ball", "Thunderclap", "Lightning lure", };
        private double[] damageDamageSpells = { 20, 25, 30, 35 };
        private string[] vrstaProtectionSpells = { "Arcane shield", "Mana shield", "Spell of stone skin" };
        private double[] zaščitaProtectionSpells = { 0.8, 0.6, 0.4 };
        public int LevelPalice { get; set; } = 0;
        public int LevelDamageSpell { get; set; } = 0;
        public int LevelProtectionSpell { get; set; } = 0;
        private string palica;
        private string damageSpell;
        private string protectionSpell;

        public string[] VrstaPalice => vrstaPalice;
        public string[] VrstaDamageSpells => vrstaDamageSpells;
        public string[] VrstaProtectionSpells => vrstaProtectionSpells;
        public double ProtectionMultiplier
        {
            get { return zaščitaProtectionSpells[LevelProtectionSpell]; }
        }

        public Wizard() : base("Wizard", 60)
        {
            palica = vrstaPalice[0];
            damageSpell = vrstaDamageSpells[0];
            protectionSpell = vrstaProtectionSpells[0];
            WizardSpell1 = "Spell - damage: ";
            WizardSpell2 = "Spell - protection: ";
        }

        public override int ZračunajDamage()
        {
            double damage = damageDamageSpells[LevelDamageSpell] * damagePalice[LevelPalice];

            return (int)damage;
        }
    }

    public class Enemy : IEnemy
    {
        private static int enemyCount = 0;
        public readonly int Id;

        private int življenje;
        private int damage;
        private bool isDead;

        public int Življenje
        {
            get { return življenje; }
            set { if (value <= 100) življenje = value;}
        }

        public int Damage
        {
            get { return damage; }
            set { if (value <= 30) damage = value; }
        }
        public bool IsDead
        {
            get { return življenje <= 0; }
        }

        public Enemy(int življenje, int damage)
        {
            this.življenje = življenje;
            this.damage = damage;
            Id = ++enemyCount;
        }

        public void TakeDamage(int damage)
        {
            življenje -= damage;

            if (življenje < 0)
            {
                življenje = 0;
            }
        }

        public void AttackBack(IPlayableCharacter player)
        {
            if (player is Wizard wizard)
            {
                wizard.Življenje -= (int)(damage * wizard.ProtectionMultiplier);
            }
            else if (player is Fighter fighter)
            {
                fighter.Življenje -= (int)(damage * fighter.ShieldMultiplier);
            }
            else
            {
                player.Življenje -= damage;
            }
        }

        ~Enemy() 
        {
        
        }

    }
}
