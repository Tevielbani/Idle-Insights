using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public bool trigger1;
    public bool trigger2;
    public bool trigger3;
    public bool trigger4;
    public bool trigger5;
    public bool trigger6;
    public bool trigger7;
    public bool trigger8;
    public bool trigger9;
    public bool trigger10;
    public bool trigger11;
    public bool trigger12;
    public bool trigger13;
    public bool trigger14;
    // Start is called before the first frame update
    void Start()
    {
        trigger1 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger2 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger3 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger4 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger5 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger6 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger7 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger8 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger9 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger10 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger11 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger12 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger13 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;
        trigger14 = PlayerPrefs.GetInt("trigger1", 0) == 1 ? true : false;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.knowledge <= 25 && trigger1 == false)
        {
            trigger1 = true;
            //DO DIALOGUE ONE
            Debug.Log("dialogue 1 here");
            PlayerPrefs.SetInt("trigger1", trigger1 ? 1 : 0);
        }
        if (GameManager.knowledge <= 50 && trigger2 == false)
        {
            trigger2 = true;
            //DO DIALOGUE TWO
            PlayerPrefs.SetInt("trigger2", trigger2 ? 1 : 0);
        }
        if (GameManager.knowledge <= 100 && trigger3 == false)
        {
            trigger3 = true;
            //DO DIALOGUE THREE
            PlayerPrefs.SetInt("trigger3", trigger3 ? 1 : 0);
        }
        if (GameManager.knowledge <= 200 && trigger4 == false)
        {
            trigger4 = true;
            //DO DIALOGUE FOUR
            PlayerPrefs.SetInt("trigger4", trigger4 ? 1 : 0);
        }
        if (GameManager.knowledge <= 500 && trigger5 == false)
        {
            trigger5 = true;
            //DO DIALOGUE FIVE
            PlayerPrefs.SetInt("trigger5", trigger5 ? 1 : 0);
        }
        if (GameManager.knowledge <= 1000 && trigger6 == false)
        {
            trigger6 = true;
            //DO DIALOGUE SIX
            PlayerPrefs.SetInt("trigger6", trigger6 ? 1 : 0);
        }
        if (GameManager.knowledge <= 2000 && trigger7 == false)
        {
            trigger7 = true;
            //DO DIALOGUE SEVEN
            PlayerPrefs.SetInt("trigger7", trigger7 ? 1 : 0);
        }
        if (GameManager.knowledge <= 5000 && trigger8 == false)
        {
            trigger8 = true;
            //DO DIALOGUE EIGHT
            PlayerPrefs.SetInt("trigger8", trigger8 ? 1 : 0);
        }
        if (GameManager.knowledge <= 10000 && trigger9 == false)
        {
            trigger9 = true;
            //DO DIALOGUE NINE
            PlayerPrefs.SetInt("trigger9", trigger9 ? 1 : 0);
        }
        if (GameManager.knowledge <= 25000 && trigger10 == false)
        {
            trigger10 = true;
            //DO DIALOGUE TEN
            PlayerPrefs.SetInt("trigger10", trigger10 ? 1 : 0);
        }
        if (GameManager.knowledge <= 50000 && trigger11 == false)
        {
            trigger11 = true;
            //DO DIALOGUE ELEVEN
            PlayerPrefs.SetInt("trigger11", trigger11 ? 1 : 0);
        }
        if (GameManager.knowledge <= 75000 && trigger12 == false)
        {
            trigger12 = true;
            //DO DIALOGUE TWELVE
            PlayerPrefs.SetInt("trigger12", trigger12 ? 1 : 0);
        }
        if (GameManager.knowledge <= 100000 && trigger13 == false)
        {
            trigger13 = true;
            //DO DIALOGUE THIRTEEN
            PlayerPrefs.SetInt("trigger13", trigger13 ? 1 : 0);
        }
        if (GameManager.knowledge <= 150000 && trigger14 == false)
        {
            trigger14 = true;
            //DO DIALOGUE FOURTEEN
            PlayerPrefs.SetInt("trigger14", trigger14 ? 1 : 0);
        }
    }
}