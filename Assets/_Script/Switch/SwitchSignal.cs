using NaughtyAttributes;
using UnityEngine;

public class SwitchSignal : MonoBehaviour
{
    private bool _redswitch;
    private bool _yellowswitch;
    private bool _greenswitch;
    private int _signalswitch=0;
    [Foldout("신호등 오브젝트")]
    [SerializeField] GameObject red;

    [Foldout("신호등 오브젝트")]
    [SerializeField] GameObject yellow;

    [Foldout("신호등 오브젝트")]
    [SerializeField] GameObject green;

    [Button]
    void Red()
    {
        red.SetActive(_redswitch=!_redswitch);
    }
    [Button]
    void Yellow()
    {
        yellow.SetActive(_yellowswitch=!_yellowswitch);
    }
    [Button]
    void Green()
    {
        green.SetActive(_greenswitch=!_greenswitch);
    }

    [Button]
    void Signal()
    {
        if(_signalswitch%3==0)
        {
            _redswitch=true;
            _yellowswitch=false;
            _greenswitch=false;
        }
        else if(_signalswitch%3==1)
        {
            _redswitch=false;
            _yellowswitch=true;
            _greenswitch=false;
        }
        else
        {
            _redswitch=false;
            _yellowswitch=false;
            _greenswitch=true;
        }
        red.SetActive(_redswitch);
        yellow.SetActive(_yellowswitch);
        green.SetActive(_greenswitch);
        _signalswitch++;
    }

    [Button]
    void Signal2()
    {
        if(_redswitch)
        {
            red.SetActive(_redswitch= !_redswitch);
            yellow.SetActive(_yellowswitch=!_yellowswitch);
        }
        else if(_yellowswitch)
        {
            yellow.SetActive(_yellowswitch= !_yellowswitch);
            green.SetActive(_greenswitch=!_greenswitch);
        }
        else
        {
            green.SetActive(_greenswitch= !_greenswitch);
            red.SetActive(_redswitch=!_redswitch);
        }
    }

    [Button]
    void Signal3()
    {
        
    }
}
