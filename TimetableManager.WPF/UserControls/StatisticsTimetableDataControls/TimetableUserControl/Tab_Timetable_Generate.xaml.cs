﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TimetableManager.WPF.StatisticsTimetableDataControls.TimetableUserControl
{
    public partial class Tab_Timetable_Generate : UserControl
    {
        public Tab_Timetable_Generate()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine("generateButton click");
        }
    }
}