using Microsoft.Extensions.Localization;
using MyAbpProject.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyAbpProject;

[Dependency(ReplaceServices = true)]
public class MyAbpProjectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MyAbpProjectResource> _localizer;

    public MyAbpProjectBrandingProvider(IStringLocalizer<MyAbpProjectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
