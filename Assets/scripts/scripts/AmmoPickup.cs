using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoBonus = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Ammo playerAmmo = other.GetComponent<Ammo>();

            if (playerAmmo != null)
            {
                playerAmmo.AddAmmo(ammoBonus);
                Destroy(gameObject); // Уничтожаем объект ящика после подбора боеприпасов
            }
            else
            {
                Debug.LogError("Компонент Ammo не найден на игроке!");
            }
        }
    }
}
