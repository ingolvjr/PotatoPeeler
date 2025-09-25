using System;
using System.Collections;
using UnityEngine;

public class Click : MonoBehaviour
{
    //Variables for the potatoes + currency
    public int potatoes;
    public int peeledPotatoes;
    public int potates;
    public int clickMultiplier;


    public void Peel()
    {
        if (potatoes > 0)
        {
            peeledPotatoes++;
            potatoes -= clickMultiplier;
        }
    }

    private void Start()
    {
        StartCoroutine(_growPotatoes());
    }

    private IEnumerator _growPotatoes()
    {
        while (true)
        {

            yield return new WaitForSeconds(1);
            potatoes += clickMultiplier;;
        }
    }
}
