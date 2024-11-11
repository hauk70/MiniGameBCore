using System;
using System.Threading.Tasks;
using UnityEngine;

public class MyCoolBoot : MonoBehaviour, IBootstrap
{
    [SerializeField] private GameObject _p1;
    [SerializeField] private GameObject _p2;

    private GameObject[] obj = new GameObject[2];

    void Update()
    {
        for (int i = 0; i < obj.Length; i++)
            if (obj[i] != null)
                obj[i].transform.Rotate(30 * Time.deltaTime, 0, 0);
    }

    public async Task Load()
    {
        obj[0] = Instantiate(_p1, transform);
        obj[1] = Instantiate(_p2, transform);
        obj[1].transform.position = new Vector3(0, 2, 0);
    }

    public async Task Unload()
    {
        for (int i = 0; i < obj.Length; i++)
            Destroy(obj[i]);
    }
}