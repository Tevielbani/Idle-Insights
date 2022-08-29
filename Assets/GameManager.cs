using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static float knowledge;
    public static float knowledgePerTick;
    public static bool occultic;
    public static float occultKnowledge;
    public static bool eldritchy;
    public static float eldritchKnowledge;
    public static float power;
    public static float occultPower;
    public static float eldritchPower;
    public static float oMultiplier;
    public static float eMultiplier;
    public static float multiplier;
    public static bool passiveKnowledge = false;
    public bool endItAll = false;
    public float tickCooldown;
    // Start is called before the first frame update
    void Start()
    {
        multiplier = PlayerPrefs.GetFloat("multiplier", 1);
        knowledgePerTick = PlayerPrefs.GetFloat("knowledgePerTick", 0);
        knowledge = PlayerPrefs.GetFloat("knowledge", 0);
        occultKnowledge = PlayerPrefs.GetFloat("occulticKnowledge", 0);
        eldritchKnowledge = PlayerPrefs.GetFloat("eldritchKnowledge", 0);

        if (oMultiplier > 1)
        {
            occultic = true;
        }
        if(eMultiplier > 1)
        {
            eldritchy = true;
        }
        tickCooldown = Time.fixedTime + 1f;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            endItAll = true;
            PlayerPrefs.DeleteAll();
        }

    }
    private void FixedUpdate()
    {
        if (endItAll == false)
        {
            if (Time.fixedTime >= tickCooldown)
            {
                knowledge += knowledgePerTick;
                PlayerPrefs.SetFloat("knowledge", knowledge);
                tickCooldown = Time.fixedTime + 1f;
            }
        }
    }

}


