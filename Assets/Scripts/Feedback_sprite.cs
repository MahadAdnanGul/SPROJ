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
        
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_emo_reason()
    {
        string disc = "Emotional Reasoning";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = emo_reason;
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_jumping_conc()
    {
        string disc = "Jumping to conclusions";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = jumping_conc;
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_labelling()
    {
        string disc = "Labelling";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = labelling;
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_mind_reading()
    {
        string disc = "Mind Reading";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = mind_reading;
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_over_generalization()
    {
        string disc = "Over Generalization";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = over_generalization;
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_personalization()
    {
        string disc = "Personalization";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = personalization;
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void use_should_must()
    {
        string disc = "Should Must";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        gameObject.GetComponent<Image>().sprite = should_must;
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);

    }
    public void Positive()
    {
        string disc = "Positive";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void Neutral()
    {
        string disc = "Neutral";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
    public void Chill()
    {
        string disc = "Chill";
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        FindObjectOfType<InputHandler>().AddNameToList(Type.Distortion, gm.year, int.Parse(ch), disc);
    }
}
