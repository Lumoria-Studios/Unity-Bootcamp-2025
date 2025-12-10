using UnityEngine;

public class hizhiz : MonoBehaviour


{
    public float hizOran = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float olu = -11;
        if (transform.position.x < olu)
            Destroy(gameObject);
        transform.position = transform.position + (Vector3.left * hizOran) * Time.deltaTime;
    }
}
