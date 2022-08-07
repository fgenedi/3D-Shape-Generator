using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateGrid : MonoBehaviour
{
	public GameObject[] prefabs; // This is our prefab object that will be exposed in the inspector

	void Update()
	{
		if (GameUI.save)
        {
			GameUI.save = false;
			Populate();
		}
			
	}
	void Populate()
	{
		GameObject prefab = prefabs[GameManager.instance.ShapeIndex];
		prefab.GetComponent<RawImage>().color = GameUI.curColor;
		Instantiate(prefab, transform);
		//newObj.GetComponent<Image>().color = GameUI.curColor;
		
	}
}