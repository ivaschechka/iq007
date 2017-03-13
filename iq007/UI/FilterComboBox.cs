using iq007.Filter;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace iq007.UI
{
    class FilterComboBox : ComboBox
    {
        public FilterComboBox()
        {
            this.IsEditable = true;
            this.StaysOpenOnEdit = true;
            this.IsTextSearchEnabled = false;
            this.DropDownOpened += FilterComboBoxDropDownOpened;
            Binding binding = new Binding() { Mode = BindingMode.OneWay, UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged };
            binding.RelativeSource = new RelativeSource(RelativeSourceMode.Self);
            binding.Path = new PropertyPath("Text");
            this.SetBinding(FilterComboBox.SearchTextProperty, binding);
        }

        private TextBox textBox;
        private TextBox TextBox
        {
            get
            {
                if (textBox == null) textBox = (TextBox)this.Template.FindName("PART_EditableTextBox", this);
                return textBox;
            }
        }

        private void FilterComboBoxDropDownOpened(object sender, EventArgs e)
        {
            TextBox.SelectionStart = TextBox.Text.Length;
            if (!IsItemsEmpty(this))
            {
                this.Items.Filter = (item) => { return true; };
            }
        }

        public Func<String, String, bool> Filter
        {
            get { return (Func<String, String, bool>)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }


        public static Func<String, String, bool> defaultFilter = ContainTextFilterCreator.CreateFilter();
        public static readonly DependencyProperty FilterProperty =
            DependencyProperty.Register("Filter", typeof(Func<String, String, bool>), typeof(FilterComboBox), new PropertyMetadata(defaultFilter));


        private String SearchText
        {
            get { return (String)GetValue(SearchTextProperty); }
            set { SetValue(SearchTextProperty, value); }
        }

        private static readonly DependencyProperty SearchTextProperty =
            DependencyProperty.Register("SearchText", typeof(String), typeof(FilterComboBox), new PropertyMetadata(PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var comboBox = (FilterComboBox)sender;
            String currentText = comboBox.Text ?? String.Empty;

            if (comboBox.SelectedItem != null && currentText == GetText(comboBox.SelectedItem, comboBox)) { return; }

            comboBox.Items.Filter = (item) =>
            {
                String itemText = GetText(item, comboBox);
                if (comboBox.Filter == null) return true;
                return comboBox.Filter.Invoke(currentText, itemText);
            };

            if (comboBox.IsDropDownOpen == false && currentText != String.Empty) comboBox.IsDropDownOpen = true;
        }



        private static bool IsItemsEmpty(FilterComboBox comboBox)
        {
            return !comboBox.HasItems || comboBox.Items == null;
        }

        private static String GetText(Object item, FilterComboBox comboBox)
        {
            String propertyName = (String)comboBox.GetValue(TextSearch.TextPathProperty);
            return (String)GetPropertyValue(item, propertyName);
        }

        private static object GetPropertyValue(object src, string propertyName)
        {
            return src.GetType().GetProperty(propertyName).GetValue(src, null);
        }
    }
}    
