namespace LokantaAdisyon;
public class SatisEkrani : UserControl
{
    public SatisEkrani()
    {
        Dock = DockStyle.Fill;
         Controls.Add(new Label { Text = "Satış", Left = 20, Top = 20, AutoSize = true });
    }
}