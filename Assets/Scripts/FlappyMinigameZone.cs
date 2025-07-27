using System.Collections;
using System.Collections.Generic;
using Unity.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyMinigameZone : MonoBehaviour
{

    public GameObject flappyMinigameWindow;

    bool canInteract = false; 

    private void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.Space))
        {
            flappyMinigameWindow.SetActive(true);
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
    

    public void ToFlappyMiniGame()
    {
        SceneManager.LoadScene(1);
    }
}
