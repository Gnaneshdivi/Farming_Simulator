using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform  target;
    public Vector3 camoffset;
public float sensitivity = 10f;
    void Start()
    {
        camoffset=transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newposition=target.transform.position+camoffset;
        transform.position=newposition;
        var c = Camera.main.transform;
    }
}
