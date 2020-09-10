using CarWash_Application.model;
using CarWash_Application.model.typeOfWash;
using System;
using System.Timers;
using System.Windows;

namespace CarWash_Application
{
    public partial class LogConsole : Window
    {
        public LogConsole()
        {
            InitializeComponent();

            Box box = new Box();
            box.BoxName = "12";
            box.ChemistryReserve = 100;
            box.EnergyReserve = 100;
            box.WaterReserve = 100;
            box.SetTypeWash(new AutomaticWash());

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += UpdateLogs;
            timer.Start();

            box.StartWash();
        }
        public void UpdateLogs(Object source, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() => Log_TextBox.Text = Debug.GetAllLogs());
        }
    }
}
