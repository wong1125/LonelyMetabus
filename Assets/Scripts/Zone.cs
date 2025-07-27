using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zone : MonoBehaviour
{
    public GameObject window;
    protected GameObject player;

    bool canInteract = false;

    private void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.Space))
        {
            window.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canInteract = true;
        player = collision.gameObject;
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
