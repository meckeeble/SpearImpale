using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowSpear : MonoBehaviour
{
    private Transform originalPosition;
    private Rigidbody throwObj;
    public BoxCollider tipCollider;
    public BoxCollider shaft;
    public float force;
    public bool held = true;
    private Transform playerCam;
    // Start is called before the first frame update
    void Awake()
    {
        throwObj = GetComponent<Rigidbody>();
        shaft = GetComponent<BoxCollider>();
        tipCollider = transform.GetChild(0).GetComponent<BoxCollider>();
        
        playerCam = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&held){
            shaft.enabled = false;
            tipCollider.enabled = true;
            transform.parent = null;
            throwObj.GetComponent<Collider>().enabled=true;

            throwObj.isKinematic = false;
            throwObj.AddForce(playerCam.forward*force);
            held=false;
        }
    }

    
}
