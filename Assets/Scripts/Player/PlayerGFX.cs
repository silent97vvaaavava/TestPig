using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PlayerGFX : MonoBehaviour
{
    [SerializeField] private AIPath aiPath;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private SpriteRenderer spriteRenderer;

    void Update()
    {
        if (Mathf.Abs(aiPath.desiredVelocity.x) > Mathf.Abs(aiPath.desiredVelocity.y))
        {
            if (aiPath.desiredVelocity.x >= .001f)
            {
                spriteRenderer.sprite = sprites[0];
            }
            else if (aiPath.desiredVelocity.x <= -.001f)
            {
                spriteRenderer.sprite = sprites[1];
            }
        }
        else
        {
            if (aiPath.desiredVelocity.y <= -.001f)
            {
                spriteRenderer.sprite = sprites[2];
            }
            else if (aiPath.desiredVelocity.y >= .001f)
            {
                spriteRenderer.sprite = sprites[3];
            }
        }
    }
}
