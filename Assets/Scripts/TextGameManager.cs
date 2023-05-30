using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro,hpTextMeshPro,StaminaTextMeshPro;
    public string storyText;
    public int HpValue,StaminaValue;
    public GameObject Level_1_Choices, Level_2_Choices;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        hpTextMeshPro.text = HpValue.ToString();
        StaminaTextMeshPro.text = StaminaValue.ToString();
    }

    public void GoDownstairs()
    {
        storyText = "You fell and You die";
        HpValue -= 10;
        Level_1_Choices.SetActive(false);
    }
    public void GoUpstairs()
    {

    }
    public void BrushmyTeeth()
    {
        storyText = "You have finished brushing your teeth";
        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(true);
        HpValue += 2;
    }
}

