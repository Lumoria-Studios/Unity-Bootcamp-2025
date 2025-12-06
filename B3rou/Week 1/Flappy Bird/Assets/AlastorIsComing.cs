using UnityEngine;

public class AlastorIsComing : MonoBehaviour
{
    public float speed = 5;
    public float destroyXPosition = -70;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}
