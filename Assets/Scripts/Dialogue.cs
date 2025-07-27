using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject DialogueCanvas;
    GameManager gM;
    public GameObject fence;

    bool firstMeet = true;
    bool onDialogue;

    public TextMeshProUGUI dialogueText;
    int index = 0;

    // 방법을 모르니 일단 하드코딩
    [SerializeField] string a0;
    [SerializeField] string a1;
    [SerializeField] string a2;
    [SerializeField] string a3;
    [SerializeField] string a4;
    [SerializeField] string a5;
    [SerializeField] string a6;

    void Start()
    {
        
        List<string> list = new List<string>() { a0, a1, a2, a3, a4, a5, a6 };
        dialogueText.text = a0;
        gM = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (onDialogue && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            Proceed();

        }
    }

    void Proceed()
    {
        switch (index)
        {
            case 0:
                firstMeet = false;
                dialogueText.text = a1;
                index = 1;
                break;
            case 1:
                dialogueText.text = a2;
                index = 2;
                break;
            default:
                EndDialogue();
                break;
        }


    }

    public void InitalDialogue()
    {
        onDialogue = true;
        this.gameObject.SetActive(true);
        GameManager.instance.SetUIOpen();

        if (!firstMeet)
        {

            gM.SetGoodSwim();

            if (!gM.LifeVest && !gM.GoodSwim)
            {
                dialogueText.text = a6;
                return;
            }

            if (gM.LifeVest && gM.GoodSwim)
                dialogueText.text = a5;
            else if (gM.LifeVest && !gM.GoodSwim)
                dialogueText.text = a3;
            else
                dialogueText.text = a4;
            fence.SetActive(false);
        }
    }

    void EndDialogue()
    {
        onDialogue = false;
        this.gameObject.SetActive(false);
        GameManager.instance.SetUIOpen();
    }
}
