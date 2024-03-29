﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class program
        {
        static void Main(string[] args)
    {
        byte selection;
            

        Console.WriteLine("Please make a selection to learn more information");
        Console.WriteLine("1 - Tyrannosaurus rex");
        Console.WriteLine("2 - Stegosaurus");
        Console.WriteLine("3 - Velociraptor");
            bool error;    

            do
            {
                error = false;
                try
                {
                    selection = Convert.ToByte(Console.ReadLine());
                    switch (selection)
                    {

                        case 1:
                            DisplayTyrannosaurusRexInfo();
                            
                            break;
                        case 2:
                            DisplayStegosaurusInfo();
                            
                            break;
                        case 3:
                            DisplayVelociraptorInfo();
                            
                            break;
                        default:
                            throw new Exception($"{selection} is not part of the selected numbers.");
                            

                    }



                }


                catch (Exception e)
                {
                    error = true;
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    error = true;
                }
            }
            while ( error);
                Console.ReadKey();
            
    }

    static void DisplayTyrannosaurusRexInfo()
    {
        Console.WriteLine("Tyrannosaurus, meaning \"tyrant lizard\", from the Ancient" +
        "Greek tyrannos, \"tyrant\", and sauros, \"lizard\" is a genus of coelurosaurian " +
        "theropod dinosaur.The species Tyrannosaurus rex(rex meaning \"king\" in Latin)," +
        "is one of the most well - represented of the large theropods.Tyrannosaurus lived" +
        "throughout what is now western North America, on what was then an island continent" +
        "known as Laramidia.Source: Wikipedia.");
        }

    static void DisplayStegosaurusInfo()
    {
        Console.WriteLine("Stegosaurus is a genus of armored dinosaur. Fossils of this" +
            "genus date to the Late Jurassic period, where they are found in Kimmeridgian to " +
            "early Tithonian aged strata, between 155 and 150 million years ago, in the western" +
            "United States and Portugal.Source: Wikipedia.");
        }

    static void DisplayVelociraptorInfo()
    {
        Console.WriteLine("Velociraptor, meaning \"swift seizer\" in Latin, is a genus" +
            "of dromaeosaurid theropod dinosaur that lived approximately 75 to 71 million years" +
            "ago during the later part of the Cretaceous Period.Two species are currently" +
            "recognized, although others have been assigned in the past.Source: Wikipedia.");
        }
}
}
