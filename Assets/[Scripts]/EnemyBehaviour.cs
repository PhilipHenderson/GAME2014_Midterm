////////////////////////////////////////
//
// Created By: Philip Henderson
// Student Number: 101137744
//
// Date Last Modified: October 22nd/2022
//
//
// Source File: GAME2014-Midterm-101137744
// Program: Video Game Programming
//
// Revision History: Changed the Core framework:
//  - Player is placed on the left side of the screen
//  - Player looking and shooting to the right
//  - Enemies placed on the right side instead of the top
//  - Enemies movement change from right-left to up-down
//
////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Boundary vBoundary;
    public Boundary hBoundary;
    public Boundary screenBounds;
    public float vSpeed;
    public Color randomColor;
    
   
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        var verticalLength = vBoundary.max - vBoundary.min;
        transform.position = new Vector3(
            transform.position.x, 
            Mathf.PingPong(Time.time * vSpeed, verticalLength) - vBoundary.max,
            transform.position.z);
    }

}
