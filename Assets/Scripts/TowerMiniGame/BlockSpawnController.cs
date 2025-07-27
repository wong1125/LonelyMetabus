using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class BlockSpawnController : MonoBehaviour
{
    public static BlockSpawnController instance;
    
    Camera camera;
    Camera componetCamera;
    float initialCameraYPos = 8.0f;
    public List<GameObject> blockList;

    GameObject blockHeld;
    bool isHolding = false;
    float spawnYpos = 16.0f;
    private bool isNextPhase = true;

    private void Awake()
    {
        if (instance == null)
        {

            instance = this;
        }

        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (TowerGameManager.instance.IsGameOver)
            return;

        float score = TowerGameManager.instance.Score;
        if (isNextPhase) //블록이 착지했다는 신호
        {
            camera.orthographicSize = 10 + (score / 5);
            blockHeld = Instantiate(blockList[Random.Range(0, blockList.Count)]);
            isNextPhase = false;
            isHolding = true;
        }

        if (blockHeld == null || !isHolding) // 블록 마우스 컨트롤
            return;

        Vector2 mousePosition = Input.mousePosition;
        float mouseXpos = camera.ScreenToWorldPoint(mousePosition).x;

        if (score > spawnYpos - 5)
        {
            blockHeld.transform.position = new Vector2(mouseXpos, score + 5);
        }
        else
            blockHeld.transform.position = new Vector2(mouseXpos, spawnYpos);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            blockHeld.transform.Rotate(0, 0, 90);
        }


        if (Input.GetMouseButtonDown(0))
        {
            isHolding = false;
            Block blockComponent = blockHeld.GetComponent<Block>();
            blockComponent.Drop();

        }
    }

    public void NextBlock()
    {
        isNextPhase = true;
    }


}
