using System;
using System.Collections.Generic;
using System.Text;

namespace Homework__3
{
    class Room
    {
        protected int number_of_room;
        public int Number_of_room
        {
            set
            {
                number_of_room = value;
            }
            get
            {
                return number_of_room;
            }
        }



        protected string owner_Surname;
        public string Owner_Surname
        {
            set
            {
                owner_Surname = value;
            }
            get
            {
                return owner_Surname;
            }
        }



        protected double in_counter;
        public double In_counter
        {
            set
            {
                in_counter = value;
            }
            get
            {
                return in_counter;
            }
        }


        protected double out_counter;
        public double Out_counter
        {
            set
            {
                out_counter = value;
            }
            get
            {
                return out_counter;
            }
        }
        protected double zaborgovanist;
        public double Zaborgovanist
        {
            set
            {
                zaborgovanist = value;
            }
            get
            {
                return zaborgovanist;
            }
        }
        public Room()
        {
            this.number_of_room = 0;
            this.out_counter =0;
            this.in_counter = 0;
            this.owner_Surname = "";

        }
        public void room_druck() 
        {
            Console.WriteLine(@"Number: {0} Surname: {1} In_Counter: {2} Out_Counter: {3}", number_of_room, owner_Surname, in_counter, out_counter);
        }

           

        
    }


}
