using Fluxor;
using ReplicaApp;
using ReplicaApp.Components.Layout;

namespace ReplicaAppTests;

/// <summary>
/// Provides unit tests for the <see cref="MainLayout"/> component.
/// </summary>
public class MainLayoutTests : TestContext
{
    [Fact]
    public void Component_DisplaysCountInTopAppBar()
    {
        // Arrange
        // Add Fluxor dependencies.
        Services.AddFluxor(options => options
            .ScanAssemblies(typeof(MauiProgram).Assembly)
            .WithLifetime(StoreLifetime.Singleton));

        // Act
        using var cut = RenderComponent<MainLayout>();

        // Assert
        cut.Find("p").MarkupMatches("<p>Count: 0</p>");
    }

    [Fact]
    public void Component_DisplaysCountInTopAppBar2()
    {
        // Arrange
        // Add Fluxor dependencies.
        Services.AddFluxor(options => options
            .ScanAssemblies(typeof(MauiProgram).Assembly)
            .WithLifetime(StoreLifetime.Singleton));

        // Act
        using var cut = RenderComponent<MainLayout>();

        // Assert
        cut.Find("p").MarkupMatches("<p>Count: 0</p>");
    }

    [Fact]
    public void Component_DisplaysCountInTopAppBar3()
    {
        // Arrange
        // Add Fluxor dependencies.
        Services.AddFluxor(options => options
            .ScanAssemblies(typeof(MauiProgram).Assembly)
            .WithLifetime(StoreLifetime.Singleton));

        // Act
        using var cut = RenderComponent<MainLayout>();

        // Assert
        cut.Find("p").MarkupMatches("<p>Count: 0</p>");
    }

    [Fact]
    public void Component_DisplaysCountInTopAppBar4()
    {
        // Arrange
        // Add Fluxor dependencies.
        Services.AddFluxor(options => options
            .ScanAssemblies(typeof(MauiProgram).Assembly)
            .WithLifetime(StoreLifetime.Singleton));

        // Act
        using var cut = RenderComponent<MainLayout>();

        // Assert
        cut.Find("p").MarkupMatches("<p>Count: 0</p>");
    }
}
