namespace  Mat_generic;

public interface Ipushable<in T>
{
    void push(T Item);
    int Count {get;}
}
// stakker opp objektene opp i stabelen(stacket)
