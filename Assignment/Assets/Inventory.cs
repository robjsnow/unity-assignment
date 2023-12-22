using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private GameObject[] inventory = new GameObject[3];
    public Image[] inventorySlots = new Image[3]; // Array for the inventory slot UI imagespublic void AddItem(GameObject item)
public void AddItem(GameObject item)
{
    for (int i = 0; i < inventory.Length; i++)
    {
        Debug.Log("Checking inventory slot: " + i);

        // Check if the inventorySlots array is properly initialized
        if (inventorySlots == null || inventorySlots.Length <= i)
        {
            Debug.LogError("InventorySlots array is not properly initialized or too small.");
            return;
        }

        if (inventory[i] == null)
        {
            inventory[i] = item;
            Debug.Log("Adding item to inventory slot: " + i);

            // Check if the specific inventory slot is assigned
            if (inventorySlots[i] != null)
            {
                Sprite itemSprite = item.GetComponent<SpriteRenderer>().sprite;
                inventorySlots[i].sprite = itemSprite;
                inventorySlots[i].enabled = true;
            }
            else
            {
                Debug.LogError("Inventory slot " + i + " is not assigned a UI element.");
            }
            break;
        }
    }
}

}
