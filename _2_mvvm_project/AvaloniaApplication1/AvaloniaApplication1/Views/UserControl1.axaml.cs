using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication1;

public partial class UserControl1 : UserControl
{
    public static readonly DirectProperty<UserControl1, string> MyTextProperty =
        AvaloniaProperty.RegisterDirect<UserControl1, string>(
            nameof(MyText),
            o => o.MyText,
            (o, v) => o.MyText = v);

    private string _myText;
    public string MyText
    {
        get => _myText;
        set => SetAndRaise(MyTextProperty, ref _myText, value);
    }
    public UserControl1()
    {
        InitializeComponent();
    }
}