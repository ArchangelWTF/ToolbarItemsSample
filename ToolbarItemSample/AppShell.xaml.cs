using System.Windows.Input;

namespace ToolbarItemSample;

public partial class AppShell : Shell
{
    public ICommand FirstCommand { get; set; }
    public ICommand SecondCommand { get; set; }

    public AppShell()
	{
        FirstCommand = new Command((parameter) =>
        {
            Console.WriteLine("First!");
        });

        SecondCommand = new Command((parameter) =>
        {
            Console.WriteLine("Second!");
        });


        InitializeComponent();
	}
}
