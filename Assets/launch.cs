using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour
{
    public GameObject bottle;
    public float force;
    public float speed;
    public float rotationSpeed;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = bottle.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space)){
            Vector3 _force = new Vector3(0,force * Time.fixedDeltaTime * speed, 0);
            // rb.AddForce(_force * Time.fi);
            rb.AddForce(_force);
            Debug.Log("launch:" + _force);

        }
    }
}
