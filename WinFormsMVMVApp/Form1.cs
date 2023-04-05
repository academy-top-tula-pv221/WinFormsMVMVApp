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

            //Binding bindingSelectedUserId = new Binding("SelectedValue", DataContext, "SelectedId");
            //bindingSelectedUserId.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            //listUsers.DataBindings.Add(bindingSelectedUserId);

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
            btnNewUser.DataBindings.Add(new Binding("Command", DataContext, "AddCommand", true));


        }

    }
}