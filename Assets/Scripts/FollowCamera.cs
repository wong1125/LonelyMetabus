using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;

    [SerializeField] Vector2 minLimtPos = Vector2.zero;
    [SerializeField] Vector2 maxLimtPos = Vector2.zero;
    
    
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

        Vector3 cameraPosition = transform.position;
        Vector2 tragetPosition = target.position;
        cameraPosition.x = Mathf.Clamp(target.position.x, minLimtPos.x, maxLimtPos.x);
        cameraPosition.y = Mathf.Clamp(target.position.y, minLimtPos.y, maxLimtPos.y);
        transform.position = cameraPosition;
    }
}
