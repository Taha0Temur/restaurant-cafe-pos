namespace LokantaAdisyon;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Button MenuButton = new Button
        {
            Text = "Menu",
            BackColor = Color.FromArgb(255, 128, 0),
            Size = new Size(300, 200),
            Location = new Point(125, 500),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        MenuButton.Click += (s, e) => MessageBox.Show("Tıklandı");
        Controls.Add(MenuButton);

        Button MasaButton = new Button
        {
            Text = "Masalar",
            BackColor = Color.FromArgb(255, 128, 0),
            Size = new Size(300, 200),
            Location = new Point(475, 500),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        MasaButton.Click += (s, e) => MessageBox.Show("Tıklandı");
        Controls.Add(MasaButton);

                Button GiderButton = new Button
        {
            Text = "Gider",
            BackColor = Color.FromArgb(255, 128, 0),
            Size = new Size(300, 200),
            Location = new Point(825, 500),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        GiderButton.Click += (s, e) => MessageBox.Show("Tıklandı");
        Controls.Add(GiderButton);

                        Button SatisButton = new Button
        {
            Text = "Satışlar",
            BackColor = Color.FromArgb(255, 128, 0),
            Size = new Size(300, 200),
            Location = new Point(1175, 500),
            Font = new Font("Arial", 24, FontStyle.Bold)
        };
        SatisButton.Click += (s, e) => MessageBox.Show("Tıklandı");
        Controls.Add(SatisButton);
    }
}
