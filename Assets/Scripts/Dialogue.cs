using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject DialogueCanvas;

    bool firstMeet;
    
    public TextMeshProUGUI dialogueText;
    int index;

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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {


        }
    }
}
