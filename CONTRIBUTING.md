# Contributing to Engineer IDE

We welcome contributions to Engineer IDE! This document provides guidelines for contributing to the project.

## Code of Conduct

By participating in this project, you agree to abide by our Code of Conduct. We are committed to providing a welcoming and inspiring community for all.

## How to Contribute

### Reporting Bugs

1. **Search existing issues** to avoid duplicates
2. **Use the bug report template** when creating new issues
3. **Provide detailed information** including:
   - Steps to reproduce
   - Expected vs actual behavior
   - Environment details (OS, .NET version, etc.)
   - Screenshots or logs if applicable

### Suggesting Features

1. **Search existing feature requests** to avoid duplicates
2. **Use the feature request template**
3. **Provide clear use cases** and explain how the feature would benefit context engineers
4. **Consider the AI-human collaboration paradigm** when proposing features

### Development Setup

#### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio 2022 (recommended) or JetBrains Rider
- Git

#### Getting Started

1. **Fork the repository** on GitHub
2. **Clone your fork** locally:
   ```bash
   git clone https://github.com/yourusername/engineer.git
   cd engineer
   ```
3. **Install dependencies**:
   ```bash
   dotnet restore
   ```
4. **Build the solution**:
   ```bash
   dotnet build
   ```
5. **Run tests**:
   ```bash
   dotnet test
   ```

### Making Changes

#### Branch Strategy
- Create a new branch for each feature or bug fix
- Use descriptive branch names: `feature/ai-provider-integration`, `fix/context-memory-leak`
- Keep branches focused on a single change

#### Coding Standards

- **Follow C# coding conventions** and use consistent formatting
- **Write clear, self-documenting code** with meaningful variable and method names
- **Add XML documentation** for public APIs
- **Include unit tests** for new functionality
- **Update documentation** when adding features

#### Commit Guidelines

- **Write clear commit messages** that explain the "why" not just the "what"
- **Use conventional commit format**:
  ```
  type(scope): description
  
  Longer explanation if needed
  
  Fixes #issue-number
  ```
- **Types**: `feat`, `fix`, `docs`, `style`, `refactor`, `test`, `chore`
- **Scope**: `core`, `ai`, `ui`, `docs`, etc.

### Pull Request Process

1. **Ensure your code builds** and all tests pass
2. **Update documentation** if you've added new features
3. **Create a pull request** with:
   - Clear title and description
   - Reference to related issues
   - Screenshots for UI changes
   - Testing instructions

4. **Address review feedback** promptly and thoughtfully
5. **Keep your branch up to date** with the main branch

### Architecture Guidelines

#### Context Engineering Principles

When contributing, keep these principles in mind:

- **Separation of Concerns**: Context engineers should focus on strategy, AI agents on implementation
- **Provider Agnostic**: Don't tie implementations to specific AI providers
- **Human Oversight**: Always maintain human control and review capabilities
- **Context Preservation**: Ensure project context is maintained and evolves appropriately

#### AI Integration Guidelines

- **Abstract AI Providers**: Use interfaces to abstract different AI services
- **Handle Failures Gracefully**: AI services can be unreliable; plan for failures
- **Respect Rate Limits**: Implement proper rate limiting and backoff strategies
- **Protect Sensitive Data**: Never send sensitive information to external AI providers without explicit consent

#### UI/UX Guidelines

- **Cross-Platform Consistency**: Ensure features work well on all supported platforms
- **Progressive Enhancement**: UI should remain functional even when AI services are unavailable
- **Accessibility**: Follow accessibility guidelines for inclusive design
- **Performance**: Keep the interface responsive during AI processing

### Testing Guidelines

#### Unit Tests
- **Write tests for all public APIs**
- **Use meaningful test names** that describe the scenario being tested
- **Follow AAA pattern**: Arrange, Act, Assert
- **Mock external dependencies** including AI providers

#### Integration Tests
- **Test AI provider integrations** with real services (when appropriate)
- **Test cross-platform scenarios** on multiple platforms
- **Validate workflow orchestration** end-to-end

### Documentation

#### Code Documentation
- **XML documentation** for all public APIs
- **Inline comments** for complex business logic
- **README files** for each major component

#### User Documentation
- **Update user guides** when adding features
- **Provide examples** and use cases
- **Include screenshots** for UI features

### Community

#### Getting Help
- **GitHub Discussions** for questions and ideas
- **GitHub Issues** for bugs and feature requests
- **Pull Request reviews** for code feedback

#### Mentorship
- **New contributors welcome** - don't hesitate to ask questions
- **Pair programming** available for complex features
- **Code reviews** are learning opportunities for everyone

## Recognition

Contributors will be recognized in:
- **Contributors list** in the repository
- **Release notes** for significant contributions
- **Documentation** where appropriate

## License

By contributing to Engineer IDE, you agree that your contributions will be licensed under the MIT License.

Thank you for contributing to Engineer IDE and helping to build the future of context-driven development!