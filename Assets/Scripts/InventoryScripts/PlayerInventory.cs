using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfPickups { get; private set; }

    public UnityEvent<PlayerInventory> OnPickUpCollected;

    public void PickUpCollected()
    {
        NumberOfPickups++;
        OnPickUpCollected.Invoke(this);
    }

    public void DecreasePickup()
    {
        if(NumberOfPickups > 0)
        {
            NumberOfPickups--;
            OnPickUpCollected.Invoke(this);
        }

    }


    
}
