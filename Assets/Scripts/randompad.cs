using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randompad : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float Randx;
    Vector2 WhereToSpawn;
    [SerializeField] 
    private float SpawnRate=1f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;
            Randx = Random.Range(7.69f, 16.8f);
            WhereToSpawn=new Vector2(Randx,transform.position.y);
            Instantiate(obj,WhereToSpawn,Quaternion.identity);
        }
    }
}