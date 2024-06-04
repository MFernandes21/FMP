using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : MonoBehaviour
{
    public void Start()
    {
        AudioManager.instance.PlaySFX("Fireplace");
    }
}
