using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] int _targetCount;

    private void Update()
    {
        if (GameManager._instance.GetCollectionCount() >= _targetCount)
        {
            _animator.SetTrigger("DoorOpen");
        }
    }
}
