using Fluxor;
using ReplicaApp;
using ReplicaApp.Components.Layout;
using ReplicaApp.Components.Pages;

namespace ReplicaAppTests;

/// <summary>
/// Unit tests for the <see cref="Counter"/> component.
/// </summary>
public class CounterComponentTests : TestContext
{
    [Fact]
    public void CounterStartsAtZero()
    {
        // Arrange
        // Add Fluxor dependencies.
        Services.AddFluxor(options => options
            .ScanAssemblies(typeof(MauiProgram).Assembly)
            .WithLifetime(StoreLifetime.Singleton));

        // Act
        RenderComponent<MainLayout>();
        var cut = RenderComponent<Counter>();

        // Assert
        cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 0</p>");
    }

    [Fact]
    public void ClickingButtonIncrementsCounter()
    {
        // Arrange
        // Add Fluxor dependencies.
        Services.AddFluxor(options => options
            .ScanAssemblies(typeof(MauiProgram).Assembly)
            .WithLifetime(StoreLifetime.Singleton));

        // Act
        RenderComponent<MainLayout>();
        var cut = RenderComponent<Counter>();
        cut.Find("button").Click();

        // Assert
        cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
    }
}
