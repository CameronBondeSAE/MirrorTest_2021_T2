using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLight : NetworkBehaviour
{
	public Light light;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		// View AND Model. BAD PROGRAMMER
		// light.color = new Color(Random.value, Random.value, Random.value);

		if (Random.value<0.2f)
		{
			if (isServer)
			{
				RpcSetColourOfLight(Random.value, Random.value, Random.value);
			}
		}
	}

	// View
	[ClientRpc]
	void RpcSetColourOfLight(float r, float g, float b)
	{
		light.color = new Color(r, g, b);
	}

}
