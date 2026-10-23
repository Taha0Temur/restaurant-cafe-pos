namespace LokantaAdisyon;
public class AnaSayfa : UserControl
{
    private Form1 form;

    public AnaSayfa(Form1 form)
    {
        this.form = form;
        Dock = DockStyle.Fill;

        var tablo = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 2
        };
        tablo.RowStyles.Add(new RowStyle(SizeType.Percent, 60));
        tablo.RowStyles.Add(new RowStyle(SizeType.Percent, 40));

        var serit = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 4,
            RowCount = 1,
            Padding = new Padding(60, 20, 60, 60)
        };
        for (int i = 0; i < 4; i++)
            serit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

        Button MenuButton = new Button
        {
            Text = "Menu",
            BackColor = Color.FromArgb(255, 128, 0),
            Dock = DockStyle.Fill,
            Margin = new Padding(10),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        MenuButton.Click += (s, e) => form.EkranGoster(new MenuEkrani());
        serit.Controls.Add(MenuButton, 0, 0);

        Button MasaButton = new Button
        {
            Text = "Masalar",
            BackColor = Color.FromArgb(255, 128, 0),
            Dock = DockStyle.Fill,
            Margin = new Padding(10),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        MasaButton.Click += (s, e) => form.EkranGoster(new MasalarEkrani());
        serit.Controls.Add(MasaButton, 1, 0);

        Button GiderButton = new Button
        {
            Text = "Gider",
            BackColor = Color.FromArgb(255, 128, 0),
            Dock = DockStyle.Fill,
            Margin = new Padding(10),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        GiderButton.Click += (s, e) => form.EkranGoster(new GiderEkrani());
        serit.Controls.Add(GiderButton, 2, 0);

        Button SatisButton = new Button
        {
            Text = "Satışlar",
            BackColor = Color.FromArgb(255, 128, 0),
            Dock = DockStyle.Fill,
            Margin = new Padding(10),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        SatisButton.Click += (s, e) => form.EkranGoster(new SatisEkrani());
        serit.Controls.Add(SatisButton, 3, 0);

        tablo.Controls.Add(serit, 0, 1);
        Controls.Add(tablo);
    }
}