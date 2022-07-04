using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float[] leftSpawnArray;
    [SerializeField] private float[] rightSpawnArray;
    private int leftSpawnpos;
    private int rightSpawnpos;
    [SerializeField] private float rightSpawnSpeed;
    [SerializeField] private float leftSpawnSpeed;
    

    private void Start()
    {
        InvokeRepeating("LeftSpawnPrefab", 0.1f, leftSpawnSpeed);
        InvokeRepeating("RightSpawnPrefab", 0.1f, rightSpawnSpeed);
    }
    private void LeftSpawnPrefab()
    {
        leftSpawnpos = Random.Range(0, leftSpawnArray.Length);   

        if (leftSpawnpos==0)
        {
            Instantiate(prefab, new Vector3(leftSpawnArray[leftSpawnpos], transform.position.y, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(prefab, new Vector3(leftSpawnArray[leftSpawnpos], transform.position.y, 0), Quaternion.Euler(0,180,0));
        }        
    }

    private void RightSpawnPrefab()
    {
        rightSpawnpos = Random.Range(0, rightSpawnArray.Length);

        if (rightSpawnpos == 0)
        {
            Instantiate(prefab, new Vector3(rightSpawnArray[rightSpawnpos], transform.position.y, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(prefab, new Vector3(rightSpawnArray[rightSpawnpos], transform.position.y, 0), Quaternion.Euler(0, 180, 0));
        }        
    }
}
