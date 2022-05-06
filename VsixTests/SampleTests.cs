using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Utilities;
using System.Threading.Tasks;
using Vsix;
using Xunit;

[assembly: VsixRunner(TraceLevel = System.Diagnostics.SourceLevels.All)]

namespace VsixTests;

public class SampleTests
{
    [VsixFact(TimeoutSeconds = 60)]
    public async Task SanityCheckAsync()
    {
        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

        var service = ServiceProvider.GlobalProvider.GetService<DTE>();
        Assert.NotNull(service);

        service = GlobalServiceProvider.GetService<DTE>();
        Assert.NotNull(service);

        var hierarchy = GlobalServiceProvider.GetExport<IVsHierarchyItemManager>();

        Assert.NotNull(hierarchy);

        var items = GlobalServiceProvider.GetExports<ContentTypeDefinition>();

        Assert.NotEmpty(items);
    }

    [VsixFact(TimeoutSeconds = 60)]
    public void GetExportFromVsix()
        => Assert.NotNull(GlobalServiceProvider.GetExport<MyComponent>());
}
