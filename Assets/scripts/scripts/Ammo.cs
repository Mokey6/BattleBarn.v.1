using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int ammoAmount = 10;

    public int GetCurrentAmmo()
    {
        return ammoAmount;
    }
    public void ReduceCurrentAmmo()
    {
        ammoAmount--;
    }
    public void AddAmmo(int amount)
    {
        ammoAmount += amount;
    }


}
