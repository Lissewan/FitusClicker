using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fitus : MonoBehaviour
{
    public int curHP;
    public int maxHP;
    public int moneyToGive;
    public Image healthBarFill;

    public void Damage()
    {
        curHP--;
        healthBarFill.fillAmount = (float)curHP / (float)maxHP;

        if(curHP <= 0)
        {
            Dead();
        }
    }

    public void Dead()
    {
        //Add money
        GameManager.instance.AddMoney(moneyToGive);
        FitusManager.instance.SpawnFitus(gameObject);

        //Kill Fitus
    }
}
