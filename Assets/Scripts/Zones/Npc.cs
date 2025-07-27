using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public GameObject DialogueWindow;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("npc!");
        DialogueWindow.SetActive(true);
    }

}
