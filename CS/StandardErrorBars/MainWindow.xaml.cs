﻿using System;
using System.Collections.Generic;
using System.Windows;

namespace StandardErrorBars {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        public class Record {
            public Record(DateTime timePoint, int temperature) {
                this.TimePoint = timePoint;
                this.Temperature = temperature;
            }
            public DateTime TimePoint { get; set; }
            public double Temperature { get; set; }
        }
        List<Record> GetData() {
            return new List<Record>() {
                new Record(new DateTime(2016, 07, 01), 26),
                new Record(new DateTime(2016, 07, 02), 24),
                new Record(new DateTime(2016, 07, 03), 26),
                new Record(new DateTime(2016, 07, 04), 29),
                new Record(new DateTime(2016, 07, 05), 30),
                new Record(new DateTime(2016, 07, 06), 33),
                new Record(new DateTime(2016, 07, 07), 32),
                new Record(new DateTime(2016, 07, 08), 30),
                new Record(new DateTime(2016, 07, 09), 22),
                new Record(new DateTime(2016, 07, 10), 27),
                new Record(new DateTime(2016, 07, 11), 27),
                new Record(new DateTime(2016, 07, 12), 28),
                new Record(new DateTime(2016, 07, 13), 29),
                new Record(new DateTime(2016, 07, 14), 31),
                new Record(new DateTime(2016, 07, 15), 31),
                new Record(new DateTime(2016, 07, 16), 32),
                new Record(new DateTime(2016, 07, 17), 32),
                new Record(new DateTime(2016, 07, 18), 34),
                new Record(new DateTime(2016, 07, 19), 28),
                new Record(new DateTime(2016, 07, 20), 29),
                new Record(new DateTime(2016, 07, 21), 32),
                new Record(new DateTime(2016, 07, 22), 34),
                new Record(new DateTime(2016, 07, 23), 36),
                new Record(new DateTime(2016, 07, 24), 34),
                new Record(new DateTime(2016, 07, 25), 34),
                new Record(new DateTime(2016, 07, 26), 32),
                new Record(new DateTime(2016, 07, 27), 33),
                new Record(new DateTime(2016, 07, 28), 35),
                new Record(new DateTime(2016, 07, 29), 29),
                new Record(new DateTime(2016, 07, 30), 29),
                new Record(new DateTime(2016, 07, 31), 26)
            };
        }
        private void OnLoaded(object sender, RoutedEventArgs e) {
            if (pointSeries != null) {
                pointSeries.ArgumentDataMember = "TimePoint";
                pointSeries.ValueDataMember = "Temperature";
                pointSeries.DataSource = GetData();
            }
        }
    }
}
