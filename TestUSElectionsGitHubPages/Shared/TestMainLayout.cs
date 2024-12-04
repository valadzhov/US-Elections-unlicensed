using Bunit;
using Microsoft.Extensions.DependencyInjection;
using USElectionsGitHubPages.Shared;
using USElectionsGitHubPages.USElections;
using USElectionsGitHubPages.State;

namespace TestUSElectionsGitHubPages
{
	[Collection("USElectionsGitHubPages")]
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbNavbarModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbNavDrawerModule),
				typeof(IgbNavDrawerItemModule));
			ctx.Services.AddScoped<IUSElectionsService>(sp => new MockUSElectionsService());
			ctx.Services.AddScoped<IStateService>(sp => new MockStateService());
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
