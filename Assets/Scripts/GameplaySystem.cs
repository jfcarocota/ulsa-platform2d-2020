namespace Platform2DUtils.GameplaySystem
{
    using UnityEngine;

    public class GameplaySystem
    {
        ///<summary>
        /// Returns a Vector2 with Horizontal and Vertical axes.
        ///</summary>
        public static Vector2 Axis
        {
            get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}