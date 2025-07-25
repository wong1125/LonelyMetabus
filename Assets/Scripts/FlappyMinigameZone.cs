using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyMinigameZone : MonoBehaviour
{

    public GameObject flappyMinigameWindow;
    
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        MapInteracion();
    }


    void MapInteracion()
    {

        Debug.Log("스페이스 바를 눌러보세요");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("스페이스 바 확인됨");
            flappyMinigameWindow.SetActive(true);
        }
    }

    public void ToFlappyMiniGame()
    {
        SceneManager.LoadScene(1);
    }
}
