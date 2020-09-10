using CarWash_Application.model.typeOfWash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CarWash_Application.model
{
    class Box
    {
        private TypeWash wash;

        private Timer washTimer;
        public bool IsBoxingFree { private set; get; }
        public string BoxName { get; set; }
        public int CurrentPrice { get; set; }
        public int WashingTime { get; set; }
        public int ChemistryReserve { get; set; }
        public int WaterReserve { get; set; }
        public int EnergyReserve { get; set; }

        public Box()
        {
            wash = new TypeWash();
            IsBoxingFree = true;
        }

        private bool CheckReserve()
        {
            if (ChemistryReserve > 0 && WaterReserve > 0 && EnergyReserve > 0)
                return true;
            else
            {
                Debug.Log($"В боксе {BoxName} закончились запасы, - химикатов: {ChemistryReserve} | воды: {WaterReserve} | электроенергии: {EnergyReserve}.");
                return false;
            }
        }

        public void SetTypeWash(IWash typeWash)
        {
            wash.SetTypeWash(typeWash);
            typeWash.GetInfoAboutWash(this);
        }

        public void StartWash()
        {
            if (IsBoxingFree)
            {
                washTimer = new Timer();
                washTimer.Interval = 1000;
                washTimer.Elapsed += WashProcess;
                washTimer.Start();
                IsBoxingFree = false;
                Debug.Log($"Процесс мойки в боксе {BoxName} начат!");
            }
            else Debug.Log($"Нельзя начать мойку в боксе {BoxName}, она занята.");
        }

        public void EndWash()
        {
            washTimer.Stop();
            IsBoxingFree = true;
            Debug.Log($"Процесс мойки в боксе {BoxName} закончен!");
        }

        public void WashProcess(Object source, ElapsedEventArgs e)
        {
            if (WashingTime >= 0)
            {
                if (CheckReserve())
                {
                    wash.DoWash(this);
                    WashingTime--;
                }
                else EndWash();
            }
            else EndWash();
        }
    }
}
