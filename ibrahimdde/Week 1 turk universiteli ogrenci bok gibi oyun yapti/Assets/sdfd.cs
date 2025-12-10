using UnityEngine;

public class sdfd : MonoBehaviour
{
    public canv logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent <canv>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
