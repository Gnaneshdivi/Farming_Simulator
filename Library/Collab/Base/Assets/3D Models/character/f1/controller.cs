using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
 private Animator myanimation;
    bool walk=false;
   float horizontal = Input.GetAxis("Horizontal");
 float vertical = Input.GetAxis("Vertical");
 float speed = 5.0f;

    private Vector3 moveDirection = Vector3.zero;
    
    
    // Start is called before the first frame update
    void Start()
    {
     myanimation=GetComponent<Animator>(); 
     characterController = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        walk=Input.GetKey(KeyCode.W);
        myanimation.SetBool("walk",walk);
         var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.position = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        
        
    }
}
