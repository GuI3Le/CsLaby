namespace Lab5
{


    public partial class Form1 : Form
    {
        private int lastLoadedIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }
        //List<Person> people = new List<Person>();
        void UpdateList(Person person)
        {
            string date = $"{person.birthDate.Day}.{person.birthDate.Month}.{person.birthDate.Year}";
            peopleListBox.Items.Add($"{person.name}, {person.lastname}, {date}, {person.gender}");
        }
        private void AddButtonClick(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string lastname = lastnameTextBox.Text;
            DateTime birthdate = birthDateTimePicker.Value;
            string gender = genderComboBox.Text;
            var person = new Person(name, lastname, birthdate, gender);
            //people.Add(person);
            UpdateList(person);
            nameTextBox.Text = "";
            lastnameTextBox.Text = "";
            birthDateTimePicker.Value = DateTime.Today;
            genderComboBox.SelectedIndex = -1;

        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            string currentItem = peopleListBox.SelectedItem.ToString();
            int index = peopleListBox.FindString(currentItem);
            if (index == -1)
            {
                MessageBox.Show("Item not found");
            }
            else
            {
                peopleListBox.Items.Remove(currentItem);
            }
        }

        private void LoadButtonClick(object sender, EventArgs e)
        {
            string currentItem = peopleListBox.SelectedItem.ToString();
            lastLoadedIndex = peopleListBox.FindString(currentItem);
            if (lastLoadedIndex == -1)
            {
                MessageBox.Show("Item not found");
            }
            else
            {
                string[] items = currentItem.Split(", ");
                nameTextBox.Text = items[0];
                lastnameTextBox.Text = items[1];
                birthDateTimePicker.Value = DateTime.Parse(items[2]);
                genderComboBox.Text = items[3];

            }
        }

        private void EditButtonClick(object sender, EventArgs e)
        { 
            peopleListBox.SelectedIndex = lastLoadedIndex;
            string name = nameTextBox.Text;
            string lastname = lastnameTextBox.Text;
            DateTime birthdate = birthDateTimePicker.Value;
            string gender = genderComboBox.Text;
            string date = $"{birthdate.Day}.{birthdate.Month}.{birthdate.Year}";
            peopleListBox.Items[lastLoadedIndex] = $"{name}, {lastname}, {date}, {gender}";
        }

    }
}
