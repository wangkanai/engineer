# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

Engineer IDE is a revolutionary cross-platform IDE designed for **context engineers** - professionals who focus on high-level strategic thinking, requirements, and architecture while AI agents handle implementation details. This represents a paradigm shift from traditional line-by-line coding to context-driven development.

## Core Architecture

The project follows a layered architecture built on .NET 8.0 with MAUI Blazor Hybrid for cross-platform support:

- **Engineer.Core**: Core business logic, abstractions, and context engine interfaces
- **Engineer.AI**: AI agent interfaces and multi-provider AI integration layer  
- **Engineer.UI**: MAUI Blazor Hybrid cross-platform UI (Windows, macOS, iOS, Android)
- **Engineer.Platforms**: Platform-specific implementations (planned)
- **Engineer.Plugins**: Extensible plugin system (planned)

## Technology Stack

- **.NET 8.0** with C# latest features and nullable reference types enabled
- **MAUI Blazor Hybrid** for cross-platform native applications
- **Microsoft Extensions** for dependency injection, logging, configuration
- **Multi-AI Provider Support**: OpenAI, Anthropic, local models (Ollama)
- **Provider-agnostic architecture** to avoid vendor lock-in

## Common Development Commands

### Build and Run
```bash
# Restore dependencies
dotnet restore

# Build entire solution
dotnet build

# Run the main application
cd src/Engineer.UI
dotnet run

# Build for specific platforms
dotnet build -f net8.0-windows10.0.19041.0
dotnet build -f net8.0-android
```

### Testing
```bash
# Run all unit tests
dotnet test

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"
```

### Development Setup
```bash
# Clone and setup
git clone https://github.com/wangkanai/engineer.git
cd engineer
dotnet restore
dotnet build
```

## Key Architectural Patterns

### Context Engineering vs Traditional Development

The project implements a fundamental shift in development paradigm:

- **Context Engineers** define requirements, architecture, and strategic direction
- **AI Agents** handle code generation, implementation, and repetitive tasks  
- **Human Oversight** maintains control through review and approval cycles
- **Provider Abstraction** supports multiple AI services through unified interfaces

### Core Interfaces

**IContextEngine** (`Engineer.Core/Abstractions/IContextEngine.cs`):
- Analyzes business requirements and generates architecture recommendations
- Reviews and validates AI-generated implementations  
- Provides strategic guidance and project direction

**IAiAgent** (`Engineer.AI/Abstractions/IAiAgent.cs`):
- Generates code from high-level requirements and context
- Refactors existing code while maintaining functionality
- Creates documentation and performs code analysis
- Supports capability-based task routing

### Service Registration Pattern

The project uses extension methods for clean service registration:

```csharp
// In Program.cs
builder.Services.AddEngineerCore();    // Core context engine services
builder.Services.AddEngineerAI();      // AI provider services
```

## Development Workflow

### Context-AI Collaboration Loop
1. **Define Context**: Specify requirements and architectural constraints
2. **AI Implementation**: AI agents generate code based on specifications  
3. **Review & Guide**: Human review with feedback and refinement
4. **Iterate**: Continuous improvement cycle until desired outcome

### Quality Gates and Validation
- All public APIs require XML documentation
- Unit tests required for new functionality
- Cross-platform compatibility validation
- AI provider abstraction compliance

## Project Structure Conventions

```
engineer/
├── src/                    # Source code projects
│   ├── Engineer.Core/      # Core abstractions and business logic
│   ├── Engineer.AI/        # AI integration layer
│   ├── Engineer.UI/        # MAUI Blazor hybrid UI
│   ├── Engineer.Platforms/ # Platform-specific code (planned)
│   └── Engineer.Plugins/   # Plugin system (planned)
├── docs/                   # Architecture and development documentation
├── tests/                  # Unit and integration tests (planned)
├── samples/                # Example projects and workflows (planned)
└── tools/                  # Development and build tools (planned)
```

## Important Configuration

### Project Properties
- **Target Framework**: `net8.0` for core libraries
- **Multi-target**: `net8.0-android;net8.0-ios;net8.0-maccatalyst;net8.0-windows10.0.19041.0` for UI
- **Language Features**: `ImplicitUsings` and `Nullable` enabled
- **Documentation**: `GenerateDocumentationFile` required

### Cross-Platform Considerations
- MAUI Blazor Hybrid provides single codebase for all platforms
- Platform-specific optimizations through conditional compilation
- Native performance with web technology familiarity
- Touch-optimized interfaces for mobile platforms

## Security and AI Integration

### AI Provider Security
- Secure API key management and rotation
- Request isolation and comprehensive logging
- Content filtering to prevent sensitive data leakage
- Support for local AI models for privacy-sensitive projects

### Local AI Capabilities
- Model isolation in sandboxed environments  
- Complete on-device processing for sensitive projects
- Audit trail for all AI interactions and decisions

## Contributing Guidelines

### Code Standards
- Follow C# coding conventions with consistent formatting
- Write self-documenting code with meaningful names
- Include XML documentation for all public APIs
- Provider-agnostic implementations required
- Maintain human oversight and control capabilities

### Architecture Principles
- **Separation of Concerns**: Context engineers focus on strategy, AI on implementation
- **Provider Agnostic**: Abstract AI services through interfaces
- **Human Control**: Maintain human review and approval cycles
- **Context Preservation**: Ensure project context evolution and continuity

### AI Integration Requirements
- Handle AI service failures gracefully with fallback strategies
- Implement proper rate limiting and backoff mechanisms
- Never send sensitive information to external providers without consent
- Support multiple AI providers simultaneously

## Performance Considerations

- **Caching Layer**: Intelligent caching of AI responses for common patterns
- **Parallel Processing**: Multiple AI agents working simultaneously  
- **Progressive Enhancement**: UI remains responsive during AI processing
- **Resource Management**: Optimized for running alongside development tools
- **Background Processing**: Long-running AI tasks execute asynchronously

The project represents the future of software development where human creativity and strategic thinking combine with AI capability to achieve unprecedented productivity and innovation through context-driven development.