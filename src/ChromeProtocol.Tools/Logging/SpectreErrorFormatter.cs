using System.Text;
using ChromeProtocol.Tools.CodeGeneration.Pipeline;
using Json.Schema;

namespace ChromeProtocol.Tools.Logging;

public class SpectreErrorFormatter : IErrorFormatter
{
  public string Format(string fileName, EvaluationResults error)
  {
    var position = $" -> {error.InstanceLocation.ToString()}";
    var builder = new StringBuilder();
    builder.Append("[underline orange3]");
    {
      builder.Append(EscapeMarkup(Path.GetFileName(fileName)));
      builder.Append(EscapeMarkup(position));
    }
    builder.Append("[/]");
    builder.Append("[bold orange3]");
    {
      builder.Append(": ");
      builder.Append(string.Join("", error.Errors?.Select(kvp => EscapeMarkup(kvp.Key) + " " + EscapeMarkup(kvp.Value)) ?? []));
    }
    builder.Append("[/]");
    return builder.ToString();
  }

  public string Format(CodeGenerationError error)
  {
    var builder = new StringBuilder();
    builder.Append("[underline orange3]");
    {
      builder.Append(EscapeMarkup(Path.GetFileName(error.FileName)));
    }
    builder.Append("[/]");
    builder.Append("[bold orange3]");
    {
      builder.Append(": ");
      builder.Append(EscapeMarkup(error.Message));
    }
    builder.Append("[/]");
    return builder.ToString();
  }

  /// <summary>
  /// Spectre.Console recognizes `[` and `]` as BBCode tags, so we should escape them properly.
  /// </summary>
  /// <returns></returns>
  private static string EscapeMarkup(string input) =>
    input.Replace("[", "[[").Replace("]", "]]");
}
