namespace LokantaAdisyon;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        var ana = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 2
        };
        ana.RowStyles.Add(new RowStyle(SizeType.Percent, 65));
        ana.RowStyles.Add(new RowStyle(SizeType.Percent, 35));

        var icerik = new Panel { Dock = DockStyle.Fill };

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
        MenuButton.Click += (s, e) => MessageBox.Show("Tıklandı");
        serit.Controls.Add(MenuButton, 0, 0);

        Button MasaButton = new Button
        {
            Text = "Masalar",
            BackColor = Color.FromArgb(255, 128, 0),
            Dock = DockStyle.Fill,
            Margin = new Padding(10),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        MasaButton.Click += (s, e) => MessageBox.Show("Tıklandı");
        serit.Controls.Add(MasaButton, 1, 0);

        Button GiderButton = new Button
        {
            Text = "Gider",
            BackColor = Color.FromArgb(255, 128, 0),
            Dock = DockStyle.Fill,
            Margin = new Padding(10),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        GiderButton.Click += (s, e) => MessageBox.Show("Tıklandı");
        serit.Controls.Add(GiderButton, 2, 0);

        Button SatisButton = new Button
        {
            Text = "Satışlar",
            BackColor = Color.FromArgb(255, 128, 0),
            Dock = DockStyle.Fill,
            Margin = new Padding(10),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        SatisButton.Click += (s, e) => MessageBox.Show("Tıklandı");
        serit.Controls.Add(SatisButton, 3, 0);

        ana.Controls.Add(icerik, 0, 0);
        ana.Controls.Add(serit, 0, 1);
        Controls.Add(ana);
    }
}