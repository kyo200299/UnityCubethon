using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Refference to Rigidbody component rb
    public Rigidbody rb;

    // Movement Force
    public float forwardForce = 8500f;

    // PC = 500f
    public float sidewayForce = 800f;

	// Update is called once per frame
    // FixedUpdate when using physics
	void FixedUpdate () {

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Player Control for PC
        /***********************************************
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        ***********************************************/

        // Player Control for Mobile - Acceloerometer
        /***********************************************
        Vector3 tilt = Quaternion.Euler(-90f, 0f, 0f) * Input.acceleration;
        if (tilt.x > 0)
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (tilt.x < 0)
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        ***********************************************/

        // Player Control for Mobile - Touch
        if (Input.GetTouch(0).position.x > Screen.width / 2)
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetTouch(0).position.x < Screen.width / 2)
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        // Check if player falls out of track
        if (rb.position.y < -2f) {
            FindObjectOfType<GameManager>().endGame();
        }

        /* (For Debug Only)
        Debug.Log("Acceleration: (" + tilt.x + ", " + tilt.y + ", " + tilt.z + ")");
        Debug.DrawRay(rb.position + Vector3.forward, tilt, Color.red);
        */
    }
}
