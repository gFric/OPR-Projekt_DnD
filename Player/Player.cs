namespace Player_ns
{
    public abstract class Player : IPlayableCharacter
    {
        protected const int maxŽivljenje = 100;
        protected int življenje;
        protected string imeRazreda;

        public string ImeRazreda { get; set; }
        public int Življenje
        {
            get { return življenje; }
            set { if (življenje + value < maxŽivljenje) življenje = value; else življenje = maxŽivljenje; }
        }

        public string DrugoOrožje { get; set; }

        public Player(string imeRazreda, int začetnoŽivljenje)
        {
            this.imeRazreda = imeRazreda;
            življenje = začetnoŽivljenje;
        }

        public void Heal(int heal)
        {
            Življenje += heal;
        }

        public static Player operator +(Player p, int heal)
        {
            p.Heal(heal);
            return p;
        }

        public virtual void Attack(IEnemy enemy)
        {
            enemy.TakeDamage(10);
        }
    }

    public class Ranger : Player
    {
        private string[] vrstaPuščice = { "Basic arrow", "Poison arrow", "Explosive arrow" };
        private int[] damagePuščice = { 10, 25, 30 };
        private string[] vrstaLoka = { "Barebow", "Longbow", "Recurve" };
        private double[] damageLoka = { 1, 1.5, 2 };
        private string puščica;
        private string lok;
        public string[] VrstaLoka => vrstaLoka;
        public string[] VrstaPuščice => vrstaPuščice;

        public Ranger() : base("Ranger", 80)
        {
            puščica = vrstaPuščice[0];
            lok = vrstaLoka[0];
            DrugoOrožje = "Arrow:";
        }

        public void SetPuščica(string p)
        {
            if (vrstaPuščice.Contains(p))
            {
                puščica = p;
            }
        }

        public void SetLok(string l)
        {
            if (vrstaLoka.Contains(l))
            {
                lok = l;
            }
        }

        public override void Attack(IEnemy enemy)
        {
            int arrowIndex = Array.IndexOf(vrstaPuščice, puščica);
            int bowIndex = Array.IndexOf(vrstaLoka, lok);

            double damage = damagePuščice[arrowIndex] * damageLoka[bowIndex];

            enemy.TakeDamage((int)damage);
        }
    }

    public class Fighter : Player
    {
        private string[] vrstaMeča = { "Dagger", "Longsword", "Claymore" };
        private int[] damageMeča = { 20, 30, 40 };
        private string[] vrstaŠčita = { "Wooden shield", "Stone shield", "Iron shield" };
        private double[] zaščitaŠčita = { 1.5, 2, 2.5 };
        private string meč;
        private string ščit;
        public string[] VrstaMeča => vrstaMeča;
        public string[] VrstaŠčita => vrstaŠčita;
        public Fighter() : base("Fighter", 100)
        {
            ščit = vrstaŠčita[0];
            meč = vrstaMeča[0];
            DrugoOrožje = "Shield:";
        }

        public void SetMeč(string izbranMeč)
        {
            if (vrstaMeča.Contains(izbranMeč))
            {
                meč = izbranMeč;
            }
        }

        public override void Attack(IEnemy enemy)
        {
            int index = Array.IndexOf(vrstaMeča, meč);
            int damage = damageMeča[index];

            enemy.TakeDamage(damage);
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
        private int[] zaščitaProtectionSpells = { 20, 25, 40 };
        private string palica;
        private string damageSpell;
        private string protectionSpell;
        public string[] VrstaPalice => vrstaPalice;
        public string[] VrstaDamageSpells => vrstaDamageSpells;
        public string[] VrstaProtectionSpells => vrstaProtectionSpells;

        public Wizard() : base("Wizard", 60)
        {
            palica = vrstaPalice[0];
            damageSpell = vrstaDamageSpells[0];
            protectionSpell = vrstaProtectionSpells[0];
            WizardSpell1 = "Spell - damage: ";
            WizardSpell2 = "Spell - protection: ";
        }

        public void SetPalica(string p)
        {
            if (vrstaPalice.Contains(p))
            {
                palica = p;
            }
        }

        public void SetDamageSpell(string s)
        {
            if (vrstaDamageSpells.Contains(s))
            {
                damageSpell = s;
            }
        }

        public override void Attack(IEnemy enemy)
        {
            int spellIndex = Array.IndexOf(vrstaDamageSpells, damageSpell);
            int wandIndex = Array.IndexOf(vrstaPalice, palica);

            double damage = damageDamageSpells[spellIndex] * damagePalice[wandIndex];

            enemy.TakeDamage((int)damage);
        }
    }

    public class Enemy : IEnemy
    {
        private static int enemyCount = 0;
        public readonly int Id;

        private int življenje;
        private int damage;

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
            get { return IsDead; }
            set { if (življenje <= 0) IsDead = true; else IsDead = false; }
        }

        public Enemy(int življenje, int damage)
        {
            this.življenje = življenje;
            this.damage = damage;
            Id = ++enemyCount;
        }

        public void TakeDamage(int dmg)
        {
            Življenje -= dmg;
        }

        public void AttackBack(IPlayableCharacter player)
        {
            player.Življenje -= damage;
        }

        ~Enemy() 
        {
        
        }

    }
}
