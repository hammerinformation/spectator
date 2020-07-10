using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spectator : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float cameraSensitivity=2;

//https://github.com/hammerinformation


    private void Start()
    {
        movementSpeed = 30;
        Cursor.visible = false;
    }

    private void Update()
    {
        Cursor.visible = false;

        
        Camera.main.fieldOfView -= Input.mouseScrollDelta.y;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed =60f;
            
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed =30f;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            movementSpeed = 15f;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            movementSpeed =30f;
        }

        Movement();
       

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x - Input.GetAxis("Mouse Y")*cameraSensitivity,
        transform.localEulerAngles.y+ Input.GetAxis("Mouse X")*cameraSensitivity,0);
    }

    #region Movement
    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (transform.forward * -movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (transform.right * movementSpeed * Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (transform.right * -movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = transform.position + (transform.up *-movementSpeed * Time.deltaTime);
        }
       if (Input.GetKey(KeyCode.E))
        {
            transform.position = transform.position + (transform.up * movementSpeed * Time.deltaTime);
        }
    }


    #endregion

    
}
