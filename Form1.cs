namespace Combo_box_and_list_box_controls_demo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Resize += Form1_Resize;
        CenterPanel();
        LoadComboBoxItems();
        LoadListBoxItems();
    }
    
    private void Form1_Resize(object? sender, EventArgs e)
    {
        CenterPanel();
    }

    private void CenterPanel()
    {
        panel1.Left = (ClientSize.Width - panel1.Width) / 2;
        panel1.Top = (ClientSize.Height - panel1.Height) / 2;
    }

    private void LoadComboBoxItems()
    {
        comboBox1.Items.AddRange(new object[] { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" });
        comboBox1.SelectedItem = "New York";
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private void LoadListBoxItems()
    {
        listBox1.Items.AddRange(new object[] { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" });
        listBox1.Height = listBox1.ItemHeight * listBox1.Items.Count;
    }
}