using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    public float turnspeed = 100f;
    public float horizontalInput;
    public float fowardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward.

        fowardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime * speed * fowardInput);

        //Move the vehicule right/left.

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);

        

    }
}
