using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication1;

public partial class UserControl1 : UserControl
{
    public static readonly DirectProperty<UserControl1, int> ValueProperty =
    AvaloniaProperty.RegisterDirect<UserControl1, int>(
        nameof(Value),                            // The name of the property     
        o => o.Value,                  // The getter of the property
        (o, v) => o.Value = v,      // The setter of the property
        defaultBindingMode: BindingMode.TwoWay,   // We change the default binding mode to be two-way, so if the user selects a new value, it will automatically update the bound property
        enableDataValidation: true);              // Enables DataValidation

    // For direct properties we need to have a backing field
    private int _value;

    /// <summary>
    /// Gets or sets the current value
    /// </summary>
    public int Value
    {
        get { return _value; }
        set { SetAndRaise(ValueProperty, ref _value, value); }
    }

    public UserControl1()
    {
        InitializeComponent();
        DataContext = this;
    }
}