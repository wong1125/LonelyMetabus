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

        Debug.Log("�����̽� �ٸ� ����������");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("�����̽� �� Ȯ�ε�");
            flappyMinigameWindow.SetActive(true);
        }
    }

    public void ToFlappyMiniGame()
    {
        SceneManager.LoadScene(1);
    }
}
