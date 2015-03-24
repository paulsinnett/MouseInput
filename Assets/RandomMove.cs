using UnityEngine;
using System.Collections;

public class RandomMove : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        StartCoroutine(randomMove(Random.onUnitSphere));
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator randomMove(Vector3 move)
    {
        for (; ;)
        {
            for (float time = 0f; time < 1f; time += Time.deltaTime)
            {
                transform.Translate(move * Time.deltaTime);
                yield return null;
            }
            move = Random.onUnitSphere;
        }
    }
}
