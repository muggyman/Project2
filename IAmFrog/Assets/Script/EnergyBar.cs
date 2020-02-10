using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Image ImgEnergyBar;

    public int Max;
    public int Min;

    private int currentValue;

    private float currentPercentage;

    public void SetEnergy(int energy)
    {
        if(energy != currentValue)
        {
            if(Max - Min == 0)
            {
                currentValue = 0;
                currentPercentage = 0;
            }
            else
            {
                currentValue = energy;
                currentPercentage = (float)currentValue / (float)(Max - Min);
            }
        }
        ImgEnergyBar.fillAmount = currentPercentage;
    }

    public void AddEnergy(int addEnergy)
    {
        SetEnergy((currentValue + addEnergy));
    }

    private void Start()
    {
        currentValue = 2000;
    }

    void Update()
    {
        SetEnergy(currentValue - 1);

        if(currentValue == 0)
        {
            FindObjectOfType<GameManager>().ShowLoseScreen2();
        }
    }


}
