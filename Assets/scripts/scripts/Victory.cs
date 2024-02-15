using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    public GameObject enemiesParent;
    public GameObject victoryCanvas;


    void Start()
    {

        victoryCanvas.SetActive(false);
    }

    void Update()
    {

        EnemyHealth[] enemies = enemiesParent.GetComponentsInChildren<EnemyHealth>(true);
        bool allEnemiesDead = true;

        foreach (EnemyHealth enemy in enemies)
        {
            if (!enemy.IsDead())
            {
                allEnemiesDead = false;
                break;
            }
        }

        if (allEnemiesDead)
        {

            victoryCanvas.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;



        }
    }
}