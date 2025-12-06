using Unity.VisualScripting;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public AudioSource pointSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        pointSound = GameObject.FindGameObjectWithTag("Score").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            pointSound.Play();
            return;
        }
    }
}
