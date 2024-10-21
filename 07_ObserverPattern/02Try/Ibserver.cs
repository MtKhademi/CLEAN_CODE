namespace _07_ObserverPattern._02Try;

// اون کلاس هایی که قرار است من رو دنبال کنند
internal interface Ibserver
{
    public void Notify(List<int> items);
}
