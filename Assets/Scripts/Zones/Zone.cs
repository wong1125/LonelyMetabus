using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zone : MonoBehaviour
{
    public GameObject window;
    public GameObject speachBubble;
    protected bool canInteract = false;

    protected virtual void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.instance.SetUIOpen();
            window.SetActive(true);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canInteract = true;
        speachBubble.SetActive(true);

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canInteract = false;
        if (speachBubble != null)
            speachBubble.SetActive(false);
    }

    public void CloseWindow()
    {
        GameManager.instance.SetUIOpen();
        window.SetActive(false);
    }

}
