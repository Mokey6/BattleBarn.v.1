using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    public GameObject enemiesParent;
    public UnityEngine.UI.Text enemyCountText;

    void Update()
    {

        int activeEnemies = CountActiveEnemies();


        UpdateEnemyCountText(activeEnemies);
    }

    int CountActiveEnemies()
    {

        int count = 0;
        foreach (Transform enemyTransform in enemiesParent.transform)
        {

            if (enemyTransform.gameObject.activeSelf && !enemyTransform.GetComponent<EnemyHealth>().IsDead())
            {
                count++;
            }
        }
        return count;
    }

    void UpdateEnemyCountText(int count)
    {

        enemyCountText.text = "" + count;
    }
}
