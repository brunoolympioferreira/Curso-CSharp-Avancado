namespace _04_DelegateMethod;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        //btn_click.Click += delegate (object sender, EventArgs e)
        //{
        //    MessageBox.Show("Ol�, fui clicado");
        //};

        btn_click.Click += delegate
        {
            MessageBox.Show("Ol�, fui clicado");
        };
    }
}
