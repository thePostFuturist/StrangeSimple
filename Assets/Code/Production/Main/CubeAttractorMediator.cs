using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

namespace cubeattractor
{
	 public class CubeAttractorMediator : Mediator {

		[Inject]
		public ICubeAttractorView view {get;set;}

		[Inject]
		public CubeDistanceSignal cube_distance_signal {get;set;}


		public override void OnRegister ()
		{
			view.onAttractionMade += ( (bool state) => {
				cube_distance_signal.Dispatch(state);
			});


		}


		public override void OnRemove ()
		{

		}

	}
}

