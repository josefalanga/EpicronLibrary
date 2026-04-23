using Yarn.Compiler;

if (args.Length == 0)
{
    Console.Error.WriteLine("Usage: yarn-linter <file1.yarn> [file2.yarn ...]");
    return 1;
}

var job = CompilationJob.CreateFromFiles(args);

CompilationResult result;
try
{
    result = Compiler.Compile(job);
}
catch (Exception ex)
{
    Console.Error.WriteLine($"💥 FATAL: {ex.Message}");
    return 1;
}

bool hasErrors = false;

foreach (var diag in result.Diagnostics)
{
    var severity = diag.Severity switch
    {
        Diagnostic.DiagnosticSeverity.Error   => "🚨 ERROR",
        Diagnostic.DiagnosticSeverity.Warning => "⚠️  WARN ",
        Diagnostic.DiagnosticSeverity.Info    => "💁 INFO ",
        _ => "     "
    };

    var file = diag.FileName ?? "(unknown)";
    var line = diag.Range.Start.Line + 1;
    var col  = diag.Range.Start.Character + 1;
    var code = diag.Code ?? "";

    Console.WriteLine($"{severity}: {file}:{line}:{col} [{code}] {diag.Message}");

    if (diag.Severity == Diagnostic.DiagnosticSeverity.Error)
        hasErrors = true;
}

if (hasErrors)
{
    Console.WriteLine("❌ Lint failed with errors.");
    return 1;
}

Console.WriteLine("✅ No errors found.");
return 0;
