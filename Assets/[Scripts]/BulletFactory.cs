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

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    // Bullet Prefab
    private GameObject bulletPrefab;

    // Sprite Textures
    private Sprite playerBulletSprite;
    private Sprite enemyBulletSprite;

    // Bullet Parent
    private Transform bulletParent;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        playerBulletSprite = Resources.Load<Sprite>("Sprites/Bullet");
        enemyBulletSprite = Resources.Load<Sprite>("Sprites/EnemySmallBullet");
        bulletPrefab = Resources.Load<GameObject>("Prefabs/Bullet");
        bulletParent = GameObject.Find("Bullets").transform;
    }

    public GameObject CreateBullet(BulletType type)
    {
        GameObject bullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity, bulletParent);
        bullet.GetComponent<BulletBehaviour>().bulletType = type;

        switch (type)
        {
            case BulletType.PLAYER:
                bullet.GetComponent<SpriteRenderer>().sprite = playerBulletSprite;
                bullet.GetComponent<BulletBehaviour>().SetDirection(BulletDirection.RIGHT);
                bullet.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, -90.0f);
                bullet.name = "PlayerBullet";
                break;
            case BulletType.ENEMY:
                bullet.GetComponent<SpriteRenderer>().sprite = enemyBulletSprite;
                bullet.GetComponent<BulletBehaviour>().SetDirection(BulletDirection.LEFT);
                bullet.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 270.0f);
                bullet.name = "EnemyBullet";
                break;
        }

        bullet.SetActive(false);
        return bullet;
    }

}
