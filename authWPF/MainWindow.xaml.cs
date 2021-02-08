using System.IO;
using System.Windows;
using System.Windows.Input;

namespace authWPF
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Register_onClick(object sender, RoutedEventArgs e)
        {
            UserRegistr GoToRegister = new UserRegistr();
            GoToRegister.Show();
            this.Close();
        }

        private void ClearTextbox_onClick(object sender, MouseButtonEventArgs e)
        {
            sender.GetType();
            
        }

        private void Login_OnClick(object sender, RoutedEventArgs e)
        {
            UserRegistr.User  user = new UserRegistr.User();
            using (BinaryReader reader = new BinaryReader(File.Open(@"D:\Rider\Git\С# Prjcts\authWPF\authWPF\bin\Debug\user.dat", FileMode.Open)))
            {
                user.Fam = reader.ReadString();
                user.Username = reader.ReadString();
                user.Otchesvo = reader.ReadString();
                user.Login = reader.ReadString();
                user.Password = reader.ReadString();
            }
            
        }
    }
}