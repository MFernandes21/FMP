using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int numberOfPickups;

    private void Start()
    {
        numberOfPickups = 0;
    }

    public UnityEvent<PlayerInventory> OnPickUpCollected;

    public void PickUpCollected()
    {
        numberOfPickups++;
        OnPickUpCollected.Invoke(this);
    }

    public void DecreasePickup()
    {
        if(numberOfPickups > 0)
        {
            numberOfPickups--;
            OnPickUpCollected.Invoke(this);
        }

    }

    public int GetNumberOfPickups()
    {
        return numberOfPickups;
    }


    
}
