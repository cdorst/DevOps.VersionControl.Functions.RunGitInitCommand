using static DevOps.VersionControl.Functions.RunGitCommand.GitCommandRunner;

namespace DevOps.VersionControl.Functions.RunGitInitCommand
{
    public static class GitInitCommandRunner
    {
        private const string init = nameof(init);

        public static void Init(string directory, params string[] arguments)
            => Git(directory,
                command: init,
                arguments);
    }
}
