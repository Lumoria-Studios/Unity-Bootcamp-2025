    using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour

{
    public LogicScript Logic;
    public BIRDSCRIPT Kus;
   
    void Start()
    {
        Logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

   
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision){

        if (collision.gameObject.layer == 3)
        {
            Logic.addScore(1);
            
        }
        
    }

}
