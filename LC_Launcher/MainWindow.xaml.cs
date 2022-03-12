using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Net;

namespace LC_Launcher
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        internal void StartGame(object sender, RoutedEventArgs args)
        {
            Process.Start(GeneratePath() + @"\LCV2\Game.exe");
        }

        internal void DownloadLatestVersion(object sender, RoutedEventArgs args)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/319170470010159114/951403869399814224/Screenshot_20220310-095900_Samsung_Health.jpg",
                                    GeneratePath() + @"\LCV2\pic.jpg");
            }
        }

        private string GeneratePath()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            for (int i = 0; i < 4; i++)
                path = Directory.GetParent(path).FullName;

            return path;
        }
    }
}
