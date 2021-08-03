using System;
[Serializable]
public class InputEntry
{
    public Type ActionType;
    public int year;
    public int chapter;
    public string discription;

    public InputEntry(Type ActionType, int year,int chapter,string disc)
    {
        this.ActionType = ActionType;
        this.year = year;
        this.chapter = chapter;
        discription = disc;
    }
}
public enum Type
{
    Distortion,
    Choice,
    Feeling,
}

