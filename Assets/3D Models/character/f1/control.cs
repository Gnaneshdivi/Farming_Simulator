using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    // Start is called before the first frame update
     private Animator myanimation;
    bool walk=false;
    private CharacterController controller;
    
    private float playerSpeed = 100.0f;
    private float playerRotationSpeed = 100.0f;
    public float sensitivity = 10f;
    bool plant=false;
    bool grow=false;
public GameObject plant1;
public GameObject plant2;
 

    
    // Start is called before the first frame update
    void Start()
    {
     myanimation=GetComponent<Animator>();  
     controller = gameObject.AddComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update(){
        walk=Input.GetKey(KeyCode.W);
       myanimation.SetBool("walk",walk); 
       if(Input.GetKey(KeyCode.I)){
           plant=Input.GetKey(KeyCode.I);
       myanimation.SetBool("dig",plant);
           plant1.SetActive(true);
           plant2.SetActive(false);

       }
       if(Input.GetKey(KeyCode.O)){
           grow=Input.GetKey(KeyCode.O);
       myanimation.SetBool("water",grow);
           myanimation.SetBool("water",Input.GetKey(KeyCode.O)); 
           plant2.SetActive(true);
plant1.SetActive(false);
       }
    
        
       float translation=Input.GetAxis("Vertical")*playerSpeed*Time.deltaTime;
       float rotation=Input.GetAxis("Horizontal")*playerRotationSpeed*Time.deltaTime;
        transform.Translate(0,0,translation);
        transform.Rotate(0,rotation,0);
        
    
        
    }
}
