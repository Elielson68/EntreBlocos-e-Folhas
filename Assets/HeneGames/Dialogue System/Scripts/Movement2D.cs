﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeneGames.DialogueSystem
{
    public class Movement2D : MonoBehaviour
    {
        float horizontal;
        float vertical;
        Rigidbody2D rb2D;

        private void Start()
        {
            rb2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }

        private void FixedUpdate()
        {
            rb2D.velocity = new Vector2(horizontal * 10f, vertical * 10f);
        }
    }
}