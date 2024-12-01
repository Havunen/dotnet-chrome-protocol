using System.Text.Json.Serialization;
using Json.Schema.Generation;

namespace ChromeProtocol.Tools.Schema.Models;

public record Type(
  [property: Required]
  string Id,
  string? Description,
  [property: JsonPropertyName("type")]
  TypeKind? Kind,
  bool? Optional,
  Property[]? Properties,
  string[]? Enum,
  bool? Experimental,
  bool? Deprecated
);
