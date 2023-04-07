namespace WinFormsMVMVApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataContext = new Group();

            Binding bindingUsers = new Binding("DataSource", DataContext, "Users");
            //bindingUsers.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            listUsers.DataBindings.Add(bindingUsers);
            listUsers.DisplayMember = "Name";
            listUsers.ValueMember = "Id";

            Binding bindingSelectedIndex = new Binding("SelectedIndex", DataContext, "SelectedIndex");
            bindingSelectedIndex.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            listUsers.DataBindings.Add(bindingSelectedIndex);

            //labelSelectedUser.DataBindings.Add(new Binding("Text",
            //                                                DataContext,
            //                                                "SelectedUser",
            //                                                false,
            //                                                DataSourceUpdateMode.OnPropertyChanged));

            // add User
            textNewName.DataBindings.Add(new Binding("Text",
                                                     DataContext,
                                                     "Name",
                                                     false,
                                                     DataSourceUpdateMode.OnPropertyChanged));
            numNewAge.DataBindings.Add(new Binding("Value",
                                                     DataContext,
                                                     "Age",
                                                     false,
                                                     DataSourceUpdateMode.OnPropertyChanged));
            btnNewUser.DataBindings.Add(new Binding("Command",
                                                    DataContext,
                                                    "AddCommand", true));
            btnDelUser.DataBindings.Add(new Binding("Command",
                                                    DataContext,
                                                    "DeleteCommand", true));
            btnDelUser.DataBindings.Add(new Binding("CommandParameter",
                                                    listUsers,
                                                    "SelectedValue"));


        }

        private void listUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listUsers?.SelectedValue?.ToString());
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listUsers?.SelectedValue?.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(DataContext as Group).SelectedIndex = (DataContext as Group).Users.Count - 1;
            //listUsers.SelectedIndex = (DataContext as Group).Users.Count - 1;
        }
    }
}