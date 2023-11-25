using System.IO;
using System.Windows;

namespace LR10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddContact add = new AddContact();
            add.Show();
            this.Close();
        }

        private void all_Checked(object sender, RoutedEventArgs e)
        {
            Contact.Items.Clear();
            pc.IsChecked = false;
            bc.IsChecked = false;
            string[] allLines = File.ReadAllLines(@"D:\Урочки\ООП\ЛР10\Personal.txt");
            foreach (string line in allLines)
            {
                string[] parts = line.Split(',');

                string name = parts[0].Trim();
                string surname = parts[1].Trim();
                string phone = parts[2].Trim();
                string gmail = parts[3].Trim(); 
                string birthday = parts[4].Trim();
                string adress = parts[5].Trim();

                PersonalContacts pc = new PersonalContacts()
                {
                    Name = name,
                    Surname = surname,
                    Phone = phone,
                    Gmail = gmail,
                    Birthday = birthday,
                    Adress = adress
                };
                Contact.Items.Add(pc);
            }

            allLines = File.ReadAllLines(@"D:\Урочки\ООП\ЛР10\Business.txt");
            foreach (string line in allLines)
            {
                string[] parts = line.Split(',');

                string name = parts[0].Trim();
                string surname = parts[1].Trim();
                string phone = parts[2].Trim();
                string gmail = parts[3].Trim();
                string companyName = parts[4].Trim();
                string position = parts[5].Trim();

                BusinessContacts bc = new BusinessContacts()
                {
                    Name = name,
                    Surname = surname,
                    Phone = phone,
                    Gmail = gmail,
                    CompanyName = companyName,
                    Position = position
                };
                Contact.Items.Add(bc);
            }
        }
        

        private void pc_Checked(object sender, RoutedEventArgs e)
        {
            Contact.Items.Clear();
            all.IsChecked = false;
            bc.IsChecked = false;
            string[] allLines = File.ReadAllLines(@"D:\Урочки\ООП\ЛР10\Personal.txt");
            foreach (string line in allLines)
            {
                string[] parts = line.Split(',');

                string name = parts[0].Trim();
                string surname = parts[1].Trim();
                string phone = parts[2].Trim();
                string gmail = parts[3].Trim();
                string birthday = parts[4].Trim();
                string adress = parts[5].Trim();

                PersonalContacts pc = new PersonalContacts()
                {
                    Name = name,
                    Surname = surname,
                    Phone = phone,
                    Gmail = gmail,
                    Birthday = birthday,
                    Adress = adress
                };
                Contact.Items.Add(pc);
            }
        }

        private void bc_Checked(object sender, RoutedEventArgs e)
        {
            Contact.Items.Clear();
            all.IsChecked = false;
            pc.IsChecked = false;
            string[] allLines = File.ReadAllLines(@"D:\Урочки\ООП\ЛР10\Business.txt");
            foreach (string line in allLines)
            {
                string[] parts = line.Split(',');

                string name = parts[0].Trim();
                string surname = parts[1].Trim();
                string phone = parts[2].Trim();
                string gmail = parts[3].Trim();
                string companyName = parts[4].Trim();
                string position = parts[5].Trim();

                BusinessContacts bc = new BusinessContacts()
                {
                    Name = name,
                    Surname = surname,
                    Phone = phone,
                    Gmail = gmail,
                    CompanyName = companyName,
                    Position = position
                };
                Contact.Items.Add(bc);
            }
        }
        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            if (Contact.SelectedItem != null)
            {
                // Видалення обраного елемента з ListView
                Contact.Items.Remove(Contact.SelectedItem);
            }
        }
    }
}
