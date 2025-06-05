using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MobController : MonoBehaviour
{
    public List<Transform> PositionsToMove;
    public int PositionToMove;
    private int _lastPosition;
    void Start()
    {
        MoveMob();
    }

    private void MoveMob()
    {
        _lastPosition = PositionToMove;

        while (PositionToMove == _lastPosition)
        {
            PositionToMove = Random.Range(0, PositionsToMove.Count);
        }

        float velocity = Random.Range(0.3f, 3);

        Ease curveMove = Random.Range(0, 2) == 1 ? Ease.OutExpo : Ease.Linear;

        transform.DOMoveX(PositionsToMove[PositionToMove].position.x, velocity).SetEase(curveMove).OnComplete(MoveMob);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Colidiu com o player!");
            //Destroy(collision.collider.gameObject);
        }
    }
}
