using System.Reflection.Metadata.Ecma335;
using Mat_generic;

namespace Mat_generic;

    public class Biff
    {
    public BiffType Type { get; set; }
    public double VektKg {get ; set; }

    public DateTime SlakteDato {get ;set; } = DateTime.Today;

    public override string ToString()
    => $"{Type}({VektKg}Kg)- slaktet{SlakteDato: dd.MM.yyyy}";
    
    // her hentes det inn data til bifflagret om hvilken type biff, vekt, slakter dato og legger det sammen til lesbar info
    
 }
        

  
