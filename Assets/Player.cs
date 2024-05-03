using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class Rörelse : MonoBehaviour
{
    Rigidbody myRigidbody;
    [SerializeField] bool canDash;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        canDash = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.AddForce(new Vector3(20, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.AddForce(new Vector3(-20, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            myRigidbody.AddForce(new Vector3(0, 0, 20));
        }
        if (Input.GetKey(KeyCode.S))
        {
            myRigidbody.AddForce(new Vector3(0, 0, -20));
        }
        if (Input.GetKeyDown(KeyCode.Space) && canDash)
        {
            myRigidbody.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            StartCoroutine(CoolDown(3));
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            transform.position += new Vector3(0, 0, 50);
            StartCoroutine(CoolDown(1));
        }
      } 

    IEnumerator CoolDown(float coolDown)
    {
        canDash = false;
        yield return new WaitForSeconds(coolDown);
        canDash = true;
    }
    
    }


