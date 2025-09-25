using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class Hire : MonoBehaviour
{
    //Pricing variables
    public int farmhandGrowerPrice = 10;
    public int farmhandPeelerPrice = 10;
    public int potatoSellerPrice = 10;
    
    
    //Texts
    public TMP_Text growerPriceText;
    public TMP_Text growerAmountText;
    public TMP_Text peelerPriceText;
    public TMP_Text peelerAmountText;
    public TMP_Text sellerPriceText;
    public TMP_Text sellerAmountText;

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
            
            growerPriceText.text = "Price: " +  farmhandGrowerPrice;
            growerAmountText.text = "Amount: " +  _farmhand.farmhandGrowerAmount;
            
            _farmhand.farmhandGrowerHired = true;
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
            
            peelerPriceText.text = "Price " + farmhandPeelerPrice;
            peelerAmountText.text = "Amount " + _farmhand.farmhandPeelerAmount;
            
            _farmhand.farmhandPeelerHired = true;
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
            
            sellerPriceText.text = "Price " + potatoSellerPrice;
            sellerAmountText.text = "Amount " + _farmhand.potatoSellerAmount;
            
            _farmhand.potatoSellerHired = true;
        }
    }

    private void Update()
    {
        growerPriceText.text = "Price: " +  farmhandGrowerPrice;
        growerAmountText.text = "Amount: " +  _farmhand.farmhandGrowerAmount;
        
        peelerPriceText.text = "Price " + farmhandPeelerPrice;
        peelerAmountText.text = "Amount " + _farmhand.farmhandPeelerAmount;
        
        sellerPriceText.text = "Price " + potatoSellerPrice;
        sellerAmountText.text = "Amount " + _farmhand.potatoSellerAmount;
    }
}
