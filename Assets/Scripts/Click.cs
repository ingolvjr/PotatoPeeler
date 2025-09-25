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
    public int potatesMultiplier;

    //Peel
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
        StartCoroutine(_sellPeelPotatoes());
    }
    

    //Passive Potato growth
    private IEnumerator _growPotatoes()
    {
        while (true)
        {

            yield return new WaitForSeconds(1);
            potatoes += clickMultiplier;;
        } 
    }

    //Passive Potates income
    private IEnumerator _sellPeelPotatoes()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            if (peeledPotatoes > 0)
            {
                peeledPotatoes -= potatesMultiplier;
                potates += potatesMultiplier;
            }
                
        }
        
    }

    void Update()
    {
        potates = Mathf.Clamp(potates, 0, 100000000);
        potatoes = Mathf.Clamp(potatoes, 0, 10000000);
        peeledPotatoes = Mathf.Clamp(peeledPotatoes, 0, 10000000);
    }
}
