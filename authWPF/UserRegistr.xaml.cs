using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace authWPF
{
    public partial class UserRegistr : Window
    {
        public UserRegistr()
        {
            InitializeComponent();
        }
        public struct User
        {
            public string Fam;
            public string Username;
            public string Otchesvo;
            public string Login;
            public string Password;
        }

        public string path = Directory.GetCurrentDirectory();
        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow goToMain = new MainWindow();
            goToMain.Show();
            this.Close();
        }

        private void Create_user(object sender, RoutedEventArgs e)
        {
            if (Password.Text == AnotherPassword.Text)
            {
                User newUser = new User();

                Password.Background = Brushes.Gray;
                AnotherPassword.Background = Brushes.Gray;
                
                newUser.Fam = UserF.Text ;
                using (BinaryWriter writer =
                    new BinaryWriter(File.Open(@"D:\Rider\Git\С# Prjcts\authWPF\authWPF\bin\Debug\user.dat", FileMode.OpenOrCreate)))
                {
                    writer.Write(UserF.Text);
                    writer.Write(UserName.Text);
                    writer.Write(UserOtch.Text);
                    writer.Write(login.Text);
                    writer.Write(Password.Text); 
                }

                MainWindow goToMain = new MainWindow();
                goToMain.Show();
                this.Close();
            }
            else
            {
                Password.Background = Brushes.Red;
                AnotherPassword.Background = Brushes.Red;
            }
        }
    }
}