using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitchController : MonoBehaviour
{
    [SerializeField]
    private bool red_Color, white_Color;

    private void OnTriggerEnter(Collider target)
    {
        if(target.CompareTag(Tags.Player_Tag))
        {
            if(red_Color)
            {
                target.GetComponent<PlayerColorController>().Player_Color = Tags.Red_Color;
            }

            if (white_Color)
            {
                target.GetComponent<PlayerColorController>().Player_Color = Tags.White_Color;
            }
        }
    }
}
