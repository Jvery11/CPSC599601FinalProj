using System;
using UnityEngine;
using UnityEngine.InputSystem;

// Attach to both hand models 

// This code is from the youtube tutorial cited in the README
public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty triggerValue;
    public InputActionProperty gripValue;

    public Animator handAnimator;

    void Start()
    {
        
    }

    void Update()
    {
        float trigger = triggerValue.action.ReadValue<float>();
        float grip = gripValue.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger", trigger);
        handAnimator.SetFloat("Grip", grip);
    }


}
