using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public GameObject crystalPrefab;

	public int numberOfCrystals = 20;
	public float levelWidth = 1.94f;
	public float minY = 3f;
	public float maxY = 10f;

	// Use this for initialization
	void Start () {

		Vector3 spawnPosition = new Vector3();

		for (int i = 0; i < numberOfCrystals; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(crystalPrefab, spawnPosition, Quaternion.identity);
		}
	}
}
