using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;



public class ControlIKAnimation : MonoBehaviour
{

    public Rig RigWeight;
    public Slider SliderWeitgh;


  void Update()
    {
        RigWeight.weight = SliderWeitgh.value;
    }
}
