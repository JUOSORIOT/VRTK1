using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeControl : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem; 

    private bool _grab;
    private bool _buttonPress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_grab && _buttonPress)
        {
            _particleSystem.Play();
        }
        else
        {
            _particleSystem.Stop();
        }
    }

    public void OnGrab()
    {
        _grab = true;
    }
    public void Put()
    {
        _grab = false;
    }
    public void ButtonPress()
    {
        _buttonPress = true;
    }
    public void ButtonUp()
    {
        _buttonPress = false;
    }
}
