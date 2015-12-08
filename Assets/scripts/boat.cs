using UnityEngine;
using System.Collections;

public class boat : MonoBehaviour {

    public float turnSpeed = 1000f;
    public float accelerateSpeed = 1000f;

    private Renderer rend;

    private Rigidbody rbody;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //Turn right or left.
        rbody.AddTorque(0f, h * turnSpeed * Time.deltaTime, 0);

        //Move Forward
        rbody.AddForce(transform.forward * accelerateSpeed * Time.deltaTime);

	}

    
    void OnCollisionEnter(Collision col)
    {
        //Not valid yet because we need to change collision
        //Hits a rock 
        if (col.collider.name == "Group003")
        {
            //rend.material.color = Color.yellow;
        }
        else if (col.collider.name == "Rock2")
        {
            //rend.material.color = Color.red;
        }
    }
    
}
