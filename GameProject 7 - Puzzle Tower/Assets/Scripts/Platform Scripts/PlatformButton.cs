using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    private RotatingPlatform rotatingPlatform;

    private void Awake()
    {
        rotatingPlatform = GetComponentInParent<RotatingPlatform>();
    }

    private void OnTriggerEnter(Collider target)
    {
        if(target.CompareTag(Tags.Player_Tag))
        {
            rotatingPlatform.ActivateRotation();
        }
    }
}
