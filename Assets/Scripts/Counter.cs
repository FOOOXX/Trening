using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private readonly float _delay = 0.5f;
    private int _value = 0;

    private Coroutine _coroutine;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && _coroutine == null) 
            _coroutine = StartCoroutine(CountDown());
        else if(Input.GetMouseButtonDown(0))
            StopCountDown();
    }

    private void StopCountDown()
    {
        if(_coroutine != null)
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    private IEnumerator CountDown()
    {
        WaitForSeconds wait = new(_delay);

        while (enabled)
        {
            yield return wait;

            _value++;
            Display();
        }
    }

    private void Display() => _text.text = _value.ToString();
}
