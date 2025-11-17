using Mat_Lager;

namespace Mat_generic;

public class BiffLager<T> : IPoppable<T>, Ipushable<T> where T : class
{ 

    private readonly Stack<T> _stabel = new();

    public int Count => _stabel.Count;
    public bool IsEmpty => _stabel.Count == 0;

    public void push(T Item)
    {
        ArgumentNullException.ThrowIfNull(Item);
        _stabel.Push(Item);

    }
     public T pop()
    {
     if (IsEmpty)
     throw new InvalidOperationException("Lageret er tomt!");
    
     var item = _stabel.Pop();
     Console.WriteLine($"[Lager] - solgt: {item}");
     return item;
    // her blir biff fjernet fra lagret og man kan se hvor mange som er igjen etter salg
    // har med sikkerhet om lagret skulle være tomt/null at beskjed kommer stede for kræsj i programmet
    }

    public void VisLager()
    {
         if (IsEmpty)
        {
            Console.WriteLine ("Lageret er tomt.");
            return;

        }
        // viser mengde i lagermengden 
        Console.WriteLine($" \nLagermengde ({Count} stykker):");
        int i = 0;
        foreach (var item in _stabel)
        {
         Console.WriteLine($" {i}  {item}");
         Console.WriteLine();
                i++;
        
        }
          Console.WriteLine();
       
       }

    } 