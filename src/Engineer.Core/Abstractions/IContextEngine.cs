namespace Engineer.Core.Abstractions;

/// <summary>
/// Defines the core interface for context engineering capabilities.
/// Context engineers work at a high level, focusing on requirements and architecture
/// rather than implementation details.
/// </summary>
public interface IContextEngine
{
    /// <summary>
    /// Analyzes business requirements and generates system architecture recommendations.
    /// </summary>
    /// <param name="requirements">The business requirements to analyze</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Architecture recommendations and design decisions</returns>
    Task<ArchitectureRecommendation> AnalyzeRequirementsAsync(
        BusinessRequirements requirements, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Reviews and validates AI-generated implementations against context and requirements.
    /// </summary>
    /// <param name="implementation">The AI-generated implementation to review</param>
    /// <param name="context">The original context and requirements</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Review results with approval status and feedback</returns>
    Task<ImplementationReview> ReviewImplementationAsync(
        AiImplementation implementation,
        ProjectContext context,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Guides the overall development direction and makes strategic decisions.
    /// </summary>
    /// <param name="projectState">Current state of the project</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Strategic guidance and next steps</returns>
    Task<StrategicGuidance> ProvideGuidanceAsync(
        ProjectState projectState,
        CancellationToken cancellationToken = default);
}