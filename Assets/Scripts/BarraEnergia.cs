using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraEnergia : MonoBehaviour
{

	public Slider slider2;

	public void SetMaxEnergy(int energy)
	{
		slider2.maxValue = energy;
		slider2.value = energy;
	}

	public void SetEnergy(int energy)
	{
		slider2.value = energy;
	}
    // Start is called before the first frame updat
}
