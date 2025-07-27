using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using static UnityEditor.PlayerSettings;

public class BoatZone : Zone
{
    GameManager gM;

    GameObject player;
    public Transform boat;
    public TilemapCollider2D groundCollider;
    public TilemapCollider2D waterCollider;
    [SerializeField] bool isReverse = false;

    private void Start()
    {
        gM = GameManager.instance;
        player = gM.player;
    }
    protected override void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.Space))
        {
            gM.SetOnBoat();
            Boarding();
        }

        if (!gM.OnBoat)
            return;
        OnBoatRide();
    }

    void Boarding()
    {
        if (gM.OnBoat)
        {
            player.transform.position = boat.position;

            waterCollider.enabled = false;
            groundCollider.enabled = true;
        }
        else
        {
            player.transform.position = this.transform.position;
            boat.position = isReverse? 
                this.transform.position + new Vector3(-1.5f,0)
                : this.transform.position + new Vector3(1.5f, 0);
            groundCollider.enabled = false;
            waterCollider.enabled = true;
        }
    }
    void OnBoatRide()
    {
        if (player != null && boat != null)
            boat.position = player.transform.position;
        else
        {
            if (boat == null)
                Debug.Log("범인은 보트");
            else
                Debug.Log("범인은 플레이어");
        }
    }
}
