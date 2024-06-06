namespace RestaurantMenu
{
    public partial class Form1 : Form
    {
        private List<MenuItem> menuItems;

        public Form1()
        {
            InitializeComponent();
            menuItems = new List<MenuItem>();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            comboBoxCategory.Items.AddRange(new string[] { "First Course", "Second Course", "Drinks" });
            comboBoxMeasurementUnit.Items.AddRange(new string[] { "g", "ml" });
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string category = comboBoxCategory.SelectedItem?.ToString();
            decimal price = numericUpDownPrice.Value;
            string measurementUnit = comboBoxMeasurementUnit.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || category == null || measurementUnit == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            MenuItem menuItem = new MenuItem
            {
                Name = name,
                Category = category,
                Price = price,
                MeasurementUnit = measurementUnit
            };

            menuItems.Add(menuItem);
            UpdateDataGridView();
            ClearInputFields();
        }

        private void UpdateDataGridView()
        {
            dataGridViewMenuItems.DataSource = null;
            dataGridViewMenuItems.DataSource = menuItems;
        }

        private void ClearInputFields()
        {
            textBoxName.Clear();
            comboBoxCategory.SelectedIndex = -1;
            numericUpDownPrice.Value = 0;
            comboBoxMeasurementUnit.SelectedIndex = -1;
        }
    }

    public class MenuItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string MeasurementUnit { get; set; }
    }
}
