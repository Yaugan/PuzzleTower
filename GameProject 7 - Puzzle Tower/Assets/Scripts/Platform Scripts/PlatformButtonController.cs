using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformButtonController : MonoBehaviour
{
    public MovingPlatform[] movingPlatforms;

    [SerializeField]
    private bool movedPlatformsToPoint;

    [SerializeField]
    private bool is_White_Button, is_Red_Button;

    private void OnTriggerEnter(Collider target)
    {
        if(target.CompareTag(Tags.Player_Tag))
        {
            if(is_White_Button)
            {
                if(!target.GetComponent<PlayerColorController>().Player_Color.Equals(Tags.White_Color))
                {
                    return;
                }
            }

            if(is_Red_Button)
            {
                if (!target.GetComponent<PlayerColorController>().Player_Color.Equals(Tags.Red_Color))
                {
                    return;
                }
            }

            if(!movedPlatformsToPoint)
            {
                movedPlatformsToPoint = true;

                for(int i = 0; i < movingPlatforms.Length; i++)
                {
                    movingPlatforms[i].ActivateMovement();
                }
            }
            else
            {
                movedPlatformsToPoint = false;

                for (int i = 0; i < movingPlatforms.Length; i++)
                {
                    movingPlatforms[i].ActivateMoveToInitial();
                }
            }
        }
    }
}
