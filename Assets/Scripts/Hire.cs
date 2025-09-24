using UnityEngine;
using UnityEngine.Rendering;

public class Hire : MonoBehaviour
{
    //Pricing variables
    public int farmhandGrowerPrice;
    public int farmhandPeelerPrice;
    public int potatoSellerPrice;

    //Getting scripts
    private Click _click;
    private Farmhand _farmhand;


    private void Start()
    {
        _click = GetComponent<Click>();
        _farmhand = GetComponent<Farmhand>();
    }
    
    
    //Hires a grower if enough potates on click
    public void HireGrower()
    {
        if (_click.potates >= farmhandGrowerPrice)
        {
            _click.potates -= farmhandGrowerPrice;
            _farmhand.farmhandGrowerAmount++;
            farmhandGrowerPrice += (farmhandGrowerPrice * 10) / 100;
        }
    }
    
    //Hires a peeler if enough potates on click
    public void HirePeeler()
    {
        if (_click.potates >= farmhandPeelerPrice)
        {
            _click.potates -= farmhandPeelerPrice;
            _farmhand.farmhandPeelerAmount++;
            farmhandPeelerPrice += (farmhandPeelerPrice * 10) / 100;
        }
    }

    //Hires a seller if enough potates on click
    public void HireSeller()
    {
        if (_click.potates >= potatoSellerPrice)
        {
            _click.potates -= potatoSellerPrice;
            _farmhand.potatoSellerAmount++;
            potatoSellerPrice += (potatoSellerPrice * 10) / 100;
        }
    }
}
