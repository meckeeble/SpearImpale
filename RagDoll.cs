using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDoll : MonoBehaviour {

    public Collider MainCollider;
    public Collider[] AllColliders;
    public Rigidbody rb;
    


	// Use this for initialization
	void Awake ()
    {
        rb = GetComponent<Rigidbody>();
        MainCollider = GetComponent<Collider>();
        AllColliders = GetComponentsInChildren<Collider>(true);
        

        DoRagdoll(false);
    }

    public void DoRagdoll(bool isRagdoll)
    {
        foreach (var col in AllColliders){
            col.enabled = isRagdoll;
        }
        
        rb.isKinematic=isRagdoll;
        MainCollider.enabled = !isRagdoll;
        GetComponent<Animator>().enabled = !isRagdoll;
        /*
        if (!isRagdoll){
        
        }
        
        else if(isRagdoll){
            Destroy(GetComponent<CharacterJoint>());
            
        }
        */
    }
}