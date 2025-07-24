namespace Engineer.AI.Abstractions;

/// <summary>
/// Defines the interface for AI agents that handle implementation tasks
/// under the guidance of context engineers.
/// </summary>
public interface IAiAgent
{
    /// <summary>
    /// Gets the AI provider name (e.g., "OpenAI", "Anthropic", "Local")
    /// </summary>
    string ProviderName { get; }

    /// <summary>
    /// Gets the model name or identifier
    /// </summary>
    string ModelName { get; }

    /// <summary>
    /// Gets the capabilities supported by this AI agent
    /// </summary>
    AiCapabilities Capabilities { get; }

    /// <summary>
    /// Generates code based on high-level requirements and context.
    /// </summary>
    /// <param name="task">The development task to implement</param>
    /// <param name="context">Project context and constraints</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Generated code implementation</returns>
    Task<CodeGeneration> GenerateCodeAsync(
        DevelopmentTask task,
        ProjectContext context,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Refactors existing code while maintaining functionality.
    /// </summary>
    /// <param name="codeToRefactor">The code to be refactored</param>
    /// <param name="refactoringGoals">Specific refactoring objectives</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Refactored code with explanations</returns>
    Task<RefactoringResult> RefactorCodeAsync(
        string codeToRefactor,
        RefactoringGoals refactoringGoals,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates comprehensive documentation for code or systems.
    /// </summary>
    /// <param name="target">What to document (code, API, system, etc.)</param>
    /// <param name="documentationType">Type of documentation needed</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Generated documentation</returns>
    Task<Documentation> GenerateDocumentationAsync(
        DocumentationTarget target,
        DocumentationType documentationType,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Analyzes code for potential issues, improvements, and quality metrics.
    /// </summary>
    /// <param name="codeToAnalyze">The code to analyze</param>
    /// <param name="analysisType">Type of analysis to perform</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Code analysis results</returns>
    Task<CodeAnalysis> AnalyzeCodeAsync(
        string codeToAnalyze,
        AnalysisType analysisType,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Checks if this AI agent can handle a specific task.
    /// </summary>
    /// <param name="task">The task to evaluate</param>
    /// <returns>True if the agent can handle the task</returns>
    bool CanHandleTask(DevelopmentTask task);
}