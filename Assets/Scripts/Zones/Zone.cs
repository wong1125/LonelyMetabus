using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zone : MonoBehaviour
{
    public GameObject window;
    protected bool canInteract = false;

    protected virtual void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.Space))
        {
            window.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canInteract = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canInteract = false;
    }

    public void CloseWindow()
    {
        window.SetActive(false);
    }

}
