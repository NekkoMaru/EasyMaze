using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToFind : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            MazeGenerator.Instance.DisappearMaze();
        }
    }
}
