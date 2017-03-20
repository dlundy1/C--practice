using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3_ex1 {
    public enum department { MATH, ENGLISH, GEOGRAPHY, CS }
    class Program {
        static void Main(string[] args) {
            University obj = new University("Baker College");
            Console.WriteLine("\n");
            obj.printName();
            
            // Using CS dpt. to Test
            var university = obj.CS;

            university.dean.printEmployeeInfo();
            university.admin.printEmployeeInfo();
            university.professors.printEmployeeInfo();
            university.researchers.printEmployeeInfo();
            Console.Read();
    }    
        }
    class University {
        // University Class
        public Department Math, English, Geography, CS;
        string Name;

        public University(string x) {
            Name = x;
            Math = new Department(department.MATH);
            English = new Department(department.ENGLISH);
            Geography = new Department(department.GEOGRAPHY);
            CS = new Department(department.CS);
        }
        public void printName() {
            Console.WriteLine($"University: {Name}");
        }
    }
    class Department {
        // Department Class
        public Dean dean;
        public Admin admin;
        public Researcher researchers;
        public Professor professors;
        department office;

        public Department(department x) {
            office = x;
            dean = new Dean();
            admin = new Admin(office);
            researchers = new Researcher(office);
            professors = new Professor(office);
        }
    }
    abstract class Employee {
        // Employee Class
        public enum jobStatus { DEAN, PROFESSOR, ADMIN, RESEARCHER, TBD }
        String firstName, lastName;
        int salary;
        jobStatus job;
        department dept;

        public Employee() {
            firstName = "First";
            lastName = "Last";
            salary = 0;
            job = jobStatus.TBD;
        }
        public string getFullName() { return $"{lastName}, {firstName}"; }
        public void setName(string x, string y) {
            firstName = y;
            lastName = x;
        }
        public int getSalary() { return salary; }
        public void setSalary(int x) { salary = x; }
        public jobStatus getJob() { return job; }
        public void setJob(jobStatus x) {
            job = x;
        }
        public void setDepartment(department x) { dept = x; }
        public department getDepartment() { return dept; }
        public void printEmployeeInfo() {
            // Prints Employee Data
            int x = salary;
            Console.WriteLine("-----------");
            Console.WriteLine($"Employee Name: {getFullName()}");
            Console.WriteLine($"Employee Position: {job}");
            Console.WriteLine($"Employee Salary: {x.ToString("C2")}");
        }
    }
    class Professor : Employee, ITeachable {
        String Course;

        public void teach() { }
        public Professor(department x) {
            setName("Cooper", "Sheldon");
            setSalary(50000);
            setJob(jobStatus.PROFESSOR);
            Course = "Unit-Testing II";
            setDepartment(x);
        }
        public new void printEmployeeInfo() {
            // Prints Employee Data
            int x = getSalary();
            Console.WriteLine("-----------");
            Console.WriteLine($"Employee Name: {getFullName()}");
            Console.WriteLine($"Employee Position: {getJob()}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Specialty: Theoretical Physics");
            Console.WriteLine($"Employee Salary: {x.ToString("C2")}");
            Console.WriteLine($"Department: {getDepartment()}");
        }
    }
    class Researcher : Employee, ITeachable {
        enum Speciality { item1, item2, item3, item4 }

        public void teach() { }
        public Researcher(department x) {
            setName("House", "Gregory");
            setSalary(50000);
            setJob(jobStatus.RESEARCHER);
            setDepartment(x);
        }
        public new void printEmployeeInfo() {
            // Prints Employee Data
            int x = getSalary();
            Console.WriteLine("-----------");
            Console.WriteLine($"Employee Name: {getFullName()}");
            Console.WriteLine($"Employee Position: {getJob()}");
            Console.WriteLine($"Course: Problems & Algrthms II");
            Console.WriteLine($"Specialty: Diagnostic Medicine");
            Console.WriteLine($"Employee Salary: {x.ToString("C2")}");
            Console.WriteLine($"Department: {getDepartment()}");
        }
    }
    class Dean : Employee, IAdmin {
        public void administrate() { }
        public Dean() {
            setName("Spooner", "Arthur");
            setSalary(75000);
            setJob(jobStatus.DEAN);
        }
    }
    class Admin : Employee, IAdmin {

        public void administrate() { }
        public Admin(department x) {
            setName("Stark", "Anthony");
            setSalary(60000);
            setJob(jobStatus.ADMIN);
            setDepartment(x);
        }
        public new void printEmployeeInfo() {
            // Prints Employee Data
            int x = getSalary();
            Console.WriteLine("-----------");
            Console.WriteLine($"Employee Name: {getFullName()} (Tony)");
            Console.WriteLine($"Employee Position: {getJob()}");
            Console.WriteLine($"Specialty: Artificial Intelligence (AI)");
            Console.WriteLine($"Employee Salary: {x.ToString("C2")}");
        }
    }
    public interface ITeachable {
        // ITeachable Interface
        void teach();
    }
    public interface IAdmin {
        // IAdmin Interface
        void administrate();
    }
}