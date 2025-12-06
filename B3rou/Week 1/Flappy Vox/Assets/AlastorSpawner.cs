using Unity.VisualScripting;
using UnityEngine;

public class AlastorSpawner : MonoBehaviour
{
    public GameObject alastor;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnAlastor();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
            return;
        }
        else
        {
            SpawnAlastor();
            timer = 0;
            return;
        }
    }
    void SpawnAlastor()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        

        Instantiate(alastor, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }
}
