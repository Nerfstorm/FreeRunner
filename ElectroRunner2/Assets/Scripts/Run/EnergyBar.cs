using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{

    public Slider slider;
    float energyy;

    private void Update()
    {
        energyy = RunCharacterMovement.energy;
        slider.value = energyy;
    }

}
