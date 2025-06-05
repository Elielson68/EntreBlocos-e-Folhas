using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class TrunkController : MonoBehaviour
{
    public bool _allTrunksBreaked;
    public List<BoxCollider2D> Trunks;

    public UnityEvent OnAllTrunkDestroyed;

    void Update()
    {
        if (_allTrunksBreaked is false && Trunks.All(x => x.enabled is false))
        {
            _allTrunksBreaked = true;
            OnAllTrunkDestroyed?.Invoke();
        }
    }
}
