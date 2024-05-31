namespace Cross.Plugin.File;

public static class TryResult
{
    /// <summary>
    /// Creates a new instance of the class.
    /// </summary>
    /// <param name="operationSucceeded">If set to <c>true</c> operation succeeded.</param>
    /// <param name="result">The result of the operation.</param>
    public static TryResult<TResult> Create<TResult>(bool operationSucceeded, TResult result)
    {
        return new TryResult<TResult>(operationSucceeded, result);
    }
}

/// <summary>
/// Result with a boolean indicating if the operation succeeded.
/// </summary>
/// <remarks>
/// Initializes a new instance of the class.
/// </remarks>
/// <param name="operationSucceeded">If set to <c>true</c> operation succeeded.</param>
/// <param name="result">The result of the operation.</param>
public class TryResult<TResult>(bool operationSucceeded, TResult result = default(TResult))
{
    /// <summary>
    /// Gets a value indicating whether the operation succeeded.
    /// </summary>
    /// <value><c>true</c> if operation succeeded; otherwise, <c>false</c>.</value>
    public bool OperationSucceeded { get; private set; } = operationSucceeded;

    /// <summary>
    /// Gets the result of the operation.
    /// </summary>
    /// <value>The result of the operation.</value>
    public TResult Result { get; private set; } = result;
}