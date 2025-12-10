using UnityEngine;

public class ssp : MonoBehaviour
{
    public GameObject boruru;
    public float spRate = 2;
    private float timer = 0;
    public float yuksek = 1;
    public float olu = -11;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spRate)
            timer = timer + Time.deltaTime;
        else
        {
            spPipe();
            timer = 0;
        }
        if (transform.position.x < olu)
            Destroy(boruru);

    }
    void spPipe()
    {
        float lowP = -1;
        float highP = 2;
        Instantiate(boruru, new Vector3(transform.position.x, Random.Range(lowP, highP), 0), transform.rotation);
    }
}
