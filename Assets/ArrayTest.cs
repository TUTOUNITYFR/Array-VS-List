using UnityEngine;

public class ArrayTest : MonoBehaviour
{
	public int numberOfGO = 1000;

    bool isFinished = false;

	void Start ()
	{
        Debug.Log("Start : "+System.DateTime.Now);
	}

	void Update ()
	{
		if (isFinished == false)
		{
			Test();
		}   
	}

	void Test ()
	{
		GameObject[] testArray = new GameObject[numberOfGO];

		for (int i = 0; i < numberOfGO; i++)
		{
			testArray[i] = Instantiate(new GameObject(), Vector3.zero, Quaternion.identity);
		}

        if(testArray.Length == numberOfGO)
        {
            Debug.Log("End : " + System.DateTime.Now);
            isFinished = true;
        }
	}
}
