using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject prefab;
    public float maxHeigth;
    public float minHeigth;
    public float maxTime = .5f;

    private float _timer;

    private void Start()
    {
        InstatiateObject();
    }

    private void Update()
    {
        if(_timer > maxTime)
        {
            InstatiateObject();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void InstatiateObject()
    {
        var instance = Instantiate(prefab);
        var y = Random.Range(minHeigth, maxHeigth);

        instance.transform.position = transform.position + new Vector3(0, y);

        Destroy(instance, 10f);
    }
}
