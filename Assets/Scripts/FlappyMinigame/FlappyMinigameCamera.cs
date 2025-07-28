using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyMinigameCamera : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        if (target == null)
            return;
    }

    void Update()
    {
        if (target == null)
            return;

        Vector3 originalPosition = transform.position;
        Vector2 tragetPosition = target.position;
        originalPosition.x = tragetPosition.x +3.0f;
        transform.position = originalPosition;
    }
}
