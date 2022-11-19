using System.Collections;
using UnityEngine;
using System.Threading.Tasks;

public class CameraEffects : MonoBehaviour
{
  private static float magnitude;

  public enum Magnitude
  {
    Soft,
    Hard,
    Extreme,
  }

  private static void SetMagnitude(Magnitude magnitude)
  {
    switch (magnitude)
    {
      case Magnitude.Soft:
        CameraEffects.magnitude = .1f;
        break;

      case Magnitude.Hard:
        CameraEffects.magnitude = 2f;
        break;

      case Magnitude.Extreme:
        CameraEffects.magnitude = 10f;
        break;

      default:
        break;
    }
  }

  private static Vector3 RandomCameraPosition()
  {
    int randomX = Random.Range(-2, 2);
    int randomY = Random.Range(-2, 2);
    return new Vector3(randomX, randomY, -10);
  }

  public static async void ShakeCamera(Camera camera, float duration, Magnitude magnitude, Vector3 initialCameraPos)
  {
    Quaternion cameraRotation = camera.transform.rotation;

    // set magnitude 
    SetMagnitude(magnitude);
    float endTime = Time.time + duration;

    while (Time.time < endTime)
    {
      Vector3 randomCameraPos = RandomCameraPosition();

      // lerp camera
      Vector3 newCameraPos = Vector3.Lerp(camera.transform.position, randomCameraPos, CameraEffects.magnitude);

      // set new camera pos
      camera.transform.SetPositionAndRotation(newCameraPos, cameraRotation);
      await Task.Yield();
    }

    // reset camera to its original position
    camera.transform.SetPositionAndRotation(initialCameraPos, cameraRotation);
  }

}
