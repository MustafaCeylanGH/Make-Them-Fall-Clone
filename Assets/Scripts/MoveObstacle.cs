using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField] private float prefabMoveSpeed = 5.0f;
    
    void Update()
    {
        transform.Translate(0, prefabMoveSpeed * Time.deltaTime, 0);
    }

}
