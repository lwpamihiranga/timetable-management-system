﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using timetable_management_system.View;

namespace timetable_management_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Trace.WriteLine(System.Windows.SystemParameters.PrimaryScreenHeight);
            //Trace.WriteLine(System.Windows.SystemParameters.PrimaryScreenWidth);

        }

        private void OpenDataWindow(object sender, RoutedEventArgs e)
        {
            //interation logic for Data Window
            MainDataWindow mainDataWindow = new MainDataWindow();
            mainDataWindow.Show();
        }
        private void OpenAvailabilityWindow(object sender, RoutedEventArgs e)
        {
            //interation logic for Availability Window
        }
        private void OpenSessionsWindow(object sender, RoutedEventArgs e)
        {
            //interation logic for Sessions Window
        }
        private void OpenSessionConfigWindow(object sender, RoutedEventArgs e)
        {
            //interation logic for Session Config Window
        }
        private void OpenRoomConfigWindow(object sender, RoutedEventArgs e)
        {
            //interation logic for Room Config Window
        }
        private void OpenTimetablesWindow(object sender, RoutedEventArgs e)
        {
            //interation logic for Timetables Window
        }
    }
}
