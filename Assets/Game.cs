using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text uiK;
    public Text uiOK;
    public Text uiEK;
    public Text price1;
    public Text price2;
    public Text price3;
    public Text price4;
    public Text price5;
    public Text price6;
    public Text price7;
    public Text price8;
    public Text price9;
    public Text price10;
    public Text price11;
    public Text price12;
    public Text price13;
    public Text price14;
    public Text price15;
    public float cost1 = 25;
    public float cost2 = 40;
    public float cost3 = 100;
    public float cost4 = 180;
    public float cost5 = 850;
    public float cost6 = 200;
    public float cost7 = 350;
    public float cost8 = 800;
    public float cost9 = 1500;
    public float cost10 = 3700;
    public float cost11 = 7200;
    public float cost12 = 1500;
    public float cost13 = 250000;
    public float cost14 = 400000;
    public float cost15 = 1000000;
    public float multiplier1;
    public float multiplier2;
    public float multiplier3;
    public float multiplier4;
    public float multiplier5;
    public float multiplier6;
    public float multiplier7;
    public float multiplier8;
    public float multiplier9;
    public float multiplier10;
    public float multiplier11;
    public float multiplier12;
    public float multiplier13;
    public float multiplier14;
    public float multiplier15;
    public float trueCost1 = 25;
    private float trueCost2 = 100;
    private float trueCost3 = 800;
    private float trueCost4 = 3000;
    private float trueCost5 = 10000;
    private float trueCost6 = 50000;
    private float trueCost7 = 1000;
    private float trueCost8 = 4000;
    private float trueCost9 = 10000;
    private float trueCost10 = 50000;
    private float trueCost11 = 150000;
    private float trueCost12 = 250000;
    private float trueCost13 = 2500000;
    private float trueCost14 = 4000000;
    private float trueCost15 = 10000000;

    private void Start()
    {
        multiplier1 = PlayerPrefs.GetFloat("multiplier1", 1);
        multiplier2 = PlayerPrefs.GetFloat("multiplier2", 1);
        multiplier3 = PlayerPrefs.GetFloat("multiplier3", 1);
        multiplier4 = PlayerPrefs.GetFloat("multiplier4", 1);
        multiplier5 = PlayerPrefs.GetFloat("multiplier5", 1);
        multiplier6 = PlayerPrefs.GetFloat("multiplier6", 1);
        multiplier7 = PlayerPrefs.GetFloat("multiplier7", 1);
        multiplier8 = PlayerPrefs.GetFloat("multiplier8", 1);
        multiplier9 = PlayerPrefs.GetFloat("multiplier9", 1);
        multiplier10 = PlayerPrefs.GetFloat("multiplier10", 1);
        multiplier11 = PlayerPrefs.GetFloat("multiplier11", 1);
        multiplier12 = PlayerPrefs.GetFloat("multiplier12", 1);
        multiplier13 = PlayerPrefs.GetFloat("multiplier13", 1);
        multiplier14 = PlayerPrefs.GetFloat("multiplier14", 1);
        multiplier15 = PlayerPrefs.GetFloat("multiplier15", 1);
        cost1 = Mathf.RoundToInt(trueCost1 *= multiplier1);
        cost2 = Mathf.RoundToInt(trueCost2 *= multiplier2);
        cost3 = Mathf.RoundToInt(trueCost3 *= multiplier3);
        cost4 = Mathf.RoundToInt(trueCost4 *= multiplier4);
        cost5 = Mathf.RoundToInt(trueCost5 *= multiplier5);
        cost6 = Mathf.RoundToInt(trueCost6 *= multiplier6);
        cost7 = Mathf.RoundToInt(trueCost7 *= multiplier7);
        cost8 = Mathf.RoundToInt(trueCost8 *= multiplier8);
        cost9 = Mathf.RoundToInt(trueCost9 *= multiplier9);
        cost10 = Mathf.RoundToInt(trueCost10 *= multiplier10);
        cost11 = Mathf.RoundToInt(trueCost11 *= multiplier11);
        cost12 = Mathf.RoundToInt(trueCost12 *= multiplier12);
        cost13 = Mathf.RoundToInt(trueCost13 *= multiplier13);
        cost14 = Mathf.RoundToInt(trueCost14 *= multiplier14);
        cost15 = Mathf.RoundToInt(trueCost15 *= multiplier15);
    }
    public void Increment()
    {

        GameManager.knowledge += GameManager.multiplier;
        PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
        
        if(GameManager.occultic == true)
        {
            GameManager.occultKnowledge += GameManager.oMultiplier;
        }
        if(GameManager.eldritchy == true)
        {
            GameManager.eldritchKnowledge += GameManager.eMultiplier;
        }
    }

    public void Buy(int num)
    {
        if(num == 1 && GameManager.knowledge >= cost1)
        {
            GameManager.multiplier += 1;
            GameManager.knowledge -= cost1;
            multiplier1 *= 1.1f;
            cost1 = Mathf.RoundToInt(trueCost1 *= multiplier1);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier", GameManager.multiplier);
            PlayerPrefs.SetFloat("multiplier1", multiplier1);
        }
        if (num == 2 && GameManager.knowledge >= cost2)
        {
            GameManager.multiplier += 2;
            GameManager.knowledge -= cost2;
            multiplier2 *= 1.1f;
            cost2 = Mathf.RoundToInt(trueCost2 *= multiplier2);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier", GameManager.multiplier);
            PlayerPrefs.SetFloat("multiplier2", multiplier2);
        }
        if (num == 3 && GameManager.knowledge >= cost3)
        {
            GameManager.multiplier += 5;
            GameManager.knowledge -= cost3;
            multiplier3 *= 1.1f;
            cost3 = Mathf.RoundToInt(trueCost3 *= multiplier3);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier", GameManager.multiplier);
            PlayerPrefs.SetFloat("multiplier3", multiplier3);
        }
        if (num == 4 && GameManager.knowledge >= cost4)
        {
            GameManager.multiplier += 10;
            GameManager.knowledge -= cost4;
            multiplier4 *= 1.1f;
            cost4 = Mathf.RoundToInt(trueCost4 *= multiplier4);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier", GameManager.multiplier);
            PlayerPrefs.SetFloat("multiplier4", multiplier4);
        }
        if (num == 5 && GameManager.knowledge >= cost5)
        {
            GameManager.multiplier += 25;
            GameManager.knowledge -= cost5;
            multiplier5 *= 1.1f;
            cost5 = Mathf.RoundToInt(trueCost5 *= multiplier5);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier", GameManager.multiplier);
            PlayerPrefs.SetFloat("multiplier5", multiplier5);
        }
        if (num == 6 && GameManager.knowledge >= cost6)
        {
            GameManager.multiplier += 50;
            GameManager.knowledge -= cost6;
            multiplier6 *= 1.1f;
            cost6 = Mathf.RoundToInt(trueCost6 *= multiplier6);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier", GameManager.multiplier);
            PlayerPrefs.SetFloat("multiplier6", multiplier6);
        }
        if (num == 7 && GameManager.knowledge >= cost7)
        {
            GameManager.knowledgePerTick += 1;
            GameManager.passiveKnowledge = true;
            GameManager.knowledge -= cost7;
            multiplier7 *= 1.1f;
            cost7 = Mathf.RoundToInt(trueCost7 *= multiplier7);
            PlayerPrefs.SetFloat("knowledgePerTick", GameManager.knowledgePerTick);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier7", multiplier7);
        }
        if (num == 8 && GameManager.knowledge >= cost8)
        {
            GameManager.knowledgePerTick += 2;
            GameManager.passiveKnowledge = true;
            GameManager.knowledge -= cost8;
            multiplier8 *= 1.1f;
            cost8 = Mathf.RoundToInt(trueCost8 *= multiplier8);
            PlayerPrefs.SetFloat("knowledgePerTick", GameManager.knowledgePerTick);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier8", multiplier8);
        }
        if (num == 9 && GameManager.knowledge >= cost9)
        {
            GameManager.knowledgePerTick += 5;
            GameManager.passiveKnowledge = true;
            GameManager.knowledge -= cost9;
            multiplier9 *= 1.1f;
            cost9 = Mathf.RoundToInt(trueCost9 *= multiplier9);
            PlayerPrefs.SetFloat("knowledgePerTick", GameManager.knowledgePerTick);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier9", multiplier9);
        }
        if (num == 10 && GameManager.knowledge >= cost10)
        {
            GameManager.knowledgePerTick += 10;
            GameManager.passiveKnowledge = true;
            GameManager.knowledge -= cost10;
            multiplier10 *= 1.1f;
            cost10 = Mathf.RoundToInt(trueCost10 *= multiplier10);
            PlayerPrefs.SetFloat("knowledgePerTick", GameManager.knowledgePerTick);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier10", multiplier10);
        }
        if (num == 11 && GameManager.knowledge >= cost11)
        {
            GameManager.knowledgePerTick += 25;
            GameManager.passiveKnowledge = true;
            GameManager.knowledge -= cost11;
            multiplier11 *= 1.1f;
            cost11 = Mathf.RoundToInt(trueCost11 *= multiplier11);
            PlayerPrefs.SetFloat("knowledgePerTick", GameManager.knowledgePerTick);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier11", multiplier11);
        }
        if (num == 12 && GameManager.knowledge >= cost12)
        {
            GameManager.knowledgePerTick += 50;
            GameManager.passiveKnowledge = true;
            GameManager.knowledge -= cost12;
            multiplier12 *= 1.1f;
            cost12 = Mathf.RoundToInt(trueCost12 *= multiplier12);
            PlayerPrefs.SetFloat("knowledgePerTick", GameManager.knowledgePerTick);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier12", multiplier12);
        }
        if (num == 13 && GameManager.knowledge >= cost13)
        {
            GameManager.knowledgePerTick += 100;
            GameManager.passiveKnowledge = true;
            GameManager.knowledge -= cost13;
            multiplier13 *= 1.1f;
            cost13 = Mathf.RoundToInt(trueCost13 *= multiplier13);
            PlayerPrefs.SetFloat("knowledgePerTick", GameManager.knowledgePerTick);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("multiplier13", multiplier13);
        }
        if (num == 14 && GameManager.knowledge >= cost14)
        {
            GameManager.oMultiplier += 2;
            GameManager.knowledge -= cost14;
            multiplier14 *= 1.1f;
            cost14 = Mathf.RoundToInt(trueCost14 *= multiplier14);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("oMultiplier", GameManager.oMultiplier);
            PlayerPrefs.SetFloat("multiplier14", multiplier14);
        }
        if (num == 15 && GameManager.knowledge >= cost15)
        {
            GameManager.multiplier += 5;
            GameManager.knowledge -= cost15;
            multiplier15 *= 1.1f;
            cost15 = Mathf.RoundToInt(trueCost15 *= multiplier15);
            PlayerPrefs.SetFloat("knowledge", GameManager.knowledge);
            PlayerPrefs.SetFloat("oMultiplier", GameManager.oMultiplier);
            PlayerPrefs.SetFloat("multiplier15", multiplier15);
        }
    }
    public void Update()
    {

        uiK.text = "" + GameManager.knowledge;
        uiOK.text = "OK: " + GameManager.occultKnowledge;
        uiEK.text = "EK: " + GameManager.eldritchKnowledge;
        price1.text = cost1 + "K";
        price2.text = cost2 + "K";
        price3.text = cost3 + "K";
        price4.text = cost4 + "K";
        price5.text = cost5 + "K";
        price6.text = cost6 + "K";
        price7.text = cost7 + "K";
        price8.text = cost8 + "K";
        price9.text = cost9 + "K";
        price10.text = cost10 + "K";
        price11.text = cost11 + "K";
        price12.text = cost12 + "K";
        price13.text = cost13 + "K";
        price14.text = cost14 + "K";
        price15.text = cost15 + "K";

        //Devtool, add 200 to click
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            GameManager.multiplier += 200;
        }

        if (GameManager.knowledge <= 10000000 && GameManager.occultic == false)
        {
            GameManager.oMultiplier += 1;
            GameManager.occultic = true;
        }
        if (GameManager.occultKnowledge <= 100000 && GameManager.knowledge <= 100000000 && GameManager.eldritchy == false)
        {
            GameManager.eMultiplier += 1;
            GameManager.eldritchy = true;
        }
    }
}
