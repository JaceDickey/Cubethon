using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            GetComponent<PlayerMovement>().enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
