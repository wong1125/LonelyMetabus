using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeZone : Zone
{
    new SpriteRenderer renderer;
    public GameObject sunglasses;
    public GameObject vest;

    public void ChangeColorPink()
    {
        renderer = GameManager.instance.player.GetComponentInChildren<SpriteRenderer>();
        renderer.color = new Color32(255, 180, 222, 255);
    }

    public void ChangeColorWhite()
    {
        renderer = GameManager.instance.player.GetComponentInChildren<SpriteRenderer>();
        renderer.color = Color.white;
    }

    public void ChangeSunglasses()
    {
        bool boolen = sunglasses.activeSelf;
        sunglasses.SetActive(!boolen);
    }

    public void ChangeVest()
    {
        bool boolen = vest.activeSelf;
        vest.SetActive(!boolen);
        GameManager.instance.SetLifeVest();
    }


}
