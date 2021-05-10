using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    private int _collectionCount = 0;

    private void Awake()
    {
        _instance = this;
    }

    public void AddItem()
    {
        _collectionCount++;
    }

    public int GetCollectionCount() => _collectionCount;
}
