using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody bullet;
    public float shootForce = 0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Rigidbody rb = Instantiate(bullet, transform.position, Quaternion.identity);
            rb.AddForce(Camera.main.transform.forward * shootForce, ForceMode.Impulse);
        }
    }
}
