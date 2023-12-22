using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Item : MonoBehaviour
{

    
private void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        Inventory inventory = other.GetComponent<Inventory>();
        if (inventory != null)
        {
            Debug.Log("Adding item to inventory");
            inventory.AddItem(gameObject);
                gameObject.SetActive(false); // Hide the item
            }
        }

        
    }
}

