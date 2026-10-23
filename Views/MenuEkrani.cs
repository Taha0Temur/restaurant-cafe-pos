namespace LokantaAdisyon;
public class MenuEkrani : UserControl
{
    public MenuEkrani()
    {
        Dock = DockStyle.Fill;
        Controls.Add(new Label { Text = "Menü", Left = 20, Top = 20, AutoSize = true });
    }
}