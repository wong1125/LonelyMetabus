using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
            return;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        Vector3 originalPosition = transform.position;
        Vector2 tragetPosition = target.position;
        originalPosition.x = tragetPosition.x;
        originalPosition.y = tragetPosition.y;
        transform.position = originalPosition;
    }
}
