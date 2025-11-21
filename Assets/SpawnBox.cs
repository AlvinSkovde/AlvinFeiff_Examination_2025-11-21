using System;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject boxSpawnPos;

    public void SpawnBoxAbove()
    {
        Instantiate(boxPrefab, boxSpawnPos.transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SpawnBoxAbove();
    }
}
