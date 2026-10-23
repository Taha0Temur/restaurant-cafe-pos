namespace LokantaAdisyon;
public class MasalarEkrani : UserControl
{
    public MasalarEkrani()
    {
        Dock = DockStyle.Fill;
         Controls.Add(new Label { Text = "Masalar", Left = 20, Top = 20, AutoSize = true });
    }
}