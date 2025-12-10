using System.IO.Pipes;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;

public class BoruSpawn : MonoBehaviour
{
    public GameObject boru;
    public float spawnRate=10;
    private float timer=0;
    public float heightOffset=6 ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer=0;
        }
        
    }
    void spawnPipe()
    {

        float lowestPoint= transform.position.y-heightOffset;
        float highestPoint=transform.position.y+heightOffset;


        Instantiate(boru, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);}

}
