using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class T300125 : System.Web.UI.Page {
    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        grid.DataSource = GetData();
        grid.DataBind();
    }

    public List<Department> GetData() {
        return new List<Department>() {
            new Department() {
                Name = "Management",
                Location = "London",
                Employees = new List<Person>() {
                    new Person() { FirstName = "Ben", LastName = "Summers", Age = 57, Position = Position.Head },
                    new Person() { FirstName = "Peter", LastName = "Enchi", Age = 48, Position = Position.Developer },
                }
            },
            new Department() {
                Name = "R&D",
                Location = "Bristol",
                Employees = new List<Person>() {
                    new Person() { FirstName = "Sam", LastName = "Johnson", Age = 34, Position = Position.Manager },
                    new Person() { FirstName = "John", LastName = "Samson", Age = 29, Position = Position.Developer },
                    new Person() { FirstName = "Julia", LastName = "Green", Age = 23, Position = Position.Developer }
                }
            },
            new Department() {
                Name = "SEO",
                Location = "Liverpool",
                Employees = new List<Person>() {
                    new Person() { FirstName = "Mary", LastName = "Smith", Age = 27, Position = Position.Manager },
                    new Person() { FirstName = "Ann", LastName = "Davolio", Age = 19, Position = Position.Manager }
                }
            },
            new Department() {
                Name = "Marketing",
                Location = "Moscow"
            }
        };
    }
    protected void detailGrid_BeforePerformDataSelect(object sender, EventArgs e) {
        var grid = sender as ASPxGridView;
        var key = grid.GetMasterRowKeyValue().ToString();
        grid.DataSource = GetData().Single(item => item.Name == key).Employees;
    }
}

public enum Position { Manager, Developer, Head }

public class Department {
    public string Name { get; set; }
    public string Location { get; set; }
    public List<Person> Employees { get; set; }
}

public class Person {
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public int Age { get; set; }
    public Position Position { get; set; }
}
