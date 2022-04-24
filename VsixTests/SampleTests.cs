using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Utilities;
using System.Threading.Tasks;
using Xunit;

[assembly: VsixRunner(TraceLevel = System.Diagnostics.SourceLevels.All)]

namespace VsixTests;

public class SampleTests
{
    [VsixFact("17.1", TimeoutSeconds = 60, RootSuffix = "")]
    public async Task SanityCheckAsync()
    {
        //await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

        //var service = ServiceProvider.GlobalProvider.GetService<DTE>();
        //Assert.NotNull(service);

        //service = GlobalServiceProvider.GetService<DTE>();
        //Assert.NotNull(service);

        //var hierarchy = GlobalServiceProvider.GetExport<IVsHierarchyItemManager>();

        //Assert.NotNull(hierarchy);

        //var items = GlobalServiceProvider.GetExports<ContentTypeDefinition>();

        //Assert.NotEmpty(items);
    }
}
