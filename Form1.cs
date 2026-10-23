namespace LokantaAdisyon;

public partial class Form1 : Form
{
    private Panel icerik = new Panel { Dock = DockStyle.Fill };

    public Form1()
    {
        InitializeComponent();
        Controls.Add(icerik);
        EkranGoster(new AnaSayfa(this));
    }

    public void EkranGoster(UserControl ekran)
    {
        icerik.Controls.Clear();
        icerik.Controls.Add(ekran);
    }
}