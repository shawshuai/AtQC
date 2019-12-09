using System;
using System.Data;
using System.Net.Sockets;
using AtQC.ViewModels;
using MySql.Data.MySqlClient;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Microsoft.Services.Store.Engagement;

namespace AtQC.Views
{
    public sealed partial class StatusPage : Page
    {
        public StatusViewModel ViewModel { get; } = new StatusViewModel();

        public StatusPage()
        {
            InitializeComponent();
            Refresh_Page();

            StoreServicesCustomEventLogger logger = StoreServicesCustomEventLogger.GetDefault();
            logger.Log("statusPageLoaded");
        }

        public void Refresh_Page()
        {
            try
            {
                water_processing.IsActive = true;
                hotwater_processing.IsActive = true;
                election_processing.IsActive = true;
                network_processing.IsActive = true;
                election_status.Text = "数据刷新中...";
                election_status_icon.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                network_status.Text = "数据刷新中...";
                network_status_icon.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                water_status.Text = "数据刷新中...";
                water_status_icon.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                hotwater_status.Text = "数据刷新中...";
                hotwater_status_icon.Visibility = Windows.UI.Xaml.Visibility.Collapsed;


                election_status_icon.Visibility = Windows.UI.Xaml.Visibility.Visible;
                network_status_icon.Visibility = Windows.UI.Xaml.Visibility.Visible;
                water_status_icon.Visibility = Windows.UI.Xaml.Visibility.Visible;
                hotwater_status_icon.Visibility = Windows.UI.Xaml.Visibility.Visible;
                string M_str_sqlcon = "数据库链接语句";
                for (int i = 1; i <= 4; i++)
                {
                    MySqlConnection mysqlcon = new MySqlConnection(M_str_sqlcon);
                    MySqlCommand mysqlcom = new MySqlCommand("select status,icon from status where id=" + i, mysqlcon);
                    mysqlcon.Open();
                    MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
                    while (mysqlread.Read())
                    {
                        if (i == 1)
                        {
                            election_status.Text = mysqlread.GetString("status");
                            election_status_icon.Source = getIcon(mysqlread.GetString("icon"));
                        }
                        if (i == 2)
                        {
                            network_status.Text = mysqlread.GetString(0);
                            network_status_icon.Source = getIcon(mysqlread.GetString("icon"));
                        }
                        if (i == 3)
                        {
                            water_status.Text = mysqlread.GetString(0);
                            water_status_icon.Source = getIcon(mysqlread.GetString("icon"));
                        };
                        if (i == 4)
                        {
                            hotwater_status.Text = mysqlread.GetString(0);
                            hotwater_status_icon.Source = getIcon(mysqlread.GetString("icon"));
                        }
                    }
                    mysqlcon.Close();
                }
                water_processing.IsActive = false;
                hotwater_processing.IsActive = false;
                election_processing.IsActive = false;
                network_processing.IsActive = false;
            }
            catch (MySqlException)
            {
                offline_hint_area.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Content.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                error_hint.Text = "无法连接到网络，请稍后再试。1";
            }
            catch (AggregateException)
            {
                offline_hint_area.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Content.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                error_hint.Text = "运行时发生错误，请稍后再试。2";
            }
            catch (SocketException)
            {
                offline_hint_area.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Content.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                error_hint.Text = "无法连接到网络，请稍后再试。3";
            }
        }

        private BitmapImage getIcon(string status)
        {
            BitmapImage img = new BitmapImage();
            if (status == "right")
            {
                img = new BitmapImage(new Uri("ms-appx:///Assets/icon/right.png"));
            }
            if (status == "wrong")
            {
                img = new BitmapImage(new Uri("ms-appx:///Assets/icon/wrong.png"));
            }
            if (status == "warning")
            {
                img = new BitmapImage(new Uri("ms-appx:///Assets/icon/warning.png"));
            }
            return img;
        }

        private void refresh_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Refresh_Page();

            StoreServicesCustomEventLogger logger = StoreServicesCustomEventLogger.GetDefault();
            logger.Log("userRefreshedStatusPage");
        }
    }
}
