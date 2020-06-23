﻿using UnityEngine;

public class Monster : MonoBehaviour
{   
    /// <summary>
    /// 怪物基底型別
    /// </summary>
    [Header("移動速度"),Range(0,100)]
    public float speed;
    [Header("傷害值"),Range(10,500)]
    public float damage;
    [Header("爆炸效果")]
    public GameObject explosion;

    /// <summary>
    /// 移動
    /// </summary>
    protected void Move()
    {
        //Time.deltaTime
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    /// <summary>
    /// 爆炸
    /// </summary>
    protected void Explosion()
    {
        GameObject exp = Instantiate(explosion, transform.position,Quaternion.identity);
        Destroy(gameObject);        //刪除怪物
        Destroy(exp, 2.5F);         //2.5秒後刪除爆炸效果
    }

    private void Awake()
    {
        Physics2D.IgnoreLayerCollision(8,8); //物理2D 忽略圖層碰撞(圖層1, 圖層2)
    }

    protected virtual void Update()
    {
        Move();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="房子")
        {
            collision.gameObject.GetComponent<House>().Damage(damage);
            Explosion();
        }
    }

}
