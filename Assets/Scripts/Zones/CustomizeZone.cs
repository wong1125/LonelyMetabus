using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeZone : Zone
{
    public SpriteRenderer renderer;

    public void ChangeColor()
    {
        renderer = GameManager.instance.player.GetComponentInChildren<SpriteRenderer>();
        renderer.color = Color.red;
    }


}
