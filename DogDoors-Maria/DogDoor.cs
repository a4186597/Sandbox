using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;


namespace DogDoors
{
    public class DogDoor
    {
        private bool _open;
        private List<Bark> _allowedBarks;

        public DogDoor()
        {
            _open = false;
            _allowedBarks = new List<Bark>();
        }

        public bool IsOpen
        {
            get
            {
                return _open;
            }

        }

        public System.Collections.Generic.List<DogDoors.Bark> AllowedBarks
        {
            get
            {
                return _allowedBarks;
            }
        }

        

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            _open = true;
            

            Timer timer = new Timer(5000);
            timer.Elapsed  +=new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
            
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Close();
            ((Timer)sender).Stop();
        }

      

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            _open = false;
        }

        public void AddAllowedBark(Bark bark)
        {
            _allowedBarks.Add(bark);
        }


    }
}
