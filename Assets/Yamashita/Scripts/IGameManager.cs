/// <summary>
/// Game manager
/// 
/// this class management 
/// Score : game score
/// Stage : Stage data
/// State : app state.
/// </summary>
public interface IGameManager {

    /// <summary>
    /// Return Score
    /// </summary>
    /// <returns>Score</returns>
    int GetScore ();

    /// <summary>
    /// Return stage data.
    /// </summary>
    /// <returns>Stage data.</returns>
    IStage GetStage ();

    /// <summary>
    /// Return app state.
    /// </summary>
    /// <returns>app state.</returns>
    State GetState ();
}

public enum State {
    INIT_ROOM_SCAN_PLEASE, INIT_ROOM_SCANNING, INIT_ROOM_SCAN_END,
    START_WAIT, START_TO_GAME,
    GAME_STAGE_INIT, GAME_MAIN, GAME_STAGE_CLOSE,
    GAME_OVER, GAME_CLEAR,
    GAME_RESULT, RESULT_TO_START
}
