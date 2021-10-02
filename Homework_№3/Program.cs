using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Text;
using System.Collections;

namespace Homework__3
{
    class Program
    {
        static void Main()
        {


            Quatrals Rooms_Quartals = new Quatrals();
            

            string[] arr_ln;

            using (StreamReader file = new StreamReader(@"C:\Users\Ruslanchik\source\repos\Homework_№3\out.txt"))
            {
                int counter = 0;
                string ln;
                


                

                while ((ln = file.ReadLine()) != null)
                {
                    counter++;
                    arr_ln = ln.Split(' ');


                    if (counter == 1)
                    {
                        Rooms_Quartals.Number_of_quartal = Convert.ToInt32(arr_ln[1]);
                        Rooms_Quartals.Quantity_of_rooms = Convert.ToInt32(arr_ln[3]);
                        Rooms_Quartals.Rooms = new Room[Convert.ToInt32(arr_ln[3])];
                        for (int i = 0; i < Rooms_Quartals.Rooms.Length; i++)
                        {
                            Room Roomss = new Room();
                            Rooms_Quartals.Rooms[i] = Roomss;
                        }

                    }
                    else
                    {
                      
                        Rooms_Quartals.Rooms[counter - 2].Number_of_room = Convert.ToInt32(arr_ln[1]);
                        Rooms_Quartals.Rooms[counter-2].Owner_Surname = arr_ln[3];
                        Rooms_Quartals.Rooms[counter - 2].In_counter = Convert.ToInt32(arr_ln[5]);
                        Rooms_Quartals.Rooms[counter - 2].Out_counter = Convert.ToInt32(arr_ln[7]);
                        Rooms_Quartals.Rooms[counter - 2].Zaborgovanist = (Convert.ToInt32(arr_ln[7])- Convert.ToInt32(arr_ln[5]));

                    }
                    

                }

                //Rooms_Quartals.normal_druk();
                //
            }



            Rooms_Quartals.max_zoborgovanist(1.58);
            //fstream.Seek(30, SeekOrigin.Begin);
            //fstream.Read(output,0,1);
            //textFromFile_quantity = Encoding.Default.GetString(output);
            //fstream.Read(output, 0, 100);
            //textFromFile_quantity = Encoding.Default.GetString(output);
            //Console.WriteLine(textFromFile_quantity);


        }
    }
}

//int o = Convert.ToInt32("er3f");
////Rooms_Quartals.Number_of_quartal = Convert.ToInt32(arr_ln[1]);
//Rooms_Quartals.Rooms = new Room[Convert.ToInt32(arr_ln[3])];Console.WriteLine(o);







            
  
 


    

