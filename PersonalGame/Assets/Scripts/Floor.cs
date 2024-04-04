using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private Transform player;
    private float lastPlayerPosition;
    private float textureUnitSizeX;

    private void Start()
    {
        //only need the x position since it's a 2d scroller
        lastPlayerPosition = player.position.x;
    }

    private void LateUpdate()
    {
        if(Mathf.Abs(lastPlayerPosition - transform.position.x) >= (transform.localScale.x % 5))
        {
            transform.position = new Vector3(player.position.x, 0, 0);
        }
    }
}


// NEED TO LOOKUP HOW TO MAKE SPRITES IN UNITY