using System.Windows;

namespace pr9_Bartova
{
    public partial class MainWindow : Window
    {
        private Warrior warrior1;
        private Warrior warrior2;
        private Warrior warrior3;

        public MainWindow()
        {
            InitializeComponent();

            warrior1 = new Warrior("Воин 1", 100);
            warrior2 = new LightArmorWarrior("Воин 2", 100);
            warrior3 = new HeavyArmorWarrior("Воин 3", 100);
        }

        private void Warrior1Attack_Click(object sender, RoutedEventArgs e)
        {
            warrior1.TakeDamage(15);
            Warrior1Health.Text = warrior1.Health.ToString();
        }

        private void Warrior2Attack_Click(object sender, RoutedEventArgs e)
        {
            warrior2.TakeDamage(15);
            Warrior2Health.Text = warrior2.Health.ToString();
        }

        private void Warrior3Attack_Click(object sender, RoutedEventArgs e)
        {
            warrior3.TakeDamage(15);
            Warrior3Health.Text = warrior3.Health.ToString();
        }
    }
}