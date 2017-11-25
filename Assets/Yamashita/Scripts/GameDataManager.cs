/// <summary>
/// Game data manager as singleton.
/// </summary>
public class GameDataManager: IGameManager {

    /// <summary>
    /// Handle instance.
    /// </summary>
    private static IGameManager mInstance = null;

    /// <summary>
    /// Seal for singleton
    /// </summary>
    private GameDataManager () { }

    /// <summary>
    /// Return singleton instance.
    /// </summary>
    /// <returns></returns>
    public static IGameManager Instance () {
        if (mInstance == null) {
            var ins = new GameDataManager().Init();
            mInstance = ins;
        }
        return mInstance;
    }

    public int GetScore () {
        throw new System.NotImplementedException();
    }

    public IStage GetStage () {
        throw new System.NotImplementedException();
    }

    public State GetState () {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// Initialize in created time.
    /// </summary>
    /// <returns>Initialized instance.</returns>
    private IGameManager Init () {

        if (mInstance != null) { return this; }

        return this;
    }
}