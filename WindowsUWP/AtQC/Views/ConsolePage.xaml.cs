using System;
using System.Data;
using AtQC.ViewModels;
using MySql.Data.MySqlClient;
using Windows.UI.Xaml.Controls;
using Microsoft.Services.Store.Engagement;

namespace AtQC.Views
{
    public sealed partial class ConsolePage : Page
    {
        public ConsoleViewModel ViewModel { get; } = new ConsoleViewModel();

        public ConsolePage()
        {
            InitializeComponent();

            StoreServicesCustomEventLogger logger = StoreServicesCustomEventLogger.GetDefault();
            logger.Log("consolePageLoaded");
        }

        private void Button_Get_Access_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            content_area_have_no_promission.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            content_area_console.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void Update_System_Status_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            try
            {
                string water_status_string = combobox_water.SelectedItem.ToString();
                string hotwater_status_sting = combobox_hotwater.SelectedItem.ToString();
                string election_status_string = combobox_election.SelectedItem.ToString();
                string network_status_string = combobox_network.SelectedItem.ToString();


                if (combobox_water.SelectedIndex != -1)
                {
                    water_status_c.Text = water_status_string;
                }
                if (combobox_hotwater.SelectedIndex != -1)
                {
                    hotwater_status_c.Text = hotwater_status_sting;
                }
                if (combobox_election.SelectedIndex != -1)
                {
                    election_status_c.Text = election_status_string;
                }
                if (combobox_network.SelectedIndex != -1)
                {
                    network_status_c.Text = network_status_string;
                }
            }
            catch (System.NullReferenceException e1)
            {
                water_status_c.Text = "必须选定新的系统状态";
                hotwater_status_c.Text = "必须选定新的系统状态";
                election_status_c.Text = "必须选定新的系统状态";
                network_status_c.Text = "必须选定新的系统状态";
            }

            string M_str_sqlcon = "数据库链接语句";
            for (int i = 1; i <= 4; i++)
            {
                string sql_status = "";
                switch (i)
                {
                    case 1: sql_status = election_status_c.Text; break;
                    case 2: sql_status = network_status_c.Text; break;
                    case 3: sql_status = water_status_c.Text; break;
                    case 4: sql_status = hotwater_status_c.Text; break;
                }
                MySqlConnection mysqlcon = new MySqlConnection(M_str_sqlcon);
                MySqlCommand mysqlcom = new MySqlCommand("update status set status='" + sql_status + "',icon='" + getIconString(sql_status) + "' where id=" + i, mysqlcon);
                mysqlcon.Open();
                MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
                while (mysqlread.Read())
                {

                }
                mysqlcon.Close();
            }

            StoreServicesCustomEventLogger logger = StoreServicesCustomEventLogger.GetDefault();
            logger.Log("userUpdatedStatus");
        }

        private string getIconString(string inp)
        {
            string res = "warning";
            if (inp == "正常") { res = "right"; }
            if (inp == "中断") { res = "wrong"; }
            return res;
        }
    }
}
