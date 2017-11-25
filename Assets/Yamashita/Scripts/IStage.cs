/// <summary>
/// Stage data 
/// </summary>
public interface IStage {

    /// <summary>
    /// Return stage level.
    /// </summary>
    /// <returns>Stage level</returns>
    int GetLevel ();

    /// <summary>
    /// Return game over time from app start.
    /// </summary>
    /// <returns></returns>
    float GetTimeLimit ();

    /// <summary>
    /// Return Stage Start time
    /// </summary>
    /// <returns>Stage Start time</returns>
    float GetStartTime ();
}
