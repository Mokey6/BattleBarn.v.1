using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickups : MonoBehaviour
{
    [SerializeField] int ammoBonus = 20;

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
