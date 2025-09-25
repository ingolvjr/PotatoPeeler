using System.Collections;
using UnityEngine;

public class Farmhand : MonoBehaviour
{
   
    public float potatoes;
    private Click _click;
    
    //Farmhand Grower
    public bool farmhandGrowerHired;
    public int farmhandGrowerAmount = 0;
    public float farmhandGrowerTimer = 5f;
    
    //Farmhand Peeler
    public bool farmhandPeelerHired;
    public int farmhandPeelerAmount = 0;
    public float farmhandPeelerTimer = 5f;
    
    //Potato seller
    public bool potatoSellerHired;
    public int potatoSellerAmount = 0;
    public int potatoSellerEarn = 15;
    public float potatoSellerTimer = 10f;



    private void Start()
    {
        _click = GetComponent<Click>();
    }

    void Update()
    {
        StartCoroutine(FarmhandGrower());
        
        StartCoroutine(FarmhandPeeler());
        
        StartCoroutine(PotatoSeller());
        
    }

    //Farmhand grower grows potatoes
    private IEnumerator FarmhandGrower()
    {
        while (farmhandGrowerHired)
        {
            yield return new WaitForSeconds(farmhandGrowerTimer);
            _click.potatoes++;
        }
    }

    //Farmhand peeler peels potatoes
    private IEnumerator FarmhandPeeler()
    {
        while (farmhandPeelerHired)
        {
            yield return new WaitForSeconds(farmhandPeelerTimer);
            _click.peeledPotatoes += farmhandPeelerAmount;
        }
    }
    
    //Potato seller sells potatoes
    private IEnumerator PotatoSeller()
    {
        while (potatoSellerHired)
        {
            yield return new WaitForSeconds(potatoSellerTimer);
            _click.potates += (potatoSellerEarn * potatoSellerAmount);
        }
    }
}
