using System.Text.Json.Serialization;
using Rinha.Dtos;

namespace Rinha.Configuration;

[JsonSerializable(typeof(FraudScoreRequest))]
[JsonSerializable(typeof(FraudScoreResponse))]
[JsonSerializable(typeof(List<string>))]
[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower,
    UseStringEnumConverter = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
)]
public partial class JsonContext : JsonSerializerContext { }
