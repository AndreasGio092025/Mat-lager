

using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;
using Mat_generic;
using Mat_Lager;


namespace Mat_generic;
public class Program
{
    
    static void Fyllerlager(BiffLager<Biff> Lager)
 {  
    //oppretter biff lager her med type, kilo og slakte dato, toppen legges på først og printes ut sist
      Lager.push(new() { Type = BiffType.Tbone,  VektKg = 1.0, SlakteDato = new DateTime (2025, 11, 15) });
      Lager.push(new() {Type = BiffType.Entrecote,  VektKg = 1.1, SlakteDato = new DateTime (2025, 11, 14) });
      Lager.push(new() {Type = BiffType.Waygu,  VektKg = 0.4, SlakteDato = new DateTime (2025, 11, 14) });
      Lager.push(new() {Type = BiffType.Tbone,  VektKg = 0.9, SlakteDato = new DateTime (2025, 11, 13) }); 
      Lager.push(new() {Type = BiffType.Entrecote,  VektKg = 1.3, SlakteDato = new DateTime (2025, 11, 12) });
// printer ut bunnen først og beveger seg opp
    
}


    static void Main()
{
    
    var Lager = new BiffLager<Biff>();
    Fyllerlager(Lager);

    Console.WriteLine("\n=== Åpne lager ===" );
    Lager.VisLager();

  
    Console.WriteLine("=== 3 av di eldste biffene solgt datoen: 19.11.2025 ===\n ");
    for (int i = 0; i < 3; i++)
        {
            if(!Lager.IsEmpty)
            {
                Lager.pop();
            }
            
        }

    Console.WriteLine("\n === Gjenstående Biffer === ");
    Lager.VisLager();



    Console.WriteLine("=== sjekker lager status ===");
    if(!Lager.IsEmpty) 
    Lager.pop();
    
    else
    Console.WriteLine("Lagre er tomt fra dato 22.11.2025");
    Console.WriteLine("\nAvslutt. Trykke en tast...");
    Console.ReadKey();
     
}   
}
   
   
   

  

