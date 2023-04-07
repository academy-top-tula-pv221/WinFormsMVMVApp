using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsMVMVApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }

    public class Group : INotifyPropertyChanged
    {
        static int globalId = 0;

        string name = "";
        int age;

        //public int SelectedIndex { get; set; }
        int selectedIndex;
        public BindingList<User> Users { get; }
        public Group()
        {
            Users = new()
            {
                new(){ Id = ++globalId, Name = "Joe", Age = 34 },
                new(){ Id = ++globalId, Name = "Bob", Age = 23 },
                new(){ Id = ++globalId, Name = "Tim", Age = 37 },
                new(){ Id = ++globalId, Name = "Sam", Age = 19 },
                new(){ Id = ++globalId, Name = "Leo", Age = 28 },
            };
            //SelectedId = 1;

            AddCommand = new MainCommand(_ => 
            { 
                Users.Add(new User() { Id = ++globalId, Name = this.Name, Age = this.Age });
                Name = "";
                Age = 0;
            });

            DeleteCommand = new MainCommand(obj =>
            {
                //int id;
                //if (obj is int)
                //    id = (int)obj;
                if(obj is int id)
                {
                    int index = SelectedIndex;
                    User? user = Users.FirstOrDefault(u => u.Id == id);
                    if(user != null) { Users.Remove(user); }

                    if (index == Users.Count)
                        SelectedIndex = Users.Count - 1;
                    else
                    {
                        SelectedIndex = index - 1;
                        SelectedIndex = index;
                    }
                        
                }
                    
            });
        }
        //public User SelectedUser { get => Users.FirstOrDefault(u => u.Id == SelectedId)!; }
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { set; get; }

        public string Name
        {
            get => name;
            set
            {
                if(name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
        }

        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                selectedIndex = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
