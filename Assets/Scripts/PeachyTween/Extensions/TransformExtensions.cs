using UnityEngine;

namespace PeachyTween {
  public static class TransformExtensions {
    public static Tween TweenRotation(this Transform transform, Quaternion endValue, float duration) =>
      Peachy.Tween(transform.rotation, endValue, v => transform.rotation = v, duration);

    public static Tween TweenRotation(this Transform transform, Vector3 endValue, float duration) =>
      Peachy.Tween(transform.eulerAngles, endValue, v => transform.eulerAngles = v, duration);

    public static Tween TweenLocalRotation(this Transform transform, Quaternion endValue, float duration) =>
      Peachy.Tween(transform.localRotation, endValue, v => transform.localRotation = v, duration);

    public static Tween TweenLocalRotation(this Transform transform, Vector3 endValue, float duration) =>
      Peachy.Tween(transform.localEulerAngles, endValue, v => transform.localEulerAngles = v, duration);

    public static Tween TweenPosition(this Transform transform, Vector3 endValue, float duration) =>
      Peachy.Tween(transform.position, endValue, v => transform.position = v, duration);

    public static Tween TweenPositionX(this Transform transform, float endValue, float duration) =>
      Peachy.Tween(
        transform.position.x,
        endValue,
        v => transform.position = transform.position.WithX(v),
        duration
      );

    public static Tween TweenPositionY(this Transform transform, float endValue, float duration) =>
      Peachy.Tween(
        transform.position.y,
        endValue,
        v => transform.position = transform.position.WithY(v),
        duration
      );

    public static Tween TweenPositionZ(this Transform transform, float endValue, float duration) =>
      Peachy.Tween(
        transform.position.z,
        endValue,
        v => transform.position = transform.position.WithZ(v),
        duration
      );


    public static Tween TweenLocalPosition(this Transform transform, Vector3 endValue, float duration) =>
      Peachy.Tween(transform.localPosition, endValue, v => transform.localPosition = v, duration);
  }
}