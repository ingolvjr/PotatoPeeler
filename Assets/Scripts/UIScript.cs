using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _potatoText;

    private int potatoes
    {
        get { return transform.parent.GetComponent<Click>().potatoes; }
    }
    
    [SerializeField] private TMP_Text _PotateText;
    private int potates
    {
        get { return transform.parent.GetComponent<Click>().potates; }
    }

    [SerializeField] private TMP_Text _peelText;
    private int _peeledPotatoes
    {
        get { return transform.parent.GetComponent<Click>().peeledPotatoes; }
    }


    private void Update()
    {
        _potatoText.text = ":" + potatoes.ToString();
        _PotateText.text = ":" + potates.ToString();
        _peelText.text = ":" + _peeledPotatoes.ToString();
    }
}
