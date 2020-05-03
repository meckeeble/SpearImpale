using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HitCheck : MonoBehaviour
{
    public GameObject Human;
    public GameObject stickPoint;
    public Collider [] parts;
    public Transform shaft;
    private Collider tip;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        tip = GetComponent<BoxCollider>();
        Debug.Log("starting");
        shaft = transform.parent;
        rb = GetComponentInParent<Rigidbody>();
        Human = GameObject.Find("Human");
        parts = GetComponentsInChildren<Collider>(true);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        
        if(collision.GetComponent<Rigidbody>()!=null) {
            //ToDo
            //merge meshes?
            //muck around with child objects to fin approriate ragdoll
            Debug.Log("Tip collided with Human");
            Physics.IgnoreCollision(tip,collision);
            shaft.GetComponent<Collider>().enabled=true;
            }

        else {
            Debug.Log(collision.gameObject);
            rb.constraints = RigidbodyConstraints.FreezeAll;

        }
    
 
    }
}
