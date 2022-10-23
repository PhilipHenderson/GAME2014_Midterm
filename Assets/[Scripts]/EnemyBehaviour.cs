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
