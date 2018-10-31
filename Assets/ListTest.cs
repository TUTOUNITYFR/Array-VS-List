using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
	public int numberOfGO = 1000000;

    bool isFinished;

    void Start ()
	{
        Debug.Log("Start : " + System.DateTime.Now);
    }

	void Update ()
	{
		if (isFinished == false)
		{
			Test();
		}
	}

	void Test()
	{
		List<GameObject> list = new List<GameObject>();

		for (int i = 0; i < numberOfGO; i++)
		{
			list.Add(Instantiate(new GameObject(), Vector3.zero, Quaternion.identity));
		}

        if(list.Count == numberOfGO)
        {
            Debug.Log("End : " + System.DateTime.Now);
            isFinished = true;
        }
	}
}
