﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlueMove : MonoBehaviour
{
    bool wasJustClicked = true;
    bool canMove;
    Vector2 playerSize;

    Rigidbody2D rb;

    public Transform BoundaryHolder;

    Boundary playerBoundary;

    struct Boundary
    {
        public float Up, Down, Left, Right;

        public Boundary(float up, float down, float left, float right)
        {
            Up = up; Down = down; Left = left; Right = right;
        }
    }

    // Use this for initialization
    void Start()
    {
        playerSize = GetComponent<SpriteRenderer>().bounds.extents;
        rb = GetComponent<Rigidbody2D>();

        playerBoundary = new Boundary(BoundaryHolder.GetChild(0).position.y,
                                      BoundaryHolder.GetChild(1).position.y,
                                      BoundaryHolder.GetChild(2).position.x,
                                      BoundaryHolder.GetChild(3).position.x);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (wasJustClicked)
            {
                wasJustClicked = false;

                if ((mousePos.x >= transform.position.x && mousePos.x < transform.position.x + playerSize.x ||
                mousePos.x <= transform.position.x && mousePos.x > transform.position.x - playerSize.x) &&
                (mousePos.y >= transform.position.y && mousePos.y < transform.position.y + playerSize.y ||
                mousePos.y <= transform.position.y && mousePos.y > transform.position.y - playerSize.y))
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }

            if (canMove)
            {
                Vector2 clampedMousePos = new Vector2(Mathf.Clamp(mousePos.x, playerBoundary.Left,
                                                                  playerBoundary.Right),
                                                      Mathf.Clamp(mousePos.y, playerBoundary.Down,
                                                                  playerBoundary.Up));
                rb.MovePosition(clampedMousePos);
            }
        }
        else
        {
            wasJustClicked = true;
        }
    }
}
/*  Rigidbody2D rb;
  Vector2 startingPosition;

  public Transform BoundaryHolder;

  Boundary playerBoundary;

  public Collider2D PlayerCollider { get; private set; }

  public PlayerControllerHockey Controller;

  public int? LockedFingerID { get; set; }

// Use this for initialization
void Start () {
      rb = GetComponent<Rigidbody2D>();
      startingPosition = rb.position;
      PlayerCollider = GetComponent<Collider2D>();

      playerBoundary = new Boundary(BoundaryHolder.GetChild(0).position.y,
                                    BoundaryHolder.GetChild(1).position.y,
                                    BoundaryHolder.GetChild(2).position.x,
                                    BoundaryHolder.GetChild(3).position.x);

  }

  private void OnEnable()
  {
      Controller.Players.Add(this);
  }
  private void OnDisable()
  {
      Controller.Players.Remove(this);
  }

  public void MoveToPosition(Vector2 position)
  {
      Vector2 clampedMousePos = new Vector2(Mathf.Clamp(position.x, playerBoundary.Left,
                                                playerBoundary.Right),
                                    Mathf.Clamp(position.y, playerBoundary.Down,
                                                playerBoundary.Up));
      rb.MovePosition(clampedMousePos);
  }

  public void ResetPosition()
  {
      rb.position = startingPosition;
  }
}*/