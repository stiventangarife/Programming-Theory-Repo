using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemysManager : MonoBehaviour
{
    public TMP_Text numberEnemys;
    public TMP_Text lastEnemy;
    public TMP_Text completeListEnemys;
    public List<Enemys> enemysList;

    private void Start()
    {
        enemysList = new List<Enemys>();

        lastEnemy.text = "-";
        numberEnemys.text = "0";
        completeListEnemys.text = "";
    }

    // ABSTRACTION
    public void AddVampire()
    {
        string enemyId = Random.Range(0, 100).ToString("000");

        int secondSkill = Random.Range(10, 15);

        Vampire newVampire = new Vampire(enemyId, secondSkill);

        AddEnemy(newVampire);
    }

    // ABSTRACTION
    public void AddGhost()
    {
        string enemyId = Random.Range(0, 100).ToString("000");

        int secondSkill = Random.Range(15, 20);

        Ghost newGhost = new Ghost(enemyId, secondSkill);

        AddEnemy(newGhost);
    }

    // POLYMORPHISM
    public void AddEnemy(Enemys enemy)
    {
        enemysList.Add(enemy);

        numberEnemys.text = enemysList.Count.ToString();
        lastEnemy.text = enemy.ToString();
    }

    public void ListAllEnemys()
    {
        string list = "";

        foreach(Enemys enemy in enemysList)
        {
            list += enemy.ToString() + System.Environment.NewLine;
        }
        completeListEnemys.text = list;
    }
}
