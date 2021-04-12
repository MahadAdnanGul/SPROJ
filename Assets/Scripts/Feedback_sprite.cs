using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feedback_sprite : MonoBehaviour
{
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
        
    }

 

    // Update is called once per frame
    void Update()
    {
        
    }

    public void use_all_or_nothing()
    {
        gameObject.GetComponent<Image>().sprite = all_or_nothing;
    }
    public void use_catas()
    {
        gameObject.GetComponent<Image>().sprite = catas;
    }
    public void use_emo_reason()
    {
        gameObject.GetComponent<Image>().sprite = emo_reason;
    }
    public void use_jumping_conc()
    {
        gameObject.GetComponent<Image>().sprite = jumping_conc;
    }
    public void use_labelling()
    {
        gameObject.GetComponent<Image>().sprite = labelling;
    }
    public void use_mind_reading()
    {
        gameObject.GetComponent<Image>().sprite = mind_reading;
    }
    public void use_over_generalization()
    {
        gameObject.GetComponent<Image>().sprite = over_generalization;
    }
    public void use_personalization()
    {
        gameObject.GetComponent<Image>().sprite = personalization;
    }
    public void use_should_must()
    {
        gameObject.GetComponent<Image>().sprite = should_must;
    }
}
