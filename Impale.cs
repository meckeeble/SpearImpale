using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impale : MonoBehaviour
{
    public GameObject Human;
    public Rigidbody body;
    public Transform stickPoint;
    public Collider col;

    public GameObject [] parts;
    // Start is called before the first frame update
    void Start()
    {
    Human = GameObject.Find("Human");
    body = Human.transform.GetChild(0).GetChild(5).GetComponent<Rigidbody>();
    stickPoint = this.gameObject.transform.GetChild(1).transform;
    col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision){
        if (collision.gameObject == Human){
        Debug.Log("shaft collided with human");
        Physics.IgnoreCollision(col, collision.gameObject.GetComponent<Collider>());
        Human.GetComponent<RagDoll>().DoRagdoll(true);
        col.enabled=false;
        collision.gameObject.transform.parent = stickPoint;
        body.constraints = RigidbodyConstraints.FreezeAll;

        
                       }
    }
}
