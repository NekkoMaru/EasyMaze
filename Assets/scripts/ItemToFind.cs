using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
    public Transform destination;
    public GameObject playerGameObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            MazeGenerator.Instance.DisappearMaze();

            // Only need for teleport
            playerGameObject.SetActive(false);

            // Teleport position
            player.position = destination.position;

            // Only need for teleport
            playerGameObject.SetActive(true);
        }
    }
}
