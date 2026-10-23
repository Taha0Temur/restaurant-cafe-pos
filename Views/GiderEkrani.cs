namespace LokantaAdisyon;
public class GiderEkrani : UserControl
{
    public GiderEkrani()
    {
        Dock = DockStyle.Fill;
         Controls.Add(new Label { Text = "Gider", Left = 20, Top = 20, AutoSize = true });
    }
}