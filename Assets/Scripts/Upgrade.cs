using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private float _timer;
    [SerializeField] private Click _click;

    [SerializeField] private InputSystem_Actions _input;
    private enum _upgradeType
    {
        Grow,
        Peel,
        Sell
    }
    [SerializeField] private _upgradeType _type;

    private void Awake()
    {
        _input = new InputSystem_Actions();
        _input.Enable();
    }

    private void Update()
    {
        if (_input.Player.Attack.WasPressedThisFrame())
        {
            Collider2D collider = Physics2D.OverlapCircle(_input.Player.Look.ReadValue<Vector2>(), 0.1f);
            if (collider == gameObject.GetComponent<Collider2D>())
            {
                _startUpgrade();
            }
        }
    }
    private void _startUpgrade()
    {
        StartCoroutine(_upgrade());
    }
    private IEnumerator _upgrade()
    {
        switch(_type)
        {
            case _upgradeType.Peel:
                _click.clickMultiplier += _click.clickMultiplier;
                yield return new WaitForSeconds(_timer);
                _click.clickMultiplier -= _click.clickMultiplier;
                break;
        }
    }
    
}
