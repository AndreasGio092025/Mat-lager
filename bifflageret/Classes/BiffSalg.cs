namespace Mat_generic;

        public static class BiffSalg
{
    public static void SelgBiffer(BiffLager<Biff> lager, int antall)
    {
        if (lager == null || antall <= 0 || lager.IsEmpty)
         {  
            //Her har jeg gjort om på kodene ville gjøre det på annen måte, har dem der for å se på dem senere

           // Console.WriteLine($"[STOPP] ingenting å selge - eller ugyldig antall");
            return;   
         }
            int solgt = 0;

        for(int i = 0 ; i < antall; i++)
       
        
         if (lager.IsEmpty)
       { 
            
           // Console.WriteLine($"[Stopp] ikke nok biffer igjen - stopp etter {solgt} solgt");
            //return;
        }                //disse også borte
        
        lager.pop();
            solgt ++;
        
   
    
    
       //if (solgt == antall)
        
        // Console.WriteLine($"[FERDIG] Alle {antall} biffer solgt! ");
        
       // else Console.WriteLine($"[FERDIG] {solgt} av {antall} biffer ");
     }
        
   
   } 