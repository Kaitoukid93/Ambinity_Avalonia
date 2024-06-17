using ReactiveUI;

namespace Ambinity.ViewModels;

public abstract class ActivatableViewModelBase : ViewModelBase, IActivatableViewModel
{
    /// <inheritdoc />
    public ViewModelActivator Activator { get; } = new();
}