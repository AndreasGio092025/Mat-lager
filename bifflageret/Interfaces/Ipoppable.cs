namespace  Mat_Lager;

public interface IPoppable<out T>
{
    T pop();
    bool IsEmpty {get;}
} //popper ut øverste av stabelen(stacket)