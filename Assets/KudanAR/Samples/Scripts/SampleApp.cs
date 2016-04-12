using UnityEngine;
using System.Collections;

namespace Kudan.AR.Samples
{
	public class SampleApp : MonoBehaviour
	{
        public KudanTracker _kudanTracker;
        public TrackingMethodMarker _markerTracking;
        public TrackingMethodMarkerless _markerlessTracking;

        public void MarkerClicked()
        {
            _kudanTracker.ChangeTrackingMethod(_markerTracking);
        }

        public void MarkerlessClicked()
        {
            _kudanTracker.ChangeTrackingMethod(_markerlessTracking);
        }

        public void StartClicked()
        {
            // from the floor placer.
            Vector3 floorPosition;
            Quaternion floorOrientation;

            _kudanTracker.FloorPlaceGetPose(out floorPosition, out floorOrientation);
            _kudanTracker.ArbiTrackStart(floorPosition, floorOrientation);
        }
	}


}