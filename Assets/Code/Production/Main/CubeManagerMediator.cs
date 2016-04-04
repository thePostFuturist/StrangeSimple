using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

namespace cubeattractor
{
	 public class CubeManagerMediator : Mediator {

		[Inject]
		public ICubeManagerView view {get;set;}

		[Inject]
		public CubeDistanceSignal cube_distance_signal {get;set;}


		public override void OnRegister ()
		{
			cube_distance_signal.AddListener ((bool state) => {
				view.AcceptAttraction(state);
			});

		}


		public override void OnRemove ()
		{

		}

	}
}

