using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoClickerManager : MonoBehaviour
{
    public List<float> autoClicker = new List<float>();
    public int autoClickerPrice;
    public TextMeshProUGUI quantityText;
    void Update()
    {
        for (int i = 0; i < autoClicker.Count; i++)
        {
            if(Time.time - autoClicker[i] >= 1.0f)
            {
                autoClicker[i] = Time.time;
            }
        }
    }
}
