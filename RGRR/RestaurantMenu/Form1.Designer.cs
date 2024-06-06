namespace RestaurantMenu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.ComboBox comboBoxMeasurementUnit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewMenuItems;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            comboBoxCategory = new ComboBox();
            numericUpDownPrice = new NumericUpDown();
            comboBoxMeasurementUnit = new ComboBox();
            buttonAdd = new Button();
            dataGridViewMenuItems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenuItems).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(12, 69);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(200, 23);
            comboBoxCategory.TabIndex = 1;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(12, 109);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(200, 23);
            numericUpDownPrice.TabIndex = 2;
            // 
            // comboBoxMeasurementUnit
            // 
            comboBoxMeasurementUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeasurementUnit.FormattingEnabled = true;
            comboBoxMeasurementUnit.Location = new Point(12, 149);
            comboBoxMeasurementUnit.Name = "comboBoxMeasurementUnit";
            comboBoxMeasurementUnit.Size = new Size(200, 23);
            comboBoxMeasurementUnit.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 200);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(200, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewMenuItems
            // 
            dataGridViewMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenuItems.Location = new Point(12, 229);
            dataGridViewMenuItems.Name = "dataGridViewMenuItems";
            dataGridViewMenuItems.RowHeadersWidth = 51;
            dataGridViewMenuItems.RowTemplate.Height = 24;
            dataGridViewMenuItems.Size = new Size(776, 209);
            dataGridViewMenuItems.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMenuItems);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxMeasurementUnit);
            Controls.Add(numericUpDownPrice);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Restaurant Menu";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenuItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
