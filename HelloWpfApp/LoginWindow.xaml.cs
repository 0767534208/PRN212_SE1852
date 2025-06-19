using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HelloWpfApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            //Giả lập account, nếu username là obam và pass là 123 thì cho vào main window
            if (txtUserName.Text == "obam" && txtPassword.Password == "123")
            {
                //Mở màn hình main
                MainWindow mw = new MainWindow();
                mw.Show();
                Close(); //Đóng màn hình đăng nhập ( để thu hồi ô nhớ đã cấp cho LoginWindow luôn )
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }
    }
}
