using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace LR10
{
    /// <summary>
    /// Interaction logic for AddContact.xaml
    /// </summary>
    public partial class AddContact : Window
    {
        public AddContact()
        {
            InitializeComponent();                        
        }

        private void check1_Checked(object sender, RoutedEventArgs e)
        {
            text1.Visibility = Visibility.Visible;
            text1.Content = "Дата народження";
            text2.Visibility = Visibility.Visible;
            text2.Content = "Адреса";
            CompanyName.Visibility = Visibility.Collapsed;
            BirthData.Visibility = Visibility.Visible;
            AdressPosition.Visibility = Visibility.Visible;
            check2.IsChecked = false;
        }

        private void check2_Checked(object sender, RoutedEventArgs e)
        {
            text1.Visibility = Visibility.Visible;
            text1.Content = "Назва компанії";
            text2.Visibility = Visibility.Visible;
            text2.Content = "Посада";
            BirthData.Visibility = Visibility.Collapsed;
            CompanyName.Visibility = Visibility.Visible;
            AdressPosition.Visibility = Visibility.Visible;
            check1.IsChecked = false;
        }
        public bool dog;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonalContacts pc = new PersonalContacts();
            BusinessContacts bc = new BusinessContacts();
            MainWindow open = new MainWindow();
            string filePath;
            if (check1.IsChecked == true)
                {
                if (Name.Text=="" || Surname.Text =="" || Phone.Text == "" || Gmail.Text =="" || BirthData.Text == "" || AdressPosition.Text == "")
                    {
                        MessageBox.Show("Заповніть усі поля!");
                    } 
                else if (dog == false)
                    {
                        MessageBox.Show("Некоректна адреса, потрібно ввести '@'!");
                    }
                else
                    {
                    pc.Name = Name.Text;
                    pc.Surname= Surname.Text;
                    pc.Gmail = Gmail.Text;
                    pc.Birthday = BirthData.Text;
                    pc.Adress = AdressPosition.Text;
                    pc.Phone = Phone.Text;                    
                        filePath = @"D:\Урочки\ООП\ЛР10\Personal.txt";
                        using (StreamWriter writer = File.AppendText(filePath))
                        {
                            writer.WriteLine($"{pc.Name}, {pc.Surname}, {pc.Phone}, {pc.Gmail}, {pc.Birthday}, {pc.Adress}");
                        }
                    open.Show();
                    this.Close();
                    }
                }
            else if (check2.IsChecked == true)
                {
                if (Name.Text == "" || Surname.Text == "" || Phone.Text == "" || Gmail.Text == "" || CompanyName.Text == "" || AdressPosition.Text == "")
                {
                    MessageBox.Show("Заповніть усі поля!");
                }
                else if (dog == false)
                {
                    MessageBox.Show("Некоректна адреса, потрібно ввести '@'!");
                }
                else
                {
                    bc.Name = Name.Text;
                    bc.Surname = Surname.Text;
                    bc.Gmail = Gmail.Text;
                    bc.CompanyName = CompanyName.Text;
                    bc.Position = AdressPosition.Text;
                    bc.Phone = Phone.Text;
                    filePath = @"D:\Урочки\ООП\ЛР10\Business.txt";
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine($"{bc.Name}, {bc.Surname}, {bc.Phone}, {bc.Gmail}, {bc.CompanyName}, {bc.Position}");
                    }
                    open.Show();
                    this.Close();
                }
                }
            else { MessageBox.Show("Оберіть категорію номеру"); }
             
        }

        private void Gmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (!textBox.Text.Contains("@"))
                {
                    dog = false;
                }
                else dog = true;
            }
        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (!int.TryParse(textBox.Text, out _))
                {
                    textBox.Text = string.Empty;
                }
            }
        }
    }
}
