using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    // Refference of the PlayerMovement script
    public PlayerMovement movement;

    // Need rigidbody and collider to be called
    private void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            FindObjectOfType<AudioManager>().Play("Collision");
            movement.enabled = false;
            Debug.Log("Collision with obstacles detected!");
            FindObjectOfType<GameManager>().endGame();
        }
    }

}
