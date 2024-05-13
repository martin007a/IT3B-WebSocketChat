using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace IT3B_Chat.Server
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
    public MainWindow()
    {
    
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
            string ip = txt_ip.Text;
            WebSocketServer server = new WebSocketServer($"ws://{ip}:7890");

            server.Start();

            MessageBox.Show("Server Connected");

            server.Stop();

    }
 }
}