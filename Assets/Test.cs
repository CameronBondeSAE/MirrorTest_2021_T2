using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	[Range(1,10)]
	[Tooltip("CAM WOZ ERE")]
	[SerializeField]
	private int count;
	
	public int Count
	{
		get
		{
			return count;
		}
		set
		{
			count = value;
			if (count>10)
			{
				count = 10;
			}
		}
	}

	// Start is called before the first frame update
	void Start()
	{
		Count = 20;
	}

	// Update is called once per frame
	void Update()
	{
	}
	
	public int SetCount(int newValue)
	{
		

		return count;
	}

	public int GetCount(int newValue)
	{
		return count;
	}
	
	public void DoThing()
	{
	}
}