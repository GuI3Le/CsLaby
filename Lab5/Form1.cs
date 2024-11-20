namespace Lab5
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> people = new List<Person>();
        void UpdateList(Person person)
        {
            //peopleListView.Items.Add(new ListViewItem(person.name, person.lastname, person.birthDate.ToString, person.gender));
        }
        private void AddButtonClick(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string lastname = lastnameTextBox.Text;
            DateTime birthdate = birthDateTimePicker.Value;
            string gender = genderComboBox.Text;
            people.Add(new Person(name, lastname, birthdate, gender));

        }
    }
}
