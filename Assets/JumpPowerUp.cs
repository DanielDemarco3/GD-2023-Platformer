using Platformer.Mechanics;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    public float increase = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameObject player = collision.gameObject;
            PlayerController playerScript = player.GetComponent<PlayerController>();

            if(playerScript)
            { 
                playerScript.jumpTakeOffSpeed += increase;
                Destroy(gameObject);
            }
        }
    }
}