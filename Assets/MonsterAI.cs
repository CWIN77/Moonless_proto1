using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
  private Rigidbody2D rb;
  private GameObject playerObj = null;
  private bool overlapPlayer = false;

  // Start is called before the first frame update
  void Start()
  {
    if (playerObj == null)
      playerObj = GameObject.Find("Player");

    print(playerObj.transform.position.x);

    rb = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    // print(playerObj.transform.position.x);
    bool isPlayerLeft = rb.velocity.x - playerObj.transform.position.x > 0;
    // print(isPlayerLeft);
    // rb.velocity = new Vector2(inputX * m_speed, m_body2d.velocity.y);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("Player"))
    {
      overlapPlayer = true;
    }
  }

  //TODO:Make track user monster ai
}
