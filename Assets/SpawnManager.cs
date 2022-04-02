using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cubePrefab;
    public Vector2 spawnRangeX;
    public Rigidbody cube;
    
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnCube", 0, 3.2f);
       
    }



GameObject cubeClone;
    private void SpawnCube() {


        Vector3 spawnPosition = new Vector3 (
            Random.Range(spawnRangeX[0], spawnRangeX[1]),
            10,
            cubePrefab.transform.position.z
        );

        
        cubeClone = Instantiate(cubePrefab, spawnPosition, cubePrefab.transform.rotation);
       // cubeClone.transform.parent = plate.transform;

    }
    
  
    private void FixedUpdate(){
     cube.velocity = new Vector3(0,1,0);
    }
    

 

 

//   private void OnCollisionExit (Collision other){
//        if(other.gameObject.tag == "Cube"){
//         cubePrefab.transform.parent = null;
//        }
  
 


  }

