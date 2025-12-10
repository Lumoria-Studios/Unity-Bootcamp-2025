using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Rigidbody2D rigBod;
    public float kanatguc;
    public canv logic;
    public bool oldumuhttp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<canv>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && oldumuhttp != true)
        {

            rigBod.linearVelocity = Vector2.up * kanatguc;
        }
    }
private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.bitti();
        oldumuhttp = true;
    }
}
