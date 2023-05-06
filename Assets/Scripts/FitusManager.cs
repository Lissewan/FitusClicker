using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitusManager : MonoBehaviour
{
    public GameObject[] fitusPrefabs;
    public Fitus curFitus;
    public Transform canvas;
    public static FitusManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void CreateFitus()
    {
        GameObject fitusToSpawn = fitusPrefabs[Random.Range(0, fitusPrefabs.Length)];
        GameObject obj = Instantiate(fitusToSpawn, canvas);

        curFitus = obj.GetComponent<Fitus>();
    }
    public void SpawnFitus(GameObject Fitus)
    {
        Destroy(Fitus);
        CreateFitus();
    }
}
