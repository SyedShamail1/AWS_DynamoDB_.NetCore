﻿using System.Text.Json.Serialization;

namespace Amazon_DynamoDB_Demo.Contracts;
public class Customer
{
    [JsonPropertyName("pk")]
    public string Pk => Id.ToString();

    [JsonPropertyName("sk")]
    public string SK => Id.ToString();

    public Guid Id { get; set; } = default!;

    public string GitHubUsername { get; init; } = default!;

    public string FullName { get; init; } = default!;

    public string Email { get; init; } = default!;

    public DateTime DateOfBirth { get; init; }

    public DateTime UpdatedAt { get; set; }
}
