using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]

public class era : MonoBehaviour    
    
{
    public GameObject Player;
    public void Start()
    {
        
    }
    // Update is called once per frame
    public void FixedUpdate()
    {
        Vector3 targetposition = Player.transform.position + new Vector3(0, 5, -10);
        transform.position = targetposition;

    }
}
