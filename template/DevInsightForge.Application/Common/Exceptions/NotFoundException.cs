﻿namespace DevInsightForge.Application.Common.Exceptions;

/// <summary>
/// Represents a custom exception for resource not found errors in the application.
/// </summary>
[Serializable]
public class NotFoundException : Exception
{
    public NotFoundException() : base("The requested resource was not found.") { }

    public NotFoundException(string message) : base(message) { }

    public NotFoundException(string message, Exception innerException)
        : base(message, innerException) { }
}
