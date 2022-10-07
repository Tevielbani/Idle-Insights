using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public bool trigger1 = false;
    public bool trigger2 = false;
    public bool trigger3 = false;
    public bool trigger4 = false;
    public bool trigger5 = false;
    public bool trigger6 = false;
    public bool trigger7 = false;
    public bool trigger8 = false;
    public bool trigger9 = false;
    public bool trigger10 = false;
    public bool trigger11 = false;
    public bool trigger12 = false;
    public bool trigger13 = false;
    public bool trigger14 = false;
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
        if (GameManager.knowledge >= 25 && trigger1 == false)
        {
            //DO DIALOGUE ONE
            Debug.Log("dialogue 1 here");
            PlayerPrefs.SetInt("trigger1", trigger1 ? 1 : 0);
            trigger1 = true;
        }
        if (GameManager.knowledge >= 50 && trigger2 == false)
        {
            //DO DIALOGUE TWO
            Debug.Log("dialogue 2 here");
            PlayerPrefs.SetInt("trigger2", trigger2 ? 1 : 0);
            trigger2 = true;
        }
        if (GameManager.knowledge >= 100 && trigger3 == false)
        {
            //DO DIALOGUE THREE
            Debug.Log("dialogue 3 here");
            PlayerPrefs.SetInt("trigger3", trigger3 ? 1 : 0);
            trigger3 = true;
        }
        if (GameManager.knowledge >= 200 && trigger4 == false)
        {
            //DO DIALOGUE FOUR
            Debug.Log("dialogue 4 here");
            PlayerPrefs.SetInt("trigger4", trigger4 ? 1 : 0);
            trigger4 = true;
        }
        if (GameManager.knowledge >= 500 && trigger5 == false)
        {
            //DO DIALOGUE FIVE
            Debug.Log("dialogue 5 here");
            PlayerPrefs.SetInt("trigger5", trigger5 ? 1 : 0);
            trigger5 = true;
        }
        if (GameManager.knowledge >= 1000 && trigger6 == false)
        {
            //DO DIALOGUE SIX
            Debug.Log("dialogue 6 here");
            PlayerPrefs.SetInt("trigger6", trigger6 ? 1 : 0);
            trigger6 = true;
        }
        if (GameManager.knowledge >= 2000 && trigger7 == false)
        {
            //DO DIALOGUE SEVEN
            Debug.Log("dialogue 7 here");
            PlayerPrefs.SetInt("trigger7", trigger7 ? 1 : 0);
            trigger7 = true;
        }
        if (GameManager.knowledge >= 5000 && trigger8 == false)
        {
            //DO DIALOGUE EIGHT
            Debug.Log("dialogue 8 here");
            PlayerPrefs.SetInt("trigger8", trigger8 ? 1 : 0);
            trigger8 = true;
        }
        if (GameManager.knowledge >= 10000 && trigger9 == false)
        {
            //DO DIALOGUE NINE
            Debug.Log("dialogue 9 here");
            PlayerPrefs.SetInt("trigger9", trigger9 ? 1 : 0);
            trigger9 = true;
        }
        if (GameManager.knowledge >= 25000 && trigger10 == false)
        {
            //DO DIALOGUE TEN
            Debug.Log("dialogue 10 here");
            PlayerPrefs.SetInt("trigger10", trigger10 ? 1 : 0);
            trigger10 = true;
        }
        if (GameManager.knowledge >= 50000 && trigger11 == false)
        {
            //DO DIALOGUE ELEVEN
            Debug.Log("dialogue 11 here");
            PlayerPrefs.SetInt("trigger11", trigger11 ? 1 : 0);
            trigger11 = true;
        }
        if (GameManager.knowledge >= 75000 && trigger12 == false)
        {
            //DO DIALOGUE TWELVE
            Debug.Log("dialogue 12 here");
            PlayerPrefs.SetInt("trigger12", trigger12 ? 1 : 0);
           trigger12 = true;
        }
        if (GameManager.knowledge >= 100000 && trigger13 == false)
        {
            //DO DIALOGUE THIRTEEN
            Debug.Log("dialogue 13 here");
            PlayerPrefs.SetInt("trigger13", trigger13 ? 1 : 0);
            trigger13 = true;
        }
        if (GameManager.knowledge >= 150000 && trigger14 == false)
        {
            //DO DIALOGUE FOURTEEN
            Debug.Log("dialogue 14 here");
            PlayerPrefs.SetInt("trigger14", trigger14 ? 1 : 0);
            trigger14 = true;
        }
    }
}