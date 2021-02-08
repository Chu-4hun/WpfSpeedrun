using System.IO;
using System.Runtime.InteropServices;
using System.Windows;

namespace authWPF
{
    public partial class UserInfo : Window
    {
        public UserInfo()
        {
            InitializeComponent();
            Show_UserInfo();
        }

        public void Show_UserInfo()
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

            Fam.Content = user.Fam;
            Username.Content = user.Username;
            Otch.Content = user.Otchesvo;
            showlogin.Content = user.Login;
            
            
            
            
        }
    }
}