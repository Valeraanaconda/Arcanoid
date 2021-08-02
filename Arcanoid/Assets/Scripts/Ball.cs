using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] Text score;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(2f, 4f), Random.Range(2f, 4f));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("panel"))
        {
            int num = Convert.ToInt32(score.text.Substring(7, 1));
            num++;
            score.text = "Score: " + num;
            Destroy(other.gameObject);
        }
    }
}
