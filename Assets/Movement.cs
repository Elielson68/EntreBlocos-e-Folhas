using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HeneGames.DialogueSystem
{
    public class Movement : MonoBehaviour
    {
        public float velocity = 2f;
        public bool StartMoveEnable;
        public bool MoveEnable { get; set; } = true;
        float horizontal;
        float vertical;
        Rigidbody2D rb2D;
        Animator _animator;

        private void Start()
        {
            MoveEnable = StartMoveEnable;
            rb2D = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");


        }

        private void FixedUpdate()
        {
            if (MoveEnable is false)
            {
                return;
            }

            rb2D.velocity = new Vector2(horizontal * velocity, vertical * velocity);
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (Input.GetKeyDown(KeyCode.F) && collision.tag == "Tronco")
            {
                _animator.SetTrigger("atack");
                collision.enabled = false;
                collision.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}