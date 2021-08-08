using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feedback_sprite : MonoBehaviour
{
    private GameManager gm;
    [SerializeField] Sprite all_or_nothing;
    [SerializeField] Sprite catas;
    [SerializeField] Sprite emo_reason;
    [SerializeField] Sprite jumping_conc;
    [SerializeField] Sprite labelling;
    [SerializeField] Sprite mind_reading;
    [SerializeField] Sprite over_generalization;
    [SerializeField] Sprite personalization;
    [SerializeField] Sprite should_must;
    [SerializeField] Sprite mental_filtering;
    [SerializeField] Sprite heaven_fallacy;
    [SerializeField] Sprite blaming;
    [SerializeField] GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(gm);
    }
    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void use_all_or_nothing()
    {
        string disc = "All or Nothing";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = all_or_nothing;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void Blaming()
    {
        string disc = "blaming";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = blaming;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void Heaven_Fallacy()
    {
        string disc = "Heaven's Fallacy Reward";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = heaven_fallacy;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void Mental_Filtering()
    {
        string disc = "Mental Filtering";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = mental_filtering;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_catas()
    {
        string disc = "Catastophizing";
       /* Debug.Log(FindObjectOfType<InputHandler>());
        Debug.Log(Type.Distortion);
        Debug.Log(gm.year);
        
        Debug.Log(disc);*/
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
    
        gameObject.GetComponent<Image>().sprite = catas;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);

        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_emo_reason()
    {
        string disc = "Emotional Reasoning";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = emo_reason;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_jumping_conc()
    {
        string disc = "Jumping to conclusions";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = jumping_conc;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_labelling()
    {
        string disc = "Labelling";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = labelling;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_mind_reading()
    {
        string disc = "Mind Reading";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = mind_reading;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_over_generalization()
    {
        string disc = "Over Generalization";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = over_generalization;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_personalization()
    {
        string disc = "Personalization";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = personalization;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_should_must()
    {
        string disc = "Should Must";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();

        gameObject.GetComponent<Image>().sprite = should_must;
        gameObject.GetComponent<Image>().enabled = true;
        button.SetActive(true);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);

    }
    public void Positive()
    {
        gameObject.SetActive(true);
        button.SetActive(false);
        gameObject.GetComponent<Image>().enabled = false;
        string disc = "Postive";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void Neutral()
    {
        gameObject.SetActive(true);
        button.SetActive(false);
        gameObject.GetComponent<Image>().enabled = false;
        string disc = "Neutral";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void Chill()
    {
        gameObject.SetActive(true);
        button.SetActive(false);
        gameObject.GetComponent<Image>().enabled = false;
        string disc = "Chill";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
   
}
