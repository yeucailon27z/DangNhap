using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

public class ComboBoxExample : Form
{
    private ComboBox comboBox;

    public ComboBoxExample()
    {
        this.Text = "ComboBox Example";
        this.Size = new System.Drawing.Size(300, 150);

        // Tạo bảng chọn
        comboBox = new ComboBox();
        comboBox.Location = new System.Drawing.Point(50, 50);
        comboBox.Items.Add("Tùy chọn 1");
        comboBox.Items.Add("Tùy chọn 2");
        comboBox.Items.Add("Tùy chọn 3");
        comboBox.Items.Add("Tùy chọn 4");

        // Đặt sự kiện cho việc chọn tùy chọn
        comboBox.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);

        this.Controls.Add(comboBox);
    }

    private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedOption = comboBox.SelectedItem.ToString();
        MessageBox.Show("Bạn đã chọn: " + selectedOption);
    }

    public static void Main()
    {
        Application.Run(new ComboBoxExample());
    }
}
