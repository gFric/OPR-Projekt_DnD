using Interfaces;

namespace Player_ns
{
    public abstract class Player : IPlayableCharacter
    {
        private const int maxŽivljenje = 100;
        private int življenje;
        private string imeRazreda;
        private int štHealov = 1;

        public int ŠtHealov { get { return štHealov; } set { štHealov = value; } }
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
        public int SelectedLok;
        public int SelectedPuščica;

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
            double damage = damagePuščice[SelectedPuščica] * damageLoka[SelectedLok];

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
        public int SelectedMeč;
        public int SelectedŠčit;

        public int LevelMeča { get; set; } = 0;
        public int LevelŠčita { get; set; } = 0;
        public string[] VrstaMeča => vrstaMeča;
        public string[] VrstaŠčita => vrstaŠčita;
        public double ShieldMultiplier
        {
            get { return zaščitaŠčita[SelectedŠčit]; }
        }

        public Fighter() : base("Fighter", 80)
        {
            ščit = vrstaŠčita[0];
            meč = vrstaMeča[0];
            DrugoOrožje = "Shield:";
        }

        public override int ZračunajDamage()
        {
            return damageMeča[SelectedMeč];
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
        public int SelectedPalica;
        public int SelectedDamageSpell;
        public int SelectedProtectionSpell;

        public string[] VrstaPalice => vrstaPalice;
        public string[] VrstaDamageSpells => vrstaDamageSpells;
        public string[] VrstaProtectionSpells => vrstaProtectionSpells;
        public double ProtectionMultiplier
        {
            get { return zaščitaProtectionSpells[SelectedProtectionSpell]; }
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
            double damage = damageDamageSpells[SelectedDamageSpell] * damagePalice[SelectedPalica];

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

        public string besedilo;

        public int Življenje
        {
            get { return življenje; }
            set { if (value <= 100) življenje = value; }
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

        public Enemy(int življenje, int damage, int id)
        {
            this.življenje = življenje;
            this.damage = damage;
            this.Id = id;
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

        public string enemyBesedilo;

        public object this[int id, Player igralec, int štPogovorov]
        {
            get
            {
                if (id == 0)
                {
                    switch (štPogovorov)
                    {
                        case 0: enemyBesedilo = $"OH so you little {igralec.ImeRazreda} have stubled apon a great battle between me and my powerful allies. I don't think you realize what you got yourself into!"; return enemyBesedilo;
                        case 1: enemyBesedilo = $"You've got some skills little {igralec.ImeRazreda} but not enough to defeat one of the GREATEST SORCERERS OF ALL TIME!"; return enemyBesedilo;
                        case 2: enemyBesedilo = $"UGH you think your pathetic attack is enough to defeat ME?! I will NEVER get as low as being killed by an amateur {igralec.ImeRazreda}!"; return enemyBesedilo;
                        case 3: enemyBesedilo = $"Maybe you think you're close to killing me, but I shall NEVER surrender!"; return enemyBesedilo;
                    }
                }
                else if (id == 1)
                {
                    switch (štPogovorov)
                    {
                        case 0: enemyBesedilo = $"Well well well, so you little {igralec.ImeRazreda} have defeated my ally and you now suddenly think noone can stop you? Let me lower that ego of yours!"; return enemyBesedilo;
                        case 1: enemyBesedilo = $"You've got a strong punch in {igralec.ImeRazreda}, but not enough to bring ME down!"; return enemyBesedilo;
                        case 2: enemyBesedilo = $"Let's see if you can dodge this!!"; return enemyBesedilo;
                        case 3: enemyBesedilo = $"You will NEVER see me surrender! pathetic {igralec.ImeRazreda}"; return enemyBesedilo;
                    }
                }
                else if (id == 2)
                {
                    switch (štPogovorov)
                    {
                        case 0: enemyBesedilo = $"So you are stronger than we thought fellow {igralec.ImeRazreda}. Let's settle this for once and for all! You against ME!"; return enemyBesedilo;
                        case 1: enemyBesedilo = $"You will soon join my allies in the ground {igralec.ImeRazreda}!"; return enemyBesedilo;
                        case 2: enemyBesedilo = $"I would like to see you try and kill the BRAVEST {igralec.ImeRazreda} OF ALL TIME!"; return enemyBesedilo;
                        case 3: enemyBesedilo = $"I will NEVER let you win you skilless {igralec.ImeRazreda}!"; return enemyBesedilo;
                    }
                }

                return "";
            }

        }
    }
}
