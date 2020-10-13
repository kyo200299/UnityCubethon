using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    //public float smoothSpeed = 0.125f;

    // Update is called once per frame, LateUpdate is called right after Update
    void Update () {
        /*
        // For smoothed camera following
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        // Transfrom starts with lower case "t" is itself
        transform.position = smoothedPosition;
        transform.LookAt(player);
        */
        transform.position = player.position + offset;
    }
}
