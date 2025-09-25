using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private List<Sprite> _sprites;

    private Sprite CurrentSprite
    {
        get {return GetComponent<Image>().sprite;}
        set {GetComponent<Image>().sprite = value;}
    }
    [SerializeField] private Click _clickScript;

    public void Click()
    {
        StartCoroutine(_click());
    }
    
    private IEnumerator _click()
    {
        if (_clickScript.potates == 0) yield break;
        if (CurrentSprite == _sprites[0]) CurrentSprite = _sprites[1];
        yield return new WaitForSeconds(0.5f);
        if (CurrentSprite == _sprites[1]) CurrentSprite = _sprites[0];
    }
}
