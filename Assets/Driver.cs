using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{




    //[SerializeField] adds parameters to the engine such that they can be controlled directly from the window
    [SerializeField]float steerspeed=0.8f;
    [SerializeField]float movespeed=0.2f;
    [SerializeField] float slowSpeed= 0.1f;
    [SerializeField] float boostSpeed= 0.4f;

   

   //boost car speed if player enters a boost zone
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost"){
        movespeed= boostSpeed;
       
        Debug.Log("HI");
        }

        else if(other.tag== "Slow"){

           

         
            movespeed=slowSpeed;
           
           
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        float steeramount=Input.GetAxis("Horizontal")*steerspeed*Time.deltaTime;
        float moveamount=Input.GetAxis("Vertical")*movespeed*Time.deltaTime;
        //rotate object
        transform.Rotate(0,0, -steeramount);
        //move around
        transform.Translate(0,moveamount,0);

         

        
    }

   

    void notes(){

       //Input.GetAxis means player control
     //Time.deltaTime makes the game frame rate independent, so it runs at the same speed on a fast or slow system
        //by multiplying the duration of a frame with the fps to standardize it
      //rigidbodies and colliders are used to simulate physics for objects. rigid bodies applies physics and 
      //colliders allow it to detetct and simulate collisions between objects

      //good coding practice is to seperate different mechanics into different scripts, making sure that a single script doesn't become
      //clunky or an accident can't wipe out everything. plus it's good for organization.






    }
}
