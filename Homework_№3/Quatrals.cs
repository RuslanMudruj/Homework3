using System;
using System.Collections.Generic;
using System.Text;

namespace Homework__3
{
    class Quatrals

    {
        protected int number_of_quartal;
        protected int quantity_of_rooms;
        public int Quantity_of_rooms
        {

            set
            {
                quantity_of_rooms = value;
            }
            get
            {
                return quantity_of_rooms;
            }

        }
        public int Number_of_quartal
        {

            set
            {
                number_of_quartal = value;
            }
            get
            {
                return number_of_quartal;
            }

        }

        public Room[] Rooms;
        public Quatrals()
        {
            this.number_of_quartal = 0;
        }

        /*Роздрук звіту в зручному для користувача форматі, який передбачає, що використовуються повні назви місяців зазначеного кварталу, а також підписи по рядках інформації про номер квартири та власника.
         Передбачити роздрук інформації тільки по одній квартирі.
         При відомій вартості кВт енергії знайти прізвище власника з найбільшою заборгованістю.
         Знайти номер квартири, в якій не використовувалась електроенергія.*/
        public void normal_druk()
        {
            Console.WriteLine(@"Quartal: {0} \n", number_of_quartal);
            switch (number_of_quartal)
            {
                case 1:
                    Console.WriteLine(@"January\tFebrary\tMarch");
                    break;
                case 2:
                    Console.WriteLine(@"April\tMay\tJune");
                    break;
                case 3:
                    Console.WriteLine(@"July\tAugust\tSemptember");
                    break;
                case 4:
                    Console.WriteLine(@"Octovber\tNovember\tDecember");
                    break;
            }
            for (int i = 0; i < Quantity_of_rooms; i++)
                Rooms[i].room_druck();
        }

        public void po_odniy(int in_number_ofroom)
        {
            for (int i = 0; i < Quantity_of_rooms; i++)
            {
                if (in_number_ofroom == Rooms[i].Number_of_room)
                {
                    Rooms[i].room_druck();
                }
            }

        }

        public void energy_was_unsed()
        {
            for (int i = 0; i < Quantity_of_rooms; i++)
            {
                if (Rooms[i].In_counter == Rooms[i].Out_counter)
                {
                    Rooms[i].room_druck();
                }

            }
        }
        public void max_zoborgovanist(double price)
        {
            int max_index = 0 ;
          

            for (int i = 1; i < Quantity_of_rooms; i++)
            {
                if(Rooms[max_index].Zaborgovanist < Rooms[0].Zaborgovanist)
                {
                    max_index = i;
                }
            }
            double max_price = Rooms[max_index].Zaborgovanist * price;
            Console.WriteLine(@"The Largest debtor {0}, price {1}", Rooms[max_index].Owner_Surname, max_price);

        }
    }
}
