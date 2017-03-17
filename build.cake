#addin "nuget:?package=Polly&version=5.0.6"

using System;
using Polly;

var target = Argument("target", "Default");
var platform = Argument("platform", "Any CPU");
var configuration = Argument("configuration", "Release");
var solution = "KimonoDesigner.sln";

Task("Restore-NuGet-Packages")
    .Does(() =>
{
    var maxRetryCount = 5;
    var toolTimeout = 1d;
    Policy
        .Handle<Exception>()
        .Retry(maxRetryCount, (exception, retryCount, context) => {
            if (retryCount == maxRetryCount)
            {
                throw exception;
            }
            else
            {
                Verbose("{0}", exception);
                toolTimeout+=0.5;
            }})
        .Execute(()=> {
              NuGetRestore(solution, new NuGetRestoreSettings {
                  ToolTimeout = TimeSpan.FromMinutes(toolTimeout)
              });
        });
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{
      MSBuild(solution, settings => {
          settings.SetConfiguration(configuration);
          settings.WithProperty("Platform", "\"" + platform + "\"");
          settings.SetVerbosity(Verbosity.Minimal);
      });
});

Task("Default")
  .IsDependentOn("Build");

RunTarget(target);
