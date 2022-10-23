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

public class BackgroundStarsBehaviour : MonoBehaviour
{
    public float horizontalSpeed;
    public Boundary boundary;
    

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    public void Move()
    {
        transform.position -= new Vector3(horizontalSpeed * Time.deltaTime, 0.0f);
    }

    public void CheckBounds()
    {
        if (transform.position.x < boundary.min)
        {
            ResetStars();
        }
    }

    public void ResetStars()
    {
        transform.position = new Vector2(boundary.max, 0.0f);
    }
}
