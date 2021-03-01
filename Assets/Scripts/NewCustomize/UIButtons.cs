using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIButtons : MonoBehaviour
{
    [SerializeField] private GameObject skinPage;
    [SerializeField] private GameObject hairPage;
    [SerializeField] private GameObject shirtPage;
    [SerializeField] private GameObject pantsPage;
    [SerializeField] private GameObject shoesPage;

    [SerializeField] private UnityEngine.UI.Button skinButton;
    [SerializeField] private UnityEngine.UI.Button hairButton;
    [SerializeField] private UnityEngine.UI.Button shirtButton;
    [SerializeField] private UnityEngine.UI.Button pantsButton;
    [SerializeField] private UnityEngine.UI.Button shoesButton;
    // Start is called before the first frame update
    public void AllDisable()
    {
        skinPage.SetActive(false);
        hairPage.SetActive(false);
        shirtPage.SetActive(false);
        pantsPage.SetActive(false);
        shoesPage.SetActive(false);
    }

    public void AllColorReset()
    {
        var defColor = skinButton.colors;
        defColor.normalColor = Color.white;
        skinButton.colors = defColor;
        hairButton.colors = defColor;
        shirtButton.colors = defColor;
        pantsButton.colors = defColor;
        shoesButton.colors = defColor;
    }
    public void ChangeColor(UnityEngine.UI.Button x)
    {
        var defColor = x.colors;
        defColor.normalColor = Color.green;
        x.colors = defColor;
    }
}
