using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


 namespace SystemException294

{
    class Car
    {
        public int MaxSpeed = 150;

        public int CurrentSpeed { get; set; } = 0;
        public string PetNaNE { get; set; } = "";


        private bool IsDead;




        private Radio TheMusicBox = new Radio();

        public Car() { }
        public Car(int Speed,string Name)
        {
            CurrentSpeed = Speed;
            PetNaNE = Name;
        }
        public void TurnTunes(bool state)
        {
            TheMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            CarlsDeadException carls = new CarlsDeadException($"{PetNaNE} has overheated", "You have a lead foot", DateTime.Now);
            carls.HelpLink = "http://www.CarsRUs.com";
            throw carls;


        }

    }
 }


