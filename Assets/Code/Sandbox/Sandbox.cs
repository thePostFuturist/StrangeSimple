using UnityEngine;
using System.Collections;

public class Sandbox : MonoBehaviour {

}

public class SandBoxGreeter : MonoBehaviour {
	
	public delegate void BoxGreetHandler (bool have_met);
	public static event BoxGreetHandler onGreeting; 

	void DispatchGreeting()
	{
		if (onGreeting !=null) 
			onGreeting(true);	
	}
}

public class SandBoxManager : MonoBehaviour {

	void OnEnable()
	{
		SandBoxGreeter.onGreeting += ( (bool have_met) => {
			// Light up
		});
	}
		
}