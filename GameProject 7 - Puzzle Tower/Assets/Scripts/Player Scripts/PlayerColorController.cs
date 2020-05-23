using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorController : MonoBehaviour
{
    public string Player_Color = "";

    private void Start()
    {
        Player_Color = Tags.White_Color;
    }
}
