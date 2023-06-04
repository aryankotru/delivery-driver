using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    bool packagepicked=false;
    bool packagedelivered=false;
    int score=0;
     [SerializeField] float destroyobjectDelay=0.5f;
     //color 32 is a 32 bit colour, new Color32 takes the RGB value of the colour as input, 4th input is alpha value i.e. transparency
     //1,1,1,1 is white i.e. no tint applied to the sprite
     [SerializeField] Color32 packagePickedColour= new Color32(1,1,1,1);
     [SerializeField] Color32 nopackagepickedColour= new Color32(1,1,1,1);

    //variable for sprites, to change colour etc.
    SpriteRenderer spriteRenderer;


    private void Start()
    {
        //getComponent is a function that allows us to connect variables to components/properties
        spriteRenderer= GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
     //Debug.Log("Collision has occurred.");
      

    }

    //we collide with any object other
    
    private void OnTriggerEnter2D(Collider2D other)
    {

       if(other.tag == "Package" && !packagepicked)// same as packagepicked==false)
       {
           Destroy(other.gameObject, destroyobjectDelay);
           Debug.Log("Package picked.");
           packagepicked=true;
           packagedelivered=false;
           spriteRenderer.color = packagePickedColour;

           //isTrigger has to be selected on the object for this to work and object has to be tagged
       }

       
         if(other.tag == "Customer" && packagepicked)//this is same as packagepicked==true)
       {

           Debug.Log("Package delivered.");

           packagepicked= false;
           packagedelivered=true;
           
           if(packagedelivered= true){

                score++;
                Debug.Log(score);
                Destroy(other.gameObject, destroyobjectDelay);
                spriteRenderer.color= nopackagepickedColour;

           }
           
           //Debug.Log(packagedelivered);
           
           //isTrigger has to be selected on the object for this to work and object has to be tagged
       }
    }

    
    private void notes(){

        //tags allow us to easily check in our code if something belongs to a particular category of thing
        //unity has default tags like player, respawn etc., we can also add our own
        //you can givr the player visual feedback when they achieve the goal of picking uo a package, like changing the colour of the car
        //capitializing letters in variable names adds a space to the name when displayed in unity
        //
        

    
}
}



