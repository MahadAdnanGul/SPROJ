using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class InputHandler : MonoBehaviour
{
    //[SerializeField] InputField nameInput;
    [SerializeField] string filename;

    List<InputEntry> entries = new List<InputEntry>();

    private void Start()
    {
        entries = FileHandler.ReadListFromJSON<InputEntry>(filename);
    }

    public void AddNameToList(Type type,int year, int chapter, string disc)
    {
        entries.Add(new InputEntry(type,year,chapter,disc));

        FileHandler.SaveToJSON<InputEntry>(entries, filename);
    }
}
