namespace Platform2DUtils.GameplaySystem
{
    using UnityEngine;

    public class GameplaySystem
    {
        public static Vector2 Axis
        {
            get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}