﻿using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace DiagramNestedItemsExample {
    public class ViewModel {
        public ObservableCollection<Department> Departments { get; set; }
        public ObservableCollection<Relation> Relations { get; set; }
        public ViewModel() {
            Departments = new ObservableCollection<Department>();
            var dep1 = new Department() { DepartmentID = 1, DepartmentName = "Provision", Sections = new ObservableCollection<Section>() };
            var dep2 = new Department() { DepartmentID = 2, DepartmentName = "Security", Sections = new ObservableCollection<Section>() };
            var dep3 = new Department() { DepartmentID = 3, DepartmentName = "HR", Sections = new ObservableCollection<Section>() };

            var section1 = new Section() { SectionID = 11, SectionName = "Local", Employees = new ObservableCollection<Employee>() };
            var section2 = new Section() { SectionID = 12, SectionName = "Foreign Hubs", Employees = new ObservableCollection<Employee>() };
            var section3 = new Section() { SectionID = 13, SectionName = "Technical security", Employees = new ObservableCollection<Employee>() };
            var section4 = new Section() { SectionID = 14, SectionName = "Staff", Employees = new ObservableCollection<Employee>() };
            var section5 = new Section() { SectionID = 15, SectionName = "Managers", Employees = new ObservableCollection<Employee>() };
            var section6 = new Section() { SectionID = 16, SectionName = "Interviewers", Employees = new ObservableCollection<Employee>() };


            section1.Employees.Add(new Employee() { EmployeeID = 101, EmployeeName = "Mark" });
            section1.Employees.Add(new Employee() { EmployeeID = 102, EmployeeName = "Jim" });

            section2.Employees.Add(new Employee() { EmployeeID = 103, EmployeeName = "Andrew" });
            section2.Employees.Add(new Employee() { EmployeeID = 104, EmployeeName = "Alex" });

            section3.Employees.Add(new Employee() { EmployeeID = 105, EmployeeName = "Simon" });
            section3.Employees.Add(new Employee() { EmployeeID = 106, EmployeeName = "Lily" });

            section4.Employees.Add(new Employee() { EmployeeID = 107, EmployeeName = "Kim" });
            section4.Employees.Add(new Employee() { EmployeeID = 108, EmployeeName = "Adam" });

            section5.Employees.Add(new Employee() { EmployeeID = 109, EmployeeName = "Jack" });
            section5.Employees.Add(new Employee() { EmployeeID = 110, EmployeeName = "Miriam" });

            section6.Employees.Add(new Employee() { EmployeeID = 111, EmployeeName = "Justin" });
            section6.Employees.Add(new Employee() { EmployeeID = 112, EmployeeName = "Alexa" });

            dep1.Sections.Add(section1);
            dep1.Sections.Add(section2);
            dep2.Sections.Add(section3);
            dep2.Sections.Add(section4);
            dep3.Sections.Add(section5);
            dep3.Sections.Add(section6);

            Departments.Add(dep1);
            Departments.Add(dep2);
            Departments.Add(dep3);

            Relations = new ObservableCollection<Relation>();
            Relations.Add(new Relation() { FromEmployeeID = 106, ToEmployeeID = 101 });
            Relations.Add(new Relation() { FromEmployeeID = 102, ToEmployeeID = 109 });
            Relations.Add(new Relation() { FromEmployeeID = 103, ToEmployeeID = 108 });
        }
    }

    public class Department : BindableBase {
        public int DepartmentID {
            get { return GetProperty(() => DepartmentID); }
            set { SetProperty(() => DepartmentID, value); }
        }
        public string DepartmentName {
            get { return GetProperty(() => DepartmentName); }
            set { SetProperty(() => DepartmentName, value); }
        }
        public ObservableCollection<Section> Sections {
            get { return GetProperty(() => Sections); }
            set { SetProperty(() => Sections, value); }
        }
    }

    public class Section : BindableBase {
        public int SectionID {
            get { return GetProperty(() => SectionID); }
            set { SetProperty(() => SectionID, value); }
        }
        public string SectionName {
            get { return GetProperty(() => SectionName); }
            set { SetProperty(() => SectionName, value); }
        }
        public ObservableCollection<Employee> Employees {
            get { return GetProperty(() => Employees); }
            set { SetProperty(() => Employees, value); }
        }
    }

    public class Employee : BindableBase {
        public int EmployeeID {
            get { return GetProperty(() => EmployeeID); }
            set { SetProperty(() => EmployeeID, value); }
        }
        public string EmployeeName {
            get { return GetProperty(() => EmployeeName); }
            set { SetProperty(() => EmployeeName, value); }
        }
    }
    public class Relation : BindableBase {
        public int FromEmployeeID {
            get { return GetProperty(() => FromEmployeeID); }
            set { SetProperty(() => FromEmployeeID, value); }
        }
        public int ToEmployeeID {
            get { return GetProperty(() => ToEmployeeID); }
            set { SetProperty(() => ToEmployeeID, value); }
        }
    }
}
