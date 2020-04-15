using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPanel : MonoBehaviour
{
    float dirX; 
    public float moveSpeed = 3f;
    public float maxHeihtPos;
    public float minHeightPos;
    bool moveUp= true;


    // Update is called once per frame
    void Update()
    {
      if(transform.position.y >maxHeihtPos){
         moveUp = false;
      }
      if(transform.position.y < minHeightPos){
         moveUp = true;
      }

      
      if(moveUp){
           transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed* Time.deltaTime);
      }else{
           transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed* Time.deltaTime);
      }
        
    }
}
