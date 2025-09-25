using System.Collections;
using UnityEngine;

public class Farmhand : MonoBehaviour
{
   
    public float potatoes;
    private Click _click;
    
    //Farmhand Grower
    public bool farmhandGrowerHired;
    public int farmhandGrowerAmount = 0;
    public int farmhandGrowerEarn = 2;
    public float farmhandGrowerTimer = 5f;
    
    //Farmhand Peeler
    public bool farmhandPeelerHired;
    public int farmhandPeelerAmount = 0;
    public int farmhandPeelerEarn = 2;
    public float farmhandPeelerTimer = 5f;
    
    //Potato seller
    public bool potatoSellerHired;
    public int potatoSellerAmount = 0;
    public int potatoSellerEarn = 15;
    public float potatoSellerTimer = 10f;



    private void Start()
    {
        _click = GameObject.FindGameObjectWithTag("Click").GetComponent<Click>();
    }

    

    //Farmhand grower grows potatoes
    public IEnumerator FarmhandGrower()
    {
        while (farmhandGrowerHired)
        {
            yield return new WaitForSeconds(farmhandGrowerTimer);
            _click.potatoes += farmhandGrowerEarn * farmhandGrowerAmount;
        }
    }

    //Farmhand peeler peels potatoes
    public IEnumerator FarmhandPeeler()
    {
        while (farmhandPeelerHired && _click.potatoes > 0)
        {
            yield return new WaitForSeconds(farmhandPeelerTimer);
            _click.potatoes -= farmhandPeelerEarn * farmhandPeelerAmount;
            _click.peeledPotatoes += farmhandPeelerEarn * farmhandPeelerAmount;
        }
    }
    
    //Potato seller sells potatoes
    public IEnumerator PotatoSeller()
    {
        while (potatoSellerHired)
        {
            yield return new WaitForSeconds(potatoSellerTimer);
            _click.peeledPotatoes -= potatoSellerAmount;
            _click.potates += (potatoSellerEarn * potatoSellerAmount);
        }
    }
}
