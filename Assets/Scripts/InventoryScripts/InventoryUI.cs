using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI pickUpText;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdatePickUpText(PlayerInventory playerInventory)
    {
        pickUpText.text = playerInventory.NumberOfPickups.ToString();
    }
}

