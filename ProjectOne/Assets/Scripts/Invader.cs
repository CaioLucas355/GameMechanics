using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    public Sprite[] animationSprites;
    public float animationTime = 1.0f;

    private SpriteRenderer spriteRederer;
    private int animationFrame;

    private void Awake()
    {
        spriteRederer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), this.animationTime, this.animationTime);
    }

    private void AnimateSprite()
    {
        animationFrame++;
        if (animationFrame >= this.animationSprites.Length) 
        {
            animationFrame = 0;
        }
        spriteRederer.sprite = this.animationSprites[animationFrame];
    
    }

}
