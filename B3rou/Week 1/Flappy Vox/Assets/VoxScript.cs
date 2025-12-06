using Unity.VisualScripting;
using UnityEngine;

public class VoxScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public LogicScript logic;
    public float flapStrength;
    public bool isVoxAlive = true;
    public float dieHeight = 30;
    public AudioSource flapSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isVoxAlive)
        {
            rb.linearVelocity = Vector2.up * flapStrength;
            flapSound.Play();
        }
        if (transform.position.y > dieHeight || transform.position.y < -dieHeight)
        {
            logic.gameOver();
            isVoxAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isVoxAlive = false;
    }
}
