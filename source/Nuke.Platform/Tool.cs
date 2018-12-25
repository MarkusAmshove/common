// Copyright 2018 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using Nuke.Platform.Tooling;

namespace Nuke.Platform
{
    public delegate IReadOnlyCollection<Output> Tool(
        string arguments = null,
        string workingDirectory = null,
        IReadOnlyDictionary<string, string> environmentVariables = null,
        int? timeout = null,
        bool logOutput = true,
        Func<string, LogLevel> logLevelParser = null,
        Func<string, string> outputFilter = null);
}
