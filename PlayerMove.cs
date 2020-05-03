using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticallInputName;
    [SerializeField] private float movementSpeed;


    private CharacterController charController;

    private void Awake(){
        charController = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }
    
    private void playerMovement()
    {
        float hInput = Input.GetAxis(horizontalInputName) * movementSpeed;
        float vInput = Input.GetAxis(verticallInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vInput;
        Vector3 sideMovement = transform.right * hInput;

        charController.SimpleMove(forwardMovement + sideMovement);
    }
}
