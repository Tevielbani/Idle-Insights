using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public static bool trigger1 = false;
    public static float dialogueCount;
    public float dialogueCountTracker;
    public static bool dialogueOver;
    // Start is called before the first frame update
    void Start()
    {
        dialogueCount = PlayerPrefs.GetFloat("dialogueCount", 0);
    }
    // Update is called once per frame
    void Update()
    {
        dialogueCountTracker = dialogueCount;
        if (GameManager.knowledge >= 25 && dialogueCount <= 1)
        {
            //DO DIALOGUE ONE
            Debug.Log("dialogue 1 here");
            dialogueCount += 0.1f;
            PlayerPrefs.SetFloat("dialogueCount", dialogueCount);
            trigger1 = true;
        }
    }
}