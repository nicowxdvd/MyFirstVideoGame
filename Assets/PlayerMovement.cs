 using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    
    // This is a reference to the Rigibody component called "rb"
    public Rigidbody rb;

    public float forwardForce  = 1000f;
    public float sidewaysForce = 600f;
    
    // Start is called before the first frame update
    void Start(){
        Debug.Log("Hola, mundo!");
        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500);
    }



    // We marked this as "Fixed" Update because we
    // are using it to mess with physics
    void FixedUpdate(){
        // Add a forwardForce
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        if ( Input.GetKey("d") ) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0 ,0);

        }

        if ( Input.GetKey("a") ) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0 ,0);
        }
    }


}
