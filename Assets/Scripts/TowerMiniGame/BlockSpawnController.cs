using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockSpawnController : MonoBehaviour
{
    public static BlockSpawnController instance;
    
    Camera camera;
    public List<GameObject> blockList;
    GameObject blockHeld;
    bool isHolding = false;
    float spawnYpos = 5.0f;
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
        
        //블록에 착지했다는 신호
        if (isNextPhase)
        {
            blockHeld = Instantiate(blockList[Random.Range(0, blockList.Count)]);
            isNextPhase = false;
            isHolding = true;
        }

        if (blockHeld == null || !isHolding)
            return;


        Vector2 mousePosition = Input.mousePosition;
        float mouseXpos = camera.ScreenToWorldPoint(mousePosition).x;
        blockHeld.transform.position = new Vector2(mouseXpos, spawnYpos);


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
