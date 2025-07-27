using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public GameObject DialogueWindow;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(true);
        Dialogue dialogue = DialogueWindow.GetComponent<Dialogue>();
        dialogue.InitalDialogue();
    }

}
