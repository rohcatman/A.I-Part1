using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateMoveControl : MonoBehaviour

{
   private float speed = 10;
   public GameObject cube;
   
    void Start(){
      
      
    }

  
    void Update()
    {
  
        float horizontalInput = Input.GetAxis("Horizontal");
    	float verticalInput = Input.GetAxis("Vertical");

    	Vector3 movement = new Vector3(horizontalInput, 0,verticalInput);
    	movement = movement.normalized * speed * Time.deltaTime;

    	this.transform.position += movement;

     
    }

    private void OnCollisionStay(Collision other){        
   if(other.gameObject.tag == "Cube"){
       Debug.Log("cube is on the plate");
            cube.transform.position = Vector3.MoveTowards(transform.position, this.transform.position, 4f * Time.fixedDeltaTime);


   }
}

    
 
    
    }



    